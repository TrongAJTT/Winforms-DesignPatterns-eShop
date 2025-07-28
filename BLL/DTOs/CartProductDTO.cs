using System;

namespace _3S_eShop.BLL.DTOs
{
    public class CartProductDTO : BaseDTO<CartProductDTO>
    {
        private long userId;
        private long productId;
        private long variantId;
        private byte quantity;

        public CartProductDTO(long userId, long productId, long variantId, byte quantity)
        {
            this.UserId = userId;
            this.ProductId = productId;
            this.VariantId = variantId;
            this.Quantity = quantity;
        }

        public string TableName => "Cart_Products";

        public long UserId { get => userId; set => userId = value; }
        public long ProductId { get => productId; set => productId = value; }
        public long VariantId { get => variantId; set => variantId = value; }
        public byte Quantity { get => quantity; set => quantity = value; }

        public bool Equals(CartProductDTO obj)
        {
            return this.UserId == obj.UserId && this.ProductId == obj.ProductId && this.VariantId == obj.VariantId;
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.UserId, this.ProductId, this.VariantId, this.Quantity };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.Quantity, this.UserId, this.ProductId, this.VariantId };
        }

        /// <summary>
        /// Tạo danh sách định danh cho đối tượng
        /// </summary>
        /// <returns>Danh sách định danh</returns>
        public long[] GenIdentity()
        {
            return new long[] { this.UserId, this.ProductId, this.VariantId };
        }

        /// <summary>
        /// Tạo danh sách định danh cho đối tượng
        /// </summary>
        /// <returns>Danh sách định danh dưới dạng mảng object</returns>
        public object[] GenIdentityObject()
        {
            return new object[] { this.UserId, this.ProductId, this.VariantId };
        }

        /// <summary>
        /// Tạo chuỗi định danh cho khách vãn lai
        /// </summary>
        /// <returns>Chuỗi định danh</returns>
        public string GenIdentityForGuest()
        {
            return $"{this.ProductId}_{this.VariantId}";
        }

        public void SetIdentity(long[] id)
        {
            this.UserId = Convert.ToInt64(id[0]);
            this.ProductId = Convert.ToInt64(id[1]);
            this.VariantId = Convert.ToInt64(id[2]);
        }

        public void SetIdentityForGuest(string id)
        {
            var ids = id.Split('_');
            this.ProductId = Convert.ToInt64(ids[0]);
            this.VariantId = Convert.ToInt64(ids[1]);
        }
    }
}
