using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Command;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Facade;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls
{
    public partial class CategoryManagerControl : UserControl
    {
        private CategoryFacade _categoryFacade;
        
        
        
        
        
        
        private Dictionary<string, CommandBase> Commands;

        public CategoryManagerControl()
        {
            InitializeComponent();
            Commands = new Dictionary<string, CommandBase>();
            Commands.Add("btnDelete", new ButtonCommand(btnDelete));
            Commands.Add("btnEdit", new ButtonCommand(btnEdit));




            categoryTable.AutoGenerateColumns = false;
            categoryTable.Columns["image"].DataPropertyName = "Image";
            categoryTable.Columns["CategoryName"].DataPropertyName = "Name";
            categoryTable.Columns["Description"].DataPropertyName = "Description";
            _categoryFacade = new CategoryFacade(new CategoryDAO(), new CategoryBuilder());
            categoryTable.AllowUserToAddRows = false;
            btnDelete.Enabled = false; // Disable delete button by default
            btnEdit.Enabled = false; // Disable edit button by default
            // Gán dữ liệu từ repository
        }

        



       

        private async void CategoryManagerControl_Load(object sender, EventArgs e)
        {
            await _categoryFacade.GetViews(categoryTable);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = false;

            foreach (DataGridViewRow row in categoryTable.Rows)
            {
                if (row.Selected)
                {
                    hasSelection = true;
                    break; // chỉ cần biết có 1 dòng được chọn là đủ
                }
            }

            if (hasSelection)
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
             _categoryFacade.Delete(categoryTable);
            await _categoryFacade.GetViews(categoryTable);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySystem.SetMainFormVisible(false);
            CategoryEditor categoryEditor = new CategoryEditor(categoryTable);
            categoryEditor.FormClosed += async (s, args) =>
            {
                MySystem.SetMainFormVisible(true);
                await _categoryFacade.GetViews(categoryTable);
            };
            categoryEditor.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySystem.SetMainFormVisible(false);
            CategoryEditor categoryEditor = new CategoryEditor();
            categoryEditor.FormClosed += async (s, args) =>
            {
                MySystem.SetMainFormVisible(true);
                await _categoryFacade.GetViews(categoryTable);
            };
            categoryEditor.Show();
        }
    }
}
