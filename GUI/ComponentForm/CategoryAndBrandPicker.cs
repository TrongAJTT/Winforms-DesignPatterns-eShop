using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class CategoryAndBrandPicker: Form
    {
        private const string CATE_BASE = "1. Loại sản phẩm",
            BRAND_BASE = "2. Nhà sản xuất";

        private BrandBLL brandBLL;
        private CategoryBLL categoryBLL;

        private BrandDTO _selectedBrand;
        private CategoryDTO _selectedCategory;

        private List<CategoryDTO> _categories;
        private Dictionary<string, List<BrandDTO>> _categoryBrandDic;

        public static int PICK_BOTH = 0, PICK_CATEGORY = 1, PICK_BRAND = 2, PICK_BOTH_OPTIONAL = 3;
        public int currentPick;

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="pickType">Muốn lấy dữ liệu gì? PICK_BOTH = 0, PICK_CATEGORY = 1 hoặc PICK_BRAND = 2, PICK_BOTH_OPTIONAL = 3 </param>
        public CategoryAndBrandPicker(int pickType = 0)
        {
            InitializeComponent();
            currentPick = pickType;
            InitializeData();
        }

        #region Các hàm hỗ trợ constructor

        private async void InitializeData()
        {
            // Khởi tạo các biến
            categoryBLL = new CategoryBLL(new CategoryDAO());
            brandBLL = new BrandBLL(new BrandDAO());
            _categoryBrandDic = new Dictionary<string, List<BrandDTO>>();

            // Lấy dữ liệu từ cơ sở dữ liệu
            _categories = categoryBLL.GetAllCategories();

            // Xử lý danh sách loại sản phẩm
            await Task.Run(() =>
            {
                foreach (var category in _categories)
                {
                    var brands = brandBLL.GetBrandsByCategoryId(category.Id);
                    _categoryBrandDic.Add(category.Name, brands);
                }
            });
            loadingCategory.Dispose();

            // Xử lý danh sách loại sản phẩm
            await Task.Run(() =>
            {
                if (listCategory.InvokeRequired)
                {
                    listCategory.Invoke(new MethodInvoker(() => LoadCategory()));
                }
                else
                {
                    LoadCategory();
                }
            });
            loadingBrand.Dispose();

            // Chọn loại sản phẩm nếu có
            if (_selectedCategory != null)
            {
                // Nếu không tồn tại loại sản phẩm này thì sẽ tự throw Exception
                _selectedCategory = _categories.First(x => x.Id == _selectedCategory.Id);

                listCategory.SelectedIndices.Add(_categories.IndexOf(_selectedCategory));
                PickCategory();
            }

            // Nếu chỉ chọn loại sản phẩm thì không cần chọn nhà sản xuất
            if (currentPick == PICK_CATEGORY)
            {
                flowBrand.Enabled = false;
                return;
            }

            // Chọn nhà sản xuất nếu có
            if (_selectedBrand != null)
            {
                // Nếu không tồn tại nhà sản xuất này thì sẽ tự throw Exception
                _selectedBrand = _categoryBrandDic[_selectedCategory.Name]
                    .First(x => x.Id == _selectedBrand.Id);

                listBrand.SelectedIndices.Add(_categoryBrandDic[_selectedCategory.Name].IndexOf(_selectedBrand));
                PickBrand();
                if (currentPick == PICK_BOTH_OPTIONAL)
                {
                    btnDone.Visible = true;
                }
            }

            // Nếu chỉ chọn nhà sản xuất thì không cần chọn loại sản phẩm
            if (currentPick == PICK_BRAND)
            {
                flowCategory.Enabled = false;
                return;
            }
        }

        private void LoadCategory()
        {
            listCategory.Items.AddRange(_categories.Select(x => {
                ListViewItem item = new ListViewItem(x.Name);
                item.SubItems.Add(x.Description);
                return item;
            }).ToArray());
        }

        #endregion

        private void PickCategory()
        {
            var selectedCategoryName = listCategory.SelectedItems[0].Text;
            _selectedCategory = _categories.FirstOrDefault(
                x => x.Name == selectedCategoryName);
            listBrand.Items.Clear();
            if (_categoryBrandDic.ContainsKey(selectedCategoryName))
            {
                listBrand.Items.AddRange(_categoryBrandDic[selectedCategoryName]
                    .Select(x =>
                    {
                        ListViewItem item = new ListViewItem(x.Name);
                        item.SubItems.Add(x.Description);
                        return item;
                    }).ToArray());
            }

            lblSection2.Enabled = listBrand.Enabled = btnPickBrand.Enabled = true;
            lblSection1.Text = CATE_BASE + " - " + selectedCategoryName;
        }

        private void PickBrand()
        {
            var selectedBrandName = listBrand.SelectedItems[0].Text;
            _selectedBrand = _categoryBrandDic[_selectedCategory.Name]
                .FirstOrDefault(x => x.Name == selectedBrandName);
        }

        /// <summary>
        /// Lấy loại sản phẩm đã chọn, hoạt động sau khi chọn từ Form
        /// </summary>
        /// <returns>Lớp DTO chứa loại sản phẩm đã chọn</returns>
        public CategoryDTO GetSelectedCategory()
        {
            return _selectedCategory;
        }

        /// <summary>
        /// Chọn loại sản phẩm cụ thể, gọi sau khi tạo Form và trước khi hiện form
        /// </summary>
        /// <param name="category">Lớp DTO chứa thông tin về loại sản phẩm, chỉ cần quan trọng Id</param>
        public void SetSelectedCategory(CategoryDTO category)
        {
            _selectedCategory = category;

        }

        /// <summary>
        /// Lấy nhà sản xuất đã chọn, hoạt động sau khi chọn từ Form
        /// </summary>
        /// <returns>Lớp DTO chứa nhà sản xuất đã chọn</returns>
        public BrandDTO GetSelectedBrand()
        {
            return _selectedBrand;
        }

        /// <summary>
        /// Chọn nhà sản xuất cụ thể, gọi sau khi tạo Form và trước khi hiện form
        /// </summary>
        /// <param name="category">Lớp DTO chứa thông tin về nhà sản xuất, chỉ cần quan trọng Id, cần truyền cùng với hàm SetSelectedCategory</param>
        public void SetSelectedBrand(BrandDTO brand)
        {
            _selectedBrand = brand;
        }

        #region Events

        private void listCategory_DoubleClick(object sender, EventArgs e)
        {
            if (listCategory.SelectedItems.Count > 0)
            {
                btnPickCategory_Click(null, null);
            }
        }

        private void listBrand_DoubleClick(object sender, EventArgs e)
        {
            if (listBrand.SelectedItems.Count > 0)
            {
                btnPickBrand_Click(null, null);
            }
        }

        private void btnPickCategory_Click(object sender, System.EventArgs e)
        {
            if (listCategory.SelectedItems.Count > 0)
            {
                PickCategory();
                if (currentPick == PICK_CATEGORY)
                {
                    this.Close();
                }
                else if (currentPick == PICK_BOTH_OPTIONAL)
                {
                    btnDone.Visible = true;
                }
            }
        }

        private void btnPickBrand_Click(object sender, System.EventArgs e)
        {
            if (listBrand.SelectedItems.Count > 0)
            {
                PickBrand();
                this.Close();
            }
        }

        private void CategoryAndBrandPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listCategory.Focused)
                {
                    btnPickCategory_Click(null, null);
                }
                else if (listBrand.Focused)
                {
                    btnPickBrand_Click(null, null);
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
