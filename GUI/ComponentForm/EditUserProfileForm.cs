using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Facade;
using _3S_eShop.PatternDistinctive.Observer.EditUserInfomation;
using _3S_eShop.Validate;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class EditUserProfileForm : Form, IObserver
    {
        UserFacade userFacade = new UserFacade(new UserDAO());
        private SendUserOTP processing;
        private bool isListening = false;
        private string originalEmail = MainForm.User.Email;
        public EditUserProfileForm()
        {
            InitializeComponent();
            processing = new SendUserOTP();
            txtEmail._TextChanged += (s, e) =>
            {
                
                if (string.IsNullOrEmpty(txtEmail.Texts) && string.IsNullOrEmpty(txtUsername.Texts))
                {
                    btnSave.Enabled = false;
                    return;
                }
                btnSave.Enabled = true;
            };
            txtUsername._TextChanged += (s, e) =>
            {
                
                if (string.IsNullOrEmpty(txtEmail.Texts) && string.IsNullOrEmpty(txtUsername.Texts))
                {
                    btnSave.Enabled = false;
                    return;
                }
                btnSave.Enabled = true;
            };
            txtOTP.Valid = new OtpValidator();
            txtEmail.Valid = new EmailVaildator();
            txtUsername.Valid = new UsernameValidator();
            btnSave.Enabled = false;
        }


        public void Update(string information, int state)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => Update(information, state)));
            }
            else
            {
                // Cập nhật giao diện người dùng dựa trên thông tin và trạng thái nhận được từ Subject
                lblOTP.Visible = true;
                switch (state)
                {
                    case 0:
                        // Đang gửi mã OTP
                        lblOTP.Text = information;
                        break;
                    case 1:
                        lblOTP.Text = information;
                        lblOTP.ForeColor = Color.Green;
                        break;
                    case 2:
                    case 3:
                        // Xác thực thất bại
                        lblOTP.Text = information;
                        lblOTP.ForeColor = Color.Red;
                        break;
                    case 4:
                        // Thời gian đã hết
                        lblOTP.Text = information;
                        lblOTP.ForeColor = Color.Red;
                        btnSend.Enabled = true;
                        isListening = false; // reset
                        break;
                    default:
                        break;
                }
            }
        }

        private async void roundedButton1_Click(object sender, EventArgs e)
        {
            bool emailNotEmpty = !string.IsNullOrWhiteSpace(txtEmail.Texts);
            bool usernameNotEmpty = !string.IsNullOrWhiteSpace(txtUsername.Texts);

            // Nếu không có gì thay đổi, thì không làm gì
            if (!emailNotEmpty && !usernameNotEmpty)
            {
                lblEmailMsg.Text = "Không có thông tin nào được thay đổi.";
                lblEmailMsg.ForeColor = Color.Gray;
                return;
            }

            // Xử lý cập nhật email nếu được nhập và có thay đổi
            bool emailChanged = emailNotEmpty && txtEmail.Texts != originalEmail;
            if (emailChanged)
            {
                if (!txtEmail.IsValid())
                {
                    lblEmailMsg.Text = txtEmail.GetInvalidMessage();
                    lblEmailMsg.ForeColor = Color.Red;
                }
                else if (isListening && txtOTP.IsValid(txtEmail.Texts))
                {
                    userFacade.UpdateEmail(MainForm.User.Id, txtEmail.Texts);
                    lblEmailMsg.Text = "Cập nhật email thành công";
                    lblEmailMsg.ForeColor = Color.Green;
                    lblOTPMsg.Text = ""; // Xóa thông báo OTP nếu thành công
                    isListening = false; // reset
                }
                else
                {
                    lblOTPMsg.Text = isListening ? txtOTP.GetInvalidMessage() : "Vui lòng xác nhận OTP trước.";
                    lblOTPMsg.ForeColor = Color.Red;
                }
            }

            // Xử lý cập nhật username nếu được nhập
            if (usernameNotEmpty)
            {
                if (txtUsername.IsValid())
                {
                    userFacade.UpdateUsername(MainForm.User.Id, txtUsername.Texts);
                    lblUsernameMsg.Text = "Cập nhật tên người dùng thành công";
                    lblUsernameMsg.ForeColor = Color.Green;
                }
                else
                {
                    lblUsernameMsg.Text = txtUsername.GetInvalidMessage();
                    lblUsernameMsg.ForeColor = Color.Red;
                }
            }
        }

        private async void listenEmail()
        {

            processing.RegisterObserver(this);

            bool result = await processing.createOTP(txtEmail.Texts);
            if (result)
            {
                await Task.Delay(3000);
                processing.timeOut();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtEmail.IsValid())
            {
                listenEmail();
                isListening = true;
            }
            else
            {
                lblEmailMsg.Text = txtEmail.GetInvalidMessage();
                lblEmailMsg.ForeColor = Color.Red;
            }
            btnSend.Enabled = false;
        }
    }
}
