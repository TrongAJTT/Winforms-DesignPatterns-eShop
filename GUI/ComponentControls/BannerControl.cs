using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class BannerControl: UserControl
    {
        private BannerObject obj;

        public EventHandler OnRequestEdited, OnRequestDeleted;

        public BannerControl(BannerObject obj)
        {
            InitializeComponent();
            this.obj = obj;
            InitializeUI();
        }

        public void UpdateBanner(BannerObject obj)
        {
            this.obj = obj;
            InitializeUI();
        }

        private async void InitializeUI()
        {
            labelOverlay.Visible = true;
            picture.Visible = false;
            date.Text = obj.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss");
            info.Text = $"[{obj.ProductId}] {obj.ProductName}";
            picture.Image = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(obj.ImageId));
            labelOverlay.Visible = false;
            picture.Visible = true;
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            this.OnRequestDeleted?.Invoke(this, new EventArgs());
        }

        private void tsmiEdit_Click(object sender, System.EventArgs e)
        {
            this.OnRequestEdited?.Invoke(this, new EventArgs());
        }
    }
}
