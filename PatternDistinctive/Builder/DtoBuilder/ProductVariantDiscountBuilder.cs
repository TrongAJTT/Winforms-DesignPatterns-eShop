using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class ProductVariantDiscountBuilder
    {
        private long variantId;
        private long discountId;

        public ProductVariantDiscountBuilder SetDiscountId(long discountId)
        {
            this.discountId = discountId;
            return this;
        }

        public ProductVariantDiscountBuilder SetVariantId(long variantId)
        {
            this.variantId = variantId;
            return this;
        }

        public ProductVariantDiscountDTO Build()
        {
            return new ProductVariantDiscountDTO(variantId, discountId);
        }

        public ProductVariantDiscountDTO FromDataRow(DataRow row)
        {
            return new ProductVariantDiscountDTO(Convert.ToInt64(row["variant_id"]), Convert.ToInt64(row["discount_id"]));
        }

        public List<ProductVariantDiscountDTO> FromDataTable(DataTable dt)
        {
            List<ProductVariantDiscountDTO> brands = new List<ProductVariantDiscountDTO>();
            foreach (DataRow row in dt.Rows)
            {
                brands.Add(FromDataRow(row));
            }
            return brands;
        }

 
    }

}
