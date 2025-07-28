using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.Database;
using _3S_eShop.GUI.ComponentControls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class BannerManagerForm: Form
    {
        private bool isMainBanner = false;

        public BannerManagerForm(bool isMainBanner = true)
        {
            InitializeComponent();
            this.isMainBanner = isMainBanner;
            Text = isMainBanner ? "Quản lý banner chính" : "Quản lý banner phụ";
            LoadData();
        }

        private async void LoadData()
        {
            List<BannerObject> list = await Task.Run(() => RedisHandler.GetAllBanner(isMainBanner));
            lblOverlay.Text = "Không có banner nào!";
            if (list == null || list.Count == 0)
            {
                return;
            }
            else
            {
                lblOverlay.Visible = false;
                // Thêm banner vào Control
                foreach (BannerObject obj in list)
                {
                    AddBannerToControl(obj);
                }
            }
            lblNoBanner.Text = $"Số lượng banner: {flowMain.Controls.Count-1}";
        }

        private void AddBannerToControl(BannerObject banner)
        {
            BannerControl control = new BannerControl(banner);
            // Sự kiện sửa banner
            control.OnRequestEdited += (s, e) =>
            {
                BannerEditorForm editor = new BannerEditorForm(banner, isMainBanner);
                this.Hide();
                editor.ShowDialog();
                this.Show();
                if (editor.IsDone)
                {
                    // Update the control with new data
                    control.UpdateBanner(banner);
                }
            };
            // Sự kiện xóa banner
            control.OnRequestDeleted += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DriveHandler.DeleteFileFromDrive(banner.ImageId);
                    _ = Task.Run(() => RedisHandler.RemoveBanner(banner.Id, isMainBanner));
                    flowMain.Controls.Remove(control);
                    // Nếu flowMain không còn control nào thì hiển thị lại lblLoading
                    if (flowMain.Controls.Count == 0)
                    {
                        lblOverlay.Visible = true;
                        lblOverlay.Text = "Không có banner nào!";
                    }
                    else
                    {
                        lblOverlay.Visible = false;
                    }
                    // Giải phóng tài nguyên
                    control.Dispose();
                    // Cập nhật số lượng banner
                    lblNoBanner.Text = $"Số lượng banner: {flowMain.Controls.Count - 1}";
                }
            };
            // Thêm banner vào Control
            flowMain.Controls.Add(control);
        }

        private void btnAddBanner_Click(object sender, EventArgs e)
        {
            BannerEditorForm adder = new BannerEditorForm(isMainBanner);
            this.Hide();
            adder.ShowDialog();
            this.Show();
            if (adder.IsDone)
            {
                BannerObject banner = adder.GetBanner();
                AddBannerToControl(banner);
                lblNoBanner.Text = $"Số lượng banner: {flowMain.Controls.Count-1}";
                lblOverlay.Visible = false;
            }
        }
    }
}
