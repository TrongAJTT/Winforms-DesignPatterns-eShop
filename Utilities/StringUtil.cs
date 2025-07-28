using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _3S_eShop.Utilities
{
    static class StringUtil
    {
        /// <summary>
        /// Tạo mã OTP ngẫu nhiên
        /// </summary>
        /// <param name="length">Độ dài mã OTP</param>
        /// <returns>Chuỗi chứa mã OTP</returns>
        public static string CreateOTP(int length = 6)
        {
            const string chars = "0123456789";
            Random random = new Random();
            StringBuilder otp = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                otp.Append(chars[random.Next(chars.Length)]);
            }
            return otp.ToString();
        }

        /// <summary>
        /// Ẩn các từ đầu trong tên người dùng bằng cách thay thế các ký tự bằng ký tự che, mặc định là '*'
        /// </summary>
        /// <param name="name">Tên người dùng cần truyền vào</param>
        /// <param name="pattern">Ký tự che</param>
        /// <returns></returns>
        public static string HideName(string name, char pattern = '*')
        {
            string[] parts = name.Split(' ');
            if (parts.Length == 0) return string.Empty;
            string lastPart = parts[parts.Length - 1];
            // Tạo chuỗi ẩn cho các phần trước
            string hiddenParts = string.Join(" ", parts, 0, parts.Length - 1);
            hiddenParts = HideParts(hiddenParts, pattern);
            // Kết hợp lại
            return $"{hiddenParts} {lastPart}";
        }

        private static string HideParts(string parts, char pattern)
        {
            // Thay thế mỗi ký tự bằng dấu '*'
            return string.Join(" ", parts.Split(' ').Select(p => new string(pattern, p.Length)));
        }

        /// <summary>
        /// Che các ký tự trong chuỗi bằng cách thay thế các ký tự bằng ký tự che trừ n ký tự cuối, mặc định là '*'
        /// </summary>
        /// <param name="text">Dãy chuỗi số cần che</param>
        /// <param name="n">Số ký tự cuối có thể hiện</param>
        /// <param name="pattern">Ký tự che</param>
        /// <returns></returns>
        public static string HideString(string text, int n, char pattern = '*')
        {
            // Trả về chuỗi gốc nếu n lớn hơn hoặc bằng độ dài
            if (n >= text.Length) return text; 
            // Tách phần số cần ẩn và số cần hiển thị
            string visiblePart = text.Substring(0, text.Length - n);
            string hiddenPart = text.Substring(text.Length - n);
            // Tạo chuỗi ẩn với ký hiệu '*'
            string hiddenString = new string(pattern, visiblePart.Length);
            // Kết hợp lại
            return hiddenString + hiddenPart;
        }

        /// <summary>
        /// Định dạng chuỗi số thành chuỗi tiền tệ với dấu phân cách là '.'
        /// </summary>
        /// <param name="numberString">Chuỗi số cần truyền vào.</param>
        /// <returns>Chuỗi tiền tệ với dấu '.' cách 3 ký tự. Vd: "1234567" -> "1.234.567</returns>
        /// <exception cref="ArgumentException">Chuỗi không phải là số hợp lệ</exception>
        public static string FormatCurrency(string numberString)
        {
            // Kiểm tra xem chuỗi có phải là số hợp lệ
            if (!long.TryParse(numberString, out long number))
            {
                throw new ArgumentException("Chuỗi không phải là số hợp lệ.");
            }
            return FormatCurrency(number);
        }

        /// <summary>
        /// Định dạng số thành chuỗi tiền tệ với dấu phân cách là '.'
        /// </summary>
        /// <param name="number">Số cần truyền vào</param>
        /// <returns>Chuỗi tiền tệ với dấu '.' cách 3 ký tự. Vd: "1234567" -> "1.234.567</returns>
        public static string FormatCurrency(long number)
        {
            // Định dạng số thành chuỗi với dấu phân cách là '.'
            return string.Format(CultureInfo.InvariantCulture, "{0:N0}", number).Replace(",", ".");
        }

    }
}
