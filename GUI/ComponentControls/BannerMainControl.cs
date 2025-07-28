using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.Database;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class BannerMainControl: UserControl
    {
        private List<BannerObject> _banners;
        private List<Image> images;
        private int current = 0;

        public BannerMainControl()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            _banners = await Task.Run(() => RedisHandler.GetAllBanner(true));
            if (_banners.Count > 0)
            {
                current = 0;
                pictureBox.Image = Properties.Resources.ic_loading_gif;
                images = new List<Image>();
                foreach(var banner in _banners)
                {
                    images.Add(Image.FromStream(
                        await DriveHandler.DownloadFilesFromDrive(banner.ImageId)));
                }
                pictureBox.Image = images[current];
            }
            else
            {
                pictureBox.Image = null;
                btnLeft.Dispose();
                btnRight.Dispose();
            }
        }

        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            MySystem.ViewProduct(_banners[current].ProductId, -1);
        }

        private void btnLeft_Click(object sender, System.EventArgs e)
        {
            current--;
            if (current < 0)
            {
                current = _banners.Count - 1;
            }
            pictureBox.Image = images[current];
        }

        private void btnRight_Click(object sender, System.EventArgs e)
        {
            current++;
            if (current >= _banners.Count)
            {
                current = 0;
            }
            pictureBox.Image = images[current];
        }
    }
}
