using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.BLL
{
    internal class ProductVariantBLL
    {
        private ProductVariantDAO dao;

        public ProductVariantBLL(ProductVariantDAO productVariantDAO)
        {
            this.dao = productVariantDAO;
        }

        public ProductDTO GetBaseProductForBriefView(long id)
        {
            ProductVariantDTO productVariant = dao.GetById(id);
            ProductDTO product = new ProductDAO().GetById(productVariant.ProductId);
            product.Description = null;
            product.Images = null;
            return product;
        }

        public List<ProductVariantDTO> Get10LatestVariants()
        {
            string query = $"SELECT * FROM {dao.TableName} ORDER BY id DESC LIMIT 10;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new ProductVariantBuilder().FromDataTable(dt);
        }

        public List<ProductVariantDTO> Get10SimilarVariants(long brandId)
        {
            string query = new PagingJoinQueryBuilder("Product_Variants", "p.created_at", "id", true, "v")
                .AddJoin("INNER", "Products", "p", "p.id = v.product_id")
                .SetSelect("v.*")
                .AddSpecific("p.brand_id = @brandId")
                .SetPage(1).SetPageSize(10).Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, brandId);
            return new ProductVariantBuilder().FromDataTable(dt);
        }

        public List<ProductVariantDTO> Get10DiscountVariants()
        {
            string query = new PagingQueryBuilder("Product_Variants", "discount_amount")
                .SetSelect("*,(price - discount_price) as 'discount_amount'")
                .AddSpecific("discount_price < price")
                .SetPage(1).SetPageSize(10).Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new ProductVariantBuilder().FromDataTable(dt);
        }

    }
}
