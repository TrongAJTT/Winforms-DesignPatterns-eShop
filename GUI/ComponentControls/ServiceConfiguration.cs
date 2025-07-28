using System;
using System.Windows.Forms;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ServiceConfiguration: UserControl
    {
        public ServiceConfiguration()
        {
            InitializeComponent();
        }

        private void btnManageEula_Click(object sender, EventArgs e)
        {
            MySystem.SetMainFormVisible(false);
            new EulaPublisherForm().ShowDialog();
            MySystem.SetMainFormVisible(true);
        }

        private void btnManageMainBanner_Click(object sender, EventArgs e)
        {
            BannerManagerForm manager = new BannerManagerForm();
            MySystem.SetMainFormVisible(false);
            manager.ShowDialog();
            MySystem.SetMainFormVisible(true);
        }

        private void btnManageSubBanner_Click(object sender, EventArgs e)
        {
            BannerManagerForm manager = new BannerManagerForm(false);
            MySystem.SetMainFormVisible(false);
            manager.ShowDialog();
            MySystem.SetMainFormVisible(true);
        }
    }
}
