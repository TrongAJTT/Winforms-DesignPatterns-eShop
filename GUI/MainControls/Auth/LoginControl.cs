using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.DAL.GoogleService;
using _3S_eShop.PatternDistinctive.SimpleFactory;
using _3S_eShop.Utilities;
using _3S_eShop.Validate;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class LoginControl : UserControl
    {
        private UserBLL userBLL;

        public LoginControl()
        {
            InitializeComponent();
            lblEmailErr.Text = lblPassErr.Text = "";
            userBLL = new UserBLL(new UserDAO());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            EmbedControl embed = new EmbedControl(
                new SignUpControl(), 
                EmbedControl.GetParentParam(this), this
            );
            embed.Title.Text = "Đăng ký tài khoản";
            embed.SetConfirmBack("Bạn có chắc muốn thoát khỏi trang đăng ký?\n" +
                "Những thông tin đã nhập sẽ bị mất!");
            embed = new EmbedControlDecoratorFactory().Decorate("auth", embed);
            embed.Start();
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            EmbedControl embed = new EmbedControl(
                new ForgotPasswordControl(), 
                EmbedControl.GetParentParam(this), this
            );
            embed.Title.Text = "Quên mật khẩu";
            embed.SetConfirmBack("Bạn có chắc muốn thoát khỏi trang quên mật khẩu?\n" +
                "Những thông tin đã nhập sẽ bị mất!");
            embed = new EmbedControlDecoratorFactory().Decorate("auth", embed);
            embed.Start();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            BaseValidator[] validates = new BaseValidator[] { new EmailVaildator() };
            AdvancedTextBox[] validateTextBoxes = new AdvancedTextBox[] { txtEmail };

            for (int i = 0; i < validateTextBoxes.Length; i++)
            {
                validateTextBoxes[i].Valid = validates[i];
                if (!validateTextBoxes[i].IsValid())
                {
                    lblEmailErr.Text = "Email không đúng định dạng";
                    return;
                }
            }

            UserDTO user = await Task.Run(() => userBLL.GetMatchEmail(txtEmail.Texts));

            if (user == null)
            {
                lblPassErr.Text = "Thông tin chưa chính xác";
                return;
            }
            else if (!Cipher3S.AESIV.Decrypt(user.Password.ToString()).Equals(txtPassword.Texts))
            {
                lblEmailErr.Text = "Thông tin chưa chính xác";
                return;
            }
            else if (user.IsActive)
            {
                LoginSession.Create(user.Email);
                MessageBox.Show("Đăng nhập thành công\nPhần mềm sẽ tự khởi động lại", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Khởi động lại ứng dụng
                MySystem.Restart();
            }
            else
            {
                MessageBox.Show(user.BanReason, "Đăng Nhập Thất bại",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Error);
                return;
            }
        }

        private async void btnGoogleAuth_Click(object sender, EventArgs e)
        {
            string s = await OathLogin.RequestLogin();

            // Xóa folder "token"
            string folderPath = System.IO.Path.Combine(Application.StartupPath, "token");
            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true); // true để xóa cả nội dung bên trong
            }

            // Lấy thông tin người dùng từ JSON
            JsonDocument jsonDocument = JsonDocument.Parse(s);
            JsonElement root = jsonDocument.RootElement;
            string email = root.GetProperty("email").GetString();
            string name = root.GetProperty("name").GetString();
            string picture = root.GetProperty("picture").GetString();

            // Kiểm tra xem email đã tồn tại trong cache chưa
            bool isDupEmail = RedisHandler.IsEmailExist(email);
            bool acceptLogin = false;
            if (!isDupEmail)
            {
                // Mở và truyền dữ liệu cho form ConfirmLoginGoogle
                ConfirmLoginGoogle confirmLoginGoogle = new ConfirmLoginGoogle(email, name, picture);
                if (confirmLoginGoogle.ShowDialog() == DialogResult.Yes) acceptLogin = true;
            }
            else
            {
                // Nếu email đã tồn tại trong cache, kiểm tra xem tài khoản đã bị khóa chưa
                UserDTO user = userBLL.GetMatchEmail(email);
                if (!user.IsActive)
                {
                    MessageBox.Show(user.BanReason, "Đăng Nhập Thất bại",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Error);
                    return;
                }

                // Nếu tài khoản chưa bị khóa, tự động đăng nhập
                acceptLogin = true;
            }


            if (acceptLogin)
            {
                // Đăng nhập thành công
                LoginSession.Create(email);
                MessageBox.Show("Đăng nhập thành công\nPhần mềm sẽ tự khởi động lại", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Khởi động lại ứng dụng
                MySystem.Restart();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void togglePassChar_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !togglePassChar.Checked;
        }
    }
}
