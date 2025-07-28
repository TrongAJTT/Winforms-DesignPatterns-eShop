using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.BLL;
using _3S_eShop.Utilities;
using System;
using _3S_eShop.GUI.MainControls;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class OrderDetailControl: UserControl
    {
        private long orderId;
        private static string prefix = "      ";

        public OrderDetailControl()
        {
            InitializeComponent();
        }

        public OrderDetailControl(long orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadOrderLog();
            LoadProductList();
            LoadOrderInfoAndActionButton();
        }

        private void LoadOrderLog()
        {
            Task.Run(() =>
            {
                var orderLogBll = new OrderLogBLL(new OrderLogDAO());
                var listLog = orderLogBll.GetListStatusOfOrder(orderId);
                foreach (var item in listLog)
                {
                    flowHistory.SafeInvoke(() =>
                    {
                        var logControl = new OrderLogControl(item);
                        flowHistory.Controls.Add(logControl);
                    });
                }
            });
        }

        private void LoadProductList()
        {
            Task.Run(() =>
            {
                var orderProductBll = new OrderProductBLL(new OrderProductDAO());
                var orderProds = orderProductBll.GetListByOrderId(orderId);
                foreach (var item in orderProds)
                {
                    flowProductList.SafeInvoke(() =>
                    {
                        var productControl = new UserOrderProductControl(item);
                        flowProductList.Controls.Add(productControl);
                    });
                }
            });
        }

        private void LoadOrderInfoAndActionButton()
        {
            Task.Run(() =>
            {
                var orderDao = new OrderDAO();
                var order = orderDao.GetById(orderId);
                var userDao = new UserDAO();
                var user = userDao.GetById(order.UserId);
                // Cập nhật thông tin đơn hàng lên giao diện
                lblOrderId.SafeInvokeSetText($"Đơn hàng #{order.Id}");
                lblOrderDate.SafeInvokeSetText($"{prefix}Thời gian đặt đơn: {order.CreatedAt.ToString("dd/MM/yyyy HH:mm")}");
                lblOrderAccount.SafeInvokeSetText($"{prefix}Tài khoản đặt: [{user.Id}] {user.Username}");
                lblTotalPrice.SafeInvokeSetText($"{prefix}Tổng giá: {StringUtil.FormatCurrency(order.TotalPrice.ToString())} đ");
                // Cập nhật thông tin địa chỉ giao hàng
                lblOrderAddressRecipient.SafeInvokeSetText($"{prefix}Người nhận: {order.RecipientName}");
                lblOrderAddressPhone.SafeInvokeSetText($"{prefix}Số điện thoại: {order.RecipientPhone}");
                lblOrderAddressAdmin.SafeInvokeSetText($"{prefix}Khu vực: {order.AdministrativeArea}");
                lblOrderAddressStreet.SafeInvokeSetText($"{prefix}Địa chỉ: {order.StreetAddress}");
                // Là người dùng thì mới hiện phần đánh giá, mua hàng
                if (!MainForm.Role.IsAdmin())
                {
                    pnlAction.SafeInvoke(() => pnlAction.Visible = true);
                    // Đơn đã hoàn thành thì mới hiện nút đánh giá
                    if (order.Status == "completed")
                    {
                        // Không cho phép rating sản phẩm nếu đơn hàng đã hoàn thành quá 21 ngày
                        var orderLogBll = new OrderLogBLL(new OrderLogDAO());
                        var completeDate = orderLogBll.GetDateCompletedOfOrder(orderId);
                        if (completeDate.AddDays(21) <= DateTime.Now)
                        {
                            btnRating.SafeInvokeEnable(false);
                        }
                        // Hiện nút đánh giá và thông báo đánh giá
                        btnRating.SafeInvokeSetVisible(true);
                        lblRatingNote.SafeInvokeSetVisible(true);
                    }
                }

                EmbedControl.RemoveLoadingForThisControl(this);
            });
        }

        private void OrderDetailControl_Resize(object sender, System.EventArgs e)
        {
            var maxSize = flowSubContainer.MaximumSize;
            maxSize.Width = this.Width + 20;
            flowSubContainer.MaximumSize = maxSize;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControl(new UserReviewManagerControl(orderId), "Đánh giá sản phẩm");
        }
    }
}
