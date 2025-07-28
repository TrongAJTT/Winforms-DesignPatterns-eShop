namespace _3S_eShop.BLL.DTOs
{
    public class CategoryDTO : BaseDTO<CategoryDTO>
    {
        private long id;
        private string name;
        private string description;
        private string image130;
        private string image40;

        public CategoryDTO(long id, string name, string description, string image130, string image40)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Image130 = image130;
            this.Image40 = image40;
        }

        public CategoryDTO(long id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Image130 = image130;
            this.Image40 = image40;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Image130 { get => image130; set => image130 = value; }
        public string Image40 { get => image40; set => image40 = value; }
        public string TableName => "Categories";

        public bool Equals(CategoryDTO obj)
        {
            return this.Id == obj.Id || this.name.Equals(obj.name);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.Name, this.Description, this.Image130, this.image40 };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.Name, this.Description, this.Image130, this.Image40 };
        }
    }
}
