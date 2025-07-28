using System;
using System.Windows.Forms;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Facade;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.Utilities;
using _3S_eShop.PatternDistinctive.Command;
using System.Collections.Generic;

namespace _3S_eShop.GUI.MainControls.Manager
{
    public partial class BrandManager: UserControl
    {
        private BrandFacade _brandFacade;
        private CategoryDTO _selectedCategory;
        private Dictionary<string, CommandBase> Commands;

        public BrandManager()
        {
            InitializeComponent();
            brandTable.AutoGenerateColumns = false;
            brandTable.Columns["image"].DataPropertyName = "Image";
            brandTable.Columns["CategoryName"].DataPropertyName = "Name";
            brandTable.Columns["Description"].DataPropertyName = "Description";
            _brandFacade = new BrandFacade(new BrandDAO(), new BrandBuilder());
            brandTable.AllowUserToAddRows = false;
            btnDelete.Enabled = false; // Disable delete button by default
            btnEdit.Enabled = false; // Disable edit button by default
            // Gán dữ liệu từ repository
            Commands = new Dictionary<string, CommandBase>();
            Commands.Add("btnDelete", new ButtonCommand(btnDelete));
            Commands.Add("btnEdit", new ButtonCommand(btnEdit));
        }

        private void BrandManager_Load(object sender, EventArgs e)
        {
            btnPickCategory.PerformClick();
        }

        private async void btnPickCategory_Click(object sender, EventArgs e)
        {
            CategoryAndBrandPicker catePicker = new CategoryAndBrandPicker(1);
            if (_selectedCategory != null)
            {
                catePicker.SetSelectedCategory(_selectedCategory);
            }
            catePicker.ShowDialog();
            CategoryDTO categoryDTO = catePicker.GetSelectedCategory();
            if (categoryDTO != null)
            {
                EmbedControl.SetLoadingForThisControl(this, "Đang tải dữ liệu");
                _selectedCategory = categoryDTO;
                lblCateoryValue.Text = categoryDTO.Name;
                await _brandFacade.GetViews(brandTable, categoryDTO.Id);
            }
            EmbedControl.RemoveLoadingForThisControl(this);
        }

        private void brandTable_SelectionChanged(object sender, EventArgs e)
        {
            if (brandTable.SelectedRows.Count > 0)
            {
                Commands["btnDelete"].on();
                Commands["btnEdit"].on();
            }
            else
            {
                Commands["btnDelete"].off();
                Commands["btnEdit"].off();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySystem.SetMainFormVisible(false);
            BrandEditor brandEditor = new BrandEditor(_selectedCategory);
            brandEditor.FormClosed += async (s, args) =>
            {
                MySystem.SetMainFormVisible(true);
                await _brandFacade.GetViews(brandTable, _selectedCategory.Id);
            };
            brandEditor.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa thương hiệu
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thương hiệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            // Tiến hành xóa thương hiệu và reload lại nếu có thay đổi
            if (_brandFacade.Delete(brandTable))
            {
                await _brandFacade.GetViews(brandTable, _selectedCategory.Id);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySystem.SetMainFormVisible(false);
            BrandEditor brandEditor = new BrandEditor(brandTable, _selectedCategory);
            brandEditor.FormClosed += async (s, args) =>
            {
                MySystem.SetMainFormVisible(true);
                await _brandFacade.GetViews(brandTable, _selectedCategory.Id);
            };
            brandEditor.Show();
        }
    }
}
