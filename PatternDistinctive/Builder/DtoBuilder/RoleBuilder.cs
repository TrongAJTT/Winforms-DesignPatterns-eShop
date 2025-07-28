using _3S_eShop.BLL.DTOs;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class RoleBuilder
    {
        private long id;
        private string roleName;
        private string description;

        public RoleBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public RoleBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public RoleBuilder SetRoleName(string name)
        {
            this.roleName = name;
            return this;
        }

        public RoleDTO Build()
        {
            return new RoleDTO(id, roleName, description);
        }

        public RoleBuilder Default()
        {
            throw new System.NotImplementedException();
        }

        public RoleDTO FromDataRow(DataRow row)
        {
            return new RoleBuilder()
                .SetId((long)row["id"])
                .SetRoleName(row["role_name"].ToString())
                .SetDescription(row["description"].ToString())
                .Build();
        }

        public List<RoleDTO> FromDataTable(DataTable dt)
        {
            throw new System.NotImplementedException();
        }
    }
}
