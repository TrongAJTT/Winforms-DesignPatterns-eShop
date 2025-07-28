using _3S_eShop.DAL.Database;
using System;

namespace _3S_eShop.Validate
{
    internal class OtpValidator : BaseValidator
    {
        // Param:
        // - Email cần lấy trên redis
        public override bool IsValid(string text, params string[] param)
        {
            text = text.Trim();

            // Kiểm tra xem email có hợp lệ không
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Vui lòng không để trống";
                return false;
            }

            // Lấy mã OTP từ Redis
            string value = RedisHandler.GetEmailOtp(param[0]);

            // Kiểm tra xem mã OTP có hợp lệ không
            if (string.IsNullOrEmpty(value))
            {
                invalidMessage = "Mã OTP đã hết hạn";
                return false;
            }

            // Kiểm tra xem mã OTP có khớp không`
            else if (!text.Equals(value))
            {
                invalidMessage = "Mã OTP không đúng";
                return false;
            }

            return true;
        }
    }
}
