using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.PatternDistinctive.TemplateMethod;
using _3S_eShop.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ProductEditorControl: UserControl
    {
        private long brandId, categoryId, productId;
        private bool isEditMode;

        public ProductEditorControl()
        {
            InitializeComponent();
            InitializeUI();
            InitializeData();
            InitializeEvents();
            InitializeToolTip();
        }

        public ProductEditorControl(long productId)
        {
            InitializeComponent();
            isEditMode = true;
            this.productId = productId;
            InitializeUI();
            InitializeData();
            InitializeEvents();
            InitializeToolTip();
        }

        private async void InitializeUI()
        {
            txtDescription.TextBox.ScrollBars = ScrollBars.Vertical;
            // Ẩn các trường chưa cần hiện
            lblErrCategoryBrand.Text = lblErrDesc.Text = lblErrWarranty.Text
                = lblErrImage.Text = lblErrVariant.Text = lblErrName.Text
                = lblErrSpec.Text = lblErrTotal.Text = "";
            // Ẩn các trường không cần thiết
            if (isEditMode)
            {
                List<Task> tasks = new List<Task>();
                btnSave.Text = "Cập nhật sản phẩm";

                // Lấy thông tin sản phẩm từ CSDL
                ProductDTO product = await Task.Run(() => new ProductDAO().GetById(productId));

                // Cập nhật thông tin nhãn hàng và danh mục
                CategoryDTO selectedCategory = new CategoryDAO().GetById(product.CategoryId);
                BrandDTO selectedBrand = new BrandDAO().GetById(product.BrandId);

                // Cập nhật ảnh thương hiệu và danh mục
                _ = Task.Run(async () =>
                {
                    picCategory.Image = Image.FromStream(await
                        DriveHandler.DownloadFilesFromDrive(selectedCategory.Image40));
                });
                _ = Task.Run(async () =>
                {
                    picBrand.Image = Image.FromStream(await
                        DriveHandler.DownloadFilesFromDrive(selectedBrand.Image40));
                });

                // Cập nhật tên thương hiệu và danh mục
                lblCategory.Text = selectedCategory.Name;
                categoryId = selectedCategory.Id;
                lblBrand.Text = selectedBrand.Name;
                brandId = selectedBrand.Id;

                // Cập nhật thông tin sản phẩm
                txtName.Texts = product.Name;
                if (product.Warranty == ProductDTO.WARRANTY_LIFT_TIME)
                {
                    toggleWarrantyLifetime.Checked = true;
                }
                else
                {
                    toggleWarrantyLifetime.Checked = false;
                    txtWarranty.Texts = product.Warranty.ToString();
                }

                // Cập nhật ảnh sản phẩm
                List<Task<MemoryStream>> uploadTasks = new List<Task<MemoryStream>>();
                foreach (var imageId in product.Images)
                {
                    uploadTasks.Add(Task.Run(async () =>
                    {
                        return await DriveHandler.DownloadFilesFromDrive(imageId);
                    }));
                }
                // Chờ tất cả các tác vụ tải lên hoàn tất
                MemoryStream[] listImages = await Task.WhenAll(uploadTasks);
                for (int i = 0; i < listImages.Length; i++)
                {
                    imgPicker.AddImageFromStream(listImages[i], product.Images[i]);
                }
                imgPicker.SetSelectedSearchFor(product.Thumb);
                imgPicker.SetEditMode();

                // Cập nhật thông số kỹ thuật
                specManager.Value = JsonConvert
                    .DeserializeObject<Dictionary<string, string>>(product.Specification);

                // Cập nhật mô tả
                txtDescription.Texts = product.Description;

                // Cập nhật biến thể
                variantManager.Value = await Task.Run(() => new ProductVariantDAO().GetByProductId(product.Id));

                EmbedControl.RemoveLoadingForThisControl(this);
            }
            else
            {
                btnSave.Text = "Thêm sản phẩm";
                lblCategory.Text = lblBrand.Text = "";
            }
        }

        private void InitializeData()
        {
            // Validator
            txtName.Valid = new TextLengthConstraintValidator(200);
            txtWarranty.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            txtWarranty.Valid = new TemplateIntegerValidator(1, 10);
            txtDescription.Valid = new TextLengthConstraintValidator(4096);
        }

        private void InitializeEvents()
        {
            imgPicker.OnImageSelected += (s, e) =>
            {
                picView.Image = imgPicker.SelectecPicture.Image;
            };
            imgPicker.OnImageUpdated += (s, e) =>
            {
                picView.Image = imgPicker.SelectecPicture.Image;
            };
        }

        private void InitializeToolTip()
        {
            ToolTipHelper.AppendToControl(btnSaveSpecTemplate, "Lưu thông số cho loại sản phẩm này.");
            ToolTipHelper.AppendToControl(btnPullSpecTemplate, "Lấy thông số cho loại sản phẩm này trên hệ thống.");
            ToolTipHelper.AppendToControl(btnExportSpec, "Xuất thông số kỹ thuật ra file");
            ToolTipHelper.AppendToControl(btnImportSpec, "Nhập thông số kỹ thuật từ file");
            ToolTipHelper.AppendToControl(btnBatchImportSpec, "Nhập thông số kỹ thuật từ văn bản của form nhập");
            ToolTipHelper.AppendToControl(btnExportVariants, "Xuất danh sách biến thể ra file");
            ToolTipHelper.AppendToControl(btnImportVariants, "Nhập danh sách biến thể từ file");
            ToolTipHelper.AppendToControl(btnBatchImportVariants, "Nhập danh sách biến thể từ văn bản của form nhập");
        }

        private bool ValidateData()
        {
            bool globalError = false, error = false;

            // Danh mục và thương hiệu
            error = lblCategory.Text == "";
            MySystem.DisplayError(lblErrCategoryBrand, "Vui lòng chọn danh mục và thương hiệu.", !error);
            globalError = globalError || error;

            // Tên sản phẩm
            globalError = globalError || !MySystem.ValidateTemplate(txtName, lblErrName);

            // Hạn bảo hành
            if (!toggleWarrantyLifetime.Checked)
            {
                error = globalError || !MySystem.ValidateTemplate(txtWarranty, lblErrWarranty, "Bảo hành");
            }
            else lblErrWarranty.Text = "";

            // Ảnh
            string errStr = imgPicker.CheckValidate();
            error = errStr != null;
            globalError = globalError || error;
            MySystem.DisplayError(lblErrImage, errStr, !error);

            // Thông số kỹ thuật
            errStr = specManager.CheckValidate();
            error = errStr != null;
            globalError = globalError || error;
            MySystem.DisplayError(lblErrSpec, errStr, !error);

            // Mô tả
            globalError = globalError || !MySystem.ValidateTemplate(txtDescription, lblErrDesc);

            // Biến thể
            errStr = variantManager.CheckValidate();
            error = errStr != null;
            globalError = globalError || error;
            MySystem.DisplayError(lblErrVariant, errStr, !error);

            return !globalError;
        }

        private async void AddProduct()
        {
            var operation = new AddProductOperation(
                this,
                this.imgPicker,
                this.txtName,
                this.categoryId,
                this.brandId,
                this.toggleWarrantyLifetime,
                this.txtWarranty,
                this.txtDescription,
                this.specManager,
                this.variantManager,
                new ProductDAO(),
                new ProductVariantDAO()
            );

            await operation.ExecuteAsync();
        }

        private async void EditProduct()
        {
            // Áp dụng mẫu thiết kế Template Method
            var operation = new EditProductOperation(
                this,
                productId,
                this.imgPicker,
                this.txtName,
                this.categoryId,
                this.brandId,
                this.toggleWarrantyLifetime,
                this.txtWarranty,
                this.txtDescription,
                this.specManager,
                this.variantManager,
                new ProductDAO(),
                new ProductVariantDAO()
            );
            await operation.ExecuteAsync();
            EmbedControl.TryClose(this);
        }

        #region Event Handlers

        private void toggleWarrantyLifetime_CheckedChanged(
            object sender, EventArgs e)
        {
            txtWarranty.Enabled = !toggleWarrantyLifetime.Checked;
        }

        private async void btnPickCategoryAndBrand_Click(object sender, EventArgs e)
        {
            CategoryAndBrandPicker picker = new CategoryAndBrandPicker();

            // Nếu đang ở chế độ sửa đổi thì lấy danh mục và thương hiệu đã chọn
            if (categoryId > 0)
            {
                picker.SetSelectedCategory(new CategoryBuilder().SetId(categoryId).Build());
                picker.SetSelectedBrand(new BrandBuilder().SetId(brandId).Build());
            }

            // Hiện form chọn danh mục và thương hiệu
            picker.ShowDialog();

            // Lấy danh mục và thương hiệu đã chọn
            CategoryDTO selectedCategory = picker.GetSelectedCategory();
            BrandDTO selectedBrand = picker.GetSelectedBrand();

            // Nếu có cả danh mục và thương hiệu được chọn thì thoát
            if (selectedBrand != null)
            {
                EmbedControl embed = EmbedControl.GetEmbedControl(this);
                embed.SetLoading("Đang tải ảnh");

                List<Task> tasks = new List<Task>();

                // Cập nhật ảnh danh mục nếu có thay đổi
                if (categoryId != selectedCategory.Id)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        picCategory.Image = Image.FromStream(await
                            DriveHandler.DownloadFilesFromDrive(selectedCategory.Image40));
                    }));
                    lblCategory.Text = selectedCategory.Name;
                    categoryId = selectedCategory.Id;
                }

                // Cập nhật ảnh thương hiệu nếu có thay đổi
                if (brandId != selectedBrand.Id)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        picBrand.Image = Image.FromStream(await
                            DriveHandler.DownloadFilesFromDrive(selectedBrand.Image40));
                    }));
                    lblBrand.Text = selectedBrand.Name;
                    brandId = selectedBrand.Id;
                }

                await Task.WhenAll(tasks);
                embed.RemoveLoading();
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (categoryId == 0)
            {
                MySystem.ShowToastMessageAtTopRight("Vui lòng chọn danh mục sản phẩm trước khi lưu thông số mẫu.", CustomControls.ToastBox.enmType.Warning);
                return;
            }
            String json = JsonConvert.SerializeObject(specManager.Value);
            RedisHandler.StoreSpecForProductCategory(categoryId.ToString(), json);
        }

        private void btnPullTemplate_Click(object sender, EventArgs e)
        {
            if (categoryId == 0)
            {
                MySystem.ShowToastMessageAtTopRight("Vui lòng chọn danh mục sản phẩm trước khi lấy thông số mẫu.", CustomControls.ToastBox.enmType.Warning);
                return;
            }
            String json = RedisHandler.GetSpecForProductCategory(categoryId.ToString());
            if (json == null)
            {
                MySystem.ShowToastMessageAtTopRight("Không tìm thấy thông số cho loại sản phẩm này trên hệ thống.", CustomControls.ToastBox.enmType.Error);
                return;
            }
            specManager.Value = JsonConvert
                .DeserializeObject<Dictionary<string,string>>(json);
        }

        private void btnExportSpec_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Xuất thông số kỹ thuật"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                StringBuilder builder = new StringBuilder();
                foreach (var item in specManager.Value)
                {
                    builder.AppendLine($"{item.Key}: {item.Value}");
                }
                File.WriteAllText(filePath, builder.ToString());
                MessageBox.Show("Xuất thông số thành công!");
            }
        }

        private void btnBatchImportSpec_Click(object sender, EventArgs e)
        {
            string placeholder = $"Nhập thông số kỹ thuật, mỗi dòng là một thông số, từ khóa thông số và giá trị cách nhau bởi dấu hai chấm. \n" +
                $"Ví dụ: \"Màn hình: 15.6 inch FHD 144Hz\".";
            BatchImportForm batchImport = new BatchImportForm(placeholder);
            batchImport.ShowDialog();
            string[] lines = batchImport.GetValueAsLines();
            Dictionary<string, string> spec = new Dictionary<string, string>();
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, 2);
                if (parts.Length == 2 && !spec.ContainsKey(parts[0].Trim()))
                {
                    spec.Add(parts[0].Trim(), parts[1].Trim());
                }
            }
            if (spec.Count > 0)
            {
                specManager.Value = spec;
                MySystem.ShowToastMessageAtTopRight("Nhập thông số thành công!");
            }
        }

        private void btnExportVariants_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Xuất danh sách biến thể"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                StringBuilder builder = new StringBuilder();
                foreach (var item in variantManager.Value)
                {
                    builder.AppendLine($"{item.Label}:{item.Description}:{item.Price}:{item.StockQuantity}");
                }
                File.WriteAllText(filePath, builder.ToString());
                MySystem.ShowToastMessageAtTopRight("Xuất danh sách biến thể thành công!");
            }
        }

        private void btnImportVariants_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Nhập danh sách biến thể"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string[] lines = File.ReadAllLines(filePath);
                var list = new List<ProductVariantDTO>();
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ':' }, 4);
                    if (parts.Length == 4)
                    {
                        short stockQuantity;
                        int price;
                        if (short.TryParse(parts[3].Trim(), out stockQuantity) && 
                            int.TryParse(parts[2].Trim(), out price))
                        {
                            list.Add(new ProductVariantBuilder().Default()
                            .SetLabel(parts[0].Trim())
                            .SetDescription(parts[1].Trim())
                            .SetPrice(price)
                            .SetStockQuantity(stockQuantity).Build());
                        }
                    }
                }
                variantManager.Value = list;
                MySystem.ShowToastMessageAtTopRight("Nhập danh sách biến thể thành công!");
            }
        }

        private void btnBatchImportVariants_Click(object sender, EventArgs e)
        {
            string placeholder = $"Nhập danh sách các biến thể sản phẩm, mỗi dòng là một biến thể. Định dạng (lúc nhập không bao gồm các dấu ngoặc): \n" +
                $"[Nhãn biến thể]:[Mô tả biến thể]:[Giá tiền]:[Lượng hàng trong kho]";
            var importForm = new BatchImportForm(placeholder);
            importForm.ShowDialog();
            string[] lines = importForm.GetValueAsLines();
            var list = new List<ProductVariantDTO>();
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, 4);
                if (parts.Length == 4)
                {
                    short stockQuantity;
                    int price;
                    if (short.TryParse(parts[3].Trim(), out stockQuantity) &&
                        int.TryParse(parts[2].Trim(), out price))
                    {
                        list.Add(new ProductVariantBuilder().Default()
                        .SetLabel(parts[0].Trim())
                        .SetDescription(parts[1].Trim())
                        .SetPrice(price)
                        .SetStockQuantity(stockQuantity).Build());
                    }
                }
            }
            variantManager.Value = list;
            MySystem.ShowToastMessageAtTopRight("Nhập danh sách biến thể thành công!");
        }

        private void btnImportSpec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Nhập thông số kỹ thuật"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string[] lines = File.ReadAllLines(filePath);
                Dictionary<string, string> spec = new Dictionary<string, string>();
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ':' }, 2);
                    if (parts.Length == 2 && !spec.ContainsKey(parts[0].Trim()))
                    {
                        spec.Add(parts[0].Trim(), parts[1].Trim());
                    }
                }
                specManager.Value = spec;
                MySystem.ShowToastMessageAtTopRight("Nhập thông số thành công!");
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            // Kiểm tra tính hợp lệ của các trường nhập liệu
            bool validateResult = ValidateData();
            if (!validateResult)
            {
                lblErrTotal.Text = "Có lỗi, vui lòng kiểm tra bên trên";
                return;
            }
            lblErrTotal.Text = "";

            if (isEditMode)
            {
                // Cập nhật sản phẩm
                EditProduct();
            }
            else
            {
                // Tạo sản phẩm mới
                AddProduct();
            }
        }

        #endregion
    }
}
