using System;
using System.Text.Json.Serialization;

namespace _3S_eShop.BLL.DTOs.ViewModel
{
    [Serializable]
    public class BannerObject
    {
        private string id, imageId, productName;
        private long productId;
        private DateTime createdAt;

        public BannerObject(string id, string imageId, long productId, string productName)
        {
            this.Id = id;
            this.ImageId = imageId;
            this.ProductId = productId;
            this.ProductName = productName;
            this.createdAt = DateTime.Now;
        }

        public string Id { get => id; private set => id = value; }
        public string ImageId { get => imageId; set => imageId = value; }
        public long ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}
