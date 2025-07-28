using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Singleton;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.TemplateMethod
{
    public class AddProductOperation : ProductOperationBase
    {
        private List<Image> imagesToUpload;

        public AddProductOperation(
            Control control,
            ImagePanelPicker imagePicker, 
            AdvancedTextBox nameTextBox, 
            long categoryId, 
            long brandId,
            ToggleButton warrantyToggle, 
            AdvancedTextBox warrantyTextBox, 
            AdvancedTextBox descriptionTextBox,
            SpecificationManager specificationManager, 
            ProductVariantsManagerControl variantMgr,
            ProductDAO prodDAO, 
            ProductVariantDAO prodVariantDAO)
            : base(control, imagePicker, nameTextBox, categoryId, brandId, warrantyToggle, warrantyTextBox, descriptionTextBox, specificationManager, variantMgr, prodDAO, prodVariantDAO)
        { }

        protected override string GetOperationTitle() => "Tạo sản phẩm";
        protected override string GetProductDatabaseActionDescription() => "Thêm sản phẩm vào CSDL";
        protected override string GetFinalLogMessage() => "Đã hoàn tất thêm sản phẩm vào hệ thống...";

        protected override Task GatherImageDataAsync(string initialSelectedImageId)
        {
            imagesToUpload = imgPicker.GetImages();
            return Task.CompletedTask;
        }

        protected override async Task ProcessImagesAsync()
        {
            List<Task<string>> uploadTasks = new List<Task<string>>();
            foreach (Image image in imagesToUpload)
            {
                Image currentImage = image;
                uploadTasks.Add(Task.Run(async () =>
                {
                    string imageIdShort = currentImage.Tag?.ToString().Substring(0, 4) ?? "???"; // Điều hướng an toàn
                    taskMng.AddLog(2, $"Đang tải ảnh {imageIdShort}...");
                    // Dùng DriveHandler để tải ảnh lên Google Drive
                    string id = await DriveHandler.UploadImageToDriveWithinTag(currentImage);
                    taskMng.AddLog(2, $"Đã hoàn tất tải ảnh {imageIdShort}.");
                    return id; // => "tempTag|driveId"
                }));
            }

            // Chờ tất cả các tác vụ tải ảnh hoàn tất
            string[] uploadedIds = await Task.WhenAll(uploadTasks);

            // Xử lý các ID đã tải lên
            foreach (var id in uploadedIds)
            {
                if (id != null)
                {
                    string[] split = id.Split('|');
                    if (split.Length == 2)
                    {
                        processedImageIds[split[0]] = split[1]; // key=tempTag, value=driveId
                    }
                }
            }
        }

        protected override ProductDTO BuildProductDTO()
        {
            return new ProductBuilder()
                .Default()
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
            return await Task.Run(() => productDAO.Add(product));
        }

        protected override async Task ProcessProductVariantsAsync()
        {
            if (resultingProduct == null || resultingProduct.Id == 0)
            {
                taskMng.AddLog(5, "Lỗi: Không thể thêm biến thể do ID sản phẩm không hợp lệ.");
                Logger.Instance.LogError("ADD PRODUCT OPERATION - Không thể thêm biến thể do ID sản phẩm không hợp lệ.");
                return;
            }

            foreach (var variant in variantManager.Value)
            {
                taskMng.AddLog(5, $"Đang thêm biến thể {variant.Label}...");
                variant.ProductId = resultingProduct.Id;
                variant.DiscountPrice = variant.Price;
                await Task.Run(() => variantDAO.Add(variant));
            }
            taskMng.AddLog(5, "Đã hoàn tất thêm biến thể sản phẩm...");
        }

        protected override string GetDoneNotifyMessage()
        {
            return "Thêm sản phẩm hoàn tất!";
        }
    }
}