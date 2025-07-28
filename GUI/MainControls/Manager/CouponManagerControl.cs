using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Manager
{
    public partial class CouponManagerControl: UserControl
    {
        private ICrudRepository<CouponDTO, long> _couponRepository;
        List<CouponDTO> coupons;

        public CouponManagerControl()
        {
            InitializeComponent();
            custommerDatagridview();
            _couponRepository = new CouponDAO();
            coupons = _couponRepository.GetAll();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            btnViewExpired.ForeColor = btnViewUseable.ForeColor = ColorUtils.PurplePastel;
            btnViewAll.ForeColor = Color.Red;
            // Logic xem tất cả mã giảm giá
            dataCoupons.DataSource = coupons;
        }

        private void btnViewExpired_Click(object sender, EventArgs e)
        {
            btnViewAll.ForeColor = btnViewUseable.ForeColor = ColorUtils.PurplePastel;
            btnViewExpired.ForeColor = Color.Red;
            // Logic xem mã giảm giá đã hết hạn
            dataCoupons.DataSource = coupons.FindAll(c => c.ExpirationDate < DateTime.Now);
        }

        private void btnViewUseable_Click(object sender, EventArgs e)
        {
            btnViewAll.ForeColor = btnViewExpired.ForeColor = ColorUtils.PurplePastel;
            btnViewUseable.ForeColor = Color.Red;
            // Logic xem mã giảm giá còn sử dụng
            dataCoupons.DataSource = coupons.FindAll(c => c.ExpirationDate >= DateTime.Now && c.RemainingUses > 0);
        }

        private void btnDeleteUnusable_Click(object sender, EventArgs e)
        {
            // Logic xóa mã giảm giá đã hết hạn hoặc không còn sử dụng đươc
            List<CouponDTO> expiredCoupons = coupons.FindAll(c => c.ExpirationDate < DateTime.Now || c.Status == false || c.RemainingUses == 0);
            foreach (var coupon in expiredCoupons)
            {
                try
                {
                    _couponRepository.DeleteById(coupon.Id);
                }
                // Xử lý xóa mã giảm giá hết hạn nhưng còn dính đến bảng khác
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi xóa mã giảm giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Instance.LogError($"Lỗi khi xóa mã giảm giá: {ex.Message}");
                }
            }
            MySystem.ShowToastMessageAtTopRight("Xóa hoàn tất");
        }

        private void dataCoupons_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataCoupons.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    dataCoupons.ClearSelection();
                    dataCoupons.Rows[hit.RowIndex].Selected = true;

                    // Hiện menu tại vị trí chuột
                    CRUDMenu.Show(dataCoupons, e.Location);
                }
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new CouponEditor().ShowDialog();
           dataCoupons.DataSource =  _couponRepository.GetAll();
           dataCoupons.DataSource = coupons = _couponRepository.GetAll();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _couponRepository.DeleteById(long.Parse(dataCoupons.SelectedRows[0].Cells[0].Value.ToString()));
            dataCoupons.DataSource = coupons = _couponRepository.GetAll();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new CouponEditor(long.Parse(dataCoupons.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
           dataCoupons.DataSource = coupons = _couponRepository.GetAll();
        }

        private void custommerDatagridview()
        {
            dataCoupons.AutoGenerateColumns = false;
            dataCoupons.Columns.Clear();  // Xóa hết cột cũ

            // Thêm các cột thủ công
            dataCoupons.Columns.Add("Id", "ID");
            dataCoupons.Columns["Id"].DataPropertyName = "Id"; // Liên kết với thuộc tính trong CouponDTO

            dataCoupons.Columns.Add("DiscountPercent", "% giảm giá");
            dataCoupons.Columns["DiscountPercent"].DataPropertyName = "DiscountPercent";

            dataCoupons.Columns.Add("MaxDiscountAmount", "Số tiền giảm tối đa");
            dataCoupons.Columns["MaxDiscountAmount"].DataPropertyName = "MaxDiscountAmount";

            dataCoupons.Columns.Add("Status", "Status");
            dataCoupons.Columns["Status"].DataPropertyName = "Trạng thái";

            dataCoupons.Columns.Add("StartDate", "Ngày có hiệu lực");
            dataCoupons.Columns["StartDate"].DataPropertyName = "StartDate";

            dataCoupons.Columns.Add("ExpirationDate", "Hạn sử dụng");
            dataCoupons.Columns["ExpirationDate"].DataPropertyName = "ExpirationDate";

            dataCoupons.Columns.Add("RemainingUses", "Lượt dùng còn lại");
            dataCoupons.Columns["RemainingUses"].DataPropertyName = "RemainingUses";
            dataCoupons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CouponManagerControl_Load(object sender, EventArgs e)
        {
            btnViewAll.PerformClick();
        }

        private void toolStripReload_Click(object sender, EventArgs e)
        {
            custommerDatagridview();
            _couponRepository = new CouponDAO();
            coupons = _couponRepository.GetAll();
            btnViewAll.PerformClick();

            MySystem.ShowToastMessageAtTopRight("Tải lại dữ liệu hoàn tất");
        }
    }
}