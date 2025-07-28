using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;

namespace _3S_eShop.BLL
{
    internal class RoleBLL
    {
        private RoleDAO roleDAO;

        public RoleBLL(RoleDAO roleDAO)
        {
            this.roleDAO = roleDAO;
        }

        public RoleDTO GetRoleFromId(long roleId)
        {
            return roleDAO.GetById(roleId);
        }

    }
}
