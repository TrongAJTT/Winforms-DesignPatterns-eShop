using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(); 
        // Tính giá sau khi áp dụng logic của lớp này
        decimal GetSubTotal();   
        // Trả về tổng giá gốc của các sản phẩm (trước coupon, điểm thưởng)
        List<PriceAdjustment> GetAdjustments(); 
        // Lấy danh sách các điều chỉnh giá đã áp dụng
    }
}
