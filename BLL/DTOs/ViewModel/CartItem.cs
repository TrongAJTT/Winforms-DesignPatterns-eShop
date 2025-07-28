using _3S_eShop.DAL.DAOs;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs.ViewModel
{
    public class CartItem
    {
        public ProductVariantDTO Variant { get; set; }
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(ProductVariantDTO productVariant, int quantity)
        {
            Variant = productVariant;
            Quantity = quantity;
            Task.Run(() =>
            {
                Product = new ProductDAO().GetById(productVariant.ProductId);
            });
        }
    }
}
