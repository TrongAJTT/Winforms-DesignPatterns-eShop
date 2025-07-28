using _3S_eShop.CustomComponents;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.Utilities;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls
{
    /// <summary>
    /// Lớp này có chức năng tạo một Control nhúng trong một Panel là container chứa nó.
    /// </summary>
    public partial class EmbedControl : UserControl, KeyBindingControl
    {
        private Control parent;
        private ControlCollection container;
        private Control creator;
        private string msgBackConfirmText, msgBackConfirmCaption;
        private MessageBoxIcon msgBackConfirmIcon;

        public EventHandler OnCallBack;

        /// <summary>
        /// Sự kiện này sẽ được gọi khi Control nhúng trở về Control cha.
        /// </summary>
        public EventHandler OnChildExit;

        /// <summary>
        /// Lấy Control cha của Control nhúng.
        /// </summary>
        public Control ParentControl { get => parent; }

        /// <summary>
        /// Panel chứa Control nhúng.
        /// </summary>
        public Control Layout { get => pnlMain; }

        /// <summary>
        /// Container chứa Control nhúng.
        /// </summary>
        public ControlCollection Container { get => container; }

        /// <summary>
        /// Thanh tiêu đề của Control nhúng.
        /// </summary>
        public Panel TitleBar { get => topPnl; }

        /// <summary>
        /// Nhãn tiêu đề của Control nhúng
        /// </summary>
        public Label Title { get => lblTitle; }

        /// <summary>
        /// Nút trở về (kích thước tối đa là 44x44px)
        /// </summary>
        public RoundedButton BackButton { get => btnBack; }

        /// <summary>
        /// Tạo một User Control nhúng trong một User Control cha.
        /// </summary>
        /// <param name="content">Control con được nhúng</param>
        /// <param name="parent">User Control cha, khi nhấn nút trở về sẽ quay về User Control này. Muốn thiết lập Control hiện tại thì có thể dùng hàm GetParentParam(this).</param>
        /// <param name="current">Truyền vào 'this', tức User Control hiện tại, lớp sẽ tự động kiểm tra Control hiện tại có được nhúng chưa mà xử lý cho phù hợp.</param>
        /// <param name="contentDock">Thiết lập Dock cho Control con, mặc định là Fill</param>
        public EmbedControl(Control content, Control parent, Control current, DockStyle contentDock = DockStyle.Fill)
        {
            InitializeComponent();
            this.parent = parent;
            this.creator = current;
            container = IsEmbed(current)
                ? (current.Parent.Parent as EmbedControl).Container
                : current.Parent.Controls;
            content.Dock = contentDock;
            pnlMain.Controls.Add(content);
        }

        /// <summary>
        /// Thiết lập MessageBox thông báo xác nhận khi trở về.
        /// </summary>
        /// <param name="text">Nội dung xác nhận</param>
        /// <param name="caption">Tiêu đề thông báo</param>
        /// <param name="icon">Biểu tượng thông báo</param>
        public void SetConfirmBack(string text, string caption = null, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            msgBackConfirmText = text;
            msgBackConfirmCaption = caption;
            msgBackConfirmIcon = icon;
        }

        /// <summary>
        /// Bắt đầu hiện Control nhúng và xóa Control hiện tại khỏi Container. Trong trường hợp muốn control nhúng lắp đầy Container thì cần thiết lập Dock Fill. LƯU Ý: Nếu Control hiện tại không dùng đến nữa thì cần Dispose() để giải phóng vùng nhớ.
        /// </summary>
        /// <param name="dockStyle">Thông số dock của Embed Control</param>
        public void Start(DockStyle dockStyle = DockStyle.Fill)
        {
            this.Dock = dockStyle;
            container.Add(this);
            container.Remove(creator.Parent.Parent is EmbedControl ? creator.Parent.Parent : creator);
            creator = null;
            // Thay control cha nếu container nằm trực tiếp trong Main
            Control containerControl = container.Owner;
            if (containerControl.Parent is MainForm)
            {
                (containerControl.Parent as MainForm).ReplaceControl();
            }
        }

        /// <summary>
        /// Trở về Control cha.
        /// </summary>
        public void BackToParent()
        {
            // Trở về Control cha
            this.Hide();
            container.Add(parent);
            container.Remove(this);
            // Thay control cha nếu container nằm trực tiếp trong Main
            Control containerControl = container.Owner;
            if (containerControl.Parent is MainForm)
            {
                (containerControl.Parent as MainForm).ReplaceControl();
            }
            // Gọi sự kiện OnChildExit nếu có
            OnChildExit?.Invoke(this, EventArgs.Empty);
            // Giải phóng vùng nhớ
            this.Dispose();
        }

        /// <summary>
        /// Thiết lập thông báo Loading cho Control nhúng. Nếu truyền vào số giây thì sẽ tự động xóa sau khi hết thời gian, nếu không truyền vào thì sẽ không tự động xóa.
        /// </summary>
        /// <param name="message">Tin nhắn loading</param>
        /// <param name="seconds">Số giây tự hủy, nếu là âm thì không thiết lập</param>
        public void SetLoading(string message, int seconds = -1)
        {
            if (sectionLoading.Controls.Count > 0)
            {
                RemoveLoading();
            }
            LoadingControl loading = seconds < 0 ?
                    new LoadingControl(message) :
                    new LoadingControl(message, seconds);
            sectionLoading.Controls.Add(loading);
        }

        /// <summary>
        /// Cập nhật thông báo Loading cho Control nhúng. Nếu không có Loading nào thì sẽ tự động tạo mới một LoadingControl.
        /// </summary>
        /// <param name="message">Tin nhắn loading</param>
        public void UpdateLoadingMessage(string message)
        {
            if (sectionLoading.Controls.Count == 0)
            {
                SetLoading(message);
            }
            else
            {
                LoadingControl loading = sectionLoading.Controls[0] as LoadingControl;
                loading.Message = message;
            }
        }

        /// <summary>
        /// Xóa thông báo Loading khỏi Control nhúng.
        /// </summary>
        public void RemoveLoading()
        {
            foreach (Control control in sectionLoading.Controls)
            {
                if (control is LoadingControl)
                {
                    control.SafeInvoke(() => control.Dispose());
                }
            }
            sectionLoading.Controls.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có thông báo xác nhận trở về không
            if (msgBackConfirmText != null)
            {
                if (MessageBox.Show(msgBackConfirmText, msgBackConfirmCaption, MessageBoxButtons.YesNo, msgBackConfirmIcon) == DialogResult.No)
                {
                    return;
                }
            }
            // Trở về Control cha
            BackToParent();
        }

        #region Hàm Static

        /// <summary>
        /// Kiểm tra xem Control có được nhúng hay chưa.
        /// </summary>
        /// <param name="control">User Control cần được kiểm tra</param>
        /// <returns></returns>
        public static bool IsEmbed(Control control)
        {
            if (control.Parent != null)
            {
                if (control.Parent.Parent != null)
                {
                    return control.Parent.Parent is EmbedControl;
                }
            }
            return false;
        }

        /// <summary>
        /// Trả về tham số parent cho Control hiện tại, tức container của Control nhúng control hiện tại. Nếu Control hiện tại không được nhúng thì trả về chính nó.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static Control GetParentParam(Control control)
        {
            return IsEmbed(control) ? control.Parent.Parent as UserControl : control;
        }

        /// <summary>
        /// Trả về EmbedControl của Control hiện tại. Nếu Control hiện tại không được nhúng thì trả về null.
        /// </summary>
        /// <param name="control">Control cần kiểm tra.</param>
        /// <returns>EmbedControl của Control hiện tại hoặc null.</returns>
        public static EmbedControl GetEmbedControl(Control control)
        {
            if (IsEmbed(control))
            {
                return control.Parent.Parent as EmbedControl;
            }
            return null;
        }

        /// <summary>
        /// Trả về Control cha của Control nhúng hiện tại sẽ quay về. Nếu Control hiện tại không được nhúng thì trả về null.
        /// </summary>
        /// <param name="control">Control nhúng cần lấy control cha.</param>
        /// <returns>UserControl hoặc null.</returns>
        public static UserControl GetParentControl(Control control)
        {
            if (IsEmbed(control))
            {
                return GetEmbedControl(control).ParentControl as UserControl;
            }
            return null;
        }

        /// <summary>
        /// Thiết lập thông báo Loading cho Control nhúng của Control hiện tại. Nếu truyền vào số giây thì sẽ tự động xóa sau khi hết thời gian, nếu không truyền vào thì sẽ không tự động xóa.
        /// </summary>
        /// <param name="control">Truyền vào this</param>
        /// <param name="message">Tin nhắn loading</param>
        /// <param name="seconds">Số giây tự hủy, nếu là âm thì không thiết lập</param>
        public static void SetLoadingForThisControl(Control control, string message, int seconds = -1)
        {
            EmbedControl embed = GetEmbedControl(control);
            if (embed != null)
            {
                if (embed.sectionLoading.Controls.Count > 0)
                {
                    embed.RemoveLoading();
                }
                LoadingControl loading = seconds < 0 ?
                        new LoadingControl(message) :
                        new LoadingControl(message, seconds);
                embed.sectionLoading.Controls.Add(loading);
            }
        }

        /// <summary>
        /// Cập nhật thông báo Loading cho Control nhúng của control hiện tại. Nếu không có Loading nào thì sẽ tự động tạo mới một LoadingControl.
        /// </summary>
        /// <param name="control">Truyền vào this</param>
        /// <param name="message">Tin nhắn loading</param>
        public static void UpdateLoadingMessageForThisControl(Control control, string message)
        {
            EmbedControl embed = GetEmbedControl(control);
            if (embed != null)
            {
                if (embed.sectionLoading.Controls.Count == 0)
                {
                    embed.SetLoading(message);
                }
                else
                {
                    LoadingControl loading = embed.sectionLoading.Controls[0] as LoadingControl;
                    loading.Message = message;
                }
            }
        }

        /// <summary>
        /// Xóa thông báo Loading khỏi Control nhúng của control hiện tại.
        /// </summary>
        /// <param name="control">Truyền vào this</param>
        public static void RemoveLoadingForThisControl(Control control)
        {
            EmbedControl embed = GetEmbedControl(control);
            if (embed != null)
            {
                foreach (Control c in embed.sectionLoading.Controls)
                {
                    if (c is LoadingControl)
                    {
                        c.SafeInvoke(() => c.Dispose());
                    }
                }
                embed.sectionLoading.SafeInvoke(() => embed.sectionLoading.Controls.Clear());
            }
        }

        /// <summary>
        /// Trở về Control cha của Control nhúng. Nếu Control hiện tại không được nhúng thì không làm gì cả.
        /// </summary>
        /// <param name="control">Truyền vào this</param>
        public static void TryClose(Control control)
        {
            EmbedControl embed = GetEmbedControl(control);
            if (embed != null)
            {
                embed.BackToParent();
            }
        }

        /// <summary>
        /// Thiết lập hiển thị nút trở về hay không
        /// </summary>
        /// <param name="control">Truyền vào this</param>
        /// <param name="isVisible">Hiển thị hay không</param>
        public static void SetVisibleBackButton(Control control, bool isVisible)
        {
            EmbedControl embed = GetEmbedControl(control);
            if (embed != null)
            {
                embed.btnBack.Visible = isVisible;
            }
        }

        #endregion

        #region KeyBindingControl

        void KeyBindingControl.KeyDown(object sender, KeyEventArgs e)
        {
            if (pnlMain.Controls.Count == 0) return;
            Control control = pnlMain.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyDown(sender, e);
            }
        }

        void KeyBindingControl.KeyUp(object sender, KeyEventArgs e)
        {
            if (pnlMain.Controls.Count == 0) return;
            Control control = pnlMain.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyUp(sender, e);
            }
        }

        void KeyBindingControl.KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pnlMain.Controls.Count == 0) return;
            Control control = pnlMain.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyPress(sender, e);
            }
        }

        #endregion
    }
}
