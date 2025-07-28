using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserOrderProductControl : UserControl
    {
        private OrderProductDTO orderProd;

        private static string status_prefix = "      ";

        public UserOrderProductControl()
        {
            InitializeComponent();
        }

        public UserOrderProductControl(OrderProductDTO orderProd)
        {
            InitializeComponent();
            this.orderProd = orderProd;
            LoadData();
        }

        private void LoadData()
        {
            var productDao = new ProductDAO();
            var variantDao = new ProductVariantDAO();

            picProduct.Image = Properties.Resources.ic_loading_gif;
            lblProductName.Text = "Đang tải tên sản phẩm...";
            lblVariantLabel.Text = "Đang tải nhãn biến thể...";

            // Cập nhật giá
            SetPrice(orderProd.OriginalPrice, orderProd.FinalPrice);
            // Cập nhật tổng giá
            lblPrice.Text = $"{status_prefix}{StringUtil.FormatCurrency(Convert.ToString(orderProd.FinalPrice * orderProd.Quantity))} đ";
            // Cập nhật số lượng sản phẩm
            lblVariantQuantity.SafeInvoke(() => lblVariantQuantity.Text = $"x{orderProd.Quantity}");

            Task.Run(() =>
            {
                // Lấy thông tin sản phẩm đầu tiên.
                var product = productDao.GetById(orderProd.ProductId);
                var variant = variantDao.GetById(orderProd.VariantId);
                // Cập nhật lên màn hình
                picProduct.SafeInvoke(async () => picProduct.Image = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(product.Thumb)));
                lblProductName.SafeInvoke(() => lblProductName.Text = product.Name);
                lblVariantLabel.SafeInvoke(() => lblVariantLabel.Text = variant.Label);
            });
        }

        private void SetPrice(uint basePrice, uint discountPrice)
        {
            // Determine which is original and which is current selling price
            if (discountPrice < basePrice && discountPrice > 0)
            {
                lblVariantPrice.SafeInvoke(() => lblVariantPrice.Text = $"{StringUtil.FormatCurrency(discountPrice.ToString())} đ");
                lblVariantOrigionalPrice.SafeInvoke(() => lblVariantOrigionalPrice.Text = $"{StringUtil.FormatCurrency(basePrice.ToString())} đ");
            }
            else
            {
                lblVariantPrice.SafeInvoke(() => lblVariantPrice.Text = $"{StringUtil.FormatCurrency(basePrice.ToString())} đ");
                lblVariantOrigionalPrice.SafeInvoke(() => lblVariantOrigionalPrice.Text = "");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            MySystem.ViewProduct(orderProd.ProductId, orderProd.VariantId);
        }

    }
}
