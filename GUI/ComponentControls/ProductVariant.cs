using System;
using System.Drawing;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductVariant: UserControl
    {
        public EventHandler OnVariantSelected;
        private ProductVariantDTO variantDTO;
        private bool isSelected = false;

        public ProductVariant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy giá trị của thuộc tính VariantDTO
        /// </summary>
        public ProductVariantDTO Value
        {
            get => variantDTO;
        }

        /// <summary>
        /// Lấy hoặc thiết lập con trỏ chuột khi di chuột qua điều khiển
        /// </summary>
        public Cursor HoverCursor
        {
            get => variantLabel.Cursor;
            set
            {
                variantLabel.Cursor = value;
                variantPrice.Cursor = value;
                pnlContainer.Cursor = value;
            }
        }

        /// <summary>
        /// Lấy hoặc thiết lập thuộc tính IsSelected
        /// </summary>
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                pnlContainer.BackColor = isSelected ? 
                    ColorUtils.PurplePastel : SystemColors.Control;
                variantPrice.ForeColor = variantLabel.ForeColor = isSelected ?
                    Color.White : Color.Black;
            }
        }

        public ProductVariant(ProductVariantDTO variantDTO) : this()
        {
            this.variantDTO = variantDTO;
            variantLabel.Text = variantDTO.Label;
            variantPrice.Text = StringUtil.FormatCurrency(variantDTO.Price);
            if (variantDTO.StockQuantity == 0)
            {
                this.Enabled = false;
                lblOutOfStock.Visible = true;
            }
            InitializeEventHandler();
        }

        private void InitializeEventHandler()
        {
            this.Click += (s, e) => OnVariantSelected?.Invoke(this, e);
            variantLabel.Click += (s, e) => OnVariantSelected?.Invoke(this, e);
            variantPrice.Click += (s, e) => OnVariantSelected?.Invoke(this, e);
        }

    }
}
