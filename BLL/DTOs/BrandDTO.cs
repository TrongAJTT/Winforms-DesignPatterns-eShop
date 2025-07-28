namespace _3S_eShop.BLL.DTOs
{
    public class BrandDTO: BaseDTO<BrandDTO>
    {
        private long id;
        private long categoryId;
        private string name;
        private string description;
        private string image130;
        private string image40;

        public BrandDTO(long id, long categoryId, string name, string description, string image130, string image40)
        {
            this.Id = id;
            this.CategoryId = categoryId;
            this.Name = name;
            this.Description = description;
            this.Image130 = image130;
            this.Image40 = image40;

        }

        public string TableName => "Brands";

        public long Id { get => id; set => id = value; }
        public long CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Image130 { get => image130; set => image130 = value; }
        public string Image40 { get => image40; set => image40 = value; }



        public bool Equals(BrandDTO obj)
        {
            return (this.Id == obj.Id) || (this.Name.Equals(obj.Name) && this.categoryId == obj.categoryId);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.categoryId, this.name, this.description, this.Image130, this.Image40 };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.categoryId, this.name, this.description, this.Image130, this.Image40, this.Id };
        }
    }
}
