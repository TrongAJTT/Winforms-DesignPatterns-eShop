using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.Utilities;
using _3S_eShop.Validate;
using Cipher3S;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class NewPasswordControl: UserControl
    {
        private string email;
        private UserBLL userBLL;
        public NewPasswordControl(string email)
        {
            InitializeComponent();
            this.email = email;
            txtPass.Valid = new PasswordValidator();
            txtPassConfirm.Valid = new PasswordConfirmValidator();
            userBLL = new UserBLL(new UserDAO());
            lblPassConfirmErr.Text = lblPassErr.Text = "";
        }

        private async void btnChange_Click(object sender, EventArgs e)
        {
            // Xác thực mật khẩu
            if (!MySystem.ValidateTemplate(txtPass, lblPassErr)) return;
            if (!MySystem.ValidateTemplate(txtPassConfirm, lblPassConfirmErr, txtPass.Texts)) return;

            // Đổi mật khẩu
            await Task.Run(() => userBLL.ChangePassword(email, txtPass.Texts));
            // Nếu người dùng đã đăng nhập thì cập nhật mật khẩu trong phiên làm việc
            if (MainForm.User != null)
            {
                MainForm.User.Password = AESIV.Encrypt(txtPass.Texts);
            }

            // Thông báo thành công
            MessageBox.Show(
                "Đổi mật khẩu thành công", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Quay về trang đăng nhập
            EmbedControl embed = EmbedControl.GetEmbedControl(this);
            if (embed != null)
            {
                embed.BackToParent();
            }
        }

        private void togglePassChar_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = txtPassConfirm.PasswordChar = !togglePassChar.Checked;
        }
    }
}
