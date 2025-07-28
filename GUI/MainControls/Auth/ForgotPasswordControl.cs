using _3S_eShop.DAL.Database;
using _3S_eShop.PatternDistinctive.Observer.Countdown;
using _3S_eShop.PatternDistinctive.SimpleFactory;
using _3S_eShop.Utilities;
using _3S_eShop.Validate;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Auth
{
    public partial class ForgotPasswordControl: UserControl
    {
        private CountdownTimer otpTimer;
        private string currentEmail;

        public ForgotPasswordControl()
        {
            InitializeComponent();
            txtEmail.Valid = new EmailVaildator();
            txtOtp.Valid = new OtpValidator();
            lblEmailErr.Text = lblOtpErr.Text = "";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Xác thực email và mã OTP
            if (!MySystem.ValidateTemplate(txtEmail, lblEmailErr)) return;
            if (!MySystem.ValidateTemplate(txtOtp, lblOtpErr, currentEmail)) return;

            // Control này luôn được nhúng -> Lấy control cha không cần xử lý null
            UserControl parent = EmbedControl.GetParentControl(this);
            // Tạo EmbedControl nhúng điều hướng sang trang tạo mật khẩu mới
            EmbedControl embed = new EmbedControl(
                new NewPasswordControl(currentEmail), parent, this
            );
            embed.Title.Text = "Tạo mật khẩu mới";
            embed.SetConfirmBack("Bạn có chắc muốn thoát khỏi trang tạo mật khẩu mới?\n" +
                "Tiến trình đổi mật khẩu sẽ hoàn toàn bị hủy bỏ!");
            embed = new EmbedControlDecoratorFactory().Decorate("auth", embed);
            embed.Start();
        }

        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            // Kiểm tra email có hợp lệ không
            if (!MySystem.ValidateTemplate(txtEmail, lblEmailErr)) return;

            // Kiểm tra email đã tồn tại trong cache chưa
            bool isDupEmail = RedisHandler.IsEmailExist(txtEmail.Texts);
            MySystem.DisplayError(lblEmailErr, "Email không tồn tại", isDupEmail);
            if (!isDupEmail) return;

            // Tạo ngẫu nhiên mã OTP 6 ký tự và gửi đến email
            string otp = StringUtil.CreateOTP();
            EmailHandler.SendOtpResetPasswordEmail(txtEmail.Texts, otp);
            currentEmail = txtEmail.Texts;

            // Disable nút gửi OTP trong 1 phút
            InitializeOtpEvent();
            otpTimer.Start();
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
                btnSendOTP.Text = "Gửi mã";
                btnSendOTP.Enabled = true;
            };
            // Khi đếm ngược kết thúc
            otpTimer.OnFinal += (s, _e) =>
            {
                btnSendOTP.Text = "Gửi mã";
                btnSendOTP.Enabled = true;
                otpTimer.Dispose();
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Giải phóng tài nguyên
                otpTimer?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
