using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class BrandBuilder {
        private long id;
        private long categoryId;
        private string name;
        private string description;
        private string image130;
        private string image40;

        public BrandBuilder SetCategoryId(long categoryId)
        {
            this.categoryId = categoryId;
            return this;
        }

        public BrandBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public BrandBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public BrandBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public BrandBuilder SetImage130(string image130)
        {
            this.image130 = image130;
            return this;
        }

        public BrandBuilder SetImage40(string image40)
        {
            this.image40 = image40;
            return this;
        }

        public BrandDTO Build()
        {
            return new BrandDTO(this.id, this.categoryId, this.name, this.description, this.image130, this.image40);
        }

        public BrandBuilder Default()
        {
            this.id = -1;
            this.categoryId = -1;
            this.name = "";
            this.description = "";
            return this;
        }

        public BrandDTO FromDataRow(DataRow row)
        {
            return new BrandBuilder()
                .SetId(Convert.ToInt64(row[0]))
                .SetCategoryId(Convert.ToInt64(row[1]))
                .SetName(row[2].ToString())
                .SetDescription(row[3]?.ToString())
                .SetImage130(row[4]?.ToString())
                .SetImage40(row[5]?.ToString())
                .Build();
        }

        public List<BrandDTO> FromDataTable(DataTable dt)
        {
            List<BrandDTO> brands = new List<BrandDTO>();
            foreach (DataRow row in dt.Rows)
            {
                brands.Add(FromDataRow(row));
            }
            return brands;
        }
    }
}
