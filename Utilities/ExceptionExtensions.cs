using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.Utilities
{
    public static class ExceptionExtensions
    {
        // Phương thức mở rộng cho lớp Exception
        // Từ khóa 'this' trước tham số đầu tiên chỉ định đây là extension method cho Exception
        public static void Log(this Exception ex, string contextMessage = null)
        {
            // Sử dụng Logger singleton của bạn
            var logger = Logger.Instance; // Lấy instance Logger

            // Kiểm tra xem Logger có khởi tạo thành công không (đề phòng)
            if (logger == null)
            {
                Console.WriteLine($"LỖI LOGGING: Logger instance is null. Không thể ghi log cho exception: {ex.Message}");
                return;
            }

            try
            {
                var sb = new StringBuilder();

                // Thêm thông điệp ngữ cảnh nếu có
                if (!string.IsNullOrEmpty(contextMessage))
                {
                    sb.AppendLine($"Context: {contextMessage}");
                    sb.AppendLine("--- Exception Details ---");
                }

                // Duyệt qua exception và các InnerException của nó
                var currentEx = ex;
                int level = 0;
                while (currentEx != null)
                {
                    if (level > 0)
                    {
                        sb.AppendLine($"\n--- Inner Exception (Level {level}) ---");
                    }
                    sb.AppendLine($"Type: {currentEx.GetType().FullName}");
                    sb.AppendLine($"Message: {currentEx.Message}");
                    // Bạn có thể thêm các thuộc tính khác nếu cần, ví dụ: Source
                    // sb.AppendLine($"Source: {currentEx.Source}");
                    sb.AppendLine($"Stack Trace:\n{currentEx.StackTrace}");

                    currentEx = currentEx.InnerException;
                    level++;
                }

                // Ghi log lỗi bằng Logger của bạn
                logger.LogError(sb.ToString());

            }
            catch (Exception logEx)
            {
                // Rất quan trọng: Bắt lỗi có thể xảy ra TRONG QUÁ TRÌNH LOGGING
                // để tránh việc logging gây ra một exception không được xử lý khác.
                Console.WriteLine($"LỖI LOGGING CRITICAL: Không thể ghi log exception. Lỗi logging: {logEx.Message}");
                // Có thể ghi vào Event Log của Windows hoặc một cơ chế dự phòng khác ở đây
            }
        }
    }
}
