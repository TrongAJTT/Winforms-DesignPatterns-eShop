using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class ProductVariantDiscountDTO : BaseDTO<ProductVariantDiscountDTO>
    {
        private long variantId;
        private long discountId;

        public ProductVariantDiscountDTO(long variantId, long discountId)
        {
            VariantId = variantId;
            DiscountId = discountId;
        }

        public long VariantId { get => variantId; set => variantId = value; }
        public long DiscountId { get => discountId; set => discountId = value; }

        public string TableName => "Product_Variant_Discount";

        public bool Equals(ProductVariantDiscountDTO obj)
        {
            return variantId == obj.VariantId && discountId == obj.DiscountId;
        }

        public object[] GenSaveObject()
        {
            return new object[] { VariantId, DiscountId };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { VariantId, DiscountId };
        }
    }

}
