using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.Utilities
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Invoke một hành động an toàn trên một Control (đa luồng).
        /// </summary>
        /// <param name="control">Control cần invoke</param>
        /// <param name="action">Hành động cần thực hiện</param>
        public static void SafeInvoke(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// Invoke một hành động đổi nhãn an toàn trên một Control (đa luồng) với tham số.
        /// </summary>
        /// <param name="control">Control cần invoke</param>
        /// <param name="text">Tên mới cần được sửa</param>
        public static void SafeInvokeSetText(this Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Text = text));
            }
            else
            {
                control.Text = text;
            }
        }

        /// <summary>
        /// Invoke một hành động bật tắt an toàn trên một Control (đa luồng) với tham số.
        /// </summary>
        /// <param name="control">Control cần invoke bật tắt</param>
        /// <param name="enable">Giá trị bật tắt</param>
        public static void SafeInvokeEnable(this Control control, bool enable)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Enabled = enable));
            }
            else
            {
                control.Enabled = enable;
            }
        }

        /// <summary>
        /// Invoke một hành động ẩn hiện an toàn trên một Control (đa luồng) với tham số.
        /// </summary>
        /// <param name="control">Control cần invoke ẩn hiện</param>
        /// <param name="visible">Giá trị ẩn hiện</param>
        public static void SafeInvokeSetVisible(this Control control, bool visible)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Visible = visible));
            }
            else
            {
                control.Visible = visible;
            }
        }

        /// <summary>
        /// Invoke một hành động đổi hình ảnh an toàn trên một PictureBox (đa luồng).
        /// </summary>
        /// <param name="pictureBox">PictureBox cần invoke đổi hình ảnh</param>
        /// <param name="image">Hình ảnh mới cần truyền vào</param>
        public static void SafeInvokeSetImage(this PictureBox pictureBox, Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() => pictureBox.Image = image));
            }
            else
            {
                pictureBox.Image = image;
            }
        }

        /// <summary>
        /// /// Invoke một hành động đổi màu nền an toàn trên một Control (đa luồng).
        /// </summary>
        /// <param name="control">Control cần invoke đổi màu nền</param>
        /// <param name="color">Màu mới cần đổi</param>
        public static void SafeInvokeBackColor(this Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.BackColor = color));
            }
            else
            {
                control.BackColor = color;
            }
        }

        /// <summary>
        /// Invoke một hành động đổi màu chữ an toàn trên một Control (đa luồng).
        /// </summary>
        /// <param name="control">Control cần invoke đổi màu chữ</param>
        /// <param name="color">Màu mới cần đổi</param>
        public static void SafeInvokeForeColor(this Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.ForeColor = color));
            }
            else
            {
                control.ForeColor = color;
            }
        }

        /// <summary>
        /// Invoke một hành động hủy an toàn trên một Control (đa luồng).
        /// </summary>
        /// <param name="control">Control cần được hủy</param>
        public static void SafeInvokeDispose(this Control control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Dispose()));
            }
            else
            {
                control.Dispose();
            }
        }

        /// <summary>
        /// Tự động điều chỉnh chiều cao của ListView dựa trên chiều cao của các mục trong danh sách.
        /// </summary>
        /// <param name="control">ListView có thể sử dụng hàm này</param>
        public static void ResizeHeight(this ListView listView)
        {
            int itemHeight = listView.GetItemRect(0).Height; // Chiều cao của một dòng
            int totalHeight = itemHeight * (listView.Items.Count+1); // Tổng chiều cao

            // Thiết lập chiều cao cho ListView
            listView.Height = totalHeight + 10;
            // Thêm 10 pixel đệm
            listView.Invalidate(); // Cập nhật lại giao diện
        }

    }
}
