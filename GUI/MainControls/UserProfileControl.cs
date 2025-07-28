using _3S_eShop.GUI.MainControls.Auth;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.SimpleFactory;
using _3S_eShop.Utilities;
using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.GUI.ComponentControls;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using _3S_eShop.DAL.DAOs;
using System.Text;
using _3S_eShop.GUI.MainControls.Manager;
using _3S_eShop.GUI.ComponentForm;

namespace _3S_eShop.GUI
{
    public partial class UserProfileControl : UserControl, ILazyLoad, KeyBindingControl
    {
        // Thành phần của ILazyLoad
        private bool isLoaded = false, 
            isShownAddress = true;

        public UserProfileControl()
        {
            InitializeComponent();
        }

        void ILazyLoad.Load()
        {
            if (!isLoaded)
            {
                LoadUserProfile();
                isLoaded = true;
            }
        }

        private void LoadUserProfile()
        {
            LoadDataAccountInfo();
            LoadDataAddressInfo();
            LoadDataOrderInfo();
            LoadDataRewardInfo();
            LoadDataReviewInfo();
        }

        private void LoadDataAccountInfo()
        {
            lblAccountInfo.Text =
                $"Tên người dùng: {MainForm.User.Username}\n" +
                $"Email: {MainForm.User.Email}";
        }

        private void LoadDataAddressInfo()
        {
            Task.Run(() =>
            {
                // Tạo đối tượng truy cập dữ liệu
                UserAddressBLL bll = new UserAddressBLL(new DAL.DAOs.UserAddressDAO());
                var address = bll.GetAddressOfUser(MainForm.User.Id);
                // Nếu có địa chỉ thì lấy địa chỉ mặc định
                if (address == null)
                {
                    btnToggleAddress.SafeInvoke(() => btnToggleAddress.Visible = false);
                    lblNoAddressInfo.SafeInvoke(() => lblNoAddressInfo.Text = "0 địa chỉ");
                    lblAddressInfo.SafeInvoke(() =>
                        lblAddressInfo.Text = "Chưa có địa chỉ nhận hàng.");
                }
                else if (address.Count > 0)
                {
                    btnToggleAddress.SafeInvoke(() => btnToggleAddress.Visible = true);
                    // Cập nhật số lượng địa chỉ
                    lblNoAddressInfo.SafeInvoke(() => lblNoAddressInfo.Text = $"{address.Count} địa chỉ");
                    // Lấy thông tin địa chỉ mặc định
                    var defaultAddress = address.First(x => x.IsDefault);
                    LoadAddress(defaultAddress);
                }
            });
        }

        private void LoadDataOrderInfo()
        {
            Task.Run(() =>
            {
                var bll = new OrderBLL(new OrderDAO());
                lblNoProcessingOrder.SafeInvokeSetText(bll.GetProcessingOrderCountOfUser(MainForm.User.Id).ToString());
                lblNoDeliveringOrder.SafeInvokeSetText(bll.GetDeliveringOrderCountOfUser(MainForm.User.Id).ToString());
                lblNoCompletedOrder.SafeInvokeSetText(bll.GetCompletedOrderCountOfUser(MainForm.User.Id).ToString());
                lblNoOrders.SafeInvokeSetText(bll.GetTotalOrderCountOfUser(MainForm.User.Id).ToString() + " đơn tất cả");
            });
        }

        private void LoadDataRewardInfo()
        {
            Task.Run(() =>
            {
                var dao = new RewardPointDAO();
                var dto = dao.GetById(MainForm.User.Id);
                lblNoRewardPoints.SafeInvoke(() => lblNoRewardPoints.Text = StringUtil.FormatCurrency(dto.Point.ToString()));
                if (dto.ExpirationDate <= DateTime.Now)
                {
                    lblNoRewardPoints.SafeInvoke(() =>
                        lblNoRewardPoints.Text = StringUtil.FormatCurrency("0"));
                    lblRewardPointsWarranty.SafeInvoke(() =>
                        lblRewardPointsWarranty.Text = "Điểm thưởng đã hết hạn hoặc chưa có");
                }
                else
                {
                    lblRewardPointsWarranty.SafeInvoke(() =>
                    lblRewardPointsWarranty.Text = $"Hết hạn vào {dto.ExpirationDate.ToString("dd/MM/yyyy")}");
                }
            });
        }

        private void LoadDataReviewInfo()
        {
            Task.Run(() =>
            {
                // Tạo đối tượng truy cập dữ liệu
                var bll = new UserReviewBLL(new UserReviewDAO());
                var orderBll = new OrderBLL(new OrderDAO());
                var productBll = new ProductBLL(new ProductDAO());
                // Lấy số lượng đánh giá của người dùng
                int count = bll.GetReviewCountByUserId(MainForm.User.Id);
                // Cập nhật số lượng đánh giá
                lblNoReview.SafeInvoke(() => lblNoReview.Text = $"{count} sản phẩm");
                // Lấy dữ liệu đánh giá nếu có
                if (count > 0)
                {
                    var reviews = bll.Get2LatestReviewByUserId(MainForm.User.Id);
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (var review in reviews)
                    {
                        stringBuilder.AppendLine(
                            $"[{review.Rating}⭐] {productBll.GetNameOfProduct(review.ProductId)} | {review.CreatedAt.ToString("dd/MM/yyyy HH:mm")}");
                    }
                    lblLatestReview.SafeInvoke(() => 
                        lblLatestReview.Text = stringBuilder.ToString());
                }
            });
        }

        private void LoadAddress(UserAddressDTO address)
        {
            string recepientName = address.RecipientName;
            string recepientPhone = address.RecipientPhone;
            string administrativeArea = address.AdministrativeArea;
            string streetAddress = address.StreetAddress;

            if (!isShownAddress)
            {
                recepientName = StringUtil.HideName(recepientName);
                recepientPhone = StringUtil.HideString(recepientPhone, 3);
                administrativeArea = StringUtil.HideString(administrativeArea, 0);
                streetAddress = StringUtil.HideString(streetAddress, 0);
            }

            lblAddressInfo.SafeInvoke(() =>
            {
                lblAddressInfo.Text =
                    $"{address.RecipientName}\n" +
                    $"{address.RecipientPhone}\n" +
                    $"{address.AdministrativeArea}\n" +
                    $"{address.StreetAddress}";
            });
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            //TODO Hưng: Mở form chỉnh sửa thông tin cá nhân
            EditUserProfileForm form = new EditUserProfileForm();
            form.ShowDialog();
            // Sau khi form đóng, tải lại thông tin người dùng
            LoadUserProfile();
        }

        private void btnManageAddress_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControl(new UserAddressManagerControl(), "Quản lý địa chỉ");
        }

        private void btnToggleAddress_Click(object sender, EventArgs e)
        {
            isShownAddress = !isShownAddress;
            LoadDataAddressInfo();
            btnToggleAddress.Text = isShownAddress ? "Ẩn" : "Hiện";
        }

        private void btnSeeAllOrders_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControl(new UserOrderHistory(), "Lịch sử đơn hàng");
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            EmbedControl embed = new EmbedControl(
                new ChangePasswordControl(),
                EmbedControl.GetParentParam(this), this
            );
            embed.Title.Text = "Đổi mật khẩu";
            embed = new EmbedControlDecoratorFactory().Decorate("auth", embed);
            embed.Start();
        }

        private void btnSeeAllReviews_Click(object sender, EventArgs e)
        {
            MySystem.SetChildControl(new UserReviewHistory(), "Lịch sử đánh giá");
        }


        #region Key Binding Control

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadUserProfile();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                EmbedControl.TryClose(this);
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e) { }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e) { }

        #endregion
    }
}
