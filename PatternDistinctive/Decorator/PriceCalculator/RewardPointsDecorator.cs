using _3S_eShop.Utilities;
using System;

namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public class RewardPointsDecorator : PriceCalculatorDecorator
    {
        private static decimal maxDiscountPercent = 0.05m; 
        // Giới hạn giảm giá tối đa là 5% của subtotal

        private readonly int _pointsToUse;
        private readonly int _availableUserPoints;
        private readonly decimal _pointsToCurrencyRate; // 1 điểm = 1 VNĐ
        private decimal _discountAmount = 0;
        private int _actualPointsUsed = 0;

        public RewardPointsDecorator(IPriceCalculator calculator, int pointsToUse, int availableUserPoints, decimal pointsToCurrencyRate) : base(calculator)
        {
            _pointsToUse = pointsToUse;
            _availableUserPoints = availableUserPoints;
            _pointsToCurrencyRate = pointsToCurrencyRate;
            ApplyPoints();
        }

        private void ApplyPoints()
        {
            decimal priceBeforePoints = _wrappedCalculator.CalculatePrice();
            if (priceBeforePoints <= 0 || _pointsToUse <= 0) return; 
            // Không áp dụng nếu giá đã <= 0 hoặc không dùng điểm

            decimal subTotal = GetSubTotal(); 
            // Lấy subtotal gốc (sau product discount)
            decimal maxPointsDiscountAllowed = subTotal * maxDiscountPercent; 
            // Giới hạn 5%

            decimal requestedPointsValue = _pointsToUse * _pointsToCurrencyRate;
            decimal availablePointsValue = _availableUserPoints * _pointsToCurrencyRate;

            // Xác định giá trị giảm thực tế
            _discountAmount = Math.Min(requestedPointsValue, availablePointsValue);
            _discountAmount = Math.Min(_discountAmount, maxPointsDiscountAllowed);
            _discountAmount = Math.Min(_discountAmount, priceBeforePoints); 
            // Không giảm quá giá trị còn lại

            if (_discountAmount > 0 && _pointsToCurrencyRate > 0)
            {
                // Tính số điểm thực sự đã dùng dựa trên số tiền giảm
                _actualPointsUsed = (int)Math.Ceiling(_discountAmount / _pointsToCurrencyRate); // Làm tròn lên để trừ đúng điểm

                _myAdjustments.Add(new PriceAdjustment
                {
                    Type = "RewardPoints",
                    Description = 
                        $"Sử dụng {StringUtil.FormatCurrency(_actualPointsUsed)} điểm",
                    Amount = _discountAmount
                });
            }
            else
            {
                _discountAmount = 0; // Reset nếu không hợp lệ
            }
        }

        public override decimal CalculatePrice()
        {
            decimal priceBeforePoints = _wrappedCalculator.CalculatePrice();
            return priceBeforePoints - _discountAmount;
        }

        // Phương thức bổ sung để biết chính xác bao nhiêu điểm đã dùng
        public int GetActualPointsUsed()
        {
            return _actualPointsUsed;
        }

        // GetSubTotal() và GetAdjustments() kế thừa từ base decorator
    }
}
