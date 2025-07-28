using _3S_eShop.Validate;
using System;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    class TemplateIntegerValidator : BaseValidator
    {
        private int minValue, maxValue;

        public TemplateIntegerValidator(int minValue = Int32.MinValue, int maxValue = Int32.MaxValue) 
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        // Param: 0 => Ký tự thay thế
        public override bool IsValid(string text, params string[] param)
        {
            string prefix = param.Length > 0 ? param[0] + ":" : string.Empty;
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = $"{prefix} Vui lòng không bỏ trống.";
                return false;
            }
            if (!int.TryParse(text, out int result))
            {
                invalidMessage = $"{prefix} Vui lòng nhập số nguyên.";
                return false;
            }
            if (result < minValue || result > maxValue)
            {
                invalidMessage = $"{prefix} Vui lòng nhập số nguyên trong khoảng [{minValue}, {maxValue}].";
                return false;
            }
            return true;
        }
    }
}
