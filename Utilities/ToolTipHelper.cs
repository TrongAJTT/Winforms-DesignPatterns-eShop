using System.Windows.Forms;

namespace _3S_eShop.Utilities
{
    /// <summary>
    /// Lớp trợ giúp cho việc tạo và cấu hình ToolTip (Chú giải công cụ).
    /// </summary>
    internal class ToolTipHelper
    {
        /// <summary>
        /// Hàm tĩnh dùng để tạo một ToolTip mới với các thông số phổ biến cụ thể.
        /// </summary>
        /// <param name="title">Tiêu đề của tooltip</param>
        /// <param name="toolTipIcon">Biểu tượng hiển thị bên cạnh tooltip</param>
        /// <param name="autoPopDelay">Thời gian hiển thị của tooltip</param>
        /// <param name="initialDelay">Thời gian chờ hiển thị tooltip khi hover control</param>
        /// <param name="reshowDelay">Thời gian chờ hiển thị lại sau khi tooltip biến mất</param>
        /// <param name="showAlways">Hiển thị ngay cả khi điều khiển không có tiêu điểm</param>
        /// <returns></returns>
        public static ToolTip CreateNew(
                string title = "",
                ToolTipIcon toolTipIcon = ToolTipIcon.None,
                int autoPopDelay = 90000,
                int initialDelay = 500,
                int reshowDelay = 500,
                bool showAlways = false)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipTitle = title;
            toolTip.ToolTipIcon = toolTipIcon;
            toolTip.AutoPopDelay = autoPopDelay;
            toolTip.InitialDelay = initialDelay;
            toolTip.ReshowDelay = reshowDelay;
            toolTip.ShowAlways = showAlways;
            return toolTip;
        }


        /// <summary>
        /// Hàm tĩnh dùng để thêm một chú giải công cụ vào một Control cụ thể, chỉ có tiêu đề, không có icon, thời gian hiện 90 giây.
        /// </summary>
        /// <param name="control">Control được thêm toolTip</param>
        /// <param name="caption">Nội dung của toolTip</param>
        public static void AppendToControl(Control control, string caption)
        {
            CreateNew().SetToolTip(control, caption);
        }


        /// <summary>
        /// Hàm tĩnh dùng để thêm một chú giải công cụ vào một Control cụ thể với các thông số phổ biến cụ thể.
        /// </summary>
        /// <param name="control">Control được thêm tooltip</param>
        /// <param name="caption">Nội dung của tooltip</param>
        /// <param name="title">Tiêu đề của tooltip</param>
        /// <param name="toolTipIcon">Biểu tượng hiển thị bên cạnh tooltip</param>
        /// <param name="autoPopDelay">Thời gian hiển thị của tooltip</param>
        /// <param name="initialDelay">Thời gian chờ hiển thị tooltip khi hover control</param>
        /// <param name="reshowDelay">Thời gian chờ hiển thị lại sau khi tooltip biến mất</param>
        /// <param name="showAlways">Hiển thị ngay cả khi điều khiển không có tiêu điểm</param>
        public static void AppendToControl(
            Control control,
            string caption,
            string title = "",
            ToolTipIcon toolTipIcon = ToolTipIcon.None,
            int autoPopDelay = 90000,
            int initialDelay = 500,
            int reshowDelay = 500,
            bool showAlways = false)
        {
            CreateNew(title, toolTipIcon, autoPopDelay, initialDelay, reshowDelay, showAlways).SetToolTip(control, caption);
        }
    }
}
