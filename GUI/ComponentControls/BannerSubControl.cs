using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.Utilities;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class BannerSubControl: UserControl
    {
        public BannerSubControl()
        {
            InitializeComponent();
        }

        public BannerSubControl(BannerObject banner)
        {
            InitializeComponent();
            LoadData(banner);
        }

        private void LoadData(BannerObject banner)
        {
            if (banner == null) return;
            Task.Run(() =>
            {
                picture.SafeInvoke(() =>
                {
                    picture.Image = Properties.Resources.ic_loading_gif;
                    picture.Image = Image.FromStream(
                        DriveHandler.DownloadFilesFromDrive(banner.ImageId).Result);
                    picture.Click += (s, e) =>
                    {
                        MySystem.ViewProduct(banner.ProductId, -1);
                    };
                });
            });
        }
    }
}
