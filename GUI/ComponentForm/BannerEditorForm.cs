using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.Database;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class BannerEditorForm: Form
    {
        private bool isMainBanner, isDateAsc = true, lockImage = false, 
            isDone = false, isEditMode = false;
        private BannerObject banner;
        private CategoryDTO selectedCategory;
        private BrandDTO selectedBrand;
        private ProductDTO selectedProduct;

        public bool IsDone { get => isDone; set => isDone = value; }

        public BannerEditorForm(bool isMainBanner = true)
        {
            InitializeComponent();
            this.isMainBanner = isMainBanner;
            InitializeEvent();
            InitializeUI();
            UpdateProductSearch();
            InitializeToolTip();
        }

        public BannerEditorForm(BannerObject banner, bool isMainBanner = true)
        {
            InitializeComponent();
            this.isMainBanner = isMainBanner;
            this.isEditMode = true;
            this.banner = banner;
            InitializeEvent();
            InitializeUI();
            UpdateProductSearch();
            InitializeToolTip();
            LoadDataFromBanner();
        }

        private void InitializeUI()
        {
            valueCateBrand.Text = lblSelectedInfo.Text = "";
            if (isMainBanner)
            {
                lblHintImage.Text = "Banner nên có tỉ lệ 3,2:1\r\nKích thước khuyến nghị 1920x600";
            }
            else
            {
                lblHintImage.Text = "Banner nên có tỉ lệ 3.125:1\r\nKích thước khuyến nghị 250x80";
            }
        }

        private void InitializeEvent()
        {
            imagePicker.OnImageSelected += (s, e) =>
            {
                if (!lockImage)
                {
                    Image selectedmage = imagePicker.SelectecPicture.Image;
                    picSelected.Image = selectedmage;
                    picSelected.Image.Tag = imagePicker.SelectecPicture.Tag;
                    UpdatePictureInfo();
                    btnChooseImage.Enabled = selectedmage != null;
                }
            };
            imagePicker.OnImageUpdated += (s, e) =>
            {
                if (!lockImage)
                {
                    Image selectedmage = imagePicker.SelectecPicture.Image;
                    picSelected.Image = selectedmage;
                    picSelected.Image.Tag = imagePicker.SelectecPicture.Tag;
                    UpdatePictureInfo();
                }
            };
            imagePicker.OnAllImageDeleted += (s, e) =>
            {
                if (!lockImage)
                {
                    picSelected.Image = null;
                    lblSelectedInfo.Text = "";
                    btnChooseImage.Enabled = false;
                }
            };
            paginationSelector.OnPageChanged += (s, e) => SearchForProduct();
            paginationSelector.OnPageSizeChanged += (s, e) => UpdateProductSearch();
        }

        private void InitializeToolTip()
        {
            ToolTipHelper.AppendToControl(btnSearch, "Tìm kiếm sản phẩm");
            ToolTipHelper.AppendToControl(btnDeleteCateBrand, "Bỏ chọn loại và hãng");
        }

        private async void LoadDataFromBanner()
        {
            selectedProduct = new ProductBuilder()
                .SetId(banner.ProductId)
                .SetName(banner.ProductName)
                .Build();
            lblSectionProduct.Text = $"Chọn sản phẩm -> {selectedProduct.Id}";
            Stream imgs = 
                await DriveHandler.DownloadFilesFromDrive(banner.ImageId);
            imagePicker.AddImageFromStream(imgs, banner.ImageId);
            imagePicker.SetEditMode();
            // Cập nhật dữ liệu
            btnDone.Text = "SỬA BANNER";
            this.selectedProduct = new ProductBuilder()
                .SetId(banner.ProductId)
                .SetName(banner.ProductName)
                .Build();
            // Mục chọn sản phẩm
            btnChooseProduct.Text = "Bỏ chọn sản phẩm";
            btnSearch.Enabled = dgvData.Enabled = paginationSelector.Enabled = false;
            lblSectionProduct.Text = $"Chọn sản phẩm -> {selectedProduct.Id}";
            // Mục chọn ảnh
            btnChooseImage.Enabled = true;
            btnChooseImage.PerformClick();
            // Tắt nút lưu
            btnDone.Visible = false;
        }

        private void UpdatePictureInfo()
        {
            Size size = picSelected.Image.Size;
            lblSelectedInfo.Text = $"{size.Width:F2}x{size.Height:F2} | " +
                $"{(size.Width / (double)size.Height):F2}:1";
        }

        private PagingQueryBuilder GetQueryBuilder()
        {
            return new PagingQueryBuilder("Products", "created_at", "id", true)
                .SetSelect("id,name,warranty,created_at")
                .SetSelectCount()
                .AddSpecific($"name like '%{txtSearchProductName.Texts}%'")
                .AddSpecific(selectedCategory != null ?
                    $"category_id = {selectedCategory.Id}" : "")
                .AddSpecific(selectedBrand != null ?
                    $"brand_id = {selectedBrand.Id}" : "")
                .SetDesc(!isDateAsc);
        }

        private async void UpdateProductSearch()
        {
            lblProductDgvOverlay.Visible = true;
            // Lấy số dòng
            long numberOfItem = (long) await Task.Run(() =>
                DataProvider.Instance.ExecuteScalar(
                GetQueryBuilder().Build())
            );
            // Cập nhật giao diện
            paginationSelector.MaxSize = (int) numberOfItem;
            // Tìm kiếm item
            SearchForProduct();
        }

        private async void SearchForProduct()
        {
            lblProductDgvOverlay.Visible = true;
            // Tạo câu truy vấn toàn bảng
            string query = GetQueryBuilder()
                .SetPage(paginationSelector.CurrentPage)
                .SetPageSize(paginationSelector.PageSize)
                .SetSelectCount(false).Build();
            // Lấy dữ liệu và gán vào bảng
            DataTable dt = await Task.Run(() => DataProvider.Instance.ExecuteQuery(query));
            dgvData.DataSource = dt;
            // Ẩn nhãn ghi đè
            lblProductDgvOverlay.Visible = false;
        }

        public BannerObject GetBanner()
        {
            return banner;
        }

        private async Task<bool> AddBanner()
        {
            TaskManager taskMang = new TaskManager("Thêm banner");
            taskMang.RegisterTask(1, "Xử lý ảnh");
            taskMang.RegisterTask(2, "Tạo banner");
            TaskProgressWatcher watcher = new TaskProgressWatcher(taskMang, true);
            watcher.Show();

            taskMang.StartTask(1);
            taskMang.AddLog(1, "Đang tải ảnh lên hệ thống...");
            string imageId = await DriveHandler.UploadImageToDriveWithinTag(picSelected.Image);

            if (imageId == null)
            {
                taskMang.AddLog(1, "Tải ảnh lên thất bại!");
                watcher.EnableExit();
                return false;
            }

            imageId = imageId.Split('|')[1];
            taskMang.AddLog(1, "Tải ảnh lên thành công!");
            taskMang.CompleteTask(1);

            taskMang.StartTask(2);
            taskMang.AddLog(2, "Đang tạo banner...");
            string id = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            banner = new BannerObject(id, imageId, selectedProduct.Id, selectedProduct.Name);

            taskMang.AddLog(2, "Đang thêm banner lên CSDL...");
            await Task.Run(() => RedisHandler.AddBanner(banner, isMainBanner));
            taskMang.AddLog(2, "Thêm banner thành công!");
            taskMang.CompleteTask(2);

            await Task.Delay(1500);

            return true;
        }

        private async Task<bool> UpdateBanner()
        {
            TaskManager taskMang = new TaskManager("Sửa banner");
            taskMang.RegisterTask(1, "Xử lý ảnh");
            taskMang.RegisterTask(2, "Sửa banner");
            TaskProgressWatcher watcher = new TaskProgressWatcher(taskMang, true);
            watcher.Show();

            taskMang.StartTask(1);

            string imageId = banner.ImageId;

            if (imagePicker.GetReplacedImage().Contains(imageId) ||
                imagePicker.GetDeletedImage().Contains(imageId))
            {
                taskMang.AddLog(1, "Đang xóa ảnh cũ trên hệ thống...");
                DriveHandler.DeleteFileFromDrive(banner.ImageId);

                taskMang.AddLog(1, "Đang tải ảnh lên hệ thống...");
                imageId = await DriveHandler.UploadImageToDriveWithinTag(picSelected.Image);

                if (imageId == null)
                {
                    taskMang.AddLog(1, "Tải ảnh lên thất bại!");
                    watcher.EnableExit();
                    return false;
                }

                imageId = imageId.Split('|')[1];
                taskMang.AddLog(1, "Tải ảnh lên thành công!");
            }
            else
            {
                taskMang.AddLog(1, "Không phát hiện thay đổi trong ảnh, không cần tải ảnh lên hệ thống!");
            }

            taskMang.CompleteTask(1);

            taskMang.StartTask(2);
            taskMang.AddLog(2, "Đang tạo banner...");

            banner.ImageId = imageId;
            banner.ProductId = selectedProduct.Id;
            banner.ProductName = selectedProduct.Name;

            taskMang.AddLog(2, "Đang sửa banner trên CSDL...");
            await Task.Run(() => RedisHandler.EditBanner(banner, isMainBanner));
            taskMang.AddLog(2, "Sửa banner thành công!");
            taskMang.CompleteTask(2);

            await Task.Delay(1500);

            return true;
        }


        #region Button Event

        private async void btnDone_Click(object sender, System.EventArgs e)
        {
            bool result;
            // Xử lý thêm hoặc sửa sản phẩm
            if (isEditMode)
            {
                result = await UpdateBanner();
            }
            else
            {
                result = await AddBanner();
            }
            // Xử lý kết quả
            if (result)
            {
                isDone = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm banner thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseImage_Click(object sender, System.EventArgs e)
        {
            if (!lockImage)
            {
                lblSectionImage.Text = $"Chọn ảnh -> " +
                    $"{picSelected.Image.Tag.ToString().Substring(0,4)}...";
                btnChooseImage.Text = "Bỏ chọn ảnh";
                lockImage = true;
                imagePicker.Enabled = false;
                btnDone.Visible = selectedProduct != null;
            }
            else
            {
                lblSectionImage.Text = "Chọn ảnh";
                btnChooseImage.Text = "Chọn hình ảnh";
                lockImage = false;
                imagePicker.Enabled = true;
                btnDone.Visible = false;
            }
        }

        private void btnChooseCateBrand_Click(object sender, System.EventArgs e)
        {
            CategoryAndBrandPicker picker = new CategoryAndBrandPicker();
            picker.ShowDialog();
            if (picker.GetSelectedCategory() != null && picker.GetSelectedBrand() != null)
            {
                // Lấy danh sách sản phẩm theo category và brand
                selectedCategory = picker.GetSelectedCategory();
                selectedBrand = picker.GetSelectedBrand();
                // Cập nhật UI
                valueCateBrand.Text = $"{selectedCategory.Name} -> {selectedBrand.Name}";
                btnDeleteCateBrand.Visible = true;
            }
        }

        private void btnDeleteCateBrand_Click(object sender, EventArgs e)
        {
            selectedBrand = null;
            selectedCategory = null;
            valueCateBrand.Text = "";
            btnDeleteCateBrand.Visible = false;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            SearchForProduct();
        }

        private void btnChooseProduct_Click(object sender, System.EventArgs e)
        {
            if (selectedProduct == null)
            {
                DataGridViewRow row = dgvData.SelectedRows[0];
                selectedProduct = new ProductBuilder()
                    .SetId((long)row.Cells[0].Value)
                    .SetName((string)row.Cells[1].Value)
                    .Build();
                btnChooseProduct.Text = "Bỏ chọn sản phẩm";
                lblSectionProduct.Text = $"Chọn sản phẩm -> {selectedProduct.Id}";
                btnSearch.Enabled = dgvData.Enabled = paginationSelector.Enabled = false;
                btnDone.Visible = lockImage;
            }
            else
            {
                selectedProduct = null;
                lblSectionProduct.Text = btnChooseProduct.Text = $"Chọn sản phẩm";
                btnSearch.Enabled = dgvData.Enabled = paginationSelector.Enabled = true;
                btnDone.Visible = false;
            }
        }

        private void dgvData_SelectionChanged(object sender, System.EventArgs e)
        {
            btnChooseProduct.Enabled = dgvData.SelectedRows.Count > 0;
        }

        private void btnProductSort_Click(object sender, System.EventArgs e)
        {
            isDateAsc = !isDateAsc;
            btnProductSort.Text = "Ngày thêm: " + (isDateAsc ? "Tăng" : "Giảm");
        }

        #endregion
    }
}
