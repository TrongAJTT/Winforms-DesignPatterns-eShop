using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.Test;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductViewerControl : UserControl
    {
        private ProductDTO product;
        private List<ProductVariant> listVariant;

        private long selectedVariantId;

        public ProductViewerControl(long productId, long variantId = -1)
        {
            InitializeComponent();

            // Thiết lập Zoom mode cho picture box hiện ảnh
            productPictures.SizeMode = PictureBoxSizeMode.Zoom;

            // Thiết lập icon cho nút thêm vào giỏ hàng
            btnAddCart.Image = Properties.Resources.grocery_store_white_32;

            // Thiết lập kích thước tự động cho flowContainer và UserControl
            flowContainer.AutoSize = true;
            var maximumSize = flowContainer.MaximumSize;
            maximumSize.Width = 980;
            flowContainer.MaximumSize = maximumSize;
            flowContainer.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.AutoSize = true;

            // Thiết lập kích thước tự động cho khu vực xem đánh giá sản phẩm
            flowReviews.MinimumSize = new Size(flowContainer.Width - 10, 0);
            flowReviews.AutoSize = true;
            flowReviews.AutoScroll = false;

            // Canh giữa flowContainer
            flowContainer.Location = new Point(Convert.ToInt32(this.Width / 2 - flowContainer.Width / 2), flowContainer.Location.Y);

            // Thiết lập kích thước tự động cho phần mô tả sản phẩm
            flowDescription.MinimumSize = new Size(flowContainer.Width, 0);
            flowDescription.AutoScroll = false;
            lblTitleDescription.Width = flowDescription.Width - 26;
            lblDesctiptionValue.MaximumSize = new Size(flowDescription.Width - 26, 0);

            // Thiết lập kích thước tự động cho phần thông số kỹ thuật
            flowSpecifications.AutoSize = true;
            flowSpecifications.AutoScroll = false;
            listViewSpecifications.Scrollable = false;
            listViewSpecifications.Enabled = false;
            listViewSpecifications.Columns[1].Width = listViewSpecifications.Width - listViewSpecifications.Columns[0].Width - 26;

            // Nếu là admin thì ẩn nút mua hàng
            if (MainForm.Role != null && MainForm.Role.IsAdmin())
            {
                btnAddCart.Dispose();
                btnBuy.Dispose();
            }
            // Nếu là người dùng thì ẩn nút sửa sản phẩm
            else
            {
                btnEdit.Dispose();
            }

            // Thiết lập chế độ chỉ xem cho bộ chọn ảnh nhỏ
            imgPicker.SetViewMode();

            // Lấy thông tin sản phẩm và thiết lập thông tin
            ProductDAO productDAO = new ProductDAO();
            product = productDAO.GetById(productId);
            this.selectedVariantId = variantId;

            // Sự kiện các nút
            btnAddCart.Click += (s, e) =>
            {
                MySystem.CartHelper.Create(productId, selectedVariantId);
                MySystem.ShowToastMessageAtTopRight("Đã thêm sản phẩm vào giỏ hàng");
            };
            btnEdit.Click += (s, e) =>
            {
                MySystem.SetChildControl(new ProductEditorControl(productId), "Chỉnh sửa sản phẩm");
            };
            btnBuy.Click += (s, e) =>
            {
                List<CartItem> carts = new List<CartItem>();
                carts.Add(new CartItem(
                    new ProductVariantDAO().GetById(selectedVariantId), 1));
                MySystem.CreateOrder(carts);
            };
        }

        private void LoadHeaderSection()
        {
            // Tạo các biến để lưu trữ thông tin danh mục và nhãn hàng
            var category = new CategoryBuilder().Default().Build();
            var brand = new BrandBuilder().Default().Build();
            // Tải dữ liệu danh mục
            Task.Run(() =>
            {
                var categoryDAO = new CategoryDAO();
                category = categoryDAO.GetById(product.CategoryId);
                llblHeaderCategory.SafeInvokeSetText(category.Name);
                // Tải dữ liệu nhãn hàng
                var brandDAO = new BrandDAO();
                brand = brandDAO.GetById(product.BrandId);
                llblHeaderBrand.SafeInvokeSetText(brand.Name);
                // Tải dữ liệu sản phẩm
                lblHeaderProductName.SafeInvokeSetText(product.Name);
                lblProductName.SafeInvokeSetText(product.Name);
            });
            // Tải sự kiện
            llblHeaderCategory.Click += (s, e) =>
            {
                MySystem.ViewCategory(category.Id);
            };
            llblHeaderBrand.Click += (s, e) =>
            {
                MySystem.ViewCategoryAndBrand(category.Id, brand.Id);
            };
        }

        private void LoadImageSection()
        {
            imgPicker.OnImageSelected += (s, e) =>
            {
                // Tải dữ liệu hình ảnh
                productPictures.Image = imgPicker.SelectecPicture.Image;
            };
            // Tải dữ liệu hình ảnh
            foreach (var img in product.Images)
            {
                Task.Run(async () =>
                {
                    Stream stream = await DriveHandler.DownloadFilesFromDrive(img);
                    imgPicker.SafeInvoke(() => imgPicker.AddImageFromStream(stream));
                });
            }
        }

        private void LoadVariantsSection()
        {
            List<ProductVariantDTO> variants;
            Task.Run(() =>
            {
                // Tải dữ liệu biến thể
                var productVariantDAO = new ProductVariantDAO();
                variants = productVariantDAO.GetByProductId(product.Id);
                listVariant = new List<ProductVariant>();
                // Tải dữ liệu biến thể
                foreach (var variant in variants)
                {
                    flowVariants.SafeInvoke(() =>
                    {
                        var productVariant = new ProductVariant(variant);
                        productVariant.Width = flowVariants.Width - 20;
                        productVariant.Margin = new Padding(0, 0, 0, 10);
                        productVariant.OnVariantSelected += (s, e) =>
                        {
                            ChooseVariant(variant.Id);
                        };
                        flowVariants.Controls.Add(productVariant);
                        listVariant.Add(productVariant);
                    });
                }
                // Tải dữ liệu giá tiền
                if (variants.Exists(x => x.Id == selectedVariantId))
                {
                    ChooseVariant(selectedVariantId);
                }
                else
                {
                    ChooseVariant(variants[0].Id);
                }
            });
        }

        private void ChooseVariant(long id)
        {
            selectedVariantId = id;
            foreach (var variant in listVariant)
            {
                if (variant.Value.Id == id)
                {
                    variant.IsSelected = true;
                    lblVariantDescription.SafeInvokeSetText(variant.Value.Description);
                }
                else
                {
                    variant.IsSelected = false;
                }
            }
        }

        private void LoadSimilarProducts()
        {
            Task.Run(() =>
            {
                var dao = new ProductVariantDAO();
                var list = new ProductVariantBLL(dao).Get10SimilarVariants(product.BrandId);
                cardProductSimilar.SafeInvoke(() => cardProductSimilar.RemoveAllChild());
                if (list.Count > 0)
                {
                    cardProductSimilar.SafeInvoke(() =>
                    {
                        cardProductSimilar.MaxChildren = list.Count;
                        foreach (var item in list)
                        {
                            var product = new CardProduct(item.Id);
                            cardProductSimilar.AddLastChild(product);
                        }
                        cardProductSimilar.OnViewAllClicked += (s, e) =>
                        {
                            var control = new BrowseControl(BrowseControl.InputMode.NewProduct);
                            MySystem.SetChildControl(control, "Xem sản phẩm mới");
                        };
                    });
                }
            });
        }

        private void LoadDescriptionAndSpecification()
        {
            lblDesctiptionValue.Text = product.Description;
            Dictionary<string, string> specifications = JsonConvert.DeserializeObject<Dictionary<string, string>>(product.Specification);
            foreach (var item in specifications)
            {
                ListViewItem litem = new ListViewItem(item.Key);
                litem.SubItems.Add(item.Value);
                listViewSpecifications.Items.Add(litem);
            }
            listViewSpecifications.ResizeHeight();
        }

        private void LoadRating()
        {
            Task.Run(() =>
            {
                UserReviewDAO userReviewDAO = new UserReviewDAO();
                UserReviewBLL userReviewBLL = new UserReviewBLL(userReviewDAO);
                long reviewCount = userReviewBLL.GetReviewCountByProductId(product.Id);
                lblRatingTotal.SafeInvokeSetText($"{reviewCount} đánh giá");
                pagingUserReview.SafeInvoke(() => pagingUserReview.MaxSize = reviewCount);

                float avgRating = userReviewBLL.GetAverageRatingByProductId(product.Id);
                lblRatingAverage.SafeInvokeSetText($"{avgRating}/5");

                SetSizeTemplateForRatingBar(ratingBar1);
                long count = userReviewBLL.GetReviewCountByProductIdAndRatingValue(product.Id, 1);
                lblNoRating1.SafeInvokeSetText($"{count} đánh giá");

                SetSizeTemplateForRatingBar(ratingBar2);
                count = userReviewBLL.GetReviewCountByProductIdAndRatingValue(product.Id, 2);
                lblNoRating2.SafeInvokeSetText($"{count} đánh giá");

                SetSizeTemplateForRatingBar(ratingBar3);
                count = userReviewBLL.GetReviewCountByProductIdAndRatingValue(product.Id, 3);
                lblNoRating3.SafeInvokeSetText($"{count} đánh giá");

                SetSizeTemplateForRatingBar(ratingBar4);
                count = userReviewBLL.GetReviewCountByProductIdAndRatingValue(product.Id, 4);
                lblNoRating4.SafeInvokeSetText($"{count} đánh giá");

                SetSizeTemplateForRatingBar(ratingBar5);
                count = userReviewBLL.GetReviewCountByProductIdAndRatingValue(product.Id, 5);
                lblNoRating5.SafeInvokeSetText($"{count} đánh giá");
            });
            pagingUserReview.OnPageChanged += (s, e) => UpdateUserReview();
            pagingUserReview.OnPageSizeChanged += (s, e) => UpdateUserReview();
            UpdateUserReview();
        }

        private void SetSizeTemplateForRatingBar(RatingBar ratingBar)
        {
            ratingBar.SafeInvoke(() =>
            {
                ratingBar.Size = new Size(164, 24);
                ratingBar.Margin = new Padding(3, 3, 3, 3);
                ratingBar.Spacing = 10;
                ratingBar.StarSize = 24;
                ratingBar.AllowEdit = false;
            });
        }

        private void UpdateUserReview()
        {
            flowReviews.Controls.Clear();
            UserReviewDAO userReviewDAO = new UserReviewDAO();
            UserReviewBLL userReviewBLL = new UserReviewBLL(userReviewDAO);
            List<UserReviewDTO> list = userReviewBLL.GetReviewsOfProductPaging(product.Id, pagingUserReview.CurrentPage, pagingUserReview.PageSize);
            if (list != null && list.Count>0)
            {
                foreach (var item in list)
                {
                    var review = new ProductReviewControl(item);
                    flowReviews.Controls.Add(review);
                }
            }
            else
            {
                PictureBox pic = new PictureBox();
                pic.Image = Properties.Resources.no_data_found;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Margin = new Padding(10, 10, 10, 10);
                pic.Size = new Size(flowReviews.Width - 30, 300);
                flowReviews.Controls.Add(pic);
            }
        }

        private void ProductViewerControl_Load(object sender, EventArgs e)
        {
            LoadHeaderSection();
            LoadImageSection();
            LoadVariantsSection();
            LoadSimilarProducts();
            LoadDescriptionAndSpecification();
            LoadRating();
        }
    }
}
