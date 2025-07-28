using _3S_eShop.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    public class DiscountPercentValidator : BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            // không chấp nhận null
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Giá trị không được để trống";
                return false;
            }


            // chỉ chấp nhận 1-100
            if (int.TryParse(text, out int value))
            {
                if (value < 0)
                {
                    invalidMessage = "Giá trị không được âm";
                    return false;
                }
                else if (value > 100)
                {
                    invalidMessage = "Phần trăm giảm giá không được lớn hơn 100";
                    return false;
                }
                else if (value == 0)
                {
                    invalidMessage = "Phần trăm giảm giá phải lớn hơn 0";
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
