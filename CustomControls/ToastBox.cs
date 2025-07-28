using _3S_eShop.Properties;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace _3S_eShop.CustomControls
{
    /// <summary>
    /// Lớp ToastBox dùng để hiển thị thông báo ngắn gọn và tạm thời.
    /// </summary>
    public partial class ToastBox : Form
    {
        private static int ORIGIONAL_TEXT_WIDTH = 124;
        private int spacingBetween = 15;
        private Margins margin = new Margins(15, 15, 15, 15);
        private Position position;
        private int max_alert, timeMs;
        private enmAction action;
        private int x, y;

        /// <summary>
        /// ToastBox dùng để hiển thị thông báo ngắn gọn và tạm thời.
        /// </summary>
        /// <param name="max_alert">Số thông báo có thể hiển thị cùng lúc tối đa</param>
        /// <param name="position">Vị trí hiển thị đầu tiên, mặc định là góc phải dưới</param>
        /// <param name="timeMs">Thời gian hiển thị, mặc định 3 giây</param>
        public ToastBox(int max_alert = 1, Position position = Position.BottomRight, int timeMs = 3000)
        {
            InitializeComponent();
            this.max_alert = max_alert+1;
            this.position = position;
            this.timeMs = timeMs;
        }

        public enum enmAction { wait, start, close }
        public enum Position { TopLeft, TopRight, BottomLeft, BottomRight }
        public enum enmType { Success, Warning, Error, Info }

        /// <summary>
        /// Thiết lập margin của ToastBox.
        /// </summary>
        /// <param name="margin">Mặc định là: left-right-top-bottom: 15px. Lưu ý: Margin sẽ được áp dụng tương ứng với Position.</param>
        public void SetMargin(Margins margin)
        {
            this.margin = margin;
        }

        /// <summary>
        /// Thiết lập khoảng cách chiều dọc giữa các ToastBox
        /// </summary>
        /// <param name="spacing">Khoảng cách giữa các ToastBox (mặc định là 15px)</param>
        public void SetSpacing(int spacing)
        {
            spacingBetween = spacing;
        }

        /// <summary>
        /// Hiện ToastBox với nội dung và loại thông báo cụ thể.
        /// </summary>
        /// <param name="msg">Nội dung thông báo</param>
        /// <param name="type">Loại thông báo</param>
        public void ShowToast(string msg, enmType type)
        {
            // Đếm số lượng AlertBox hiện tại
            int currentAlertCount = 0;
            for (int i = 1; i <= max_alert; i++)
            {
                string fname = "alert" + i.ToString();
                ToastBox frm = (ToastBox)Application.OpenForms[fname];

                if (frm != null)
                {
                    currentAlertCount++;
                }
            }

            // Kiểm tra xem số lượng AlertBox hiện tại có vượt quá max_alert không
            if (currentAlertCount >= max_alert-1)
            {
                return; // Không hiển thị Alert mới nếu đã đạt giới hạn
            }

            // Cập nhật nội dung và trạng thái ban đầu
            this.lblMsg.Text = msg;
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            // Điều chỉnh kích thước Form nếu cần
            if (lblMsg.Width > ORIGIONAL_TEXT_WIDTH)
            {
                int diff = lblMsg.Width - ORIGIONAL_TEXT_WIDTH;
                this.Width += diff;
            }

            // Xác định vị trí hiển thị của Alert Dialog
            for (int i = 1; i < max_alert; i++)
            {
                string fname = "alert" + i.ToString();
                ToastBox frm = (ToastBox)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    if (position == Position.TopLeft)
                    {
                        this.x = margin.Left;
                        this.y = this.Height * (i == 1 ? 0 : i - 1) + spacingBetween * (i == 1 ? 0 : i - 1) + margin.Top;
                    }
                    else if (position == Position.TopRight)
                    {
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - margin.Right;
                        this.y = this.Height * (i==1 ? 0 : i-1) + spacingBetween * (i == 1 ? 0 : i - 1) + margin.Top;
                    }
                    else if (position == Position.BottomLeft)
                    {
                        this.x = margin.Left;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - spacingBetween * i - margin.Bottom;
                    }
                    else // BottomRight
                    {
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - margin.Right;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - spacingBetween * i - margin.Bottom;
                    }
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            // Cập nhật hình ảnh và màu nền dựa trên loại thông báo
            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Properties.Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Properties.Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Properties.Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Properties.Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            // Hiển thị Alert Dialog
            this.Show();
            this.TopMost = true;
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = timeMs;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
