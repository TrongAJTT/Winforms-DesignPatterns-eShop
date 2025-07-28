using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class UserInfoViewer: Form
    {
        private UserDTO user;

        // Page 3
        private string status = "%%";
        private PictureBox picOverlayP3;

        public UserInfoViewer(long userId)
        {
            InitializeComponent();
            var userDAO = new UserDAO();
            user = userDAO.GetById(userId);

            // Page 1
            LoadOverallInfo();

            // Page 2
            LoadAddress();

            // Page 3
            InitializeEventP3();
            UpdateOrdersSearchP3();


            // Page 4
            InitializeEventP4();
            UpdateReviewsSearchP4();
        }

        #region Page 1

        private void LoadOverallInfo()
        {
            valueName.Text = user.Username;
            valueEmail.Text = user.Email;
            valueCreated.Text = user.CreatedDate.ToString("dd/MM/yyyy HH:mm:ss");
            valueLatestLogin.Text = user.LastLoginDate.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #endregion

        #region Page 2

        private void LoadAddress()
        {
            var dao = new UserAddressDAO();
            var bll = new UserAddressBLL(dao);
            var addresses = bll.GetAddressOfUser(user.Id);

            flowAddress.Controls.Clear();
            if (addresses != null && addresses.Count > 0)
            {
                foreach (var address in addresses)
                {
                    var userAddressControl = new UserAddressControl(address);
                    userAddressControl.Width = flowAddress.Width - 30;
                    userAddressControl.Margin = new Padding(5);
                    userAddressControl.EnableContextMenu = false;
                    flowAddress.Controls.Add(userAddressControl);
                }
            }
            else
            {
                // Không có địa chỉ nào
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.no_data_found;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new System.Drawing.Size(flowAddress.Width - 20, 400);
                flowAddress.Controls.Add(pictureBox);
            }
        }

        #endregion

        #region Page 3

        private void InitializePictureOverlay()
        {
            picOverlayP3 = new PictureBox();
            picOverlayP3.Image = Properties.Resources.ic_loading_gif;
            picOverlayP3.SizeMode = PictureBoxSizeMode.Zoom;
            picOverlayP3.Size = new Size(flowOrders.Width, 300);
            picOverlayP3.Visible = true;
            flowOrders.Controls.Add(picOverlayP3);
        }

        private void InitializeEventP3()
        {
            paginationSelector.OnPageChanged += (s, e) => SearchForOrderP3();
            paginationSelector.OnPageSizeChanged += (s, e) => UpdateOrdersSearchP3();
        }

        // Tạo câu truy vấn tìm kiếm theo bộ lọc
        private PagingQueryBuilder GetQueryBuilderP3()
        {
            return new PagingQueryBuilder("Orders", "created_at", "id", true)
                .AddSpecific($"user_id = {user.Id}")
                .AddSpecific($"status like '{status}'")
                .SetDesc(true);
        }

        // Dọn dữ liệu trong flowProducts
        private void ClearDataInFlowP3()
        {
            flowOrders.Controls.Clear();
            if (picOverlayP3 == null)
            {
                InitializePictureOverlay();
            }
        }

        // Cập nhật số lượng sản phẩm tìm kiếm được cho pagingSelector và tìm kiếm sản phẩm
        private async void UpdateOrdersSearchP3()
        {
            ClearDataInFlowP3();
            // Lấy số dòng
            long numberOfItem = (long)await Task.Run(() =>
            DataProvider.Instance.ExecuteScalar(
                GetQueryBuilderP3().SetSelectCount().Build())
            );
            // Cập nhật giao diện
            paginationSelector.MaxSize = numberOfItem;
            // Tìm kiếm item
            SearchForOrderP3();
        }

        // Tìm kiếm sản phẩm
        private void SearchForOrderP3()
        {
            ClearDataInFlowP3();
            // Tạo câu truy vấn phân trang toàn bảng
            string query = GetQueryBuilderP3()
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
                    picOverlayP3.SafeInvoke(() => picOverlayP3.Visible = false);
                    // Tạo danh sách sản phẩm
                    foreach (long id in list)
                    {
                        flowOrders.SafeInvoke(() =>
                        {
                            // Tạo sản phẩm
                            UserOrderControl order = new UserOrderControl(id);
                            order.Width = flowOrders.Width - 30;
                            order.Margin = new Padding(0, 0, 0, 10);
                            // Thêm vào danh sách
                            flowOrders.Controls.Add(order);
                        });
                    }
                }
                else
                {
                    picOverlayP3.SafeInvoke(() => picOverlayP3.Image = Properties.Resources.no_data_found);
                }
            });
        }

        private void ChangeStatus(string statusValue, string statusDisplay)
        {
            status = statusValue;
            lblCurrentStatus.Text = statusDisplay;
            UpdateOrdersSearchP3();
        }

        private void btnProcessingOrders_Click(object sender, EventArgs e)
        {
            ChangeStatus("processing", "Đơn đang chờ");
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            ChangeStatus("%%", "Tất cả đơn");
        }

        private void btnShippingOrders_Click(object sender, EventArgs e)
        {
            ChangeStatus("shipping", "Đơn đang giao");
        }

        private void btnCompletedOrders_Click(object sender, EventArgs e)
        {
            ChangeStatus("completed", "Đơn đã giao");
        }

        private void btnCancelledOrders_Click(object sender, EventArgs e)
        {
            ChangeStatus("cancelled", "Đơn đã hủy");
        }

        //private void UserOrderHistory_Resize(object sender, System.EventArgs e)
        //{
        //    picOverlay.Width = flowOrders.Width = flowOrders.Width;
        //    foreach (Control control in flowOrders.Controls)
        //    {
        //        if (control is UserOrderControl order)
        //        {
        //            order.Width = flowOrders.Width - 20;
        //        }
        //    }
        //    this.Invalidate();
        //}

        #endregion

        #region Page 4

        // Khởi tạo sự kiện
        private void InitializeEventP4()
        {
            paginationSelector.OnPageChanged += (s, e) => SearchForReviewsP4();
            paginationSelector.OnPageSizeChanged += (s, e) => UpdateReviewsSearchP4();
        }

        // Tạo câu truy vấn tìm kiếm theo bộ lọc
        private PagingQueryBuilder GetQueryBuilderP4()
        {
            return new PagingQueryBuilder("User_Review", "created_at", "id", true)
                .AddSpecific($"user_id = @userId")
                .SetDesc(true);
        }

        // Dọn dữ liệu trong flowReview
        private void ClearDataInFlowP4()
        {
            flowReviews.Controls.Clear();
            picOverlayP4.Visible = true;
            picOverlayP4.Image = Properties.Resources.ic_loading_gif;
        }

        // Cập nhật số lượng sản phẩm tìm kiếm được cho pagingSelector và tìm kiếm sản phẩm
        private async void UpdateReviewsSearchP4()
        {
            ClearDataInFlowP4();
            // Lấy số dòng
            long numberOfItem = (long)await Task.Run(() =>
            DataProvider.Instance.ExecuteScalar(GetQueryBuilderP4().SetSelectCount().Build(), user.Id));
            // Cập nhật giao diện
            paginationSelector.MaxSize = numberOfItem;
            // Tìm kiếm item
            SearchForReviewsP4();
        }

        // Tìm kiếm sản phẩm
        private void SearchForReviewsP4()
        {
            ClearDataInFlowP4();
            // Tạo câu truy vấn phân trang toàn bảng
            string query = GetQueryBuilderP4()
                .SetSelect("product_id")
                .SetPage(paginationSelector.CurrentPage)
                .SetPageSize(paginationSelector.PageSize).Build();
            Task.Run(() =>
            {
                // Lấy dữ liệu và gán vào bảng
                List<object> list = DataProvider.Instance.ExecuteQuerryAsColumn(query, user.Id);
                // Hiện kết quả
                if (list.Count > 0)
                {
                    // Ẩn nhãn ghi đè
                    picOverlayP4.SafeInvokeSetVisible(false);
                    // Tạo danh sách sản phẩm
                    foreach (long id in list)
                    {
                        flowReviews.SafeInvoke(() =>
                        {
                            // Tạo đối tượng điều khiển đánh giá
                            var control = new UserReviewControl(user.Id, id, true);
                            // Thêm vào danh sách
                            flowReviews.Controls.Add(control);
                        });
                    }
                }
                else
                {
                    picOverlayP4.SafeInvokeSetImage(Properties.Resources.no_data_found);
                }
            });
        }

        #endregion

    }
}
