using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ChatMessageControl: UserControl
    {
        private bool isFromMe;

        public ChatMessageControl()
        {
            InitializeComponent();
            InitializeUI();
        }

        public ChatMessageControl(MessageDTO messageInfo) : this()
        {
            SetData(messageInfo);
        }

        private void InitializeUI()
        {
            // Thiết lập kích thước tối đa cho lblMessage
            var size = lblMessage.MaximumSize;
            size.Width = 400;
            lblMessage.MaximumSize = size;
            // Thiết lập kích thước tối thiểu cho control
            size = this.MinimumSize;
            size.Width = 500;
            this.MinimumSize = size;
        }

        [Category("Advanced Settings")]
        [Description("Nội dung tin nhắn hiển thị trong đoạn chat.")]
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        [Category("Advanced Settings")]
        [Description("Tin nhắn có phải đến từ admin không (hay người dùng).")]
        public bool IsFromMe
        {
            get => isFromMe;
            set
            {
                isFromMe = value;
                if (!isFromMe)
                {
                    flowContainer.FlowDirection = FlowDirection.LeftToRight;
                    lblMessage.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Black;
                }
                else
                {
                    flowContainer.FlowDirection = FlowDirection.RightToLeft;
                    lblMessage.BackColor = Color.FromArgb(120, 170, 255);
                    lblMessage.ForeColor = Color.White;
                }
            }
        }

        public void SetWidth(int width)
        {
            // Thiết lập kích thước tối đa cho lblMessage
            var size = lblMessage.MaximumSize;
            size.Width = width - 100;
            lblMessage.MaximumSize = size;
            // Thiết lập kích thước tối thiểu cho control
            size = this.MinimumSize;
            size.Width = width;
            this.MinimumSize = size;
        }

        private void SetData(MessageDTO messageInfo)
        {
            Message = messageInfo.Content;
            IsFromMe = messageInfo.UserId == MainForm.User.Id;
            string sendDate = messageInfo.SendDate.Date == DateTime.Today ? messageInfo.SendDate.ToString("HH:mm") : messageInfo.SendDate.ToString("dd/MM/yyyy HH:mm");
            ToolTipHelper.AppendToControl(lblMessage, $"Được gửi vào {sendDate}");
        }

        private void tsmiChatCopy_Click(object sender, EventArgs e)
        {
            // Sao chép vào clipboard
            try
            {
                Clipboard.SetText(lblMessage.Text, TextDataFormat.UnicodeText);
            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, "Lỗi khi cố sao chép văn bản");
            }
        }
    }
}
