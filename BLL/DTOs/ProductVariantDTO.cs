using System;

namespace _3S_eShop.BLL.DTOs
{
    [Serializable] 
    public class ProductVariantDTO : BaseDTO<ProductVariantDTO>
    {
        private long id;
        private long productId;
        private string label;
        private string description;
        private int price;
        private int discountPrice;
        private short stockQuantity;

        public ProductVariantDTO
        (
            long id, 
            long productId, 
            string label, 
            string description, 
            int price, 
            int discountPrice, 
            short stockQuantity
        )
        {
            this.Id = id;
            this.ProductId = productId;
            this.Label = label;
            this.Description = description;
            this.Price = price;
            this.DiscountPrice = discountPrice;
            this.StockQuantity = stockQuantity;
        }

        public long Id { get => id; set => id = value; }
        public long ProductId { get => productId; set => productId = value; }
        public string Label { get => label; set => label = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int DiscountPrice { get => discountPrice; set => discountPrice = value; }
        public short StockQuantity { get => stockQuantity; set => stockQuantity = value; }

        public string TableName => "Product_Variants";

        public bool Equals(ProductVariantDTO obj)
        {
            return (this.Id == obj.Id) || (this.Label.Equals(obj.Label) && this.ProductId == obj.ProductId);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.ProductId, this.Label, this.Description, this.Price, this.DiscountPrice, this.StockQuantity };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.ProductId, this.Label, this.Description, this.Price, this.DiscountPrice, this.StockQuantity, this.Id };
        }
    }
}
