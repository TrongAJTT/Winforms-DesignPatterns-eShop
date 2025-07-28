using System;

namespace _3S_eShop.Validate
{
    internal class PasswordValidator: BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Mật khẩu không được để trống";
                return false;
            }

            // Mật khẩu phải chứa ít nhất 6 ký tự
            if (text.Length < 6)
            {
                invalidMessage = "Mật khẩu phải ít nhất 6 ký tự";
                return false;
            }

            return true;
        }
    }
}
