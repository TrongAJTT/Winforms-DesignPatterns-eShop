using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.GUI.MainControls.Manager;
using _3S_eShop.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class AdminControl : UserControl, ILazyLoad, KeyBindingControl
    {
        // Thành phần của ILazyLoad
        private bool isLoaded = false;

        // Tiền tố cho các nhãn
        private string prefix = "      ";

        // Hàm khởi tạo
        public AdminControl()
        {
            InitializeComponent();
            InitializeTooltip();
        }

        // Hàm lazy load
        void ILazyLoad.Load()
        {
            if (!isLoaded)
            {
                LoadCategoryData();
                LoadBrandData();
                LoadUserData();
                LoadCouponData();
                LoadProductData();
                LoadOrderData();
                isLoaded = true;
            }
        }

        #region Các hàm tải dữ liệu

        private void InitializeTooltip()
        {
            ToolTipHelper.AppendToControl(lblCategoryTotal, "Tổng số danh mục hàng");
            ToolTipHelper.AppendToControl(lblBrandTotal, "Tổng số thương hiệu");
            ToolTipHelper.AppendToControl(lblUserTotal, "Tổng số người dùng");
            ToolTipHelper.AppendToControl(lblUserBan, "Tổng số người dùng bị cấm");
            ToolTipHelper.AppendToControl(lblCouponTotal, "Tổng số mã giảm giá");
            ToolTipHelper.AppendToControl(lblCouponUnusable, "Tổng số mã giảm giá không còn khả năng sử dụng");
            ToolTipHelper.AppendToControl(lblProductSelling, "Tổng số sản phẩm đang bán");
            ToolTipHelper.AppendToControl(lblProductSoldOut, "Tổng số sản phẩm đã hết hàng");
            ToolTipHelper.AppendToControl(lblProductStopSelling, "Tổng số sản phẩm đã ngừng bán");
            ToolTipHelper.AppendToControl(lblNoProcessingOrder, "Tổng số đơn hàng đang xử lý");
            ToolTipHelper.AppendToControl(lblNoDeliveringOrder, "Tổng số đơn hàng đang giao");
            ToolTipHelper.AppendToControl(lblNoCompletedOrder, "Tổng số đơn hàng đã hoàn thành");
        }

        private void LoadCategoryData()
        {
            Task.Run(() =>
            {
                long noTotal = new CategoryDAO().Count();
                lblCategoryTotal.SafeInvokeSetText($"{prefix}{noTotal}");
            });
        }

        private void LoadBrandData()
        {
            Task.Run(() =>
            {
                long noTotal = new BrandDAO().Count();
                lblBrandTotal.SafeInvokeSetText($"{prefix}{noTotal}");
            });
        }

        private void LoadUserData()
        {
            Task.Run(() =>
            {
                UserDAO userDAO = new UserDAO();
                long noTotal = userDAO.Count();
                long noBan = new UserBLL(userDAO).GetBannedUserCount();
                lblUserTotal.SafeInvokeSetText($"{prefix}{noTotal}");
                lblUserBan.SafeInvokeSetText($"{prefix}{noBan}");
            });
        }

        private void LoadCouponData()
        {
            Task.Run(() =>
            {
                CouponDAO couponDAO = new CouponDAO();
                long noUnusable = new CouponBLL(couponDAO).GetUnusableCouponCount();
                long noTotal = new CouponDAO().Count();
                lblCouponTotal.SafeInvokeSetText($"{prefix}{noTotal}");
                lblCouponUnusable.SafeInvokeSetText($"{prefix}{noUnusable}");
            });
        }

        private void LoadProductData()
        {
            Task.Run(() =>
            {
                ProductBLL productBLL = new ProductBLL(new ProductDAO());
                // Số lượng sản phẩm đang bán
                long onSell = productBLL.GetProductOnSellCount();
                lblProductSelling.SafeInvokeSetText($"{prefix}{onSell}");
                // Số lượng sản phẩm đang hết hàng
                long soldOut = productBLL.GetProductOutOfStockCount();
                lblProductSoldOut.SafeInvokeSetText($"{prefix}{soldOut}");
                // Số lượng sản phẩm đã ngừng bán
                long stopSelling = productBLL.GetProductDiscontinuedCount();
                lblProductStopSelling.SafeInvokeSetText($"{prefix}{stopSelling}");
            });
        }

        private void LoadOrderData()
        {
            Task.Run(() =>
            {
                var bll = new OrderBLL(new OrderDAO());
                lblNoProcessingOrder.SafeInvokeSetText($"{prefix}{bll.GetProcessingOrderCount()}");
                lblNoDeliveringOrder.SafeInvokeSetText($"{prefix}{bll.GetDeliveringOrderCount()}");
                lblNoCompletedOrder.SafeInvokeSetText($"{prefix}{bll.GetCompletedCount()}");
            });
        }

        #endregion

        #region Sự kiện nhấn nút 

        // Nút quản lý danh mục hàng
        private void btnManageCategory_Click(object sender, System.EventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new CategoryManagerControl(),
                EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Quản lý danh mục hàng";
            embedControl.SetLoading("Đang tải dữ liệu", 6);
            embedControl.Start();
        }

        // Nút quản lý nhà sản xuất
        private void btnManageBrand_Click(object sender, System.EventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new BrandManager(),
                EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Quản lý thương hiệu";
            embedControl.Start();
        }

        // Nút quản lý người dùng
        private void btnManageUser_Click(object sender, System.EventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new UserManagerControl(),
                EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Quản lý người dùng";
            embedControl.Start();
        }

        // Nút quản lý mã giảm giá
        private void btnManageCoupon_Click(object sender, System.EventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new CouponManagerControl(),
                EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Quản lý mã giảm giá";
            embedControl.Start();
        }

        // Nút thêm sản phẩm
        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new ProductEditorControl(),
                EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Thêm sản phẩm";
            embedControl.Start();
        }

        // Nút quản lý sản phẩm
        private void btnManageProduct_Click(object sender, System.EventArgs e)
        {
            MySystem.SetChildControl(new ProductManagerControl(), "Quản lý sản phẩm");
        }

        // Nút tùy chỉnh hệ thống
        private void btnCustomSystem_Click(object sender, System.EventArgs e)
        {
            MySystem.SetChildControl(new ServiceConfiguration(), "Tùy chỉnh hệ thống");
        }

        // Nút quản lý đơn hàng

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng này sẽ được cập nhật ở các phiên bản trong tương lai!", 
                "Thông báo", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        #endregion

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            isLoaded = false;
            ((ILazyLoad)this).Load();
        }

        #region Key Binding

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                isLoaded = false;
                ((ILazyLoad)this).Load();
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e) { }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e) { }

        #endregion

        private void btnSeeAnalysis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng này sẽ được cập nhật ở các phiên bản trong tương lai!", 
                "Thông báo", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
