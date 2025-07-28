using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace _3S_eShop.BLL
{
    internal class CartProductBLL
    {
        private CartProductDAO dao;

        public CartProductBLL(CartProductDAO cartProductDAO)
        {
            this.dao = cartProductDAO;
        }

        public void AddToCart(long userId, long productId, long variantId, byte quantity = 1)
        {
            var cartProduct = new CartProductDTO(userId, productId, variantId, quantity);
            // Kiểm tra xem có sản phẩm trong giỏ hàng chưa
            var isExist = dao.GetById(cartProduct.GenIdentity());
            // Nếu có rồi thì cập nhật số lượng lên 1
            if (isExist != null)
            {
                // Không cho phép thêm quá 99 sản phẩm
                if (isExist.Quantity < 99)
                {
                    isExist.Quantity++;
                    dao.Update(cartProduct.GenIdentity(), isExist);
                }
            }
            // Nếu chưa có thì mới thêm
            else
            {
                dao.Add(cartProduct);
            }
        }

        public static void AddToCart(long productId, long variantId)
        {
            Dictionary<string, byte> list = JsonConvert.DeserializeObject<Dictionary<string, byte>>(
                    File.ReadAllText(".cart"));
            if (list == null)
            {
                list = new Dictionary<string, byte>();
            }
            var cartProduct = new CartProductDTO(-1, productId, variantId, 1);
            if (list.ContainsKey(cartProduct.GenIdentityForGuest()))
            {
                // Không cho phép thêm quá 99 sản phẩm
                if (list[cartProduct.GenIdentityForGuest()] < 99)
                {
                    list[cartProduct.GenIdentityForGuest()]++;
                    File.WriteAllText(".cart", JsonConvert.SerializeObject(list));
                }
            }
            else
            {
                // Thêm sản phẩm mới vào giỏ hàng
                list.Add(cartProduct.GenIdentityForGuest(), 1);
                File.WriteAllText(".cart", JsonConvert.SerializeObject(list));
            }
        }

        public List<CartProductDTO> GetCartProductsByUserId(long userId)
        {
            return dao.FindMatch("user_id", userId.ToString());
        }

        public static List<CartProductDTO> GetCartProducts()
        {
            Dictionary<string, byte> list = JsonConvert.DeserializeObject<Dictionary<string, byte>>(
                    File.ReadAllText(".cart"));
            if (list == null)
            {
                list = new Dictionary<string, byte>();
            }
            List<CartProductDTO> cartProducts = new List<CartProductDTO>();
            foreach (var item in list)
            {
                var cartProductDto = new CartProductDTO(-1, -1, -1, item.Value);
                cartProductDto.SetIdentityForGuest(item.Key);
                cartProducts.Add(cartProductDto);
            }
            return cartProducts;
        }

        public void ChangeQuantity(long userId, long productId, long variantId, byte quantity)
        {
            var cartProduct = new CartProductDTO(userId, productId, variantId, quantity);
            dao.Update(cartProduct.GenIdentity(), cartProduct);
        }

        public static void ChangeQuantity(long productId, long variantId, byte quantity)
        {
            Dictionary<string, byte> list = JsonConvert.DeserializeObject<Dictionary<string, byte>>(
                    File.ReadAllText(".cart"));
            if (list == null)
            {
                list = new Dictionary<string, byte>();
            }
            var cartProduct = new CartProductDTO(-1, productId, variantId, quantity);
            if (list.ContainsKey(cartProduct.GenIdentityForGuest()))
            {
                list[cartProduct.GenIdentityForGuest()] = quantity;
                File.WriteAllText(".cart", JsonConvert.SerializeObject(list));
            }
        }

        public void RemoveFromCart(long userId, long productId, long variantId)
        {
            var cartProduct = new CartProductDTO(userId, productId, variantId, 0);
            dao.Delete(cartProduct);
        }

        public static void RemoveFromCart(long productId, long variantId)
        {
            Dictionary<string, byte> list = JsonConvert.DeserializeObject<Dictionary<string, byte>>(
                    File.ReadAllText(".cart"));
            if (list == null)
            {
                list = new Dictionary<string, byte>();
            }
            var cartProduct = new CartProductDTO(-1, productId, variantId, 0);
            if (list.ContainsKey(cartProduct.GenIdentityForGuest()))
            {
                list.Remove(cartProduct.GenIdentityForGuest());
                File.WriteAllText(".cart", JsonConvert.SerializeObject(list));
            }
        }
    }
}
