using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Singleton;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.TemplateMethod
{
    public class EditProductOperation : ProductOperationBase
    {
        private readonly long productId;
        private List<Image> currentImages;
        private List<string> addedImageTags;
        private List<string> replacedImageTags;
        private List<string> deletedImageTags;
        private List<string> existingImageTags;

        public EditProductOperation(
            Control control,
            long prodId,
            ImagePanelPicker imagePicker, 
            AdvancedTextBox nameTextBox, 
            long catId, 
            long brdId,
            ToggleButton warrantyToggle, 
            AdvancedTextBox warrantyTextBox, 
            AdvancedTextBox descriptionTextBox,
            SpecificationManager specificationManager, 
            ProductVariantsManagerControl variantMgr,
            ProductDAO prodDAO, ProductVariantDAO prodVariantDAO)
            : base(control, imagePicker, nameTextBox, catId, brdId, warrantyToggle, warrantyTextBox, descriptionTextBox, specificationManager, variantMgr, prodDAO, prodVariantDAO)
        {
            productId = prodId;
        }

        protected override string GetOperationTitle() => "Sửa sản phẩm";
        protected override string GetProductDatabaseActionDescription() => "Cập nhật sản phẩm trong CSDL";
        protected override string GetFinalLogMessage() => "Hoàn tất sửa đổi thông tin sản phẩm...";

        protected override Task GatherImageDataAsync(string initialSelectedImageId)
        {
            // Lấy thông tin hình ảnh từ imgPicker
            currentImages = imgPicker.GetImages();
            addedImageTags = imgPicker.GetAddedImage();
            replacedImageTags = imgPicker.GetReplacedImage();
            deletedImageTags = imgPicker.GetDeletedImage();
            existingImageTags = new List<string>();

            // Xử lý trước danh sách để xử lý tình trạng chồng chéo.
            // Không thể vừa thêm vừa xóa hình ảnh, v.v. Điều chỉnh logic dựa trên hành vi của imgPicker.

            // Xác định hình ảnh ban đầu có sẵn và không được thêm vào, thay thế hoặc xóa
            var allModifiedTags = new HashSet<string>(addedImageTags.Concat(replacedImageTags).Concat(deletedImageTags));
            foreach (var img in currentImages)
            {
                string tag = img.Tag?.ToString();
                if (!string.IsNullOrEmpty(tag) && !allModifiedTags.Contains(tag))
                {
                    existingImageTags.Add(tag);
                }
            }

            return Task.CompletedTask;
        }

        protected override async Task ProcessImagesAsync()
        {
            List<Task<string>> imageTasks = new List<Task<string>>();
            Dictionary<string, string> tempTagToDriveIdMap = new Dictionary<string, string>();

            // 0. Thêm hình ảnh hiện có, chưa chỉnh sửa trực tiếp vào danh sách cuối cùng
            taskMng.AddLog(2, "Xác định ảnh không thay đổi...");
            foreach (string existingTag in existingImageTags)
            {
                processedImageIds[existingTag] = existingTag;
            }
            taskMng.AddLog(2, $"Tìm thấy {processedImageIds.Count} ảnh không thay đổi.");

            // 1. Tải lên hình ảnh MỚI (những hình ảnh trong addedImageTags)
            taskMng.AddLog(2, "Xử lý ảnh mới...");
            var imagesToUpload = currentImages.Where(img => addedImageTags.Contains(img.Tag?.ToString())).ToList();
            foreach (Image image in imagesToUpload)
            {
                Image currentImage = image;
                imageTasks.Add(Task.Run(async () =>
                {
                    string tempTag = currentImage.Tag?.ToString();
                    string imageIdShort = tempTag?.Substring(0, 4) ?? "???";
                    taskMng.AddLog(2, $"Đang tải ảnh mới {imageIdShort}...");
                    string idResult = await DriveHandler.UploadImageToDriveWithinTag(currentImage); // => "tempTag|driveId"
                    taskMng.AddLog(2, $"Đã hoàn tất tải ảnh mới {imageIdShort}.");
                    return idResult;
                }));
            }
            string[] uploadedIds = await Task.WhenAll(imageTasks);
            foreach (var idStr in uploadedIds)
            {
                if (idStr != null && idStr.Contains('|'))
                {
                    var parts = idStr.Split('|');
                    tempTagToDriveIdMap[parts[0]] = parts[1];
                    processedImageIds[parts[0]] = parts[1];
                }
            }
            imageTasks.Clear();


            // 2. Thay thế hình ảnh (Xóa hình ảnh cũ, Tải lên hình ảnh mới)
            taskMng.AddLog(2, "Xử lý sửa đổi ảnh...");
            var imagesToReplace = currentImages.Where(img => replacedImageTags.Contains(img.Tag?.ToString())).ToList();

            List<Task> deleteTasks = new List<Task>();
            foreach (string originalDriveIdToDelete in replacedImageTags)
            {
                // Chỉ xóa nếu đó không phải là thẻ tạm thời của hình ảnh mới được thêm vào
                if (!addedImageTags.Contains(originalDriveIdToDelete))
                {
                    deleteTasks.Add(Task.Run(() => {
                        taskMng.AddLog(2, $"Đang xóa ảnh cũ {originalDriveIdToDelete.Substring(0, 4)}...");
                        DriveHandler.DeleteFileFromDrive(originalDriveIdToDelete);
                        taskMng.AddLog(2, $"Đã xóa ảnh cũ {originalDriveIdToDelete.Substring(0, 4)}.");
                    }));
                }
            }
            await Task.WhenAll(deleteTasks); // Chờ xóa trước khi tải lên


            // Tải lên những hình ảnh *mới* thay thế những hình ảnh cũ
            foreach (Image image in imagesToReplace)
            {
                Image currentImage = image;
                imageTasks.Add(Task.Run(async () =>
                {
                    string tempTag = currentImage.Tag?.ToString();
                    string imageIdShort = tempTag?.Substring(0, 4) ?? "???";
                    taskMng.AddLog(2, $"Đang tải ảnh thay thế {imageIdShort}...");
                    string idResult = await DriveHandler.UploadImageToDriveWithinTag(currentImage);
                    taskMng.AddLog(2, $"Đã hoàn tất tải ảnh thay thế {imageIdShort}.");
                    return idResult; // Format: "tempTag|newDriveId"
                }));
            }
            string[] replacedUploadIds = await Task.WhenAll(imageTasks);
            foreach (var idStr in replacedUploadIds)
            {
                if (idStr != null && idStr.Contains('|'))
                {
                    var parts = idStr.Split('|');
                    tempTagToDriveIdMap[parts[0]] = parts[1]; // Map temp tag với new Drive ID
                    processedImageIds[parts[0]] = parts[1]; // Thêm vào final list
                }
            }
            imageTasks.Clear();


            // 3. Xóa ảnh
            taskMng.AddLog(2, "Xử lý xóa ảnh...");
            deleteTasks.Clear();
            foreach (string imageIdToDelete in deletedImageTags)
            {
                // Đảm bảo không cố xóa thẻ tạm thời của hình ảnh mới được thêm vào
                if (!addedImageTags.Contains(imageIdToDelete) && !replacedImageTags.Contains(imageIdToDelete))
                {
                    deleteTasks.Add(Task.Run(() => {
                        taskMng.AddLog(2, $"Đang xóa ảnh {imageIdToDelete.Substring(0, 4)}...");
                        DriveHandler.DeleteFileFromDrive(imageIdToDelete);
                        taskMng.AddLog(2, $"Đã xóa ảnh {imageIdToDelete.Substring(0, 4)}.");
                    }));
                }
            }
            await Task.WhenAll(deleteTasks);

            taskMng.AddLog(2, "Hoàn tất xử lý hình ảnh.");
        }


        protected override ProductDTO BuildProductDTO()
        {
            // Sử dụng các processedImageIds được ProcessImagesAsync điền vào
            // Phương thức DetermineThumbnail của lớp cơ sở đã thiết lập selectedThumbId
            return new ProductBuilder()
                .Default()
                .SetId(productId) // Đặt ID sản phẩm hiện tại để cập nhật
                .SetName(txtName.Texts)
                .SetCategoryId(categoryId)
                .SetBrandId(brandId)
                .SetWarranty(toggleWarrantyLifetime.Checked ? (byte)0 : byte.Parse(txtWarranty.Texts))
                .SetDescription(txtDescription.Texts)
                .SetThumb(selectedThumbId)
                .SetImages(processedImageIds.Values.ToArray())
                .SetSpecification(JsonConvert.SerializeObject(specManager.Value))
                .Build();
        }

        protected override async Task<ProductDTO> PerformProductDatabaseActionAsync(ProductDTO product)
        {
            await Task.Run(() => productDAO.Update(productId, product));
            return product;
        }

        protected override async Task ProcessProductVariantsAsync()
        {
            if (resultingProduct == null || resultingProduct.Id == 0)
            {
                taskMng.AddLog(5, "Lỗi: Không thể xử lý biến thể do ID sản phẩm không hợp lệ.");
                Logger.Instance.LogError("EDIT PRODUCT OPERATION - Không thể xử lý biến thể do ID sản phẩm không hợp lệ.");
                return;
            }

            // 1. Thêm hoặc cập nhật variant
            var currentVariantIds = new HashSet<long>();
            foreach (var newOrUpdatedVariant in variantManager.Value)
            {
                long idToInsert = -1;
                // Thêm variant
                if (newOrUpdatedVariant.Id == 0)
                {
                    taskMng.AddLog(5, $"Đang thêm biến thể {newOrUpdatedVariant.Label}...");
                    newOrUpdatedVariant.ProductId = resultingProduct.Id;
                    newOrUpdatedVariant.DiscountPrice = newOrUpdatedVariant.Price;
                    var uploaded = await Task.Run(() => variantDAO.Add(newOrUpdatedVariant));
                    idToInsert = uploaded.Id;
                }
                // Cập nhật thông tin variant
                else
                {
                    taskMng.AddLog(5, $"Đang sửa biến thể {newOrUpdatedVariant.Label}...");
                    newOrUpdatedVariant.ProductId = resultingProduct.Id;
                    await Task.Run(() => variantDAO.Update(newOrUpdatedVariant.Id, newOrUpdatedVariant));
                    idToInsert = newOrUpdatedVariant.Id;
                }
                // Thêm ID vào danh sách hiện tại
                currentVariantIds.Add(idToInsert);
            }

            // 2. Xóa variant không còn tồn tại trong danh sách hiện tại
            var existingVariants = await Task.Run(() => variantDAO.GetByProductId(resultingProduct.Id));
            foreach (var dbVariant in existingVariants)
            {
                if (!currentVariantIds.Contains(dbVariant.Id))
                {
                    taskMng.AddLog(5, $"Đang xóa biến thể {dbVariant.Label}...");
                    await Task.Run(() => variantDAO.Delete(dbVariant));
                }
            }
            taskMng.AddLog(5, "Đã hoàn tất xử lý biến thể sản phẩm...");
        }

        protected override string GetDoneNotifyMessage()
        {
            return "Sửa sản phẩm hoàn tất!";
        }
    }
}
