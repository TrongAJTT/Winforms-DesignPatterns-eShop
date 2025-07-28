using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductReviewControl: UserControl
    {
        private UserReviewDTO userReview;

        public ProductReviewControl()
        {
            InitializeComponent();
        }

        public ProductReviewControl(UserReviewDTO userReview) : this()
        {
            this.userReview = userReview;
            LoadData();
            ratingBar.Size = new Size(164, 24);
            ratingBar.Margin = new Padding(3, 3, 3, 3);
            ratingBar.Spacing = 10;
            ratingBar.StarSize = 24;
            ratingBar.AllowEdit = false;
        }

        private async void LoadData()
        {
            // Tải dữ liệu từ userReview
            lblDate.Text = userReview.CreatedAt.ToString("dd/MM/yyyy HH:mm");
            contentReview.Text = userReview.Content;
            ratingBar.RatingValue = userReview.Rating;
            // Tải dữ liệu người dùng
            var userDTO = await Task.Run(() => new UserDAO().GetById(userReview.UserId));
            if (userDTO != null)
            {
                lblCustomerName.Text = userDTO.Username;
            }
        }
    }
}
