using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.CustomComponents;
using _3S_eShop.CustomControls;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.GUI.MainControls.Auth;
using _3S_eShop.GUI.Test;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace _3S_eShop.Utilities
{
    internal static class MySystem
    {
        public static String DB_TYPE_SQLSERVER = "sqlserver";
        public static String DB_TYPE_MYSQL = "mysql";
        private static MainForm mainForm;

        /// <summary>
        /// Thiết lập form chính cho hệ thống
        /// </summary>
        /// <param name="form">Đối tượng MainForm</param>
        public static void SetMainForm(MainForm form)
        {
            mainForm = form;
        }

        /// <summary>
        /// Thiết lập trạng thái hiển thị của form chính
        /// </summary>
        /// <param name="visible">true là hiện, false là ẩn</param>
        public static void SetMainFormVisible(bool visible)
        {
            if (visible)
            {
                mainForm.Show();
            }
            else
            {
                mainForm.Hide();
            }
        }

        /// <summary>
        /// Thoát ứng dụng
        /// </summary>
        public static void Terminate()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Khởi động lại ứng dụng
        /// </summary>
        public static void Restart()
        {
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(exePath);
            Environment.Exit(0);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của một AdvancedTextBox theo mẫu đã định nghĩa
        /// </summary>
        /// <param name="textBox">TextBox cần kiểm tra hợp lệ, cần phải thiết lập Validator trước đó.</param>
        /// <param name="errLabel">Label chứa thông báo lỗi cần hiển thị tương ứng.</param>
        /// <param name="param">Các tham số khác.</param>
        /// <returns></returns>
        public static bool ValidateTemplate(AdvancedTextBox textBox, Label errLabel, params string[] param)
        {
            bool valid = textBox.IsValid(param);
            DisplayError(errLabel, textBox.GetInvalidMessage(), valid);
            return valid;
        }

        /// <summary>
        /// Hiển thị thông báo lỗi cho một Label
        /// </summary>
        /// <param name="errLabel">Label cần thông báo lỗi.</param>
        /// <param name="errorMessage">Thông báo lỗi tương ứng.</param>
        /// <param name="isValid">true là vượt qua, không hiện. False là thất bại, hiện.</param>
        public static void DisplayError(Label errLabel, string errorMessage, bool isValid)
        {
            if (isValid)
            {
                errLabel.Visible = false;
            }
            else
            {
                errLabel.Text = errorMessage;
                errLabel.Visible = true;
            }
        }

        /// <summary>
        /// Thực hiện hành động xem thông tin sản phẩm
        /// </summary>
        /// <param name="id">id của sản phẩm cần xem</param>
        public static void ViewProduct(long id, long variantId)
        {
            // Tạo một control mới để xem sản phẩm
            SetChildControl(new ProductViewerControl(id), "Xem sản phẩm");
            // Thêm vào danh sách sản phẩm đã xem gần đây
            if (variantId != -1)
            {
                UpdateRecentlyViewedProducts(variantId);
            }
        }

        private static EmbedControl GetTemplateChildControl(Control control, string title)
        {
            EmbedControl embedControl = new EmbedControl(
                control,
                EmbedControl.GetParentParam(mainForm.GetPage()),
                mainForm.GetPage());
            embedControl.Title.Text = title;
            return embedControl;
        }

        /// <summary>
        /// Thiết lập một control con cho một control hiện tại của MainForm
        /// </summary>
        /// <param name="control">Control con.</param>
        /// <param name="title">Tiêu đề của control nhúng.</param>
        public static void SetChildControl(Control control, string title)
        {
            EmbedControl embedControl = GetTemplateChildControl(control, title);
            if (control is ILazyLoad)
            {
                ((ILazyLoad)control).Load();
            }
            embedControl.Start();
        }

        /// <summary>
        /// Thiết lập một control con cho một control hiện tại của MainForm với thông báo đang tải
        /// </summary>
        /// <param name="control">Control con.</param>
        /// <param name="title">Tiêu đề của control nhúng.</param>
        /// <param name="loadingMessage">Tin nhắn đang tải.</param>
        /// <param name="second">Số giây hiện (<0 là hiện vĩnh viễn đến khi có hàm gọi tắt đi)</param>
        public static void SetChildControlWithLoading(Control control, string title, string loadingMessage, int second = -1)
        {
            EmbedControl embedControl = GetTemplateChildControl(control, title);
            embedControl.SetLoading(loadingMessage, second);
            embedControl.Start();
        }

        /// <summary>
        /// Thực hiện hành động cập nhật sản phẩm đã xem gần đây
        /// </summary>
        /// <param name="productVariantId">Id của biến thể sản phẩm vừa xem</param>
        public static void UpdateRecentlyViewedProducts(long productVariantId)
        {
            List<long> recentlyViewedProducts = JsonConvert.DeserializeObject<List<long>>(
                File.ReadAllText(".recent"));
            if (recentlyViewedProducts == null)
            {
                recentlyViewedProducts = new List<long>();
            }
            if (recentlyViewedProducts.Contains(productVariantId))
            {
                recentlyViewedProducts.Remove(productVariantId);
            }
            recentlyViewedProducts.Insert(0, productVariantId);
            if (recentlyViewedProducts.Count > 20)
            {
                recentlyViewedProducts.RemoveAt(20);
            }
            File.WriteAllText(".recent", JsonConvert.SerializeObject(recentlyViewedProducts));
        }

        /// <summary>
        /// Lấy số lượng sản phẩm đã xem gần đây
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static int GetRecentlyViewedProductsCount()
        {
            List<long> recentlyViewedProducts = JsonConvert.DeserializeObject<List<long>>(
                File.ReadAllText(".recent"));
            return recentlyViewedProducts?.Count ?? 0;
        }

        /// <summary>
        /// Xóa danh sách sản phẩm đã xem gần đây
        /// </summary>
        public static void ClearRecentlyViewedProducts()
        {
            File.WriteAllText(".recent", "[]");
        }

        /// <summary>
        /// Thực hiện hành động xem thông tin danh mục
        /// </summary>
        /// <param name="id">Id của danh mục cần xem</param>
        public static void ViewCategory(long id)
        {
            BrowseControl browse = new BrowseControl(id);
            (browse as ILazyLoad).Load();
            SetChildControl(browse, "Xem danh mục");
        }

        /// <summary>
        /// Thực hiện hành động xem thông tin danh mục và thương hiệu
        /// </summary>
        /// <param name="categoryId">Id của danh mục cần xem (cần khớp với brand).</param>
        /// <param name="brandId">Id của thương hiệu cần xem.</param>
        public static void ViewCategoryAndBrand(long categoryId, long brandId)
        {
            BrowseControl browse = new BrowseControl(categoryId, brandId);
            (browse as ILazyLoad).Load();
            SetChildControl(browse, "Xem danh mục");
        }

        /// <summary>
        /// Cập nhật điểm thưởng cho người dùng
        /// </summary>
        public static void UpdateRewardPoint()
        {
            mainForm.UpdateRewardPoint();
        }

        /// <summary>
        /// Hiện thông báo Toast ở góc trên bên trái
        /// </summary>
        /// <param name="message">Nội dung thông báo</param>
        /// <param name="type">Loại thông báo</param>
        public static void ShowToastMessageAtTopRight(string message, ToastBox.enmType type = ToastBox.enmType.Success, int maxAlert = 1)
        {
            ToastBox toastBox = new ToastBox(maxAlert, ToastBox.Position.TopRight, 2000);
            toastBox.ShowToast(message, type);
        }

        /// <summary>
        /// Thực hiện hành động liên quan đến giỏ hàng
        /// </summary>
        public static class CartHelper
        {
            public static void Create(long productId, long productVariantId)
            {
                // Xử lý trường hợp khách hàng
                if (MainForm.User != null)
                {
                    var bll = new CartProductBLL(new CartProductDAO());
                    bll.AddToCart(MainForm.User.Id, productId, productVariantId);
                }
                // Xử lý trường hợp khách vãn lai
                else
                {
                    CartProductBLL.AddToCart(productId, productVariantId);
                }
            }

            public static List<CartProductDTO> Read()
            {
                if (MainForm.User != null)
                {
                    var bll = new CartProductBLL(new CartProductDAO());
                    return bll.GetCartProductsByUserId(MainForm.User.Id);
                }
                else
                {
                    return CartProductBLL.GetCartProducts();
                }
            }

            public static void Delete(long productId, long productVariantId)
            {
                if (MainForm.User != null)
                {
                    var bll = new CartProductBLL(new CartProductDAO());
                    bll.RemoveFromCart(MainForm.User.Id, productId, productVariantId);
                }
                else
                {
                    CartProductBLL.RemoveFromCart(productId, productVariantId);
                }
            }

            public static void Update(long productId, long productVariantId, byte quantity)
            {
                if (MainForm.User != null)
                {
                    var bll = new CartProductBLL(new CartProductDAO());
                    bll.ChangeQuantity(MainForm.User.Id, productId, productVariantId, quantity);
                }
                else
                {
                    CartProductBLL.ChangeQuantity(productId, productVariantId, quantity);
                }
            }
        }
    
        public static EmbedControl CreateOrder(
            List<CartItem> cartItems, 
            CouponDTO coupon = null, 
            bool useRewardPoint = false)
        {
            if (MainForm.User == null)
            {
                MessageBox.Show("Vui lòng đăng nhập để tạo đơn hàng!\nĐừng lo lắng, bạn có thể nhập lại giỏ hàng từ phiên đăng nhập trong mục thiết lập tài khoản sau khi đăng nhập/đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MySystem.SetChildControl(new LoginControl(), "Chức năng này yêu cầu tài khoản");
                return null;
            }
            else
            {
                OrderCreateControl control = new OrderCreateControl(cartItems, coupon, useRewardPoint);
                EmbedControl embedControl = new EmbedControl(control, EmbedControl.GetParentParam(mainForm.GetPage()), mainForm.GetPage());
                embedControl.SetConfirmBack("Bạn có chắc chắn muốn quay lại giỏ hàng không?\nTất cả những gì trên trang này sẽ bị mất!", "Xác nhận trở về");
                embedControl.Title.Text = "Tạo đơn hàng";
                embedControl.Start();
                return embedControl;
            }
        }
    }
}