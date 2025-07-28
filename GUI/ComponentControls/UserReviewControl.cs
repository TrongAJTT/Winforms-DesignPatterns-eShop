using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserReviewControl: UserControl
    {
        private long userId = -1, productId = -1;
        private UserReviewDTO review;

        private static string prefix = "      ";

        public UserReviewControl()
        {
            InitializeComponent();
            InitializeUI();
            txtContent.Valid = new TextLengthConstraintValidator(2048);
        }

        public UserReviewControl(long userId, long productId, bool viewOnly = false) : this()
        {
            this.userId = userId;
            this.productId = productId;
            LoadData();
            if (viewOnly)
            {
                txtContent.Enabled = false;
                this.Height = 283;
            }
        }

        private void InitializeUI()
        {
            ratingBar.StarSize = 32;
            ratingBar.Spacing = 10;
            ratingBar.RatingValue = 3;
        }

        private void LoadData()
        {
            picProduct.Image = Properties.Resources.ic_loading_gif;
            lblProductName.Text = "Đang tải tên sản phẩm...";
            lblErrContent.Text = "";

            var reviewBll = new UserReviewBLL(new UserReviewDAO());

            // Cập nhật thông tin sản phẩm
            Task.Run(async () =>
            {
                var productDao = new ProductDAO();
                var product = productDao.GetById(productId);
                if (product != null)
                {
                    lblProductName.SafeInvokeSetText(product.Name);
                    Stream imageStream = await DriveHandler.DownloadFilesFromDrive(product.Thumb);
                    picProduct.SafeInvokeSetImage(Image.FromStream(imageStream));
                    lblProductName.SafeInvoke(() => lblProductName.Text = product.Name);
                }
            });

            // Cập nhật thông tin đánh giá
            Task.Run(() =>
            {
                var review = reviewBll.GetProductReviewFromUser(userId, productId);
                if (review != null)
                {
                    this.review = review;
                    ratingBar.SafeInvoke(() => ratingBar.RatingValue = review.Rating);
                    txtContent.SafeInvoke(() =>
                    {
                        txtContent.Focus();
                        txtContent.Texts = review.Content;
                    });
                    lblDateCreate.SafeInvokeSetVisible(true);
                    lblDateCreate.SafeInvokeSetText($"{prefix}{review.CreatedAt.ToString("dd/MM/yyyy HH:mm")}");
                    lblReviewLock.SafeInvokeSetVisible(true);
                    // Khóa edit sau 7 ngày
                    if (review.CreatedAt.AddDays(7) <= DateTime.Now)
                    {
                        txtContent.SafeInvokeEnable(false);
                        lblReviewLock.SafeInvoke(() =>
                        {
                            lblReviewLock.Image = Properties.Resources.lock_white_24;
                            lblReviewLock.Text = $"{prefix}Không thể sửa sau 7 ngày";
                            lblReviewLock.BackColor = Color.Salmon;
                        });
                        ratingBar.SafeInvoke(() => ratingBar.AllowEdit = false);
                    }
                    else
                    {
                        btnSaveReview.SafeInvokeSetVisible(true);
                        lblReviewLock.SafeInvoke(() =>
                        {
                            var dateRemain = review.CreatedAt.AddDays(7) - DateTime.Now;
                            lblReviewLock.Visible = true;
                            lblReviewLock.Image = Properties.Resources.compose_white_24;
                            lblReviewLock.Text = $"{prefix}Còn sửa trong {dateRemain.Days} ngày {dateRemain.Hours}h";
                            lblReviewLock.BackColor = Color.LimeGreen;
                        });
                    }
                }
                else
                {
                    this.review = new UserReviewBuilder()
                        .Default()
                        .SetUserId(userId)
                        .SetProductId(productId)
                        .Build();
                    btnSaveReview.SafeInvokeSetVisible(true);
                }
            });
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            MySystem.ViewProduct(productId, -1);
        }

        private async void btnSaveReview_Click(object sender, EventArgs e)
        {
            if (!MySystem.ValidateTemplate(txtContent, lblErrContent)) return;

            var dao = new UserReviewDAO();
            review.Rating = (byte)ratingBar.RatingValue;
            review.Content = txtContent.Texts.Trim();

            await Task.Run(() =>
            {
                if (review.Id == -1)
                {
                    review.CreatedAt = DateTime.Now;
                    dao.Add(review);
                    // Thêm 10k điểm thưởng
                    var rewardDao = new RewardPointDAO();
                    var rewardPoint = rewardDao.GetById(userId);
                    rewardPoint.Point += 5000;
                    rewardDao.Update(userId, rewardPoint);
                    // Tải lại thông tin điểm thưởng
                    MySystem.UpdateRewardPoint();
                }
                else
                {
                    dao.Update(review.Id, review);
                }
            });

            MySystem.ShowToastMessageAtTopRight("Đánh giá đã được lưu thành công!", CustomControls.ToastBox.enmType.Success);
            LoadData();

        }

    }
}