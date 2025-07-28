using System.Drawing;
using System;

namespace _3S_eShop.Utilities
{
    public class ImageHelper
    {
        /// <summary>
        /// Nén ảnh với kích thước mới
        /// </summary>
        /// <param name="image">Ảnh cần nén</param>
        /// <param name="width">Kích thước chiều ngang mới</param>
        /// <param name="height">Kích thước chiều cao mới</param>
        /// <returns>Ảnh đã được nén</returns>
        /// <exception cref="ArgumentNullException">Ném ngoại lệ khi ảnh bị null</exception>
        public static Image ResizeImage(Image image, int width, int height)
        {
            // Kiểm tra xem ảnh có hợp lệ không
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "Ảnh không được null.");
            }

            // Tạo một Bitmap mới với kích thước mong muốn
            Bitmap resizedImage = new Bitmap(width, height);

            // Sử dụng Graphics để vẽ ảnh đã nén
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // Thiết lập chế độ chất lượng cho việc vẽ
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Vẽ ảnh vào Bitmap mới
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

    }
}
