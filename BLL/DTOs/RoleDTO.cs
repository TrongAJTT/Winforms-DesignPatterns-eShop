namespace _3S_eShop.BLL.DTOs
{
    public class RoleDTO : BaseDTO<RoleDTO>
    {
        private long id;
        private string roleName;
        private string description;

        public RoleDTO
        (
            long id, 
            string roleName, 
            string description
        )
        {
            this.Id = id;
            this.RoleName = roleName;
            this.Description = description;
        }

        public string TableName => "Roles";

        public long Id { get => id; set => id = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Description { get => description; set => description = value; }

        public bool Equals(RoleDTO obj)
        {
            return this.Id == obj.Id;
        }

        public object[] GenSaveObject()
        {
            return new object[] {this.RoleName, this.Description };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.RoleName, this.Description, this.Id };
        }

        public bool IsAdmin()
        {
            return this.Id == 1;
        }

    }
}
