using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class CartProductBuilder
    {
        private long userId;
        private long productId;
        private long variantId;
        private byte quantity;

        public CartProductBuilder SetProductId(long productId)
        {
            this.productId = productId;
            return this;
        }

        public CartProductBuilder SetQuantity(byte quantity)
        {
            this.quantity = quantity;
            return this;
        }

        public CartProductBuilder SetUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public CartProductBuilder SetVariantId(long variantId)
        {
            this.variantId = variantId;
            return this;
        }

        public CartProductDTO Build()
        {
            return new CartProductDTO(userId, productId, variantId, quantity);
        }

        public CartProductBuilder Default()
        {
            this.userId = -1;
            this.productId = -1;
            this.variantId = -1;
            this.quantity = 0;
            return this;
        }

        public CartProductDTO FromDataRow(DataRow row)
        {
            return new CartProductDTO(
                Convert.ToInt64(row[0]),
                Convert.ToInt64(row[1]),
                Convert.ToInt64(row[2]),
                Convert.ToByte(row[3])
            );
        }

        public List<CartProductDTO> FromDataTable(DataTable dt)
        {
            List<CartProductDTO> list = new List<CartProductDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(FromDataRow(row));
            }
            return list;
        }
    }
}
