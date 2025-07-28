using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.Connect;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.Utilities;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ChatController: UserControl, KeyBindingControl
    {
        private long userId; // ID của người dùng chủ trì đoạn chat
        private int loadPage = 1;

        public ChatController()
        {
            InitializeComponent();
            ToolTipHelper.AppendToControl(btnSend, "(Ctrl+Enter) Gửi tin nhắn");
        }

        /// <summary>
        /// Tải lịch sử chat của người dùng
        /// </summary>
        /// <param name="userId">Id của người dùng chủ trì đoạn chat</param>
        public void LoadChat(long userId)
        {
            // Lấy thông tin
            this.userId = userId;
            // Tải lịch sử chat trang 1
            LoadChat(1);
        }

        public void ClearChat()
        {
            // Xóa tất cả các control trong flowChatHistory
            flowChatHistory.Controls.Clear();
            // Đặt lại trang tải về
            loadPage = 1;
            // Ẩn overlay đang tải
            overlayLoadHistory.Visible = false;
        }

        /// <summary>
        /// Tải lịch sử chat của người dùng.
        /// </summary>
        /// <param name="page">Trang cần tải</param>
        public async void LoadChat(int page)
        {
            // Hiện overlay đang tải
            overlayLoadHistory.Visible = true;
            // Lấy dữ liệu
            MessageDAO messageDAO = new MessageDAO();
            MessageBLL messageBbll = new MessageBLL(messageDAO);
            var messages = await Task.Run(() => messageBbll.GetHistoryChatPage(userId, loadPage));
            // Hiển thị lịch sử chat
            _ = Task.Run(() =>
            {
                foreach (var message in messages)
                {
                    AddChatToHistory(message);
                }
            });
            // 
            InitializePubSub();
            // Ẩn overlay đang tải
            overlayLoadHistory.Visible = false;
        }

        private void AddChatToHistory(MessageDTO message)
        {
            var chatControl = new ChatMessageControl(message);
            if (flowChatHistory.InvokeRequired)
            {
                flowChatHistory.Invoke(new Action(() => AddChatToHistory(message)));
                return;
            }
            chatControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowChatHistory.Controls.Add(chatControl);
            flowChatHistory.Controls.SetChildIndex(chatControl, 0);
        }

        private void InitializePubSub()
        {
            // // Đăng ký kênh sub để nhận tin nhắn mới từ Redis
            var pubSub = Redis.Instance.GetConnectionMultiplexer().GetSubscriber();
            pubSub.Subscribe(
                Redis.CHANNEL_CUSTOMER_SREVICE_NEW_MESSAGE,
                (channel, message) =>
                {
                    // Chuyển json về dạng DTO
                    var dto = JsonConvert.DeserializeObject<MessageDTO>(message);
                    // Chỉ nhận tin nhắn từ đoạn chat hiện tại và của người khác
                    if (dto.ChatId == userId && dto.UserId != MainForm.User.Id)
                    {
                        AddChatToHistory(dto);
                    }
                });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Lưu và xóa nội dung tin nhắn
            string message = txtMessage.Texts;
            txtMessage.ClearText();
            // Gửi tin nhắn
            MessageDTO msg = new MessageBuilder().setChatId(userId)
                .setContent(message).setSendDate(DateTime.Now)
                .setUserId(MainForm.User.Id).Build();
            AddChatToHistory(msg);
            // Cập nhật tin nhắn lên CSDL
            MessageBLL bll = new MessageBLL(new MessageDAO());
            Task.Run(() => bll.SendMessage(msg));
            // Đăng ký trạng thái của chat lên Redis
            var pubSub = Redis.Instance.GetConnectionMultiplexer().GetSubscriber();
            pubSub.Publish(
                Redis.CHANNEL_CUSTOMER_SERVICE_STATUS_UPDATE,
                msg.ChatId);
            // Đăng ký tin nhắn lên Redis
            pubSub.Publish(
                Redis.CHANNEL_CUSTOMER_SREVICE_NEW_MESSAGE,
                JsonConvert.SerializeObject(msg)
            );
        }

        private void ChatController_Resize(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                foreach (var item in flowChatHistory.Controls)
                {
                    if (item is ChatMessageControl chatMessageControl)
                    {
                        chatMessageControl.SafeInvoke(() =>
                            chatMessageControl.SetWidth(flowChatHistory.Width - 3)
                        );
                    }
                }
            });
        }

        #region Key Binding

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e) { }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e) { }

        #endregion

    }
}
