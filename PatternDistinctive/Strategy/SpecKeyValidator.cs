using _3S_eShop.Validate;
using System.Linq;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    class SpecKeyValidator : BaseValidator
    {
        private static int MAX_LENGTH = 20;

        public override bool IsValid(string text, params string[] param)
        {
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Vui lòng không để trống";
                return false;
            }
            else if (param.Contains(text))
            {
                invalidMessage = "Thông số này đã tồn tại";
                return false;
            }
            else if (text.Length > MAX_LENGTH)
            {
                invalidMessage = $"Tên thống số nhập quá {MAX_LENGTH} ký tự. ({text.Length}/{MAX_LENGTH})";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
