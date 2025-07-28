using _3S_eShop.PatternDistinctive.DbBuilder; // Assuming this namespace contains DataProvider
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _3S_eShop.PatternDistinctive.Builder
{
    /// <summary>
    /// Lớp Builder để tạo câu truy vấn SQL phân trang cho SQL Server và MySQL.
    /// Hỗ trợ JOIN bảng, truy vấn thuộc tính xuyên bảng, và cả phân trang nông (OFFSET/LIMIT) và phân trang sâu (subquery/JOIN).
    /// </summary>
    public class PagingJoinQueryBuilder : BaseBuilder<string>
    {
        // --- Fields lưu trữ cấu hình ---

        private readonly string _tableName;
        private string _tableAlias = "t"; 
        // Default alias for the main table
        private string _orderByColumn; 
        // Can now include alias, e.g., "t.created_at" or "u.name"
        private readonly string _dbTypeIdentifier;
        private readonly bool _isDeepPaging;
        private string _primaryKeyColumn;

        private long _pageSize = 1000;
        private long _pageNo = 1; // Page number (bắt đầu từ 1)
        private string _selectColumns = "*"; // Default to selecting all from the main table alias
        private bool _isDescending = false, _select_count = false;
        private StringBuilder _whereBuilder = new StringBuilder();
        private List<string> _joinClauses = new List<string>(); // Stores full JOIN clauses like "INNER JOIN users u ON t.userId = u.id"

        // --- Constructor ---

        /// <summary>
        /// Khởi tạo PagingJoinQueryBuilder.
        /// </summary>
        /// <param name="tableName">Tên bảng chính cần truy vấn.</param>
        /// <param name="orderByColumn">Cột dùng để sắp xếp và phân trang. Nên bao gồm alias nếu không thuộc bảng chính (ví dụ: "u.name" hoặc "t.creation_date").</param>
        /// <param name="primaryKeyColumn">Tên cột khóa chính của bảng chính (quan trọng cho phân trang sâu). Mặc định là "id".</param>
        /// <param name="isDeepPaging">True nếu sử dụng phân trang sâu (khuyến nghị cho offset lớn), False cho phân trang nông.</param>
        /// <exception cref="ArgumentNullException">Ném ra nếu tableName, orderByColumn hoặc dbTypeIdentifier là null/trống.</exception>
        public PagingJoinQueryBuilder(string tableName, string orderByColumn, string primaryKeyColumn = "id", bool isDeepPaging = false, string defaultTableAlias = "t")
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentNullException(nameof(tableName));
            if (string.IsNullOrWhiteSpace(orderByColumn))
                throw new ArgumentNullException(nameof(orderByColumn));
            // primaryKeyColumn is only strictly required for deep paging, but often useful anyway.
            if (string.IsNullOrWhiteSpace(primaryKeyColumn))
                throw new ArgumentNullException(nameof(primaryKeyColumn), "Primary key column name is required."); // Enforce PK always for simplicity now

            _tableName = tableName;
            _orderByColumn = orderByColumn; 
            // User provides potentially qualified column name
            _dbTypeIdentifier = DataProvider.Instance.GetDatabaseType();
            _isDeepPaging = isDeepPaging;
            _primaryKeyColumn = primaryKeyColumn; 
            // Lưu khóa chính (assumed on main table 't')
            _tableAlias = defaultTableAlias;

            // Automatically qualify primary key and order by column with main table alias if not already qualified
            // Ensure Primary Key always refers to the main table 't' for joins
            if (!_primaryKeyColumn.Contains("."))
            {
                _primaryKeyColumn = $"{_tableAlias}.{_primaryKeyColumn}";
            }
            // Let user qualify order by column explicitly if it's from a joined table
            // If order by doesn't have an alias, assume it's from the main table
            if (!_orderByColumn.Contains("."))
            {
                _orderByColumn = $"{_tableAlias}.{_orderByColumn}";
            }

            // Default select is now t.*
            SetSelect($"{_tableAlias}.*");
        }

        #region --- Phương thức cấu hình (Fluent API) ---

        /// <summary>
        /// Thiết lập kích thước trang (số lượng bản ghi mỗi trang).
        /// </summary>
        /// <param name="size">Kích thước trang (phải lớn hơn 0).</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder SetPageSize(long size)
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
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder SetPage(long page)
        {
            if (page <= 0)
                throw new ArgumentOutOfRangeException(nameof(page), "Page number must be greater than 0.");
            _pageNo = page;
            return this;
        }

        /// <summary>
        /// Thêm một điều kiện vào mệnh đề WHERE.
        /// Các điều kiện sẽ được nối với nhau bằng 'AND'.
        /// Nên sử dụng alias khi tham chiếu cột (ví dụ: "t.status = 'active'" hoặc "u.age > 18").
        /// </summary>
        /// <param name="condition">Điều kiện WHERE (ví dụ: "t.status = 'active'").</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder AddSpecific(string condition)
        {
            if (!string.IsNullOrWhiteSpace(condition))
            {
                if (_whereBuilder.Length > 0)
                {
                    _whereBuilder.Append(" AND ");
                }
                // Wrap condition in parentheses to ensure logical precedence
                _whereBuilder.Append("(").Append(condition).Append(")");
            }
            return this;
        }

        /// <summary>
        /// Thêm một mệnh đề JOIN vào câu truy vấn.
        /// </summary>
        /// <param name="joinType">Loại JOIN (ví dụ: "INNER", "LEFT", "RIGHT").</param>
        /// <param name="joinedTable">Tên bảng cần JOIN.</param>
        /// <param name="alias">Alias cho bảng được JOIN (ví dụ: "u" cho bảng "users").</param>
        /// <param name="onCondition">Điều kiện JOIN (ví dụ: "t.userId = u.id").</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        /// <exception cref="ArgumentNullException">Ném ra nếu tham số không hợp lệ.</exception>
        public PagingJoinQueryBuilder AddJoin(string joinType, string joinedTable, string alias, string onCondition)
        {
            if (string.IsNullOrWhiteSpace(joinType)) throw new ArgumentNullException(nameof(joinType));
            if (string.IsNullOrWhiteSpace(joinedTable)) throw new ArgumentNullException(nameof(joinedTable));
            if (string.IsNullOrWhiteSpace(alias)) throw new ArgumentNullException(nameof(alias));
            if (string.IsNullOrWhiteSpace(onCondition)) throw new ArgumentNullException(nameof(onCondition));
            if (alias.Equals(_tableAlias, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException($"The alias '{alias}' is reserved for the main table '{_tableName}'. Please choose a different alias.", nameof(alias));
            // Basic validation to prevent joining the same alias twice could be added here

            _joinClauses.Add($"{joinType.ToUpper()} JOIN {joinedTable} {alias} ON {onCondition}");
            return this;
        }

        /// <summary>
        /// Thêm một mệnh đề INNER JOIN vào câu truy vấn.
        /// </summary>
        /// <param name="joinedTable">Tên bảng cần JOIN.</param>
        /// <param name="alias">Alias cho bảng được JOIN (ví dụ: "u" cho bảng "users").</param>
        /// <param name="onCondition">Điều kiện JOIN (ví dụ: "t.userId = u.id").</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder AddInnerJoin(string joinedTable, string alias, string onCondition)
        {
            return AddJoin("INNER", joinedTable, alias, onCondition);
        }

        /// <summary>
        /// Thêm một mệnh đề LEFT JOIN vào câu truy vấn.
        /// </summary>
        /// <param name="joinedTable">Tên bảng cần JOIN.</param>
        /// <param name="alias">Alias cho bảng được JOIN (ví dụ: "u" cho bảng "users").</param>
        /// <param name="onCondition">Điều kiện JOIN (ví dụ: "t.userId = u.id").</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder AddLeftJoin(string joinedTable, string alias, string onCondition)
        {
            return AddJoin("LEFT", joinedTable, alias, onCondition);
        }


        /// <summary>
        /// Thiết lập các cột cần lấy trong mệnh đề SELECT.
        /// Nên sử dụng alias (ví dụ: "t.id, t.name, u.email"). Mặc định là "t.*".
        /// </summary>
        /// <param name="columns">Danh sách các cột, cách nhau bởi dấu phẩy (ví dụ: "t.id, u.name").</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder SetSelect(string columns)
        {
            if (string.IsNullOrWhiteSpace(columns))
                _selectColumns = $"{_tableAlias}.*"; // Default back to selecting all from main table
            else
                _selectColumns = columns;
            return this;
        }

        /// <summary>
        /// Thiết lập để lấy số lượng bản ghi thay vì dữ liệu thực tế.
        /// Lệnh COUNT(*) sẽ được áp dụng sau khi JOIN và WHERE.
        /// </summary>
        /// <param name="value">True để đếm, False để lấy dữ liệu (mặc định).</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder SetSelectCount(bool value = true)
        {
            _select_count = value;
            // Override select columns if counting
            if (_select_count)
            {
                _selectColumns = $"COUNT({_primaryKeyColumn})"; // Count primary key of main table for potentially better performance than COUNT(*) with joins
                // Or simply use COUNT(*) which is often optimized anyway:
                // _selectColumns = "COUNT(*)";
            }
            return this;
        }

        /// <summary>
        /// Thiết lập sắp xếp theo thứ tự giảm dần (DESC). Mặc định là tăng dần (ASC).
        /// </summary>
        /// <param name="value">True nếu sắp xếp giảm dần.</param>
        /// <returns>Đối tượng PagingJoinQueryBuilder hiện tại để gọi chuỗi.</returns>
        public PagingJoinQueryBuilder SetDesc(bool value = true) // Default to true for convenience
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
            string joinClause = _joinClauses.Any() ? string.Join(" ", _joinClauses) : "";

            // --- Handle COUNT query separately ---
            if (_select_count)
            {
                // COUNT query doesn't need ordering or pagination clauses (OFFSET/LIMIT/FETCH)
                return $"SELECT {_selectColumns} FROM {_tableName} {_tableAlias} {joinClause} {whereClause};";
            }

            // --- Build FROM clause with JOINs ---
            string fromJoinClause = $"{_tableName} {_tableAlias} {joinClause}";

            // --- Phân trang nông (Shallow Paging) ---
            if (!_isDeepPaging)
            {
                switch (_dbTypeIdentifier.ToLower())
                {
                    case "sqlserver":
                        // SQL Server (2012+) - OFFSET/FETCH
                        return $"SELECT {_selectColumns} FROM {fromJoinClause} {whereClause} ORDER BY {_orderByColumn} {orderDirection} OFFSET {offset} ROWS FETCH NEXT {_pageSize} ROWS ONLY;";
                    case "mysql":
                        // MySQL - LIMIT/OFFSET
                        return $"SELECT {_selectColumns} FROM {fromJoinClause} {whereClause} ORDER BY {_orderByColumn} {orderDirection} LIMIT {offset}, {_pageSize};";
                    default:
                        throw new NotSupportedException($"Database type '{_dbTypeIdentifier}' is not supported for shallow paging.");
                }
            }
            // --- Phân trang sâu (Deep Paging) ---
            else
            {
                // Deep paging selects the primary keys of the main table ('t') in a subquery,
                // then joins back to the main table and potentially other tables.

                // Subquery fetches only the primary keys based on filters and order
                string subquerySelect = $"{_primaryKeyColumn}"; // Select main table's PK aliased with 't.'
                string subqueryFrom = $"{_tableName} {_tableAlias} {joinClause}"; // Joins needed if WHERE/ORDER BY use joined tables
                string subqueryOrderBy = $"{_orderByColumn} {orderDirection}";

                string subquerySql;
                switch (_dbTypeIdentifier.ToLower())
                {
                    case "sqlserver":
                        subquerySql = $@"
    SELECT {subquerySelect}
    FROM {subqueryFrom}
    {whereClause}
    ORDER BY {subqueryOrderBy}
    OFFSET {offset} ROWS FETCH NEXT {_pageSize} ROWS ONLY";
                        break;
                    case "mysql":
                        subquerySql = $@"
    SELECT {subquerySelect}
    FROM {subqueryFrom}
    {whereClause}
    ORDER BY {subqueryOrderBy}
    LIMIT {offset}, {_pageSize}";
                        break;
                    default:
                        throw new NotSupportedException($"Database type '{_dbTypeIdentifier}' is not supported for deep paging subquery.");
                }

                // Outer query joins the main table AGAIN using the PKs found by the subquery
                // and then joins any OTHER tables needed for the final SELECT
                // Note: We join the main table ('t') back to the subquery result.
                // Then, we re-apply the ORIGINAL joins (_joinClauses) to get columns from other tables.
                string finalSelectColumns = _selectColumns; // User specifies columns with aliases (e.g., t.col1, u.col2)
                string finalOrderBy = $"ORDER BY {_orderByColumn} {orderDirection}"; // Re-apply order to the final small set

                // Construct the final query
                return $@"
SELECT {finalSelectColumns}
FROM {_tableName} {_tableAlias}
INNER JOIN (
{subquerySql}
) subquery ON {_tableAlias}.{_primaryKeyColumn.Split('.').Last()} = subquery.{_primaryKeyColumn.Split('.').Last()} -- Join main table PK with subquery PK (remove alias for subquery column)
{joinClause} -- Re-apply joins to fetch columns from joined tables if needed by SELECT
{finalOrderBy};"; // Order the final results
            }
        }


        // --- BaseBuilderString Implementation (Dummy) ---
        // These methods are placeholders and should be implemented based on
        // how you intend to map database results to objects/strings.
        public string FromDataRow(DataRow row)
        {
            throw new NotSupportedException();
        }

        public List<string> FromDataTable(DataTable dt)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}