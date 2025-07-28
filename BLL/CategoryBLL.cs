using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using System.Collections.Generic;

namespace _3S_eShop.BLL
{
    internal class CategoryBLL
    {
        private CategoryDAO cateDAO;

        public CategoryBLL(CategoryDAO cateDAO)
        {
            this.cateDAO = cateDAO;
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return cateDAO.GetAll();
        }
    }
}
