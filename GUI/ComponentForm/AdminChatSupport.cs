using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.Connect;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.Utilities;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class AdminChatSupport: Form
    {
        // Triển khai Singleton
        private static AdminChatSupport instance;
        public static AdminChatSupport Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new AdminChatSupport();
                }
                return instance;
            }
        }

        private int loadPage = 1; // Trang hiện tại

        // Hàm khởi tạo
        public AdminChatSupport()
        {
            InitializeComponent();
            LoadChatList();
            InitializePubSub();
        }

        private void LoadChatList()
        {
            // Tải danh sách khách hàng
            CustomerChatBLL bll = new CustomerChatBLL(new CustomerChatDAO());
            List<CustomerChatDTO> list = bll.GetListCustomerChatsAtPage(1);
            foreach (CustomerChatDTO dto in list)
            {
                // Tạo control hiển thị khách hàng
                var chatControl = new ChatUserTile(dto);
                // Thêm control vào danh sách
                flowChatHeader.Controls.Add(chatControl);
            }
        }

        private void InitializePubSub()
        {
            // Đăng ký kênh sub để nhận tin nhắn mới từ Redis
            var pubsub = Redis.Instance.GetConnectionMultiplexer().GetSubscriber();
            pubsub.Subscribe(
                RedisChannel.Literal(Redis.CHANNEL_CUSTOMER_SERVICE_STATUS_UPDATE),
                (channel, message) =>
                {
                    // Lấy đối tượng CustomerChatDTO từ message
                    var dto = new CustomerChatDAO().GetById(Convert.ToInt64(message));
                    // Lặp qua các kênh chat trong panel và dời lên trên đầu nếu có
                    foreach(var control in flowChatHeader.Controls)
                    {
                        if (control is ChatUserTile chatUserTile)
                        {
                            // Nếu kênh chat đã có trong danh sách thì dời lên đầu
                            if (chatUserTile.GetChatId() == dto.UserId)
                            {
                                flowChatHeader.SafeInvoke(
                                    () => chatUserTile.SafeInvoke(
                                       () => {
                                           // Cập nhật lại vị trí của control
                                           flowChatHeader.Controls.SetChildIndex(chatUserTile, 0);
                                           // Cập nhật tin nhắn mới nhất
                                           chatUserTile.RefreshMessage();
                                       }
                                    )
                                );
                                return;
                            }
                        }
                    }
                    // Thêm kênh chat vào đầu danh sách nếu không có
                    flowChatHeader.SafeInvoke(
                        () => {
                            var chatHeader = new ChatUserTile(dto);
                            flowChatHeader.Controls.Add(chatHeader);
                            flowChatHeader.Controls.SetChildIndex(chatHeader, 0);
                        }
                    );
                }
            );
        }

        public void LoadChat(long userId)
        {
            chatController.ClearChat();
            chatController.LoadChat(userId);
            chatController.Visible = true;
            chatController.Enabled = true;
        }

        #region Key Event

        private void AdminChatSupport_KeyDown(object sender, KeyEventArgs e)
        {
            if (chatController.Visible)
            {
                (chatController as KeyBindingControl).KeyDown(sender, e);
            }
        }

        private void AdminChatSupport_KeyUp(object sender, KeyEventArgs e)
        {
            if (chatController.Visible)
            {
                (chatController as KeyBindingControl).KeyUp(sender, e);
            }
        }

        private void AdminChatSupport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chatController.Visible)
            {
                (chatController as KeyBindingControl).KeyPress(sender, e);
            }
        }

        #endregion
    }
}
