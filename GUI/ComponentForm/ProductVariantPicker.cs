using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.CustomControls
{
    public partial class ProductVariantPicker: Form
    {
        private List<ProductVariant> listVariant;
        private ProductDTO product;
        private long selectedVariantId;
        private ProductVariantDTO selectedVariant;
        private bool isComplete = false;

        /// <summary>
        /// Lấy ID của biến thể được chọn
        /// </summary>
        public long SelectedVariantId { get => selectedVariantId; }
        /// <summary>
        /// Lấy biến thể được chọn
        /// </summary>
        public ProductVariantDTO SelectedVariant { get => selectedVariant; }
        /// <summary>
        /// Lấy thuộc tính IsComplete (đã hoàn tất)
        /// </summary>
        public bool IsComplete { get => isComplete; }

        public ProductVariantPicker(long productId, long variantId = -1)
        {
            InitializeComponent();

            // Lấy thông tin sản phẩm và thiết lập thông tin
            ProductDAO productDAO = new ProductDAO();
            product = productDAO.GetById(productId);
            this.selectedVariantId = variantId;
            LoadProductInfo();
            LoadVariantsSection();
        }

        private void LoadProductInfo()
        {
            lblProductName.Text = product.Name;
            Task.Run(async () =>
            {
                productThumb.Image = Properties.Resources.ic_loading_gif;
                Stream imgStream = await DriveHandler.DownloadFilesFromDrive(product.Thumb);
                productThumb.SafeInvokeSetImage(Image.FromStream(imgStream));
            });
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
                        productVariant.Cursor = Cursors.Hand;
                        productVariant.OnVariantSelected += (s, e) =>
                        {
                            ChooseVariant(variant.Id);
                        };
                        flowVariants.Controls.Add(productVariant);
                        listVariant.Add(productVariant);
                    });
                }
                // Tải variant được chọn
                if (variants.Exists(x => x.StockQuantity > 0 && x.Id == SelectedVariantId))
                {
                    ChooseVariant(SelectedVariantId);
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
                    selectedVariant = variant.Value;
                    variant.IsSelected = true;
                    lblVariantDescription.SafeInvokeSetText(variant.Value.Description);
                }
                else
                {
                    variant.IsSelected = false;
                }
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (selectedVariant != null)
            {
                isComplete = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một biến thể sản phẩm trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
