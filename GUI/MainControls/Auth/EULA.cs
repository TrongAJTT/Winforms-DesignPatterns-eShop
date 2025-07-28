using _3S_eShop.DAL.Database;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class EULA: UserControl
    {
        public EULA()
        {
            InitializeComponent();
            LoadContent();
        }

        private async void LoadContent()
        {
            lblDate.Text = await Task.Run(() => RedisHandler.GetPolicyDate());
            txtContent.Text = await Task.Run(() => RedisHandler.GetPolicyContent());
        }
    }
}
