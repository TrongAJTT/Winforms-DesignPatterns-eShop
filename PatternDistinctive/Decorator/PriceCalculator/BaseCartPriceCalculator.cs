using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.Utilities;
using System.Collections.Generic;

namespace _3S_eShop.PatternDistinctive.Decorator.PriceCalculator
{
    public class BaseCartPriceCalculator : IPriceCalculator
    {
        private readonly List<CartItem> _items;
        private decimal _subTotal;
        private List<PriceAdjustment> _adjustments = new List<PriceAdjustment>();

        public BaseCartPriceCalculator(List<CartItem> items)
        {
            _items = items;
            CalculateInitialTotals();
        }

        private void CalculateInitialTotals()
        {
            _subTotal = 0;
            foreach (var item in _items)
            {
                decimal pricePerUnit = item.Variant.Price;
                // Ưu tiên giá đã giảm nếu có và hợp lệ
                if (item.Variant.DiscountPrice > 0 /* && IsDiscountActive(item.ProductVariant.Id) */)
                {
                    decimal amount = (item.Variant.Price - item.Variant.DiscountPrice) * item.Quantity;
                    // Ghi nhận giảm giá từ sản phẩm (nếu muốn chi tiết)
                    _adjustments.Add(new PriceAdjustment
                    {
                        Type = "ProductDiscount",
                        Description = $"Giảm giá sản phẩm {item.Variant.ProductId}:{item.Variant.Label}",
                        Amount = amount
                    });
                    pricePerUnit = item.Variant.DiscountPrice;
                }
                _subTotal += pricePerUnit * item.Quantity;
            }
        }

        // private bool IsDiscountActive(long variantId) { /* Logic kiểm tra DiscountDTO qua ProductVariantDiscountDTO */ }

        public decimal CalculatePrice()
        {
            // Giá gốc chính là subTotal đã tính toán ban đầu (sau product discount)
            return _subTotal;
        }

        public decimal GetSubTotal()
        {
            // Trả về subtotal sau khi đã áp dụng product discount
            return _subTotal;
        }

        public List<PriceAdjustment> GetAdjustments()
        {
            // Trả về bản sao để tránh sửa đổi từ bên ngoài
            return new List<PriceAdjustment>(_adjustments);
        }
    }

}
