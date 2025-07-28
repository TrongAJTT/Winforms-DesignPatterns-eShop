using _3S_eShop.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    public class MaxDiscountAmountValidator : BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Giá trị không được để trống";
                return false;
            }

            if (int.TryParse(text, out int value))
            {
                if (value < 0)
                {
                    invalidMessage = "Giá trị không được âm";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                invalidMessage = "Giá trị không hợp lệ";
                return false;
            }
        }
    }
}
