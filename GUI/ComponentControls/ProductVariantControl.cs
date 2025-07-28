using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductVariantControl: UserControl
    {
        private ProductVariantDTO productVariant;
        private bool viewOnly = false, controlButton = true;

        public EventHandler OnEdited, OnDeleted;

        public ProductVariantControl()
        {
            InitializeComponent();
            InitializeValidator();
        }

        public ProductVariantControl(ProductVariantDTO productVariant)
        {
            InitializeComponent();
            InitializeValidator();
            // Thiết lập dữ liệu cho control từ đối tượng ProductVariantDTO
            this.productVariant = productVariant;
            txtLabel.Focus();
            txtLabel.Texts = productVariant.Label;
            txtPrice.Focus();
            txtPrice.Texts = productVariant.Price.ToString();
            txtStock.Focus();
            txtStock.Texts = productVariant.StockQuantity.ToString();
            txtDescription.Focus();
            txtDescription.Focus();
            txtDescription.Texts = productVariant.Description;
        }

        private void InitializeValidator()
        {
            // Input validator
            txtPrice.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            txtStock.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            // Data validator
            txtLabel.Valid = new TextLengthConstraintValidator(100);
            txtPrice.Valid = new TemplateIntegerValidator(0, 2000000000);
            txtStock.Valid = new TemplateIntegerValidator(0, 32000);
            txtDescription.Valid = new TextLengthConstraintValidator(256);
        }

        /// <summary>
        /// Lấy đối tượng ProductVariantDTO từ các trường nhập liệu.
        /// </summary>
        /// <returns>Đối tượng ProductVariantDTO, ánh xạ lên bảng product_variants trên CSDL</returns>
        public ProductVariantDTO GetData()
        {
            if (productVariant == null)
            {
                productVariant = new ProductVariantBuilder()
                    .Default()
                    .SetLabel(txtLabel.Texts)
                    .SetDescription(txtDescription.Texts)
                    .SetPrice(int.Parse(txtPrice.Texts))
                    .SetStockQuantity(short.Parse(txtStock.Texts))
                    .Build();
            }
            else
            {
                productVariant.Label = txtLabel.Texts;
                productVariant.Description = txtDescription.Texts;
                productVariant.Price = int.Parse(txtPrice.Texts);
                productVariant.StockQuantity = short.Parse(txtStock.Texts);
            }
            return productVariant;
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của các trường nhập liệu và trả về thông báo lỗi đầu tiên nếu có.
        /// </summary>
        /// <returns>null -> Dữ liệu hợp lệ. String -> Thông báo lỗi</returns>
        public string CheckValid()
        {
            List<string> s = new List<string>();
            if (!txtLabel.IsValid())
                s.Add("Nhãn variant: Vui lòng không để trống");
            if (!txtPrice.IsValid("Giá"))
                s.Add(txtPrice.GetInvalidMessage());
            if (!txtStock.IsValid("Lượng hàng trong kho"))
                s.Add(txtStock.GetInvalidMessage());
            if (!txtDescription.IsValid())
                s.Add("Mô tả: Vui lòng không để trống");
            return s.Count == 0 ? null : s[0];
        }

        [Category("Advanced Settings")]
        public bool ViewOnly
        {
            get => viewOnly;
            set
            {
                viewOnly = value;
                txtLabel.TextBox.Enabled = !viewOnly;
                txtPrice.TextBox.Enabled = !viewOnly;
                txtStock.TextBox.Enabled = !viewOnly;
                txtDescription.TextBox.Enabled = !viewOnly;
            }
        }

        [Category("Advanced Settings")]
        public bool ControlButton
        {
            get => controlButton;
            set
            {
                controlButton = value;
                if (value)
                {
                    btnEdit.Size = btnDelete.Size = new Size(40, 40);
                    btnEdit.Location = new Point(txtDescription.Location.X + txtDescription.Width + 20, txtDescription.Location.Y);
                    btnDelete.Location = new Point(btnEdit.Location.X, btnEdit.Location.Y + 50);
                    btnEdit.Enabled = btnDelete.Enabled
                        = btnEdit.Visible = btnDelete.Visible = true;
                    txtDescription.Width -= 60;
                }
                else
                {
                    btnEdit.Size = btnDelete.Size = new Size(0, 0);
                    btnEdit.Location = btnDelete.Location = new Point(0, 0);
                    btnEdit.Enabled = btnDelete.Enabled = false;
                    btnEdit.Visible = btnDelete.Visible = false;
                    txtDescription.Width += 60;
                }
            }
        }

        /// <summary>
        /// Thiết lập dữ liệu cho control từ đối tượng ProductVariantDTO.
        /// </summary>
        /// <param name="productVariant">Đối tượng ProductVariantDTO, ánh xạ của product_variants trên CSDL.</param>
        public void SetData(ProductVariantDTO productVariant)
        {
            this.productVariant = productVariant;
            txtLabel.Focus();
            txtLabel.Texts = productVariant.Label;
            txtPrice.Focus();
            txtPrice.Texts = productVariant.Price.ToString();
            txtStock.Focus();
            txtStock.Texts = productVariant.StockQuantity.ToString();
            txtDescription.Focus();
            txtDescription.Texts = productVariant.Description;
        }

        // Các hàm Focus
        public void FocusName()
        {
            txtLabel.Focus();
        }
        public void FocusPrice()
        {
            txtPrice.Focus();
        }
        public void FocusStock()
        {
            txtStock.Focus();
        }
        public void FocusDescription()
        {
            txtDescription.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.OnEdited?.Invoke(this, new EventArgs());
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.OnDeleted?.Invoke(this, new EventArgs());
                this.Dispose();
            }
        }

    }
}
