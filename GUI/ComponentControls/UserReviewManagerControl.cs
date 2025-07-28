using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserReviewManagerControl: UserControl
    {
        private long orderId;

        public UserReviewManagerControl()
        {
            InitializeComponent();
            orderId = -1;
        }

        public UserReviewManagerControl(long orderId) : this()
        {
            this.orderId = orderId;
            lblTitleOrderReviews.Text += orderId.ToString();
            LoadData();
        }

        private void LoadData()
        {
            //var dao = new OrderDAO();
            var ordProdBll = new OrderProductBLL(new OrderProductDAO());

            Task.Run(() =>
            {
                var orderProds = ordProdBll.GetListByOrderId(orderId);

                foreach (var item in orderProds)
                {
                    flowReviews.SafeInvoke(() =>
                    {
                        var reviewControl = new UserReviewControl(MainForm.User.Id, item.ProductId);
                        flowReviews.Controls.Add(reviewControl);
                    });
                }
            });
        }
    }
}
