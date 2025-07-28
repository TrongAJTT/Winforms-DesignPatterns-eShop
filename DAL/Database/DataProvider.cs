using _3S_eShop.Connect;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3S_eShop
{
    internal class DataProvider
    {
        private string connectionStr;
        private static DataProvider instance;
        internal static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    String dbType = new Environment.GetEnvironmentVariable("DB_TYPE");
                    if (dbType.Equals("mysql")) 
                        instance = new DataProvider(new MySqlDbFactory());
                    else 
                        instance = new DataProvider(new SqlServerDbFactory());
                    instance.SetConnectionString();
                }
                return instance;
            }
        }

        private readonly DatabaseFactory _db;

        private DataProvider(DatabaseFactory dbType)
        {
            _db = dbType;
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL trả về một DataTable.
        /// </summary>
        /// <param name="query">Câu truy vấn SQL.</param>
        /// <param name="para">Danh sách tham số (nếu có).</param>
        /// <returns>DataTable chứa kết quả truy vấn.</returns>
        public DataTable ExecuteQuery(string query, params object[] para)
        {
            DataTable dt = new DataTable();
            using (IDbConnection con = _db.CreateConnection(connectionStr))
            {
                con.Open();
                IDbCommand cmd = CreateAndProcessParametersIfNotNull(con, query, para);
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL không trả về kết quả (dùng cho INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">Câu truy vấn SQL.</param>
        /// <param name="para">Danh sách tham số (nếu có).</param>
        /// <returns>Số dòng bị ảnh hưởng bởi truy vấn.</returns>
        public int ExecuteNonQuery(string query, params object[] para)
        {
            int data = 0;
            using (IDbConnection con = _db.CreateConnection(connectionStr))
            {
                con.Open();
                IDbCommand cmd = CreateAndProcessParametersIfNotNull(con, query, para);
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL trả về một giá trị đơn (scalar).
        /// </summary>
        /// <param name="query">Câu truy vấn SQL.</param>
        /// <param name="para">Danh sách tham số (nếu có).</param>
        /// <returns>Giá trị đơn trả về từ truy vấn.</returns>
        public object ExecuteScalar(string querry, params object[] para)
        {
            object data;
            using (IDbConnection con = _db.CreateConnection(connectionStr))
            {
                con.Open();
                IDbCommand cmd = CreateAndProcessParametersIfNotNull(con, querry, para);
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }

        /// <summary>
        /// Thực thi câu truy vấn SQL trả về danh sách các cột dưới dạng List<object>.
        /// </summary>
        /// <param name="query">Câu truy vấn SQL.</param>
        /// <param name="para">Danh sách tham số (nếu có).</param>
        /// <returns>Danh sách các cột dưới dạng List<object>.</returns>
        public List<object> ExecuteQuerryAsColumn(string querry, params object[] para)
        {
            DataTable dt = new DataTable();
            using (IDbConnection con = _db.CreateConnection(connectionStr))
            {
                con.Open();
                IDbCommand cmd = CreateAndProcessParametersIfNotNull(con, querry, para);
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt.AsEnumerable().Select(col => col[0]).ToList();
        }


        /// <summary>
        /// Đếm số lượng hàng trong bảng chỉ định.
        /// </summary>
        /// <param name="tableName">Tên bảng cần đếm số hàng.</param>
        /// <returns>Số lượng hàng trong bảng.</returns>
        public object CountRows(string tableName)
        {
            return ExecuteScalar($"SELECT COUNT(*) FROM {tableName}");
        }


        /// <summary>
        /// Kiểm tra xem có bản ghi nào trong bảng thỏa mãn điều kiện so sánh "like" hay không.
        /// </summary>
        /// <param name="tableName">Tên bảng.</param>
        /// <param name="property">Tên cột.</param>
        /// <param name="value">Giá trị so sánh (có thể chứa ký tự đại diện của SQL like: %, _).</param>
        /// <returns>True nếu có ít nhất một bản ghi thỏa mãn, False nếu không có bản ghi nào.</returns>
        public bool AnyMatch(string tableName, string property, string value)
        {
            return Convert.ToInt32(ExecuteScalar($"SELECT COUNT(*) FROM {tableName} WHERE {property} like @value", value)) > 0;
        }


        /// <summary>
        /// Tìm kiếm các bản ghi trong bảng thỏa mãn điều kiện so sánh "like".
        /// </summary>
        /// <param name="tableName">Tên bảng.</param>
        /// <param name="property">Tên cột.</param>
        /// <param name="value">Giá trị so sánh (có thể chứa ký tự đại diện của SQL like: %, _).</param>
        /// <returns>DataTable chứa các bản ghi thỏa mãn.</returns>
        public DataTable FindMatch(string tableName, string property, string value)
        {
            return ExecuteQuery($"SELECT * FROM {tableName} WHERE {property} like @value", value);
        }


        /// <summary>
        /// Lấy id vừa thêm vào và trả về một object<object>.
        /// </summary>
        /// <returns>Object chứa id vừa thêm vào<object>.</returns>
        public object GetLastInsertedId()
        {
            object newId = null;

            using (IDbConnection connection = _db.CreateConnection(connectionStr))
            {
                connection.Open();
                IDbCommand command = _db.CreateCommand(string.Empty, connection); // Tạo command trước

                // Xác định loại database để chọn câu truy vấn lấy ID phù hợp.
                string getIdQuery = "";
                if (_db is SqlServerDbFactory)
                {
                    getIdQuery = "SELECT SCOPE_IDENTITY();";
                }
                else if (_db is MySqlDbFactory)
                {
                    getIdQuery = "SELECT LAST_INSERT_ID();";
                }
                // Có thể thêm các else if cho các loại database khác (PostgreSQL, SQLite, ...)

                // Gộp câu truy vấn INSERT và câu truy vấn lấy ID.
                command.CommandText = getIdQuery;

                // Thực thi và lấy ID.
                newId = command.ExecuteScalar();
                connection.Close();
            }
            return newId;
        }


        /// <summary>
        /// Kiểm tra kết nối đến database (dùng cho mục đích xác thực).
        /// </summary>
        /// <param name="connectionString">Chuỗi kết nối.</param>
        /// <returns>True nếu kết nối thành công, ngược lại false.</returns>
        public static string TryConnecting(string connectionString, string dbType)
        {
            try
            {
                IDbConnection conn;
                if (dbType.Equals(MySystem.DB_TYPE_MYSQL))
                    conn = new MySqlConnection(connectionString);
                else
                    conn = new SqlConnection(connectionString);
                conn.Open();
                conn.Close();
                return null;
            }
            catch (Exception e)
            {
                Logger.Instance.LogError("DATA PROVIDER - Lỗi khi kết nối đến CSDL: " + e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// Cập nhật chuỗi kết nối từ file ".connect".
        /// </summary>
        public void SetConnectionString()
        {
            this.connectionStr = Environment.GetEnvironmentVariable("DB_CONN");
            if (string.IsNullOrEmpty(connectionStr))
            {
                Logger.Instance.LogError("KHÔNG THỂ THIẾT LẬP KẾT NỐI ĐẾN CSDL, KHÔNG TÌM THẤY CHUỖI KẾT NỐI -> BUỘC DỪNG CHƯƠNG TRÌNH.");
                MessageBox.Show("Không thể thiết lập kết nối đến CSDL!\nBuộc dừng chương trình", "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySystem.Terminate();
            }
        }

        /// <summary>
        /// Lấy loại database.
        /// </summary>
        /// <returns>Chuỗi MySystem.DB_TYPE</returns>
        public String GetDatabaseType()
        {
            return _db is SqlServerDbFactory ? MySystem.DB_TYPE_SQLSERVER : MySystem.DB_TYPE_MYSQL;
        }


        private IDbCommand CreateAndProcessParametersIfNotNull(IDbConnection con, string query, object[] para)
        {
            IDbCommand cmd = _db.CreateCommand(query, con);
            if (para != null)
            {
                string[] listPara = ExtractParams(query);
                for (int i = 0; i < listPara.Length; i++)
                {
                    IDbDataParameter parameter = cmd.CreateParameter();
                    parameter.ParameterName = listPara[i];
                    parameter.Value = para[i];
                    cmd.Parameters.Add(parameter);
                }
            }
            return cmd;
        }

        private string[] ExtractParams(string input)
        {
            List<string> results = new List<string>();
            // Regex pattern:
            // @         : Tìm ký tự '@'
            // (         : Bắt đầu capturing group
            // [a-zA-Z0-9_]+ : Một hoặc nhiều ký tự chữ (a-z, A-Z), số (0-9), hoặc dấu gạch dưới (_)
            // )         : Kết thúc capturing group
            MatchCollection matches = Regex.Matches(input, @"@([a-zA-Z0-9_]+)");

            foreach (Match match in matches)
            {
                // match.Groups[0] chứa toàn bộ match (@param1, @param2,...)
                // match.Groups[1] chứa phần capturing group ([a-zA-Z0-9_]+)  ->  param1, param2,...
                results.Add(match.Groups[0].Value); // Thêm toàn bộ match (@param1, @param2,...) vào list
                results.Remove("@gmail");
            }

            return results.ToArray();
        }
    }
}
