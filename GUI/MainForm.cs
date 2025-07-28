using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.PatternDistinctive.SimpleFactory;
using _3S_eShop.PatternDistinctive.Command;
using _3S_eShop.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.GUI.MainControls.Auth;
using System.Threading.Tasks;
using _3S_eShop.GUI;

namespace _3S_eShop
{
    public partial class MainForm : Form
    {
        private static UserDTO user;
        private static RoleDTO role;

        private MainControlFactory simpleFactory;

        private RoundedButton[] sideButtons;
        private UserControl[] controls;
        private ICommand<bool> command;

        public MainForm()
        {
            InitializeComponent();
            // Hiện Form tải dữ liệu
            LoadingForm.Instance.Show();
            // Lấy thông tin người dùng từ session
            user = LoginSession.Get();
            // Nếu không có session thì không cần thiết lập thông tin người dùng
            if (user == null)
            {
                // Nếu không có session
                picAccAvatar.SafeInvokeSetImage(Properties.Resources.guest);
                btnAdmin.SafeInvokeDispose();
            }
            // Tải thông tin người dùng
            else
            {
                lblName.Text = user.Username;
                RoleBLL roleBLL = new RoleBLL(new RoleDAO());
                role = roleBLL.GetRoleFromId(user.RoleId);
                lblRole.Text = role.Description;
                // Nếu là admin
                if (role.IsAdmin())
                {
                    picAccAvatar.SafeInvokeSetImage(Properties.Resources.admin);
                    btnCart.SafeInvokeDispose();
                    btnUser.SafeInvokeDispose();
                }
                // Nếu là khách hàng thông thường
                else
                {
                    btnAdmin.SafeInvokeDispose();
                }
            }

            // Tạo danh sách và factory cho các nút bên trái
            simpleFactory = new MainControlFactory();
            sideButtons = new RoundedButton[7]
            {
                btnHome, btnCategory, btnBrowse, btnCart, btnUser, btnSetting, btnAdmin
            };
            controls = new UserControl[7];

            UpdateRewardPoint();
            InitializeControls();

            // Tắt form tải dữ liệu
            LoadingForm.Instance.Dispose();

            SetPage(btnHome);
            this.TopLevel = true;
        }

        /// <summary>
        /// Lấy trang hiện tại đang hiển thị trong contentPanel.
        /// </summary>
        /// <returns>Biến Control đang hiển thị (Có thể cần convert lại)</returns>
        public Control GetPage()
        {
            int index = sideButtons.AsEnumerable().ToList()
                .FindIndex(x => x.BackColor == Color.FromArgb(120, 170, 255));
            return controls[index];
        }


        /// <summary>
        /// Thiết lập trang hiển thị tương ứng với nút bên trái được chọn.
        /// </summary>
        /// <param name="sender">Nút gửi sự kiện</param>
        public void SetPage(object sender)
        {
            RoundedButton button = sender as RoundedButton;
            contentPanel.Controls.Clear();
            UserControl control = controls[Array.IndexOf(sideButtons, button)];
            contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            if (control is ILazyLoad)
            {
                (control as ILazyLoad).Load();
            }
            sideButtons
                .Select((btn, index) => new { btn, index }).ToList()
                .ForEach(
                    x => x.btn.BackColor = (x.btn == button)
                    ? Color.FromArgb(120, 170, 255)
                    : Color.FromArgb(65, 136, 255));
        }

        /// <summary>
        /// Thay thế Control tương ứng trong danh sách Controls bằng Control hiện tại.
        /// </summary>
        public void ReplaceControl()
        {
            RoundedButton btn = btnHome;
            foreach (RoundedButton button in sideButtons)
            {
                if (button.BackColor == Color.FromArgb(120, 170, 255))
                {
                    btn = button;
                    break;
                }
            }
            controls[Array.IndexOf(sideButtons, btn)] = contentPanel.Controls[0] as UserControl;
        }

        // Cập nhật điểm thưởng
        internal void UpdateRewardPoint()
        {
            Task.Run(() =>
            {
                if (user != null)
                {
                    var dao = new RewardPointDAO();
                    var reward = dao.GetById(user.Id);
                    if (reward != null)
                    {
                        lblReward.SafeInvokeSetText("Điểm thưởng: " + StringUtil.FormatCurrency(reward.Point.ToString()));
                    }
                }
            });
        }

        #region Properties

        public static UserDTO User
        {
            get { return user; }
            //private set { user = value; }
        }

        public static RoleDTO Role
        {
            get { return role; }
            //private set { role = value; }
        }

        public static RewardPointDTO RewardPoint
        {
            get
            {
                if (user != null)
                {
                    var dao = new RewardPointDAO();
                    return dao.GetById(user.Id);
                }
                return null;
            }
        }

        #endregion

        #region Side Button Click Event

        /// <summary>
        /// Khởi tạo các Control tương ứng với các nút bên trái.
        /// </summary>
        private void InitializeControls()
        {
            foreach (RoundedButton btn in sideButtons)
            {
                UserControl control;
                if (btn == btnHome)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Home);
                }
                else if (btn == btnCategory)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Category);
                }
                else if (btn == btnBrowse)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Browse);
                }
                else if (btn == btnCart)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Cart);
                }
                else if (btn == btnUser)
                {
                    if (user == null)
                    {
                        control = simpleFactory.CreateUserControl(MainControlFactory.Type.Login);
                    }
                    else
                    {
                        control = simpleFactory.CreateUserControl(MainControlFactory.Type.User);
                    }
                }
                else if (btn == btnSetting)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Setting);
                }
                else if (btn == btnAdmin)
                {
                    control = simpleFactory.CreateUserControl(MainControlFactory.Type.Admin);
                }
                else continue;
                controls[Array.IndexOf(sideButtons, btn)] = control;
            }

            ToolTipHelper.AppendToControl(btnSupport, "Chăm sóc khách hàng");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            checkConnection(sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            checkConnection(sender);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            checkConnection(sender);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SetPage(sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SetPage(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SetPage(sender);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SetPage(sender);
        }

        #endregion

        #region Key Event

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Control control = contentPanel.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyDown(sender, e);
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control control = contentPanel.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyPress(sender, e);
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            Control control = contentPanel.Controls[0];
            if (control is KeyBindingControl)
            {
                (control as KeyBindingControl).KeyUp(sender, e);
            }
        }

        private void checkConnection(object sender)
        {
            command = new CheckInternetCommand();
            if(!command.Execute())
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(simpleFactory.CreateUserControl(MainControlFactory.Type.NoInternet));
                RoundedButton button = sender as RoundedButton;
                sideButtons
               .Select((btn, index) => new { btn, index })
               .ToList()
               .ForEach(
                   x => x.btn.BackColor = (x.btn == button)
                   ? Color.FromArgb(120, 170, 255)
                   : Color.FromArgb(65, 136, 255));
            }
            else
            {
                SetPage(sender);
            }
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            if (role == null)
            {
                MySystem.SetChildControl(new LoginControl(), "Bạn cần đăng nhập để sử dụng chức năng này");
                return;
            }
            if (role.IsAdmin())
            {
                AdminChatSupport.Instance.Show();
            }
            else
            {
                UserChatSupport.Instance.Show();
            }
        }

        #endregion


    }
}
