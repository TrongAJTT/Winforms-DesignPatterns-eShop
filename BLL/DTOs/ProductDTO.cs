using Newtonsoft.Json;
using System;

namespace _3S_eShop.BLL.DTOs
{
    public class ProductDTO : BaseDTO<ProductDTO>
    {
        public static int WARRANTY_LIFT_TIME = 255;
        public static String STATUS_IN_STOCK = "in_stock", 
            STATUS_SOLD_OUT = "sold_out", 
            STATUS_STOP_SELLING = "stop_selling";

        private long id;
        private long categoryId;
        private long brandId;
        private string name;
        private string description;
        // SortedList<String, String> -> JsonConvert.SerializeObject()
        private string specification;
        private string thumb;
        private string[] images;
        private string status;
        private byte warranty;
        private byte hide;
        private DateTime createdAt;

        public ProductDTO
        (
            long id, 
            long categoryId, 
            long brandId, 
            string name, 
            string description, 
            string specification, 
            string thumb, 
            string[] images,
            string status, 
            byte warranty, 
            byte hide, 
            DateTime createdAt
        )
        {
            this.Id = id;
            this.CategoryId = categoryId;
            this.BrandId = brandId;
            this.Name = name;
            this.Description = description;
            this.Specification = specification;
            this.Thumb = thumb;
            this.Images = images;
            this.Status = status;
            this.Warranty = warranty;
            this.Hide = hide;
            this.CreatedAt = createdAt;
        }

        public string TableName => "Products";

        public long Id { get => id; set => id = value; }
        public long CategoryId { get => categoryId; set => categoryId = value; }
        public long BrandId { get => brandId; set => brandId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Specification { get => specification; set => specification = value; }
        public string Thumb { get => thumb; set => thumb = value; }
        public string Status { get => status; set => status = value; }
        public byte Warranty { get => warranty; set => warranty = value; }
        public byte Hide { get => hide; set => hide = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public string[] Images { get => images; set => images = value; }

        public bool Equals(ProductDTO obj)
        {
            return this.Id == obj.Id || (this.Name.Equals(obj.Name) && this.CategoryId == obj.CategoryId && this.BrandId == obj.BrandId);
        }

        public object[] GenSaveObject()
        {
            return new object[] {this.CategoryId, this.BrandId, this.Name, this.Description, this.Specification, this.Thumb, JsonConvert.SerializeObject(Images), this.Status, this.Warranty, this.Hide, this.CreatedAt };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.CategoryId, this.BrandId, this.Name, this.Description, this.Specification, this.Thumb, JsonConvert.SerializeObject(Images), this.Status, this.Warranty, this.Hide, this.CreatedAt, this.Id };
        }
    }
}
