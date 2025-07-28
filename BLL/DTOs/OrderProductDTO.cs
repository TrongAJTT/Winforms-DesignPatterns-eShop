namespace _3S_eShop.BLL.DTOs
{
    public class OrderProductDTO : BaseDTO<OrderProductDTO>
    {
        private long id;
        private long orderId;
        private long productId;
        private long variantId;
        private byte quantity;
        private uint originalPrice;
        private uint finalPrice;

        public OrderProductDTO(long id, long orderId, long productId, long variantId, byte quantity, uint originalPrice, uint finalPrice)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            VariantId = variantId;
            Quantity = quantity;
            OriginalPrice = originalPrice;
            FinalPrice = finalPrice;
        }

        public string TableName => "Order_Products";

        public long Id { get => id; set => id = value; }
        public long OrderId { get => orderId; set => orderId = value; }
        public long ProductId { get => productId; set => productId = value; }
        public byte Quantity { get => quantity; set => quantity = value; }
        public uint OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public uint FinalPrice { get => finalPrice; set => finalPrice = value; }
        public long VariantId { get => variantId; set => variantId = value; }

        public bool Equals(OrderProductDTO obj)
        {
            return Id == obj.Id;
        }

        public object[] GenSaveObject()
        {
            return new object[] {
                OrderId,
                ProductId,
                VariantId,
                Quantity,
                OriginalPrice,
                FinalPrice,
            };
        }

        public object[] GenUpdateObject()
        {
            return new object[] {
                OrderId,
                ProductId,
                VariantId,
                Quantity,
                OriginalPrice,
                FinalPrice,
                Id
            };
        }
    }

}
