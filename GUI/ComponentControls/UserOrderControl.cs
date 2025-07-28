using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;
using _3S_eShop.DAL.CloudStore;
using System;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserOrderControl: UserControl
    {
        private long orderId;
        private static string status_prefix = "      ";

        public UserOrderControl(long orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadData();
        }

        private void LoadData()
        {
            var orderDao = new OrderDAO();
            var orderProductBll = new OrderProductBLL(new OrderProductDAO());
            var productDao = new ProductDAO();
            var variantDao = new ProductVariantDAO();

            picFirstProduct.Image = Properties.Resources.ic_loading_gif;
            lblOrderStatus.Text = status_prefix + "Đang tải...";
            lblNameFirstProduct.Text = "Đang tải tên sản phẩm...";
            lblLabelFirstVariant.Text = "Đang tải nhãn biến thể...";
            lblTotalPrice.Text = status_prefix + "Đang tải...";
            lblOrigionalPriceFirstVariant.Text = "Đang tải...";
            lblDateOrder.Text = status_prefix + "Đang tải...";
            lblPriceFirstVariant.Text = "Đang tải...";
            lblQuantityFirstVariant.Text = "...";
            lblNumberOtherProduct.Text = "Đang tải số lượng sản phẩm...";

            Task.Run(() =>
            {
                // Lấy thông tin đơn hàng
                var order = orderDao.GetById(orderId);
                // Cập nhật thông tin đơn hàng lên giao diện
                lblOrderStatus.SafeInvoke(() => lblOrderStatus.Text =
                    order.Status == "processing" ? status_prefix + "Đang chờ" :
                    order.Status == "shipping" ? status_prefix + "Đang giao" :
                    order.Status == "completed" ? status_prefix + "Đã giao" :
                        status_prefix + "Bị hủy");
                lblTotalPrice.SafeInvoke(() => lblTotalPrice.Text = $"{status_prefix}{StringUtil.FormatCurrency(order.TotalPrice.ToString())} đ");
                lblDateOrder.SafeInvoke(() => lblDateOrder.Text = $"{status_prefix}{order.CreatedAt.ToString("dd/MM/yyyy HH:mm")}");
                // Nếu đơn hoàn thành thì mới hiện nút đánh giá
                if (order.Status == "completed")
                {
                    // Không cho phép rating sản phẩm nếu đơn hàng đã hoàn thành quá 21 ngày
                    var orderLogBll = new OrderLogBLL(new OrderLogDAO());
                    var completeDate = orderLogBll.GetDateCompletedOfOrder(orderId);
                    if (completeDate.AddDays(21) <= DateTime.Now)
                    {
                        btnRating.SafeInvokeEnable(false);
                    }
                    // Hiện nút đánh giá
                    btnRating.SafeInvokeSetVisible(true);
                }
                // Lấy danh sách sản phẩm trong đơn hàng
                var lstOrdProd = orderProductBll.GetListByOrderId(orderId);
                // Cập nhật số lượng sản phẩm khác lên giao diện
                if (lstOrdProd.Count > 1)
                {
                    lblNumberOtherProduct.SafeInvoke(() => lblNumberOtherProduct.Text = $"và {lstOrdProd.Count - 1} sản phẩm khác");
                }
                else
                {
                    lblNumberOtherProduct.SafeInvoke(() => lblNumberOtherProduct.Text = string.Empty);
                }
                // Lấy thông tin sản phẩm đầu tiên.
                var firstProduct = lstOrdProd[0];
                var product = productDao.GetById(firstProduct.ProductId);
                var variant = variantDao.GetById(firstProduct.VariantId);
                // Cập nhật lên màn hình
                picFirstProduct.SafeInvoke(async () => picFirstProduct.Image = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(product.Thumb)));
                lblNameFirstProduct.SafeInvoke(() => lblNameFirstProduct.Text = product.Name);
                lblLabelFirstVariant.SafeInvoke(() => lblLabelFirstVariant.Text = variant.Label);
                lblQuantityFirstVariant.SafeInvoke(() => lblQuantityFirstVariant.Text = $"x{firstProduct.Quantity}");
                SetPrice(firstProduct.OriginalPrice, firstProduct.FinalPrice);
            });
        }

        private void SetPrice(uint basePrice, uint discountPrice)
        {
            // Determine which is original and which is current selling price
            if (discountPrice < basePrice && discountPrice > 0)
            {
                lblPriceFirstVariant.SafeInvoke(() => lblPriceFirstVariant.Text = $"{StringUtil.FormatCurrency(discountPrice.ToString())} đ");
                lblOrigionalPriceFirstVariant.SafeInvoke(() => lblOrigionalPriceFirstVariant.Text = $"{StringUtil.FormatCurrency(basePrice.ToString())} đ");
            }
            else
            {
                lblPriceFirstVariant.SafeInvoke(() => lblPriceFirstVariant.Text = $"{StringUtil.FormatCurrency(basePrice.ToString())} đ");
                lblOrigionalPriceFirstVariant.SafeInvoke(() => lblOrigionalPriceFirstVariant.Text = "");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControlWithLoading(
                new OrderDetailControl(orderId), 
                "Chi tiết đơn hàng",
                "Đang tải thông tin");
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControl(new UserReviewManagerControl(orderId), "Đánh giá sản phẩm");
        }
    }
}
