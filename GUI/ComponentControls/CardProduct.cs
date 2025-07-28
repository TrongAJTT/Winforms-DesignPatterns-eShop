using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Flyweight;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class CardProduct : UserControl
    {
        // --- Extrinsic State ---
        private int price;
        private int origionalPrice;
        public event EventHandler ViewDetail_Click, AddCart_Click;
        private long productVariantId = -1;

        // --- Flyweight Reference ---
        private IProductFlyweight productFlyweight;

        public CardProduct()
        {
            InitializeComponent();
            Size = new Size(202, 376);
            Margin = new Padding(0, 0, 0, 0);
        }

        public CardProduct(long productVariantId)
        {
            InitializeComponent();
            Size = new Size(202, 376);
            Margin = new Padding(0, 0, 0, 0);
            this.productVariantId = productVariantId;
            SetupPlaceholders();
            LoadData();
        }

        private void SetupPlaceholders()
        {
            // Set loading state initially
            picThumb.SafeInvoke(() => picThumb.Image = Properties.Resources.ic_loading_gif); // Use loading gif
            lblName.SafeInvoke(() => lblName.Text = "Đang tải...");
            lblPrice.SafeInvoke(() => lblPrice.Text = "...");
            lblDiscountOrigional.SafeInvoke(() => lblDiscountOrigional.Text = "");
            lblDiscountPercent.SafeInvoke(() => lblDiscountPercent.Text = "");
            lblBriefInfo.SafeInvoke(() => lblBriefInfo.Text = "...");
        }

        public async void LoadData() // Consider returning Task instead of void
        {
            if (productVariantId <= 0) return; // Nothing to load

            try
            {
                SetupPlaceholders(); // Reset to loading state

                // 1. Load Variant Data (Extrinsic State)
                ProductVariantDAO varDao = new ProductVariantDAO();
                ProductVariantDTO productVar = varDao.GetById(productVariantId);

                if (productVar == null)
                {
                    // Handle variant not found - Show error state on card
                    this.Dispose();
                    Console.WriteLine($"Biến thể {productVar} không tồn tại");
                    return;
                }

                // 2. Get the Shared Flyweight (Intrinsic State) using the Factory
                //    The factory handles loading the base product and image only if needed.
                productFlyweight = await ProductFlyweightFactory.Instance.GetFlyweightAsync(productVar.ProductId);

                if (productFlyweight == null || productFlyweight.Name == "Product Not Found") // Check for placeholder/error
                {
                    Console.WriteLine($"Sản phẩm gốc từ biến thể {productVar} không tồn tại");
                    return;
                }

                // 3. Apply Data to UI Controls
                // Apply intrinsic data from Flyweight
                Thumb = productFlyweight.ThumbImage; // Assign shared image
                ProductBaseName = productFlyweight.Name;

                // Apply extrinsic data from VariantDTO
                SetPrice(productVar.Price, productVar.DiscountPrice);
                ProductBriefInfo = productVar.Label;

            }
            catch (Exception ex)
            {
                string errMsg = $"Lỗi khi tải dữ liệu của biến thể sản phẩm {productVariantId}: {ex.Message}";
                Console.WriteLine(errMsg);
                Logger.Instance.LogErrorException(ex, "CARD PRODUCT - Lỗi khi tải dữ liệu của biến thể sản phẩm");
                lblBriefInfo.SafeInvokeSetText("Lỗi tải dữ liệu");
            }
        }


        public Image Thumb
        {
            get => picThumb.Image;
            set => picThumb.SafeInvoke(() => picThumb.Image = value);
        }

        [Category("Advanced Settings")]
        [Description("Giá của sản phẩm (giá gốc hoặc giá hiện tại đang được giảm)")]
        public int Price
        {
            get => price;
            set
            {
                price = value;
                lblPrice.SafeInvoke(() => lblPrice.Text = value.ToString("N0").Replace(",", ".") + " đ");
            }
        }

        [Category("Advanced Settings")]
        [Description("Mã số biến thể sản phẩm")]
        public long ProductVariantId 
        { 
            get => productVariantId; 
            set => productVariantId = value; 
        }


        [Category("Advanced Settings")]
        [Description("Tên sản phẩm")]
        public string ProductBaseName 
        { 
            get => lblName.Text;
            set => lblName.SafeInvoke(() => lblName.Text = value);
        }


        [Category("Advanced Settings")]
        [Description("Thông tin ngắn gọn về sản phẩm")]
        public string ProductBriefInfo 
        { 
            get => lblBriefInfo.Text;
            set => lblBriefInfo.SafeInvoke(() => lblBriefInfo.Text = value);
        }


        [Category("Advanced Settings")]
        [Description("Giá gốc của sản phẩm (-1 nếu giá không giảm)")]
        public int OrigionalPrice
        {
            get => origionalPrice < 0 ? -1 : origionalPrice;
            private set // Make setter private/internal
            {
                origionalPrice = value;
                if (value <= 0) // Check for <= 0 instead of just -1 for robustness
                {
                    lblDiscountOrigional.SafeInvoke(() => lblDiscountOrigional.Text = "");
                    lblDiscountPercent.SafeInvoke(() => lblDiscountPercent.Text = "");
                }
                else
                {
                    // Ensure price is valid before calculating discount percentage
                    if (price > 0 && origionalPrice > price)
                    {
                        lblDiscountOrigional.SafeInvoke(() => lblDiscountOrigional.Text
                           = origionalPrice.ToString("N0").Replace(",", ".") + " đ"); // Note: removed '&'
                        lblDiscountPercent.SafeInvoke(() => lblDiscountPercent.Text = $"-{(origionalPrice - price) * 100 / origionalPrice}%");
                    }
                    else // Handle cases where price might be >= original or invalid
                    {
                        lblDiscountOrigional.SafeInvoke(() => lblDiscountOrigional.Text = "");
                        lblDiscountPercent.SafeInvoke(() => lblDiscountPercent.Text = "");
                    }
                }
            }
        }

        private void SetPrice(int basePrice, int discountPrice)
        {
            // Determine which is original and which is current selling price
            if (discountPrice < basePrice && discountPrice > 0)
            {
                Price = discountPrice;        // Selling price is the lower, discounted price
                OrigionalPrice = basePrice;   // Original price is the higher base price
            }
            else
            {
                Price = basePrice;            // Selling price is the base price
                OrigionalPrice = -1;          // No discount, so original price is irrelevant or same as selling
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (productFlyweight != null)
            {
                MySystem.CartHelper.Create(productFlyweight.ProductId, productVariantId);
                MySystem.ShowToastMessageAtTopRight("Đã thêm sản phẩm vào giỏ hàng");
            }
            else
            {
                Console.WriteLine("Cannot add to cart: Product data not loaded.");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (productFlyweight != null)
            {
                MySystem.ViewProduct(productFlyweight.ProductId, ProductVariantId);
            }
            else
            {
                Console.WriteLine("Cannot view details: Product data not loaded.");
            }
        }

    }
}
