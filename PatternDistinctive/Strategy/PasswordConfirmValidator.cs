using _3S_eShop.Validate;
using System;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    class PasswordConfirmValidator : BaseValidator
    {
        // Param:
        // - Mật khẩu gốc cần đối chiếu
        public override bool IsValid(string text, params string[] param)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Mật khẩu xác nhận không được để trống";
                return false;
            }

            // Mật khẩu không khớp
            if (!text.Equals(param[0]))
            {
                invalidMessage = "Mật khẩu không khớp";
                return false;
            }

            return true;
        }
    }
}
