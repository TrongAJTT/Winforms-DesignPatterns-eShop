using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.Test
{
    public partial class BrowseControl : UserControl, ILazyLoad
    {
        // Thành phần của ILazyLoad
        private LoadType loadType;
        private bool isLoaded = false, isAscending = true;

        // Thành phần của tham số Constructor
        private long inpCategoryId, inpBrandId;
        private InputMode inputMode;

        // Danh mục và nhà sản xuất được chọn
        private CategoryDTO selectedCategory;
        private BrandDTO selectedBrand;

        // Các hàm khởi tạo
        public BrowseControl()
        {
            InitializeComponent();
        }

        public BrowseControl(long categoryId)
        {
            InitializeComponent();
            this.inpCategoryId = categoryId;
            loadType = LoadType.Category;
        }

        public BrowseControl(long categoryId, long brandId)
        {
            InitializeComponent();
            this.inpCategoryId = categoryId;
            this.inpBrandId = brandId;
            loadType = LoadType.CategoryAndBrand;
        }

        public BrowseControl(InputMode inputMode)
        {
            InitializeComponent();
            this.inputMode = inputMode;
            loadType = LoadType.SpecificInput;
        }

        // Hàm lazy load
        void ILazyLoad.Load()
        {
            if (!isLoaded)
            {
                // Thiết lập giao diện, dữ liệu và sự kiện chung
                InitializeUI();
                InitializeDataValidator();
                InitializeEvent();
                // Tùy vào constructor mà xử lý riêng
                // Nếu là tải từ danh mục thì lấy thông tin danh mục
                if (loadType == LoadType.Category)
                {
                    this.selectedCategory = new CategoryDAO().GetById(inpCategoryId);
                    lblValueCateBrand.Text = selectedCategory.Name;
                    btnRemoveCateBrand.Visible = true;
                    cboSortTarget.SelectedIndex = 2;
                }
                // Nếu là tải từ danh mục và nhà sản xuất thì lấy thông tin danh mục và nhà sản xuất
                else if (loadType == LoadType.CategoryAndBrand)
                {
                    this.selectedCategory = new CategoryDAO().GetById(inpCategoryId);
                    this.selectedBrand = new BrandDAO().GetById(inpBrandId);
                    lblValueCateBrand.Text = $"{selectedCategory.Name} -> {selectedBrand.Name}";
                    btnRemoveCateBrand.Visible = true;
                    cboSortTarget.SelectedIndex = 2;
                }
                else if (loadType == LoadType.SpecificInput)
                {
                    // Nếu là tải sản phẩm giảm giá
                    if (inputMode == InputMode.SaleProduct)
                    {
                        cboSortTarget.SelectedIndex = 2;
                        isAscending = true;
                        btnSortOrder.PerformClick();
                        chkSale.Checked = false;
                        chkSaleOnly.Checked = true;
                    }
                    // Nếu là tải sản phẩm mới
                    else if (inputMode == InputMode.NewProduct)
                    {
                        cboSortTarget.SelectedIndex = 3;
                        isAscending = true;
                        btnSortOrder.PerformClick();
                    }
                }
                // Tìm kiếm sản phẩm dựa trên dữ liệu đã thiết lập
                UpdateProductSearch();
                isLoaded = true;
            }
        }

        // Thiết lập giao diện
        private void InitializeUI()
        {
            // Thiết lập lại flowProducts
            flowProducts.BackColor = Color.Transparent;
            flowProducts.AutoSize = true;
            var maxSize = flowProducts.MaximumSize;
            maxSize.Width = 1000;
            flowProducts.MaximumSize = maxSize;
            // Thiết lập items cho các comboboX
            cboSortTarget.Items.AddRange(new string[]
            {
                "Tên sản phẩm",
                "Giá",
                "Giá khuyến mãi",
                "Ngày tạo",
                "Thời gian bảo hành"
            });
            // Đặt giá trị ban đầu cho các combobox
            cboSortTarget.SelectedIndex = 0;
            // Ẩn các control chưa động đến
            btnRemoveCateBrand.Visible = false;
            lblValueCateBrand.Text = "";
            // Thiết lập Tooltip
            ToolTipHelper.AppendToControl(
                btnChooseCateBrand, "Chọn loại sản phẩm và nhà sản xuất");
            ToolTipHelper.AppendToControl(
                btnRemoveCateBrand, "Xóa loại sản phẩm và nhà sản xuất đã chọn");
            ToolTipHelper.AppendToControl(
                btnFilter, "Ẩn/hiện bộ lọc tìm kiếm");
            ToolTipHelper.AppendToControl(
                btnSearch, "Tìm kiếm sản phẩm theo bộ lọc");
        }

        // Thiết lập các validator cho các control
        private void InitializeDataValidator()
        {
            txtMinPrice.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            txtMaxPrice.InputCharacterValidator = new NumberOnlyCharacterStrategy();
        }

        // Thiết lập các sự kiện cho các control
        private void InitializeEvent()
        {
            pagingSelector.OnPageChanged += (s, e) => SearchForProduct();
            pagingSelector.OnPageSizeChanged += (s, e) => UpdateProductSearch();
        }

        // Tạo câu truy vấn tìm kiếm theo bộ lọc
        private PagingJoinQueryBuilder GetQueryBuilder()
        {
            int idx = cboSortTarget.SelectedIndex;
            string orderCol = 
                idx == 0 ? "p.name" : 
                idx == 1 ? "v.price" : 
                idx == 2 ? "v.discount_price" :
                idx == 3 ? "p.created_at" : 
                           "p.warranty";

            string productStat = "'in_stock'";
            if (chkSoldOut.Checked) productStat += ",'sold_out'";
            if (chkStopSelling.Checked) productStat += ",'in_stock'";

            string productDiscount = "v.discount_price = v.price";
            if (chkSale.Checked) productDiscount = "";
            else if (chkSaleOnly.Checked) productDiscount = "v.discount_price != v.price";

            return new PagingJoinQueryBuilder("Product_Variants", orderCol, "id", true, "v")
                .SetSelect("v.id")
                .AddInnerJoin("Products", "p", "p.id = v.product_id")
                .AddSpecific($"p.name like '%{txtSearchName.Texts}%'")
                .AddSpecific($"p.hide = 0")
                .AddSpecific(selectedCategory != null ?
                    $"category_id = {selectedCategory.Id}" : "")
                .AddSpecific(selectedBrand != null ?
                    $"brand_id = {selectedBrand.Id}" : "")
                .AddSpecific($"v.price >= {txtMinPrice.Texts}")
                .AddSpecific($"v.price <= {txtMaxPrice.Texts}")
                .AddSpecific(productDiscount)
                .AddSpecific($"p.status in ({productStat})")
                .SetDesc(!isAscending);
        }

        // Dọn dữ liệu trong flowProducts
        private void ClearDataInFlow()
        {
            flowProducts.Controls.Clear();
            picOverlay.Visible = true;
            picOverlay.Image = Properties.Resources.ic_loading_gif;
        }

        // Cập nhật số lượng sản phẩm tìm kiếm được cho pagingSelector và tìm kiếm sản phẩm
        private async void UpdateProductSearch()
        {
            ClearDataInFlow();
            // Lấy số dòng
            long numberOfItem = (long)await Task.Run(() =>
            DataProvider.Instance.ExecuteScalar(
                GetQueryBuilder().SetSelectCount().Build())
            );
            // Cập nhật giao diện
            pagingSelector.MaxSize = numberOfItem;
            // Tìm kiếm item
            SearchForProduct();
        }

        // Tìm kiếm sản phẩm
        private void SearchForProduct()
        {
            ClearDataInFlow();
            // Tạo câu truy vấn phân trang toàn bảng
            string query = GetQueryBuilder()
                .SetPage(pagingSelector.CurrentPage)
                .SetPageSize(pagingSelector.PageSize)
                .SetSelectCount(false).Build();
            Task.Run(() =>
            {
                // Lấy dữ liệu và gán vào bảng
                List<object> list = DataProvider.Instance.ExecuteQuerryAsColumn(query);
                // Hiện kết quả
                if (list.Count > 0)
                {
                    // Ẩn nhãn ghi đè
                    picOverlay.SafeInvoke(() => picOverlay.Visible = false);
                    // Tạo danh sách sản phẩm
                    foreach (long id in list)
                    {
                        flowProducts.SafeInvoke(() => 
                        {
                            // Tạo sản phẩm
                            CardProduct product = new CardProduct(id);
                            product.Margin = new Padding(10);
                            // Thêm vào danh sách
                            flowProducts.Controls.Add(product);
                        });
                    }
                }
                else
                {
                    picOverlay.SafeInvoke(() => picOverlay.Image = Properties.Resources.no_data_found);
                }
            });
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = !panelFilter.Visible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateProductSearch();
        }

        #region Các sự kiện của các control

        private void chkSaleOnly_CheckedChanged(object sender, EventArgs e)
        {
            chkSale.Checked = false;
            // Nếu chọn "chỉ hiện khuyến mãi" thì không thể chọn "bao gồm khuyến mãi"
            chkSale.Enabled = !chkSaleOnly.Checked;
        }

        private void btnChooseCateBrand_Click(object sender, EventArgs e)
        {
            CategoryAndBrandPicker picker = new CategoryAndBrandPicker(3);
            // Truyền vào dữ liệu hiện tại nếu có
            if (selectedCategory != null)
            {
                picker.SetSelectedCategory(selectedCategory);
            }
            if (selectedBrand != null)
            {
                picker.SetSelectedBrand(selectedBrand);
            }
            // Hiện form
            picker.ShowDialog();
            // Lấy kết quả
            if (picker.GetSelectedCategory() != null)
            {
                selectedCategory = picker.GetSelectedCategory();
                if (picker.GetSelectedBrand() != null)
                {
                    selectedBrand = picker.GetSelectedBrand();
                }
            }
            // Hiện dữ liệu chọn và nút xóa nếu có
            if (selectedCategory != null)
            {
                lblValueCateBrand.Text = $"{selectedCategory.Name}";
                if (selectedBrand != null)
                {
                    lblValueCateBrand.Text += $" -> {selectedBrand.Name}";
                }
                btnRemoveCateBrand.Visible = true;
            }
        }

        private void btnRemoveCateBrand_Click(object sender, EventArgs e)
        {
            selectedBrand = null;
            selectedCategory = null;
            lblValueCateBrand.Text = "";
            btnRemoveCateBrand.Visible = false;
        }

        #endregion

        public enum InputMode
        {
            NewProduct,
            SaleProduct
        }

        private enum LoadType
        {
            Default,
            Category,
            CategoryAndBrand,
            SpecificInput
        }

        private void btnSortOrder_Click(object sender, EventArgs e)
        {
            isAscending = !isAscending;
            btnSortOrder.Text = "     " + (isAscending ? "Tăng dần" : "Giảm dần");
        }
    }
}
