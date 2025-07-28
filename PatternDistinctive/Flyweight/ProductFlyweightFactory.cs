using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL.DAOs;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using _3S_eShop.PatternDistinctive.Singleton;

namespace _3S_eShop.PatternDistinctive.Flyweight
{
    public class ProductFlyweightFactory
    {
        // Nhóm flyweight (pool), được khóa bằng ProductId.
        // ConcurrentDictionary để đảm bảo an toàn cho luồng.
        private readonly ConcurrentDictionary<long, IProductFlyweight> _flyweights = new ConcurrentDictionary<long, IProductFlyweight>();

        // Sử dụng SemaphoreSlim để khóa bất đồng bộ nhằm ngăn chặn nhiều luồng tải cùng một sản phẩm cùng lúc
        private readonly ConcurrentDictionary<long, SemaphoreSlim> _locks = new ConcurrentDictionary<long, SemaphoreSlim>();

        // Truy cập dữ liệu (Thông qua Singleton hoặc Dependency Injection)
        // Những điều này lý tưởng nhất sẽ được inject thông qua hàm khởi tạo
        private readonly ProductVariantDAO _varDao = new ProductVariantDAO();
        private readonly ProductVariantBLL _varBll = new ProductVariantBLL(new ProductVariantDAO());

        // Áp dụng Singleton.
        // Để phù hợp cho việc testing, nên dùng Dependency Injection.
        private static readonly Lazy<ProductFlyweightFactory> _instance =
            new Lazy<ProductFlyweightFactory>(() => new ProductFlyweightFactory());

        public static ProductFlyweightFactory Instance => _instance.Value;

        private ProductFlyweightFactory() { } // Hàm khởi tạo private cho Singleton.

        public async Task<IProductFlyweight> GetFlyweightAsync(long productId)
        {
            // Lấy dữ liệu thông qua Flyweight đã tồn tại
            if (_flyweights.TryGetValue(productId, out var flyweight))
            {
                return flyweight;
            }

            // Lấy hoặc thêm semaphore cho productId hiện tại
            var semaphore = _locks.GetOrAdd(productId, k => new SemaphoreSlim(1, 1));

            // Chờ bất đồng bộ để thả khóa cho productId hiện tại.
            await semaphore.WaitAsync();
            try
            {
                // Double-check nếu có một luồng khác được tạo tại thời điểm chờ
                if (_flyweights.TryGetValue(productId, out flyweight))
                {
                    return flyweight;
                }

                // --- Nếu không tìm thấy Flyweight, ta cần khởi tạo nó ---

                // 1. Tải dữ liệu từ ProductDTO gốc (Name, Thumb ID, etc.)
                ProductDAO productDao = new ProductDAO();
                ProductDTO baseProductData = productDao.GetById(productId);

                if (baseProductData == null)
                {
                    // Xử lý trường hợp không tìm thấy sản phẩm gốc
                    Console.WriteLine($"Base product with ID {productId} not found.");
                    // Tạo một placeholder Flyweight và trả về
                    var placeholder = new ProductFlyweight(productId, "Product Not Found", Properties.Resources.no_data_found);
                    _flyweights.TryAdd(productId, placeholder); // Thêm placeholder để ngăn việc tải lại sau này.
                    return placeholder;
                }

                // 2. Tải ảnh thật (bất đồng bộ)
                Image thumbImage = null;
                if (!string.IsNullOrEmpty(baseProductData.Thumb))
                {
                    try
                    {
                        thumbImage = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(baseProductData.Thumb));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi tải ảnh cho sản phảm {productId}: {ex.Message}");
                        Logger.Instance.LogErrorException(ex, $"PRODUCT FLYWEIGHT - Lỗi tải ảnh cho sản phẩm {productId}");
                        thumbImage = Properties.Resources.no_data_found;
                    }
                }
                else
                {
                    thumbImage = Properties.Resources.no_data_found; // Placeholder
                }


                // 3. Create the new Concrete Flyweight
                flyweight = new ProductFlyweight(productId, baseProductData.Name, thumbImage); // Use the internal constructor


                // 4. Thêm vào pool (dùng TryAdd cho an toàn, mặc dù lock sẽ ngăn chặn Race Condition)
                _flyweights.TryAdd(productId, flyweight);

                return flyweight;
            }
            finally
            {
                // Thả khóa cho productId hiện tại
                semaphore.Release();
            }
        }

        // Hàm gọi để dọp dẹp bộ nhớ nếu cần
        public void ClearCache()
        {
            foreach (var kvp in _flyweights)
            {
                kvp.Value.ThumbImage?.Dispose();
            }
            _flyweights.Clear();
            _locks.Clear();
        }

        // Có thể thêm phương pháp để loại bỏ tài nguyên một cách rõ ràng nếu ProductFlyweight triển khai IDisposable trong tương lai
        // public void DisposeImages() { ... loop and dispose ... }
    }


}
