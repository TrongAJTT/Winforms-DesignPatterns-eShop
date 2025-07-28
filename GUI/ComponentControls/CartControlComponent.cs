using System;
using System.Windows.Forms;
using _3S_eShop.CustomControls;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;
using System.Threading.Tasks;
using System.Drawing;
using _3S_eShop.DAL.CloudStore;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class CartControlComponent: UserControl
    {
        private static string prefix = "      ";

        public EventHandler NotifyUpdate, NotifyDataChange;
        private CartItem cartItem;
        private bool pendingUpload = false;

        /// <summary>
        /// Lấy hoặc thiết lập thuộc tính CartItem
        /// </summary>
        public CartItem Value
        {
            get => cartItem;
            set
            {
                cartItem = value;
                // Cập nhật lại số lượng
                txtQuantity.Texts = $"x{cartItem.Quantity}";
                // Cập nhật lại giá
                SetPrice(cartItem.Variant.Price, cartItem.Variant.DiscountPrice);
                // Cập nhật lại tổng giá
                lblPrice.Text = $"{prefix}{StringUtil.FormatCurrency(cartItem.Variant.DiscountPrice * cartItem.Quantity)} đ";
            }
        }

        /// <summary>
        /// Lấy hoặc thiết lập thuộc tính IsSelected
        /// </summary>
        public bool IsSelected
        {
            get => chkSelect.Checked;
            set 
            {
                chkSelect.Checked = value;
                roundedTopRight.BackColor = value ? Color.LimeGreen : ColorUtils.PurplePastel;
                lblPrice.BackColor = value ? Color.LimeGreen : SystemColors.ControlDarkDark;
                this.NotifyUpdate?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Lấy hoặc thiết lập thuộc tính Quantity
        /// </summary>
        public byte Quantity
        {
            get => (byte) cartItem.Quantity;
            set
            {
                if (value < 1 || value > 99)
                {
                    txtQuantity.Texts = $"{cartItem.Quantity}";
                    return;
                }
                cartItem.Quantity = value;
                txtQuantity.Texts = $"{value}";
                // Cập nhật lại tổng giá, gọi sự kiện NotifyUpdate
                UpdateTotalPrice();
            }
        }

        public CartControlComponent(CartProductDTO cartProduct)
        {
            InitializeComponent();
            // Validator
            txtQuantity.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            // tải dữ liệu
            LoadData(cartProduct);
        }

        private void LoadData(CartProductDTO cartProduct)
        {
            var productDao = new ProductDAO();
            var variantDao = new ProductVariantDAO();

            picProduct.Image = Properties.Resources.ic_loading_gif;
            lblProductName.Text = "Đang tải tên sản phẩm...";
            lblVariantLabel.Text = "Đang tải nhãn biến thể...";

            // Cập nhật số lượng sản phẩm
            txtQuantity.SafeInvoke(() => txtQuantity.Texts = $"{cartProduct.Quantity}");

            // Lấy thông tin sản phẩm đầu tiên.
            var product = productDao.GetById(cartProduct.ProductId);
            var variant = variantDao.GetById(cartProduct.VariantId);
            // Mock dữ liệu
            cartItem = new CartItem(variant, cartProduct.Quantity);
            // Trạng thái còn, Hết hàng.
            SetVariantStock(variant);
            // Cập nhật dữ liệu khác
            Task.Run(() =>
            {
                // Cập nhật giá
                SetPrice(variant.Price, variant.DiscountPrice);
                // Cập nhật tổng giá
                lblPrice.SafeInvokeSetText($"{prefix}{StringUtil.FormatCurrency(variant.DiscountPrice * cartProduct.Quantity)} đ");
                // Cập nhật tên sản phẩm và nhãn biến thể
                lblProductName.SafeInvokeSetText(product.Name);
                lblVariantLabel.SafeInvokeSetText(variant.Label);
                // Cập nhật ảnh bìa lên màn hình
                picProduct.SafeInvoke(async () => picProduct.Image = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(product.Thumb)));
            });
        }

        private void SetVariantStock(ProductVariantDTO variant)
        {
            // Nếu đã hết hàng
            if (variant.StockQuantity == 0)
            {
                lblOutOfStock.Visible = true;
                btnSubtract.Visible = txtQuantity.Visible = btnAdd.Visible
                    = roundedTopRight.Visible = chkSelect.Visible = false;
            }
            // Nếu còn hàng
            else
            {
                lblOutOfStock.Visible = false;
                btnSubtract.Visible = txtQuantity.Visible = btnAdd.Visible
                    = roundedTopRight.Visible = chkSelect.Visible = true;
            }
        }

        private void SetPrice(int basePrice, int discountPrice)
        {
            // Determine which is original and which is current selling price
            if (discountPrice < basePrice && discountPrice > 0)
            {
                lblVariantPrice.SafeInvokeSetText(
                    $"{StringUtil.FormatCurrency(discountPrice)} đ");
                lblVariantOrigionalPrice.SafeInvokeSetText(
                    $"{StringUtil.FormatCurrency(basePrice)} đ");
            }
            else
            {
                lblVariantPrice.SafeInvokeSetText(
                    $"{StringUtil.FormatCurrency(basePrice)} đ");
                lblVariantOrigionalPrice.SafeInvokeSetText("");
            }
        }

        private void UpdateVariant(ProductVariantDTO variant)
        {
            // Cập nhật lại biến thể
            cartItem.Variant = variant;
            // Cập nhật lại trạng thái còn, Hết hàng.
            SetVariantStock(variant);
            // Cập nhật lại nhãn biến thể
            lblVariantLabel.Text = variant.Label;
            // Cập nhật lại giá
            SetPrice(cartItem.Variant.Price, cartItem.Variant.DiscountPrice);
            // Gọi hàm cập nhật lại tổng giá và gọi sự kiện NotifyUpdate
            UpdateTotalPrice();
        }

        private async void UpdateTotalPrice()
        {
            // Cập nhật lại tổng giá
            lblPrice.Text = $"{prefix}{StringUtil.FormatCurrency(cartItem.Variant.DiscountPrice * cartItem.Quantity)} đ";
            // Gọi sự kiện NotifyUpdate
            this.NotifyUpdate?.Invoke(this, new EventArgs());
            // Tải dữ liệu lên CSDL
            if (!pendingUpload)
            {
                pendingUpload = true;

                // Tạo độ trễ 10 giây
                await Task.Delay(10000);

                // Tải dữ liệu lên CSDL
                MySystem.CartHelper.Update(cartItem.Variant.ProductId, cartItem.Variant.Id, Quantity);

                pendingUpload = false;
            }
        }

        private void btnChangeVariant_Click(object sender, EventArgs e)
        {
            var formPicker = new ProductVariantPicker(cartItem.Variant.ProductId, cartItem.Variant.Id);
            formPicker.ShowDialog();
            if (formPicker.DialogResult == DialogResult.OK)
            {
                // Cập nhật dữ liệu
                MySystem.CartHelper.Delete(cartItem.Variant.ProductId, cartItem.Variant.Id);
                MySystem.CartHelper.Create(cartItem.Variant.ProductId, formPicker.SelectedVariant.Id);
                if (Quantity > 0)
                {
                    MySystem.CartHelper.Update(cartItem.Variant.ProductId, formPicker.SelectedVariant.Id, Quantity);
                }
                // Cập nhật lại biến thể
                UpdateVariant(formPicker.SelectedVariant);
            }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            this.IsSelected = chkSelect.Checked;
        }

        private void roundedTopRight_Click(object sender, EventArgs e)
        {
            this.IsSelected = !this.IsSelected;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Quantity++;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Quantity--;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu nhấn Enter thì xử lý cập nhật
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Nếu không có gì thì không làm gì cả
                if (txtQuantity.Texts == "")
                {
                    txtQuantity.Texts = $"{cartItem.Quantity}";
                    return;
                }
                // Nếu có thay đổi thì cập nhật lại số lượng
                if (byte.TryParse(txtQuantity.Texts, out byte quantity))
                {
                    Quantity = quantity;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PerformDeleteWithoutNotify();
                MySystem.ShowToastMessageAtTopRight("Đã xóa sản phẩm khỏi giỏ hàng");
                this.NotifyDataChange?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Xóa sản phẩm khỏi giỏ hàng
        /// </summary>
        public void PerformDeleteWithoutNotify()
        {
            MySystem.CartHelper.Delete(cartItem.Variant.ProductId, cartItem.Variant.Id);
        }
    }
}
