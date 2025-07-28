using System;
using System.Windows.Forms;
using _3S_eShop.Utilities;
using _3S_eShop.BLL.DTOs;
using System.Collections.Generic;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductVariantsManagerControl: UserControl
    {
        private List<ProductVariantDTO> _variants = new List<ProductVariantDTO>();
        private int column = 1;

        public ProductVariantsManagerControl()
        {
            InitializeComponent();
            lblErr.Text = "";
        }

        public List<ProductVariantDTO> Value
        {
            get => _variants;
            set
            {
                _variants = value;
                listViewData.Items.Clear();
                foreach (ProductVariantDTO variant in _variants)
                {
                    ListViewItem item = new ListViewItem(variant.Label);
                    item.SubItems.AddRange(new string[]
                    {
                        variant.Price.ToString(),
                        variant.StockQuantity.ToString(),
                        variant.Description
                    });
                    item.Tag = variant;
                    listViewData.Items.Add(item);
                }
            }
        }

        public string CheckValidate()
        {
            if (_variants.Count == 0)
            {
                return "Vui lòng thêm ít nhất 1 biến thể sản phẩm.";
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của các trường nhập liệu
            string error = variantEditor.CheckValid();
            MySystem.DisplayError(lblErr, error, error == null);
            if (error != null) return;

            // Lấy thông tin sản phẩm từ variantEditor
            ProductVariantDTO productVariant = variantEditor.GetData();

            // Thêm sản phẩm vào danh sách
            _variants.Add(productVariant);

            // Cập nhật danh sách hiển thị
            ListViewItem item = new ListViewItem(productVariant.Label);
            item.SubItems.AddRange(new string[]
            {
                productVariant.Price.ToString(),
                productVariant.StockQuantity.ToString(),
                productVariant.Description
            });
            item.Tag = productVariant;
            listViewData.Items.Add(item);

            // Đặt lại dữ liệu cho variantEditor
            variantEditor.SetData(new ProductVariantDTO(0, 0, "", "", 0, 0, 0));
            variantEditor.FocusName();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewData.SelectedItems[0];
            ProductVariantDTO selectedVariant = selectedItem.Tag as ProductVariantDTO;
            
            _variants.Remove(selectedVariant);
            listViewData.Items.Remove(selectedItem);

            variantEditor.SetData(selectedVariant);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Chắc chắn XÓA {listViewData.SelectedItems.Count} BIẾN THỂ SẢN PHẨM?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem selectedItem in listViewData.SelectedItems)
                {
                    ProductVariantDTO selectedVariant = selectedItem.Tag as ProductVariantDTO;
                    _variants.Remove(selectedVariant);
                    listViewData.Items.Remove(selectedItem);
                }
            }
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsmiDelete.Enabled = listViewData.SelectedItems.Count > 0;
            tsmiEdit.Enabled = listViewData.SelectedItems.Count > 0;
        }
    }
}
