using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.TemplateMethod
{
    public abstract class ProductOperationBase
    {
        // --- Property phụ thuộc ---
        private readonly Control control;
        protected readonly ImagePanelPicker imgPicker;
        protected readonly AdvancedTextBox txtName;
        protected readonly long categoryId;
        protected readonly long brandId;
        protected readonly ToggleButton toggleWarrantyLifetime;
        protected readonly AdvancedTextBox txtWarranty;
        protected readonly AdvancedTextBox txtDescription;
        protected readonly SpecificationManager specManager;
        protected readonly ProductVariantsManagerControl variantManager;
        protected readonly ProductDAO productDAO;
        protected readonly ProductVariantDAO variantDAO;

        // --- Internal State ---
        protected TaskManager taskMng;
        private TaskProgressWatcher taskProgressWatcher;
        protected SortedList<string, string> processedImageIds = new SortedList<string, string>();
        protected string selectedThumbId;
        protected ProductDTO resultingProduct; // Lưu sản phẩm sau Add/Update

        protected ProductOperationBase(
            Control control,
            ImagePanelPicker imagePicker,
            AdvancedTextBox nameTextBox,
            long catId,
            long brdId,
            ToggleButton warrantyToggle,
            AdvancedTextBox warrantyTextBox,
            AdvancedTextBox descriptionTextBox,
            SpecificationManager specificationManager,
            ProductVariantsManagerControl variantMgr,
            ProductDAO prodDAO,
            ProductVariantDAO prodVariantDAO)
        {
            this.control = control;
            this.imgPicker = imagePicker;
            this.txtName = nameTextBox;
            this.categoryId = catId;
            this.brandId = brdId;
            this.toggleWarrantyLifetime = warrantyToggle;
            this.txtWarranty = warrantyTextBox;
            this.txtDescription = descriptionTextBox;
            this.specManager = specificationManager;
            this.variantManager = variantMgr;
            this.productDAO = prodDAO;
            this.variantDAO = prodVariantDAO;
        }

        // --- The Template Method ---
        public async Task ExecuteAsync()
        {
            // 0. Thiết lập Task Manager
            InitializeTaskManager();
            taskProgressWatcher = new TaskProgressWatcher(taskMng, true);
            taskProgressWatcher.Show();

            // Thoát khỏi Control thêm sửa sản phẩm khi thoát Form
            taskProgressWatcher.FormClosing += (s, e) =>
            {
                control.SafeInvoke(() =>
                {
                    taskMng?.Dispose();
                    taskProgressWatcher?.Dispose();
                    EmbedControl.TryClose(control);
                });
            };

            try
            {
                // 1. Xử lý thông tin đầu vào (Bước chung)
                taskMng.StartTask(1);
                taskMng.AddLog(1, "Đang xử lý thông tin sản phẩm...");
                string initialSelectedImageId = GetInitialSelectedImageId();
                // Lấy dữ liệu ảnh do các lớp con xử lý
                await GatherImageDataAsync(initialSelectedImageId);
                taskMng.CompleteTask(1);

                // 2. Xử lý ảnh (Bước riêng, logic thêm/sửa khác nhau)
                taskMng.StartTask(2);
                taskMng.AddLog(2, "Tiến hành xử lý hình ảnh...");
                await ProcessImagesAsync(); // Gọi hàm abstract
                taskMng.CompleteTask(2);

                // 3. Chuẩn bị dữ liệu sản phẩm (Abstract một phần - logic xây dựng thì giống nhau nhưng xử lý ID thì khác nhau)
                taskMng.StartTask(3);
                taskMng.AddLog(3, "Đang xử lý thông tin sản phẩm...");
                DetermineThumbnail(initialSelectedImageId);
                taskMng.AddLog(3, "Đang tạo dữ liệu sản phẩm...");
                ProductDTO productToProcess = BuildProductDTO(); // Gọi hàm abstract
                taskMng.CompleteTask(3);

                // 4. Thao tác với CSDL (Bước abstract - Thêm và sửa)
                taskMng.StartTask(4);
                taskMng.AddLog(4, "Đang tải sản phẩm lên hệ thống...");
                resultingProduct = await PerformProductDatabaseActionAsync(productToProcess); // Gọi hàm abstract
                taskMng.CompleteTask(4);

                // 5. Xử lý biến thể sản phẩm (Bước abstract - Thêm vs Thêm/Sửa/Xóa)
                taskMng.StartTask(5);
                taskMng.AddLog(5, "Đang xử lý biến thể sản phẩm...");
                await ProcessProductVariantsAsync(); // Gọi hàm abstract
                taskMng.AddLog(5, GetFinalLogMessage()); // Gọi hàm abstract
                taskMng.CompleteTask(5);

                // Xử lý bước cuối cùng và thông báo hoàn tất
                MySystem.ShowToastMessageAtTopRight(GetDoneNotifyMessage());
            }
            catch (Exception ex)
            {
                // Xử lý lỗi logic
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Instance.LogErrorException(ex, "Lỗi trong quá trình thực hiện thao tác sản phẩm");
                taskMng?.AddLog(-1, $"Lỗi: {ex.Message}"); 
                //
                taskProgressWatcher.EnableExit();
            }
        }

        // --- Helper and Abstract/Virtual Methods ---

        protected virtual void InitializeTaskManager()
        {
            taskMng = new TaskManager(GetOperationTitle());
            taskProgressWatcher = new TaskProgressWatcher(taskMng, true);
            taskMng.RegisterTask(1, "Xử lý thông tin");
            taskMng.RegisterTask(2, "Xử lý hình ảnh");
            taskMng.RegisterTask(3, "Tạo dữ liệu sản phẩm");
            taskMng.RegisterTask(4, GetProductDatabaseActionDescription());
            taskMng.RegisterTask(5, "Xử lý biến thể sản phẩm");
        }

        protected virtual string GetInitialSelectedImageId()
        {
            return imgPicker.SelectecPicture?.Tag as string;
        }

        protected virtual void DetermineThumbnail(string initialSelectedImageId)
        {
            bool containKey = !string.IsNullOrEmpty(initialSelectedImageId) && processedImageIds.ContainsKey(initialSelectedImageId);
            selectedThumbId = containKey ? processedImageIds[initialSelectedImageId] : (processedImageIds.Count > 0 ? processedImageIds.Values[0] : null);
        }

        // --- Abstract methods to be implemented by subclasses ---

        /// <summary>
        /// Gets the title for the TaskManager.
        /// </summary>
        protected abstract string GetOperationTitle();

        /// <summary>
        /// Gets the description for the main product database action (Task 4).
        /// </summary>
        protected abstract string GetProductDatabaseActionDescription();

        /// <summary>
        /// Gathers specific image data needed (e.g., added/deleted lists for edit).
        /// Called within Step 1.
        /// </summary>
        protected abstract Task GatherImageDataAsync(string initialSelectedImageId);

        /// <summary>
        /// Handles the actual image processing (uploading, deleting, replacing).
        /// Populates the `processedImageIds` list. Called within Step 2.
        /// </summary>
        protected abstract Task ProcessImagesAsync();

        /// <summary>
        /// Builds the ProductDTO object using the builder pattern. Handles setting ID for updates.
        /// Called within Step 3.
        /// </summary>
        protected abstract ProductDTO BuildProductDTO();

        /// <summary>
        /// Performs the core database operation (Add or Update) for the main product.
        /// Called within Step 4.
        /// </summary>
        protected abstract Task<ProductDTO> PerformProductDatabaseActionAsync(ProductDTO product);

        /// <summary>
        /// Processes product variants (Add for new products, Add/Update/Delete for existing).
        /// Needs the `resultingProduct.Id`. Called within Step 5.
        /// </summary>
        protected abstract Task ProcessProductVariantsAsync();

        /// <summary>
        /// Gets the final log message after processing variants (Task 5).
        /// </summary>
        protected abstract string GetFinalLogMessage();

        /// <summary>
        /// Gets the message to notify the user when the operation is done.
        /// </summary>
        protected abstract string GetDoneNotifyMessage();

    }

}
