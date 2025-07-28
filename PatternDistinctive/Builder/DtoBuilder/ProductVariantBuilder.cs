using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using _3S_eShop.BLL.DTOs;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class ProductVariantBuilder
    {
        private long id;
        private long productId;
        private string label;
        private string description;
        private int price;
        private int discountPrice;
        private short stockQuantity;

        public ProductVariantBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public ProductVariantBuilder SetDiscountPrice(int discountPrice)
        {
            this.discountPrice = discountPrice;
            return this;
        }

        public ProductVariantBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public ProductVariantBuilder SetLabel(string label)
        {
            this.label = label;
            return this;
        }

        public ProductVariantBuilder SetPrice(int price)
        {
            this.price = price;
            return this;
        }

        public ProductVariantBuilder SetProductId(long productId)
        {
            this.productId = productId;
            return this;
        }

        public ProductVariantBuilder SetStockQuantity(short stockQuantity)
        {
            this.stockQuantity = stockQuantity;
            return this;
        }

        public ProductVariantDTO Build()
        {
            return new ProductVariantDTO(id, productId, label, description, price, discountPrice, stockQuantity);
        }

        public ProductVariantBuilder Default()
        {
            return new ProductVariantBuilder()
            {
                id = 0,
                productId = 0,
                label = "",
                description = "",
                price = 0,
                discountPrice = -1,
                stockQuantity = 0
            };
        }

        public ProductVariantDTO FromDataRow(DataRow row)
        {
            return new ProductVariantBuilder()
                .SetId(Convert.ToInt64(row[0]))
                .SetProductId(Convert.ToInt64(row[1]))
                .SetLabel(row[2].ToString())
                .SetDescription(row[3].ToString())
                .SetPrice(Convert.ToInt32(row[4]))
                .SetDiscountPrice(Convert.ToInt32(row[5]))
                .SetStockQuantity(Convert.ToInt16(row[6]))
                .Build();
        }

        public List<ProductVariantDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(row => FromDataRow(row)).ToList();
        }
    }
}
