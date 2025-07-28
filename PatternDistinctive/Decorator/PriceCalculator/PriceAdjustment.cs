namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public class PriceAdjustment
    {
        public string Type { get; set; } 
        // "ProductDiscount", "Coupon", "RewardPoints"
        public string Description { get; set; } 
        public decimal Amount { get; set; } 
        // Số tiền giảm (luôn là số dương)
    }
}
