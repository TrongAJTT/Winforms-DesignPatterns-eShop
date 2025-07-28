using System.Collections.Generic;

namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public abstract class PriceCalculatorDecorator : IPriceCalculator
    {
        protected IPriceCalculator _wrappedCalculator;
        protected List<PriceAdjustment> _myAdjustments = new List<PriceAdjustment>();

        protected PriceCalculatorDecorator(IPriceCalculator calculator)
        {
            _wrappedCalculator = calculator;
        }

        public abstract decimal CalculatePrice(); // Lớp con phải implement

        public virtual decimal GetSubTotal()
        {
            // Lấy subtotal gốc từ calculator được bọc
            return _wrappedCalculator.GetSubTotal();
        }

        public virtual List<PriceAdjustment> GetAdjustments()
        {
            // Lấy danh sách điều chỉnh từ lớp được bọc và thêm điều chỉnh của lớp này
            var adjustments = _wrappedCalculator.GetAdjustments();
            adjustments.AddRange(_myAdjustments);
            return adjustments;
        }
    }
}
