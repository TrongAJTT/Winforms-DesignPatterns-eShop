using System;
using System.Text.RegularExpressions;

namespace _3S_eShop.Validate
{
    internal class EmailVaildator : BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Email không được để trống";
                return false;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(text, pattern))
            {
                invalidMessage = "Email không đúng định dạng";
                return false;
            }

            return true;
        }

    }
}
