using _3S_eShop.GUI.ComponentControls;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class UserChatSupport: Form
    {
        // Thiết lập Singleton
        private static UserChatSupport instance;

        public static UserChatSupport Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new UserChatSupport();
                }
                return instance;
            }
        }

        // Khởi tạo dữ liệu cho ChatController
        public UserChatSupport()
        {
            InitializeComponent();
            chatController.LoadChat(MainForm.User.Id);
        }

        #region Key Binding

        private void UserChatSupport_KeyDown(object sender, KeyEventArgs e)
        {
            (chatController as KeyBindingControl).KeyDown(sender, e);
        }

        private void UserChatSupport_KeyUp(object sender, KeyEventArgs e)
        {
            (chatController as KeyBindingControl).KeyUp(sender, e);
        }

        private void UserChatSupport_KeyPress(object sender, KeyPressEventArgs e)
        {
            (chatController as KeyBindingControl).KeyPress(sender, e);
        }

        #endregion

    }
}
