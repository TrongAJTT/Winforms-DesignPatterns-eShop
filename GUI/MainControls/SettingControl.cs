using _3S_eShop.BLL;
using _3S_eShop.CustomControls;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.PatternDistinctive.State;
using _3S_eShop.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class SettingControl : UserControl, KeyBindingControl
    {
        // Thành phần của ILazyLoad
        private ConfirmHandler confirmLogOut, confirmRestart, confirmAccessStopAccount;

        public SettingControl()
        {
            InitializeComponent();
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            InitializeConfirmHandler();
            LoadingUIBaseFromUser();
            LoadData();
        }

        private void LoadingUIBaseFromUser()
        {
            // Nếu là khách vãn lai thì không có nút xóa tài khoản và đăng xuất
            if (MainForm.User == null)
            {
                pnlMore.Dispose();
                btnLogout.Dispose();
            }
            // Nếu là admin thì không có nút dừng tài khoản
            else if (MainForm.Role.IsAdmin())
            {
                pnlMore.Dispose();
            }
        }

        private void LoadData()
        {
            // Cập nhật thông tin tài khoản
            Task.Run(() =>
            {
                lblInfoLog.SafeInvokeSetText(Logger.GetLogSize());
                lblInfoRecent.SafeInvokeSetText(MySystem.GetRecentlyViewedProductsCount() + " sản phẩm");
            });
            // Lấy thông tin dữ liệu khách vãn lai
            Task.Run(() =>
            {
                var list = CartProductBLL.GetCartProducts();
                if (list == null || list.Count == 0)
                {
                    lblInfoGuestCart.SafeInvokeSetText("0 sản phẩm");
                    btnImportGuestCart.SafeInvokeEnable(false);
                }
                else
                {
                    lblInfoGuestCart.SafeInvokeSetText(list.Count + " sản phẩm");
                    btnImportGuestCart.SafeInvokeEnable(true);
                }
            });
        }

        private void InitializeConfirmHandler()
        {
            // Xác nhận đăng xuất
            confirmLogOut = new ConfirmHandler(2);
            confirmLogOut.OnConfirming += () =>
            {
                MySystem.ShowToastMessageAtTopRight("Nhấn thêm lần nữa để xác nhận đăng xuất", ToastBox.enmType.Info);
            };
            confirmLogOut.OnAlreadyConfirmed += () =>
            {
                LoginSession.Clear();
                MySystem.Restart();
            };
            // Xác nhận khởi động lại
            confirmRestart = new ConfirmHandler(2);
            confirmRestart.OnConfirming += () =>
            {
                MySystem.ShowToastMessageAtTopRight("Nhấn thêm lần nữa để xác nhận khởi động lại", ToastBox.enmType.Info);
            };
            confirmRestart.OnAlreadyConfirmed += () =>
            {
                MySystem.Restart();
            };
            // Xác nhận truy cập chức năng dừng tài khoản
            confirmAccessStopAccount = new ConfirmHandler(2);
            confirmAccessStopAccount.OnConfirming += () =>
            {
                MySystem.ShowToastMessageAtTopRight("Nhấn thêm lần nữa", ToastBox.enmType.Warning);
            };
            confirmAccessStopAccount.OnAlreadyConfirmed += () =>
            {
                MySystem.SetChildControl(new StopAccountControl(), "Dừng tài khoản của tôi");
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            confirmLogOut.Confirm();
        }


        private void lblSectionMore_Click(object sender, EventArgs e)
        {
            pnlMore.Height = pnlMore.Height == 47 ? 108 : 47;
            this.Invalidate();
        }

        private void btnStopMyAccount_Click(object sender, EventArgs e)
        {
            confirmAccessStopAccount.Confirm();
        }

        private void btnClearRecent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch sử sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Xóa lịch sử tìm kiếm
                MySystem.ClearRecentlyViewedProducts();
                // Thông báo
                MySystem.ShowToastMessageAtTopRight("Đã xóa lịch sử sản phẩm");
                // Tải lại UI
                lblInfoRecent.SafeInvokeSetText(MySystem.GetRecentlyViewedProductsCount() + " sản phẩm");
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Xóa nhật ký
                Logger.Clear();
                // Thông báo
                MySystem.ShowToastMessageAtTopRight("Đã xóa nhật ký");
                // Tải lại UI
                lblInfoLog.SafeInvokeSetText(Logger.GetLogSize());
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            confirmRestart.Confirm();
        }

        #region KeyBindingControl

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadData();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                LoadData();
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e) { }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnImportGuestCart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var list = CartProductBLL.GetCartProducts();
                var bll = new CartProductBLL(new CartProductDAO());
                foreach (var item in list)
                {
                    // Thêm sản phẩm vào giỏ hàng
                    bll.AddToCart(MainForm.User.Id, item.ProductId, item.VariantId, item.Quantity);
                    CartProductBLL.RemoveFromCart(item.ProductId, item.VariantId);
                }
                btnImportGuestCart.SafeInvokeEnable(false);
                lblInfoGuestCart.SafeInvokeSetText("0 sản phẩm");
                MySystem.ShowToastMessageAtTopRight("Đã nhập giỏ hàng khách vãn lai vào tài khoản", ToastBox.enmType.Success);
            });
        }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e) { }

        #endregion

    }
}
