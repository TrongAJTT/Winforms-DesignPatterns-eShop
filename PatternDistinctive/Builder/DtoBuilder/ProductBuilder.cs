using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using _3S_eShop.BLL.DTOs;
using Newtonsoft.Json;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class ProductBuilder
    {
        private long id;
        private long categoryId;
        private long brandId;
        private string name;
        private string description;
        private string specification;
        private string thumb;
        private string[] images;
        private string status;
        private byte warranty;
        private byte hide;
        private DateTime createdAt;

        public ProductBuilder SetBrandId(long brandId)
        {
            this.brandId = brandId;
            return this;
        }

        public ProductBuilder SetCategoryId(long categoryId)
        {
            this.categoryId = categoryId;
            return this;
        }

        public ProductBuilder SetCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public ProductBuilder SetHide(byte hide)
        {
            this.hide = hide;
            return this;
        }

        public ProductBuilder SetImages(string[] images)
        {
            this.images = images;
            return this;
        }

        public ProductBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public ProductBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ProductBuilder SetSpecification(string specification)
        {
            this.specification = specification;
            return this;
        }

        public ProductBuilder SetStatus(string status)
        {
            this.status = status;
            return this;
        }

        public ProductBuilder SetThumb(string thumb)
        {
            this.thumb = thumb;
            return this;
        }

        public ProductBuilder SetWarranty(byte warranty)
        {
            this.warranty = warranty;
            return this;
        }

        public ProductDTO Build()
        {
            return new ProductDTO(id, categoryId, brandId, name, description, specification, thumb, images, status, warranty, hide, createdAt);
        }

        public ProductBuilder Default()
        {
            return new ProductBuilder()
            {
                id = -1,
                categoryId = -1,
                brandId = -1,
                name = "",
                description = "",
                specification = "",
                thumb = "",
                status = ProductDTO.STATUS_IN_STOCK,
                warranty = 0,
                hide = 0,
                createdAt = DateTime.Now
            };
        }

        public ProductDTO FromDataRow(DataRow row)
        {
            return new ProductBuilder()
                .SetId(Convert.ToInt64(row[0]))
                .SetCategoryId(Convert.ToInt64(row[1]))
                .SetBrandId(Convert.ToInt64(row[2]))
                .SetName(row[3].ToString())
                .SetDescription(row[4].ToString())
                .SetSpecification(row[5].ToString())
                .SetThumb(row[6].ToString())
                .SetImages(JsonConvert.DeserializeObject<string[]>(row[7].ToString()))
                .SetStatus(row[8].ToString())
                .SetWarranty(Convert.ToByte(row[9]))
                .SetHide(Convert.ToByte(row[10]))
                .SetCreatedAt(Convert.ToDateTime(row[11]))
                .Build();
        }

        public List<ProductDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(row => FromDataRow(row)).ToList();
        }
    }
}
