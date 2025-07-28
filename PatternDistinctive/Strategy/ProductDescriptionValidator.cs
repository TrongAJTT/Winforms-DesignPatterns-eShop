using _3S_eShop.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Strategy
{
    class ProductDescriptionValidator : BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Mô tả không được để trống";
                return false;
            }

            else if (text.Length > 4096)
            {
                invalidMessage = $"Mô tả quá dài ({text.Length}/4096 ký tự)";
                return false;
            }

            return true;
        }
    }
}
