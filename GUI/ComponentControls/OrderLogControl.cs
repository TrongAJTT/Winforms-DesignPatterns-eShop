using _3S_eShop.BLL.DTOs;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class OrderLogControl: UserControl
    {
        private static string STATUS_PROCESSING = "Đơn hàng đã được đặt thành công và đang chờ xử lý.";
        private static string STATUS_SHIPPING = "Đơn hàng đã được giao cho đơn vị vận chuyển và đang trên đường đến tay bạn.";
        private static string STATUS_COMPLETED = "Đơn hàng đã được giao thành công.";
        private static string STATUS_CANCELED = "Đơn hàng đã bị hủy.";

        private OrderLogDTO orderLog;

        public OrderLogControl()
        {
            InitializeComponent();
        }

        public OrderLogControl(OrderLogDTO orderLog)
        {
            InitializeComponent();
            this.orderLog = orderLog;
            lblDate.Text = orderLog.CreatedAt.ToString("dd/MM/yyyy\nHH:mm");
            lblStatus.Text = 
                orderLog.Status == "processing" ? STATUS_PROCESSING + GetStatusDetail() :
                orderLog.Status == "shipping" ? STATUS_SHIPPING + GetStatusDetail() :
                orderLog.Status == "completed" ? STATUS_COMPLETED + GetStatusDetail() :
                STATUS_CANCELED + GetStatusDetail();
        }

        private string GetStatusDetail()
        {
            if (string.IsNullOrEmpty(orderLog.StatusDetail))
            {
                return string.Empty;
            }
            else
            {
                string detail = orderLog.Status == "cancelled" ? 
                    "\nLý do: " : "\nChi tiết: ";
                return detail + orderLog.StatusDetail;
            }
        }

    }
}
