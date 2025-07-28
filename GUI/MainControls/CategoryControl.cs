using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomControls;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class CategoryControl : UserControl, ILazyLoad, KeyBindingControl
    {
        // Thành phần của ILazyLoad
        private bool isLoaded = false;

        // Danh sách các danh mục
        List<CategoryDTO> listCategory;

        // Hàm khởi tạo
        public CategoryControl()
        {
            InitializeComponent();
        }

        // Hàm lazy load
        void ILazyLoad.Load()
        {
            if (!isLoaded)
            {
                GetListCategory();
                AddCategoryCard();
                mainFLow.Controls.Add(new Panel() { BackColor = mainFLow.BackColor, Anchor = AnchorStyles.Left | AnchorStyles.Right, Height = 30, Width = mainFLow.Width / 2 });
                isLoaded = true;
            }
        }

        // Hàm lấy danh sách danh mục
        private void GetListCategory()
        {
            listCategory = new CategoryBLL(new CategoryDAO()).GetAllCategories();
            if (listCategory.Count == 0)
            {
                listCategory = new List<CategoryDTO>();
            }
        }

        // Hàm thêm các thẻ danh mục vào bảng
        private void AddCategoryCard()
        {
            AlikeTableLayout tableCategory = new AlikeTableLayout();
            tableCategory.Margin = cardCategoryLabel.Padding;
            tableCategory.Anchor = cardCategoryLabel.Anchor;
            tableCategory.Width = cardCategoryLabel.Width;
            tableCategory.ColumnCount = 5;
            tableCategory.ContextMenuStrip = cmsCategory;
            mainFLow.Controls.Add(tableCategory);

            foreach(CategoryDTO category in listCategory)
            {
                tableCategory.AddControl(new CardCategory(category));
            }
        }

        private void Reload()
        {
            foreach (Control control in mainFLow.Controls)
            {
                if (control is AlikeTableLayout)
                {
                    mainFLow.Controls.Remove(control);
                    control.Dispose();
                    break;
                }
            }

            // Reload the control
            isLoaded = false;
            ((ILazyLoad)this).Load();
        }

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Reload();
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e) { }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e) { }

        private void tsmiReload_Click(object sender, System.EventArgs e)
        {
            Reload();
        }
    }
}
