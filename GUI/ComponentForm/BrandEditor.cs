using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Facade;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class BrandEditor: Form
    {
        BrandFacade brandFacade;
        private DataGridView brandTable;
        private CategoryDTO selectedCategory;

        public BrandEditor(CategoryDTO selectedCategory)
        {
            InitializeComponent();
            brandFacade = new BrandFacade(new BrandDAO(), new BrandBuilder());
            // Ẩn các lỗi
            lblErrCategory.Text = lblErrDescription.Text 
                = lblErrName.Text = lblErrImage.Text = "";
            // Validator
            txtName.Valid = new TextLengthConstraintValidator(100, 1);
            txtDescription.Valid = new TextLengthConstraintValidator(256, 1);
            // Danh mục sản phẩm
            this.selectedCategory = selectedCategory;
            UpdateCategoryLabel();
        }

        public BrandEditor(DataGridView brandTable, CategoryDTO selectedCategory) : this(selectedCategory)
        {
            this.brandTable = brandTable;
        }

        private void UpdateCategoryLabel()
        {
            txtCategory.Texts = selectedCategory.Id + ". " + selectedCategory.Name;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pictureBox1.Image = Image.FromFile(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private bool CheckValidate()
        {
            bool result = true;

            // Kiểm tra danh mục sản phẩm
            if (selectedCategory == null)
            {
                lblErrCategory.Text = "Vui lòng chọn danh mục sản phẩm";
                result = false;
            }
            else
            {
                result = result && true;
                lblErrCategory.Text = "";
            }

            // Kiểm tra tên thương hiệu
            result = result && MySystem.ValidateTemplate(txtName, lblErrName);

            // Kiểm tra mô tả thương hiệu
            result = result && MySystem.ValidateTemplate(txtDescription, lblErrDescription);

            // Kiểm tra ảnh thương hiệu
            if (pictureBox1.Image == null)
            {
                lblErrImage.Text = "Vui lòng chọn ảnh thương hiệu";
                result = false;
            }
            else
            {
                result = result && true;
                lblErrImage.Text = "";
            }

            return result;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ
            if (!CheckValidate()) return;
            // Hiện icon tải
            loadingControl.Visible = true;
            // Ngăn người dùng thoát Form
            this.ControlBox = false;
            // Xử lý dữ liệu
            if (brandTable != null)
            {
                await brandFacade.Update(
                    brandTable.CurrentRow.Cells["Id"].Value.ToString(),
                    selectedCategory.Id,
                    txtName.Texts, 
                    txtDescription.Texts, 
                    pictureBox1.Image);
            }
            else
            {
                await brandFacade.Add(
                    selectedCategory.Id,
                    txtName.Texts, 
                    txtDescription.Texts, 
                    pictureBox1.Image);
            }
            // Đóng form
            this.Close();
        }

        private void btnPickCategory_Click(object sender, EventArgs e)
        {
            CategoryAndBrandPicker catePicker = new CategoryAndBrandPicker(1);
            if (selectedCategory != null)
            {
                catePicker.SetSelectedCategory(selectedCategory);
            }
            catePicker.ShowDialog();
            CategoryDTO categoryDTO = catePicker.GetSelectedCategory();
            if (categoryDTO != null)
            {
                EmbedControl.SetLoadingForThisControl(this, "Đang tải dữ liệu");
                selectedCategory = categoryDTO;
                UpdateCategoryLabel();
            }
        }

        private void BrandEditor_Load(object sender, EventArgs e)
        {
            if (brandTable != null)
            {
                txtName.Texts = brandTable.CurrentRow.Cells["Name"].Value.ToString();
                txtDescription.Texts = brandTable.CurrentRow.Cells["Description"].Value.ToString();
                pictureBox1.Image = (Image)brandTable.CurrentRow.Cells["Image"].Value;
            }
        }
    }
}
