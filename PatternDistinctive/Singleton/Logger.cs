using System;
using System.IO;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Singleton
{
    public sealed class Logger : IDisposable
    {
        private static readonly Lazy<Logger> _instance  = new Lazy<Logger>(() => new Logger());
        

        public static Logger Instance => _instance.Value;


        private Logger()
        {
            try
            {
                InitializeData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi khởi tạo Logger: {ex.Message}");
            }
        }

        private static readonly string _logFilePath =
            $"log/log-{DateTime.Now.ToString("yyMMdd")}.txt";
        // Đối tượng khóa cho đồng bộ hóa
        private static readonly object _lock = new object();
        private StreamWriter _logStream;

        private void InitializeData()
        {
            // Đảm bảo thư mục log tồn tại
            Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath));

            // Mở hoặc tạo file log để ghi thêm (append)
            _logStream = new StreamWriter(_logFilePath, true, System.Text.Encoding.UTF8);
            _logStream.AutoFlush = false; // Tắt AutoFlush để tối ưu hóa ghi log
        }

        // Đóng StreamWriter khi đối tượng Logger bị hủy
        ~Logger()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_logStream != null)
                {
                    _logStream.Flush(); // Đảm bảo dữ liệu cuối cùng được ghi
                    _logStream.Close();
                    _logStream.Dispose();
                    _logStream = null;
                }
            }
        }

        public void Log(LogLevel level, string message)
        {
            if (_logStream == null) return; // Kiểm tra Stream có hợp lệ không

            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level.ToString().ToUpper()}] {message}";

            // Ghi log bất đồng bộ để không block luồng chính
            Task.Run(() =>
            {
                try
                {
                    lock (_lock) // Đồng bộ hóa truy cập vào StreamWriter
                    {
                        _logStream.WriteLine(logMessage);
                        _logStream.Flush(); // Flush định kỳ hoặc khi cần thiết
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi ghi log: {ex.Message}");
                }
            });
        }

        private void WipeData()
        {
            try
            {
                Dispose(true); // Đảm bảo StreamWriter được đóng
                File.Delete(_logFilePath); // Xóa file log
                // Reinitialize the Logger instance
                InitializeData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa dữ liệu: {ex.Message}");
            }
        }

        public void LogInfo(string message) => Log(LogLevel.Info, message);
        public void LogWarning(string message) => Log(LogLevel.Warning, message);
        public void LogError(string message) => Log(LogLevel.Error, message);
        public void LogErrorException(Exception ex, string message = "Chương trình gặp sự cố")
        {
            LogError($"{message}\n" +
                $"- Source: {ex.Source}" +
                $"- Message: {ex.Message}.\n" +
                $"- Stacktrace: {ex.StackTrace}.\n" +
                $"- Data: {ex.Data}.");
            if(ex.InnerException != null)
            {
                LogErrorException(ex.InnerException);
            }
        }
        public void LogFatal(string message) => Log(LogLevel.Fatal, message);

        /// <summary>
        /// Xóa tất cả các file log
        /// </summary>
        public static void Clear()
        {
            DirectoryInfo directory = new DirectoryInfo("log");
            FileInfo[] fileInfos = directory.GetFiles("log-*.txt");
            foreach (FileInfo fileInfo in fileInfos)
            {
                if (_logFilePath.EndsWith(fileInfo.Name))
                {
                    Instance.WipeData();
                }
                else
                {
                    File.Delete(fileInfo.FullName);
                }
            }
        }

        public static string GetLogSize()
        {
            DirectoryInfo directory = new DirectoryInfo("log");
            FileInfo[] fileInfos = directory.GetFiles("log-*.txt");
            long totalSize = 0;
            foreach (FileInfo fileInfo in fileInfos)
            {
                totalSize += fileInfo.Length;
            }
            return $"{totalSize / 1024} KB"; 
            // Trả về kích thước tổng cộng của các file log
        }
    }


    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Fatal
    }
}
