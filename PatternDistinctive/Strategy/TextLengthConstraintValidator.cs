using _3S_eShop.Validate;
using System;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    class TextLengthConstraintValidator : BaseValidator
    {
        private int maxLength = 1000;
        private int minLength = 1;

        public TextLengthConstraintValidator(int maxLength = 2048, int minLength = 1) 
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        public override bool IsValid(string text, params string[] param)
        {
            // Trường hợp không có dữ liệu
            if (string.IsNullOrEmpty(text.Trim()))
            {
                invalidMessage = $"Vui lòng không để trống";
                return false;
            }
            // Dữ liệu không đạt ngưỡng tối thiểu
            else if (text.Length < minLength)
            {
                invalidMessage = $"Vui lòng nhập ít nhất {minLength} ký tự";
                return false;
            }
            // Dữ liệu không đạt ngưỡng tối đa
            else if (text.Length > maxLength)
            {
                invalidMessage = $"Vui lòng nhập tối đa {maxLength} ký tự";
                return false;
            }
            // Dữ liệu hợp lệ
            else
            {
                return true;
            }
        }
    }
}
