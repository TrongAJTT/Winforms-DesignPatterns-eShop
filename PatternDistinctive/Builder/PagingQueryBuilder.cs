using _3S_eShop.PatternDistinctive.DbBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _3S_eShop.PatternDistinctive.Builder
{
    /// <summary>
    /// Lớp Builder để tạo câu truy vấn SQL phân trang cho SQL Server và MySQL.
    /// Hỗ trợ cả phân trang nông (OFFSET/LIMIT) và phân trang sâu (subquery/JOIN).
    /// </summary>
    public class PagingQueryBuilder : BaseBuilder<String>
    {
        // --- Fields lưu trữ cấu hình ---

        private readonly string _tableName;
        private readonly string _orderByColumn;
        private readonly string _dbTypeIdentifier; // "sqlserver" hoặc "mysql"
        private readonly bool _isDeepPaging;
        private readonly string _primaryKeyColumn; // Cần cho phân trang sâu

        private long _pageSize = 1000;
        private long _pageNo = 1; // Page number (bắt đầu từ 1)
        private string _selectColumns = "*";
        private bool _isDescending = false, select_count = false;
        private StringBuilder _whereBuilder = new StringBuilder();

        // --- Constructor ---

        /// <summary>
        /// Khởi tạo PagingQueryBuilder.
        /// </summary>
        /// <param name="tableName">Tên bảng cần truy vấn.</param>
        /// <param name="orderByColumn">Cột dùng để sắp xếp và phân trang.</param>
        /// <param name="primaryKeyColumn">Tên cột khóa chính (quan trọng cho phân trang sâu). Mặc định là "id".</param>
        /// <param name="isDeepPaging">True nếu sử dụng phân trang sâu (khuyến nghị cho offset lớn), False cho phân trang nông.</param>
        /// <exception cref="ArgumentNullException">Ném ra nếu tableName, orderByColumn hoặc dbTypeIdentifier là null/trống.</exception>
        public PagingQueryBuilder(string tableName, string orderByColumn, string primaryKeyColumn = "id", bool isDeepPaging = false)
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentNullException(nameof(tableName));
            if (string.IsNullOrWhiteSpace(orderByColumn))
                throw new ArgumentNullException(nameof(orderByColumn));
            if (string.IsNullOrWhiteSpace(primaryKeyColumn) && isDeepPaging)
                throw new ArgumentNullException(nameof(primaryKeyColumn), "Primary key column name is required for deep paging.");

            _tableName = tableName;
            _orderByColumn = orderByColumn;
            _dbTypeIdentifier = DataProvider.Instance.GetDatabaseType();
            _isDeepPaging = isDeepPaging;
            _primaryKeyColumn = primaryKeyColumn; // Lưu khóa chính
        }

        #region --- Phương thức cấu hình (Fluent API) ---

        /// <summary>
        /// Thiết lập kích thước trang (số lượng bản ghi mỗi trang).
        /// </summary>
        /// <param name="size">Kích thước trang (phải lớn hơn 0).</param>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder SetPageSize(long size)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException(nameof(size), "Page size must be greater than 0.");
            _pageSize = size;
            return this;
        }

        /// <summary>
        /// Thiết lập số trang cần lấy dữ liệu (bắt đầu từ 1).
        /// </summary>
        /// <param name="page">Số trang (phải lớn hơn 0).</param>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder SetPage(long page)
        {
            if (page > 0)
            {
                _pageNo = page;
            }
            return this;
        }

        /// <summary>
        /// Thêm một điều kiện vào mệnh đề WHERE.
        /// Các điều kiện sẽ được nối với nhau bằng 'AND'.
        /// </summary>
        /// <param name="condition">Điều kiện WHERE (ví dụ: "status = 'active'" hoặc "price > 100").</param>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder AddSpecific(string condition)
        {
            if (!string.IsNullOrWhiteSpace(condition))
            {
                if (_whereBuilder.Length > 0)
                {
                    _whereBuilder.Append(" AND ");
                }
                _whereBuilder.Append("(").Append(condition).Append(")"); // Đóng ngoặc để đảm bảo thứ tự ưu tiên
            }
            return this;
        }

        /// <summary>
        /// Thiết lập các cột cần lấy trong mệnh đề SELECT.
        /// </summary>
        /// <param name="columns">Danh sách các cột, cách nhau bởi dấu phẩy (ví dụ: "id, name, created_at"). Mặc định là "*".</param>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder SetSelect(string columns)
        {
            if (string.IsNullOrWhiteSpace(columns))
                _selectColumns = "*";
            else
                _selectColumns = columns;
            return this;
        }

        /// <summary>
        /// Thiết lập để lấy số lượng bản ghi thay vì dữ liệu thực tế.
        /// </summary>
        /// <param name="value">Giá trị boolean cần truyền vào</param>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder SetSelectCount(bool value = true)
        {
            select_count = value;
            return this;
        }

        /// <summary>
        /// Thiết lập sắp xếp theo thứ tự giảm dần (DESC). Mặc định là tăng dần (ASC).
        /// </summary>
        /// <returns>Đối tượng PagingQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingQueryBuilder SetDesc(bool value)
        {
            _isDescending = value;
            return this;
        }

        #endregion

        #region --- Phương thức tạo câu truy vấn ---

        /// <summary>
        /// Tạo và trả về câu truy vấn SQL phân trang dựa trên các cấu hình đã thiết lập.
        /// </summary>
        /// <returns>Chuỗi SQL query.</returns>
        /// <exception cref="NotSupportedException">Ném ra nếu dbTypeIdentifier không được hỗ trợ.</exception>
        public string Build()
        {
            long offset = (_pageNo - 1) * _pageSize;
            string orderDirection = _isDescending ? "DESC" : "ASC";
            string whereClause = _whereBuilder.Length > 0 ? $"WHERE {_whereBuilder.ToString()}" : "";
            if (select_count)
            {
                _selectColumns = "COUNT(*)";
            }

            // --- Phân trang nông ---
            if (!_isDeepPaging)
            {
                switch (_dbTypeIdentifier)
                {
                    case "sqlserver":
                        // SQL Server (2012+)
                        return $"SELECT {_selectColumns} FROM {_tableName} {whereClause} ORDER BY {_orderByColumn} {orderDirection} OFFSET {offset} ROWS FETCH NEXT {_pageSize} ROWS ONLY;";
                    case "mysql":
                        // MySQL
                        return $"SELECT {_selectColumns} FROM {_tableName} {whereClause} ORDER BY {_orderByColumn} {orderDirection} LIMIT {offset}, {_pageSize};";
                    default:
                        throw new NotSupportedException($"Database type '{_dbTypeIdentifier}' is not supported for shallow paging.");
                }
            }
            // --- Phân trang sâu ---
            else
            {
                // Xử lý tên cột cho SELECT bên ngoài khi dùng alias 't'
                string outerSelectColumns = _selectColumns == "*" ? 
                    "t.*" : GetPrefixedColumns("t", _selectColumns);
                if (select_count)
                {
                    outerSelectColumns = "COUNT(*)";
                }

                switch (_dbTypeIdentifier)
                {
                    case "sqlserver":
                        // SQL Server (2012+) - Deep Paging
                        return $@"
SELECT {outerSelectColumns} 
FROM {_tableName} t 
INNER JOIN ( 
    SELECT {_primaryKeyColumn} 
    FROM {_tableName} 
    {whereClause} 
    ORDER BY {_orderByColumn} {orderDirection} 
    OFFSET {offset} ROWS FETCH NEXT {_pageSize} ROWS ONLY 
) subquery ON t.{_primaryKeyColumn} = subquery.{_primaryKeyColumn} 
ORDER BY t.{_orderByColumn} {orderDirection};"; // Sắp xếp lại tập kết quả nhỏ cuối cùng

                    case "mysql":
                        // MySQL - Deep Paging
                        return $@"
SELECT {outerSelectColumns} 
FROM {_tableName} t 
INNER JOIN ( 
    SELECT {_primaryKeyColumn} 
    FROM {_tableName} 
    {whereClause} 
    ORDER BY {_orderByColumn} {orderDirection} 
    LIMIT {offset}, {_pageSize} 
) subquery ON t.{_primaryKeyColumn} = subquery.{_primaryKeyColumn} 
ORDER BY t.{_orderByColumn} {orderDirection};"; // Sắp xếp lại tập kết quả nhỏ cuối cùng

                    default:
                        throw new NotSupportedException($"Database type '{_dbTypeIdentifier}' is not supported for deep paging.");
                }
            }
        }

        // --- Phương thức trợ giúp ---
        private string GetPrefixedColumns(string prefix, string columns)
        {
            if (columns == "*") return $"{prefix}.*";

            var cols = columns.Split(',')
                              .Select(c => c.Trim())
                              .Where(c => !string.IsNullOrEmpty(c));
            return string.Join(", ", cols.Select(c => $"{prefix}.{c}"));
        }

        public string FromDataRow(DataRow row)
        {
            throw new NotImplementedException();
        }

        public List<string> FromDataTable(DataTable dt)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
