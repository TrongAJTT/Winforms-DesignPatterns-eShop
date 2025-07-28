using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Flyweight
{
    public class ProductFlyweight : IProductFlyweight
    {
        // Trạng thái chia sẻ chung (Intrint State) giữa nhiều đối tượng Card Product
        public long ProductId { get; private set; }
        public string Name { get; private set; }
        public Image ThumbImage { get; private set; }

        // Constructor khởi tạo thông qua Factory
        public ProductFlyweight(long productId, string name, Image thumbImage)
        {
            ProductId = productId;
            Name = name;
            ThumbImage = thumbImage;
        }

        // Phương thức factorty tĩnh, áp dụng logic khởi tạo đơn giãn
        // Có thể dời qua một lớp Factory riêng
        public static async Task<ProductFlyweight> CreateAsync(long productId, ProductDTO productData)
        {
            if (productData == null || productData.Id != productId)
            {
                // Tốt nhất là tải productData ở đây nếu không được cung cấp, nhưng để đơn giản, hãy giả sử nó được truyền vào
                // Đối với một factory thực sự, logic này sẽ nằm bên trong phương thức GetFlyweight của nhà máy.
                Logger.Instance.LogError($"PRODUCT FLYWEIGHT - Dữ liệu sản phẩm không đủ hoặc không khớp với Id: {productId}");
                throw new ArgumentException("Product data is required and must match the productId.");
            }

            Image thumb = null;
            if (!string.IsNullOrEmpty(productData.Thumb))
            {
                try
                {
                    // Chỉ tải hình ảnh CHỈ MỘT LẦN cho mỗi productId tại đây
                    thumb = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(productData.Thumb));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image for product {productId}: {ex.Message}");
                    Logger.Instance.LogErrorException(ex, $"PRODUCT FLYWEIGHT - Lỗi tải ảnh cho sản phẩm {productId}"); // Ghi log lỗi
                    // Ảnh placeholder mặc định
                    thumb = Properties.Resources.product_not_found;
                }
            }
            else
            {
                thumb = Properties.Resources.product_not_found;
            }


            return new ProductFlyweight(productId, productData.Name, thumb);
        }

        // Triển khai IDisposable nếu Image cần kiểm soát xử lý rõ ràng, nhưng thông thường Factory sẽ quản lý vòng đời.
    }

}