using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.Utilities;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserOrderHistory: UserControl
    {
        private string status = "%%";
        private PictureBox picOverlay;

        public UserOrderHistory()
        {
            InitializeComponent();
            InitializeEvent();
            UpdateOrdersSearch();
        }

        private void InitializePictureOverlay()
        {
            picOverlay = new PictureBox();
            picOverlay.Image = Properties.Resources.ic_loading_gif;
            picOverlay.SizeMode = PictureBoxSizeMode.Zoom;
            picOverlay.Size = new Size(flowOrders.Width, 300);
            picOverlay.Visible = true;
            flowOrders.Controls.Add(picOverlay);
        }

        private void InitializeEvent()
        {
            paginationSelector.OnPageChanged += (s, e) => SearchForOrder();
            paginationSelector.OnPageSizeChanged += (s, e) => UpdateOrdersSearch();
        }

        // Tạo câu truy vấn tìm kiếm theo bộ lọc
        private PagingQueryBuilder GetQueryBuilder()
        {
            return new PagingQueryBuilder("Orders", "created_at", "id", true)
                .AddSpecific($"user_id = {MainForm.User.Id}")
                .AddSpecific($"status like '{status}'")
                .SetDesc(true);
        }

        // Dọn dữ liệu trong flowProducts
        private void ClearDataInFlow()
        {
            flowOrders.Controls.Clear();
            if (picOverlay == null)
            {
                InitializePictureOverlay();
            }
        }

        // Cập nhật số lượng sản phẩm tìm kiếm được cho pagingSelector và tìm kiếm sản phẩm
        private async void UpdateOrdersSearch()
        {
            ClearDataInFlow();
            // Lấy số dòng
            long numberOfItem = (long)await Task.Run(() =>
            DataProvider.Instance.ExecuteScalar(
                GetQueryBuilder().SetSelectCount().Build())
            );
            // Cập nhật giao diện
            paginationSelector.MaxSize = numberOfItem;
            // Tìm kiếm item
            SearchForOrder();
        }

        // Tìm kiếm sản phẩm
        private void SearchForOrder()
        {
            ClearDataInFlow();
            // Tạo câu truy vấn phân trang toàn bảng
            string query = GetQueryBuilder()
                .SetPage(paginationSelector.CurrentPage)
                .SetPageSize(paginationSelector.PageSize).Build();
            Task.Run(() =>
            {
                // Lấy dữ liệu và gán vào bảng
                List<object> list = DataProvider.Instance.ExecuteQuerryAsColumn(query);
                // Hiện kết quả
                if (list.Count > 0)
                {
                    // Ẩn nhãn ghi đè
                    picOverlay.SafeInvoke(() => picOverlay.Visible = false);
                    // Tạo danh sách sản phẩm
                    foreach (long id in list)
                    {
                        flowOrders.SafeInvoke(() =>
                        {
                            // Tạo sản phẩm
                            UserOrderControl order = new UserOrderControl(id);
                            order.Width = flowOrders.Width - 30;
                            order.Margin = new Padding(0,0,0,10);
                            // Thêm vào danh sách
                            flowOrders.Controls.Add(order);
                        });
                    }
                }
                else
                {
                    picOverlay.SafeInvoke(() => picOverlay.Image = Properties.Resources.no_data_found);
                }
            });
        }

        private void ChangeStatus(string statusValue, string statusDisplay)
        {
            status = statusValue;
            lblCurrentStatus.Text = statusDisplay;
            UpdateOrdersSearch();
        }

        private void btnProcessingOrders_Click(object sender, System.EventArgs e)
        {
            ChangeStatus("processing", "Đơn đang chờ");
        }

        private void btnShippingOrders_Click(object sender, System.EventArgs e)
        {
            ChangeStatus("shipping", "Đơn đang giao");
        }

        private void btnCompletedOrders_Click(object sender, System.EventArgs e)
        {
            ChangeStatus("completed", "Đơn đã giao");
        }

        private void btnAllOrders_Click(object sender, System.EventArgs e)
        {
            ChangeStatus("%%", "Tất cả đơn");
        }

        private void btnCancelledOrders_Click(object sender, System.EventArgs e)
        {
            ChangeStatus("cancelled", "Đơn đã hủy");
        }

        private void UserOrderHistory_Resize(object sender, System.EventArgs e)
        {
            picOverlay.Width = flowOrders.Width = flowOrders.Width;
            foreach(Control control in flowOrders.Controls)
            {
                if (control is UserOrderControl order)
                {
                    order.Width = flowOrders.Width - 20;
                }
            }
            this.Invalidate();
        }
    }
}
