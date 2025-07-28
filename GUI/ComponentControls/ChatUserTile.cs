using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.BLL;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ChatUserTile: UserControl
    {
        private CustomerChatDTO chatDto;
        private static int MAX_SIZE_WRAP = 36;

        public ChatUserTile()
        {
            InitializeComponent();
        }

        public ChatUserTile(CustomerChatDTO chatDto)
        {
            InitializeComponent();
            this.chatDto = chatDto;
            LoadData();
            InitializeEvent();
        }

        private void LoadData()
        {
            lblName.Text = "Đang tải tên khách hàng...";
            lblNewMessage.Text = "Đang tải nội dung tin nhắn...";
            Task.Run(() =>
            {
                UserDTO user = new UserDAO().FindMatch("id", chatDto.UserId.ToString())[0];
                lblName.SafeInvoke(() => lblName.Text = user.Username);
            });
            Task.Run(() =>
            {
                MessageBLL bll = new MessageBLL(new MessageDAO());
                string msg = bll.GetLatestMessageOfChat(chatDto.UserId);
                // Rút ngắn nội dung nếu quá dài
                if (msg.Length > MAX_SIZE_WRAP)
                {
                    msg = msg.Substring(0, MAX_SIZE_WRAP-1) + "...";
                }
                // Cập nhật lên giao diện
                lblNewMessage.SafeInvoke(() => lblNewMessage.Text = msg);
            });
        }

        /// <summary>
        /// Lấy id của đoạn chat
        /// </summary>
        /// <returns>Id của đoạn chat</returns>
        public long GetChatId()
        {
            return chatDto.UserId;
        }

        private void InitializeEvent()
        {
            pnlContainer.Click += (s,e) => ShowChatController();
            lblName.Click += (s, e) => ShowChatController();
            lblNewMessage.Click += (s, e) => ShowChatController();
            iconUser.Click += (s, e) => ShowChatController();
        }

        private void ShowChatController()
        {
            AdminChatSupport.Instance.LoadChat(chatDto.UserId);
        }

        public void RefreshMessage()
        {
            lblNewMessage.Text = "Đang cập nhật...";
            Task.Run(() =>
            {
                MessageBLL bll = new MessageBLL(new MessageDAO());
                string msg = bll.GetLatestMessageOfChat(chatDto.UserId);
                // Rút ngắn nội dung nếu quá dài
                if (msg.Length > MAX_SIZE_WRAP)
                {
                    msg = msg.Substring(0, MAX_SIZE_WRAP - 1) + "...";
                }
                // Cập nhật lên giao diện
                lblNewMessage.SafeInvoke(
                    () => lblNewMessage.Text = msg
                );
            });
        }

        /// <summary>
        /// Cập nhật lại dữ liệu của control
        /// </summary>
        /// <param name="dto">Đối tượng CustomerChatDTO dữ liệu mới cần cập nhật</param>
        public void UpdateMesage(string message)
        {
            if (message.Length > MAX_SIZE_WRAP)
            {
                message = message.Substring(0, MAX_SIZE_WRAP-1) + "...";
            }
            lblNewMessage.Text = message;
        }

    }
}
