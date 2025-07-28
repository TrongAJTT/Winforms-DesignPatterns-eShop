using _3S_eShop.DAL.DAOs;
using System;

namespace _3S_eShop.BLL
{
    internal class ProductBLL
    {
        private ProductDAO productDAO;

        public ProductBLL(ProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }

        public long GetProductOnSellCount()
        {
            return productDAO.GetProductCountBaseOnStatus("in_stock");
        }

        public long GetProductOutOfStockCount()
        {
            return productDAO.GetProductCountBaseOnStatus("sold_out");
        }

        public long GetProductDiscontinuedCount()
        {
            return productDAO.GetProductCountBaseOnStatus("stop_selling");
        }

        public string GetNameOfProduct(long id)
        {
            var product = productDAO.GetById(id);
            if (product == null) return "";
            return product.Name;
        }

    }
}
