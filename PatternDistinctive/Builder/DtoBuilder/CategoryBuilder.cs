using _3S_eShop.BLL.DTOs;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class CategoryBuilder 
    {
        private long id;
        private string name;
        private string description;
        private string image130;
        private string image40;

        public CategoryBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public CategoryBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public CategoryBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public CategoryDTO Build()
        {
            return new CategoryDTO(id, name, description, image130, image40);
        }

        public CategoryBuilder Default()
        {
            this.id = -1;
            this.name = "";
            this.description = "";
            return this;
        }

        public CategoryDTO FromDataRow(DataRow row)
        {
            return new CategoryDTO(
                (long)row["Id"], 
                row["Name"].ToString(), 
                row["Description"]?.ToString(),
                row["Image130"]?.ToString(),
                row["Image40"]?.ToString()
            );
        }

        public List<CategoryDTO> FromDataTable(DataTable dt)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            foreach (DataRow row in dt.Rows)
            {
                categories.Add(FromDataRow(row));
            }
            return categories;
        }

        public CategoryBuilder SetImage130(string image130)
        {
            this.image130 = image130;
            return this;
        }

        public CategoryBuilder SetImage40(string image40)
        {
            this.image40 = image40;
            return this;
        }
    }
}
