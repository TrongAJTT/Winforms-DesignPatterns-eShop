using _3S_eShop.DAL.DAOs;
using System.Collections.Generic;

namespace _3S_eShop.BLL.DTOs
{
    internal class BrandBLL
    {
        private BrandDAO brandDAO;
        public BrandBLL(BrandDAO brandDAO)
        {
            this.brandDAO = brandDAO;
        }

        internal List<BrandDTO> GetBrandsByCategoryId(long id)
        {
            return brandDAO.FindByCategory(id);
        }
    }
}
