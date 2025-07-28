using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.PatternDistinctive.Observer.Countdown;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.Utilities;
using _3S_eShop.Validate;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class SignUpControl : UserControl
    {
        private static String currentEmail;
        private UserBLL userBLL;
        private CountdownTimer otpTimer;

        public SignUpControl()
        {
            InitializeComponent();
            lblErrorEmail.Text = lblErrorUsername.Text 
                = lblErrorPassword.Text = lblErrorOTP.Text = "";
            txtEmail.Valid = new EmailVaildator();
            txtOTP.Valid = new OtpValidator();
            txtPassword.Valid = new PasswordValidator();
            txtUsername.Valid = new UsernameValidator();
            txtConfirmPassword.Valid = new PasswordConfirmValidator();
            txtUsername.Focus();
            userBLL = new UserBLL(new UserDAO());
        }

        private void InitializeOtpEvent() 
        {
            otpTimer = new CountdownTimer(60, 1);
            // Bắt đầu đếm ngược
            otpTimer.OnStart += (s, _e) =>
            {
                btnSendOTP.Enabled = false;
                btnSendOTP.Text = "60s";
            };
            // Mỗi bước đếm ngược
            otpTimer.OnNotify += (s, _e) =>
            {
                btnSendOTP.Text = $"{_e.SecondsRemaining}s";
            };
            // Hủy bỏ đếm ngược
            otpTimer.OnCancel += (s, _e) =>
            {
                btnSendOTP.Text = "Gửi";
                btnSendOTP.Enabled = true;
            };
            // Khi đếm ngược kết thúc
            otpTimer.OnFinal += (s, _e) =>
            {
                btnSendOTP.Text = "Gửi";
                btnSendOTP.Enabled = true;
            };
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Điều kiện đồng ý với điều khoản sử dụng
            if (!chkAgree.Checked)
            {
                MessageBox.Show("Bạn cần đồng ý với điều khoản sử dụng", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng ký
            if (!ValidateAll()) return;

            // Lưu thông tin tài khoản vào DB
            SaveToDB();

            // Tạo session đăng nhập
            LoginSession.Create(currentEmail);
            MessageBox.Show("Đăng ký tài khoản thành công\nPhần mềm sẽ tự khởi động lại", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Khởi động lại ứng dụng
            MySystem.Restart();
        }

        private bool ValidateAll()
        {
            if (!MySystem.ValidateTemplate(txtUsername, lblErrorUsername)) return false;
            if (!MySystem.ValidateTemplate(txtEmail, lblErrorEmail)) return false;
            if (!MySystem.ValidateTemplate(txtPassword, lblErrorPassword)) return false;
            if (!MySystem.ValidateTemplate(txtConfirmPassword, lblErrorConfirmPassword, txtPassword.Texts)) return false;
            if (!MySystem.ValidateTemplate(txtOTP, lblErrorOTP, txtEmail.Texts)) return false;
            return true;
        }

        private void SaveToDB()
        {
            userBLL.AddUser(currentEmail, txtPassword.Texts, txtUsername.Texts);
            RedisHandler.StoreEmail(txtEmail.Texts);
        }

        private void togglePassChar_CheckedChanged(object sender, System.EventArgs e)
        {
            txtPassword.PasswordChar = txtConfirmPassword.PasswordChar
                = !togglePassChar.Checked;
        }

        //private CancellationTokenSource _otpCancellationTokenSource;

        private void btnSendOTP_Click(object sender, System.EventArgs e)
        {
            // Kiểm tra email có hợp lệ không
            if (!MySystem.ValidateTemplate(txtEmail, lblErrorEmail)) return;

            // Kiểm tra email đã tồn tại trong cache chưa
            bool isDupEmail = RedisHandler.IsEmailExist(txtEmail.Texts);
            MySystem.DisplayError(lblErrorEmail, "Tài khoản đã tồn tại", !isDupEmail);
            if (isDupEmail) return;

            // Tạo ngẫu nhiên mã OTP 6 ký tự và gửi đến email, redis
            string otp = StringUtil.CreateOTP();
            EmailHandler.SendOtpSignUpEmail(txtEmail.Texts, otp);
            currentEmail = txtEmail.Texts;

            // Disable nút gửi OTP trong 1 phút
            InitializeOtpEvent();
            otpTimer.Start();
        }

        // Hủy bỏ đếm ngược khi người dùng nhập lại email
        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            if (otpTimer != null)
            {
                otpTimer.Cancel();
            }
            
        }

        private void lblEULA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmbedControl embedControl = new EmbedControl(
                new EULA(), EmbedControl.GetParentParam(this), this
            );
            embedControl.Title.Text = "Điều khoản sử dụng";
            embedControl.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Hủy bỏ đếm ngược khi không còn sử dụng
                otpTimer?.Cancel();
                otpTimer?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
