using System;
using System.Windows.Forms;
using _3S_eShop.Validate;
using _3S_eShop.PatternDistinctive.SimpleFactory;
using _3S_eShop.Utilities;
using Cipher3S;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class ChangePasswordControl: UserControl
    {

        public ChangePasswordControl()
        {
            InitializeComponent();
            txtPass.Valid = new PasswordValidator();
            lblPassErr.Text = "";
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu có hợp lệ không
            if (!MySystem.ValidateTemplate(txtPass, lblPassErr)) return;
            if (!txtPass.Texts.Equals(AESIV.Decrypt(MainForm.User.Password)))
            {
                MySystem.DisplayError(lblPassErr, "Mật khẩu không chính xác", false);
                return;
            }

            // Control này luôn được nhúng -> Lấy control cha không cần xử lý null
            UserControl parent = EmbedControl.GetParentControl(this);
            // Tạo EmbedControl nhúng điều hướng sang trang tạo mật khẩu mới
            EmbedControl embed = new EmbedControl(
                new NewPasswordControl(MainForm.User.Email), parent, this
            );
            embed.Title.Text = "Tạo mật khẩu mới";
            embed.SetConfirmBack("Bạn có chắc muốn thoát khỏi trang tạo mật khẩu mới?\n" +
                "Tiến trình đổi mật khẩu sẽ hoàn toàn bị hủy bỏ!");
            embed = new EmbedControlDecoratorFactory().Decorate("auth", embed);
            embed.Start();
        }

        private void togglePassChar_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = !togglePassChar.Checked;
        }
    }
}
