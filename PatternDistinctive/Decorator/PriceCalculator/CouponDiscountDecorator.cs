using _3S_eShop.BLL.DTOs;
using _3S_eShop.Utilities;
using System;

namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public class CouponDiscountDecorator : PriceCalculatorDecorator
    {
        private readonly CouponDTO _coupon;
        private decimal _discountAmount = 0;

        public CouponDiscountDecorator(IPriceCalculator calculator, CouponDTO coupon) : base(calculator)
        {
            _coupon = coupon;
            // Thực hiện tính toán giảm giá ngay trong constructor hoặc trong CalculatePrice
            ApplyDiscount();
        }

        private void ApplyDiscount()
        {
            // Lấy giá trị *trước* khi áp dụng coupon này
            decimal priceBeforeCoupon = _wrappedCalculator.CalculatePrice();

            // Tính số tiền giảm theo %
            decimal calculatedDiscount = priceBeforeCoupon * (_coupon.DiscountPercent / 100.0m);

            // Giới hạn bởi MaxDiscountAmount
            _discountAmount = Math.Min(calculatedDiscount, _coupon.MaxDiscountAmount);

            // Đảm bảo không giảm thành số âm (mặc dù không nên xảy ra với % và max)
            _discountAmount = Math.Min(_discountAmount, priceBeforeCoupon);

            if (_discountAmount > 0)
            {
                _myAdjustments.Add(new PriceAdjustment
                {
                    Type = "Coupon",
                    // Bạn nên có thuộc tính Code/ID trong CouponDTO để hiển thị
                    Description = $"Sử dụng mã [{_coupon.Id}] giảm {StringUtil.FormatCurrency(Convert.ToInt64(_discountAmount))}đ",
                    Amount = _discountAmount
                });
            }
        }

        public override decimal CalculatePrice()
        {
            decimal priceBeforeCoupon = _wrappedCalculator.CalculatePrice();
            return priceBeforeCoupon - _discountAmount;
        }

        // GetSubTotal() và GetAdjustments() kế thừa từ base decorator
    }
}
