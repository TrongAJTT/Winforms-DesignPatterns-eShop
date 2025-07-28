using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class OrderProductBuilder
    {
        private long id;
        private long orderId;
        private long productId;
        private long variantId;
        private byte quantity;
        private uint originalPrice;
        private uint finalPrice;

        public OrderProductBuilder SetFinalPrice(uint finalPrice)
        {
            this.finalPrice = finalPrice;
            return this;
        }

        public OrderProductBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public OrderProductBuilder SetOrderId(long orderId)
        {
            this.orderId = orderId;
            return this;
        }

        public OrderProductBuilder SetOriginalPrice(uint originalPrice)
        {
            this.originalPrice = originalPrice;
            return this;
        }

        public OrderProductBuilder SetProductId(long productId)
        {
            this.productId = productId;
            return this;
        }

        public OrderProductBuilder SetVariantId(long variantId)
        {
            this.variantId = variantId;
            return this;
        }

        public OrderProductBuilder SetQuantity(byte quantity)
        {
            this.quantity = quantity;
            return this;
        }
        public OrderProductDTO Build()
        {
            return new OrderProductDTO(id, orderId, productId, variantId, quantity, originalPrice, finalPrice);
        }

        public OrderProductDTO FromDataRow(DataRow row)
        {
            return new OrderProductBuilder()
                .SetId((long)row[0])
                .SetOrderId((long)row[1])
                .SetProductId((long)row[2])
                .SetVariantId((long)row[3])
                .SetQuantity(Convert.ToByte(row[4]))
                .SetOriginalPrice((uint)row[5])
                .SetFinalPrice((uint)row[6])
                .Build();
        }

        public List<OrderProductDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(row => FromDataRow(row)).ToList();
        }

        
    }
}
