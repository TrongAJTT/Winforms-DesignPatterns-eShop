using _3S_eShop.GUI;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using StackExchange.Redis;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.Connect
{
    internal class Redis
    {
        private static Redis _instance;
        private static readonly object _lock = new object();
        private ConnectionMultiplexer _connection;

        public static String 
            CHANNEL_CUSTOMER_SERVICE_STATUS_UPDATE = "customer-service:chat-updated",
            CHANNEL_CUSTOMER_SREVICE_NEW_MESSAGE = "customer-service:new-message";

        private Redis()
        {
            try
            {
                string host = Environment.GetEnvironmentVariable("REDIS_HOST");
                string port = Environment.GetEnvironmentVariable("REDIS_PORT");
                string user = Environment.GetEnvironmentVariable("REDIS_USER");
                string pass = Environment.GetEnvironmentVariable("REDIS_PASS");
                UpdateConnection(host, port, user, pass);
            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, "REDIS - Không thể kết nối đến CSDL Redis. Vui lòng kiểm tra lại thư mục dữ liệu secret_data trong thư mục chạy chương trình!");
                MessageBox.Show("Không thể kết nối đến CSDL Redis. Vui lòng kiểm tra lại thư mục dữ liệu secret_data trong thư mục chạy chương trình!", "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySystem.Terminate();
            }
        }

        private Redis(params string[] param)
        {
            UpdateConnection(param);
        }

        public static Redis Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new Redis();
                    return _instance;
                }
            }
        }

        public ConnectionMultiplexer GetConnectionMultiplexer()
        {
            if (_connection == null || !_connection.IsConnected)
            {
                Logger.Instance.LogError("REDIS - Kết nối đến redis không được thành lập.");
                throw new InvalidOperationException("Kết nối đến redis không được thành lập.");
            }
            return _connection;
        }

        public IDatabase GetDatabase()
        {
            return _connection.GetDatabase();
        }

        #region Các hàm thường dùng với Redis

        /// <summary>
        /// Lưu trữ một giá trị string vào Redis.
        /// </summary>
        /// <param name="key">Khóa.</param>
        /// <param name="value">Giá trị.</param>
        /// <param name="expiry">Thời gian hết hạn (tùy chọn).</param>
        /// <returns>True nếu thành công, False nếu thất bại.</returns>
        public bool StringSet(string key, string value, TimeSpan? expiry = null)
        {
            IDatabase db = GetDatabase();
            return db.StringSet(key, value, expiry);
        }

        public Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = null)
        {
            IDatabase db = GetDatabase();
            return db.StringSetAsync(key, value, expiry);
        }

        /// <summary>
        /// Lấy một giá trị string từ Redis.
        /// </summary>
        /// <param name="key">Khóa.</param>
        /// <returns>Giá trị string, hoặc null nếu không tìm thấy.</returns>
        public string StringGet(string key)
        {
            IDatabase db = GetDatabase();
            return db.StringGet(key);
        }

        /// <summary>
        /// Lưu trữ một đối tượng (được serialize thành JSON) vào Redis.
        /// </summary>
        /// <typeparam name="T">Kiểu dữ liệu của đối tượng.</typeparam>
        /// <param name="key">Khóa.</param>
        /// <param name="value">Đối tượng.</param>
        /// <param name="expiry">Thời gian hết hạn (tùy chọn).</param>
        /// <returns>True nếu thành công, False nếu thất bại.</returns>
        public bool SetObject<T>(string key, T value, TimeSpan? expiry = null)
        {
            IDatabase db = GetDatabase();
            string json = JsonSerializer.Serialize(value); // Sử dụng System.Text.Json
            return db.StringSet(key, json, expiry);
        }

        /// <summary>
        /// Lấy một đối tượng (được deserialize từ JSON) từ Redis.
        /// </summary>
        /// <typeparam name="T">Kiểu dữ liệu của đối tượng.</typeparam>
        /// <param name="key">Khóa.</param>
        /// <returns>Đối tượng, hoặc null nếu không tìm thấy hoặc lỗi deserialize.</returns>
        public T GetObject<T>(string key)
        {
            IDatabase db = GetDatabase();
            string json = db.StringGet(key);
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            try
            {
                return JsonSerializer.Deserialize<T>(json); // Sử dụng System.Text.Json
            }
            catch
            {
                return default(T); // Hoặc ném exception tùy theo yêu cầu
            }
        }

        /// <summary>
        /// Xóa một khóa khỏi Redis.
        /// </summary>
        /// <param name="key">Khóa cần xóa.</param>
        /// <returns>True nếu xóa thành công, False nếu không tìm thấy khóa.</returns>
        public bool KeyDelete(string key)
        {
            IDatabase db = GetDatabase();
            return db.KeyDelete(key);
        }

        /// <summary>
        /// Kiểm tra xem một khóa có tồn tại trong Redis không.
        /// </summary>
        /// <param name="key">Khóa cần kiểm tra.</param>
        /// <returns>True nếu tồn tại, False nếu không.</returns>
        public bool KeyExists(string key)
        {
            IDatabase db = GetDatabase();
            return db.KeyExists(key);
        }

        /// <summary>
        /// Tăng giá trị của một khóa lên 1.
        /// </summary>
        /// <param name="key">Khóa.</param>
        /// <returns>Giá trị sau khi tăng.</returns>
        public long StringIncrement(string key)
        {
            IDatabase db = GetDatabase();
            return db.StringIncrement(key);
        }

        /// <summary>
        /// Giảm giá trị của một khóa đi 1.
        /// </summary>
        /// <param name="key">Khóa.</param>
        /// <returns>Giá trị sau khi giảm.</returns>
        public long StringDecrement(string key)
        {
            IDatabase db = GetDatabase();
            return db.StringDecrement(key);
        }

        /// <summary>
        /// Thêm một phần tử vào danh sách (list) trong Redis.
        /// </summary>
        /// <param name="key">Khóa của danh sách.</param>
        /// <param name="value">Giá trị cần thêm.</param>
        public void ListRightPush(string key, string value)
        {
            IDatabase db = GetDatabase();
            db.ListRightPush(key, value);
        }

        /// <summary>
        /// Lấy và xóa phần tử đầu tiên (bên trái) của danh sách (list) trong Redis.
        /// </summary>
        /// <param name="key">Khóa của danh sách.</param>
        /// <returns>Phần tử đầu tiên, hoặc null nếu danh sách rỗng.</returns>
        public string ListLeftPop(string key)
        {
            IDatabase db = GetDatabase();
            return db.ListLeftPop(key);
        }

        /// <summary>
        /// Lấy tất cả các phần tử của danh sách trong Redis.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns></returns>
        public RedisValue[] ListRange(string key)
        {
            IDatabase db = GetDatabase();
            return db.ListRange(key);
        }

        /// <summary>
        /// Đặt một giá trị cho một khóa băm
        /// </summary>
        public bool HashSet<T>(string key, string hashField, T value)
        {
            IDatabase db = GetDatabase();
            string json = JsonSerializer.Serialize(value);
            return db.HashSet(key, hashField, json);
        }

        /// <summary>
        /// Lấy một giá trị từ một khóa băm
        /// </summary>
        public T HashGet<T>(string key, string hashField)
        {
            IDatabase db = GetDatabase();
            string json = db.HashGet(key, hashField);
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            try
            {
                return JsonSerializer.Deserialize<T>(json); // Sử dụng System.Text.Json
            }
            catch
            {
                return default(T); // Hoặc ném exception tùy theo yêu cầu
            }
        }

        /// <summary>
        /// Xóa một giá trị khỏi một khóa băm
        /// </summary>
        public bool HashDelete(string key, string hashField)
        {
            IDatabase db = GetDatabase();
            return db.HashDelete(key, hashField);
        }

        /// <summary>
        /// Kiểm tra nếu khóa băm tồn tại
        /// </summary>
        public bool HashExists(string key, string hashField)
        {
            IDatabase db = GetDatabase();
            return db.HashExists(key, hashField);
        }

        /// <summary>
        /// Lấy tất cả dữ liệu từ băm
        /// </summary>
        public HashEntry[] HashGetAll(string key)
        {
            IDatabase db = GetDatabase();
            return db.HashGetAll(key);
        }

        #endregion

        public void UpdateConnection(params string[] input)
        {
            try
            {
                _connection = ConnectionMultiplexer.Connect
                (
                    new ConfigurationOptions
                    {
                        EndPoints = { { input[0], Convert.ToInt32(input[1]) } },
                        User = input[2],
                        Password = input[3]
                    }
                );
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể thiết lập kết nối đến CSDL Redis!\nBuộc dừng ứng dụng", "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.LogErrorException(e, "REDIS - Không thể kết nối đến CSDL");
                MySystem.Terminate();
            }
        }

        public static string TestConnection(params string[] input)
        {
            try
            {
                Redis redis = new Redis(input);
                redis.StringGet("test");
                return null;
            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, "REDIS - Lỗi khi kết nối đến Redis.");
                return ex.Message;
            }
        } 

    }
}
