using _3S_eShop.BLL;
using _3S_eShop.CustomComponents;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.Validate;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class ConfirmLoginGoogle : Form
    {
        private static String email;
        private UserBLL userBLL;

        public ConfirmLoginGoogle(String email, String name, String picture)
        {
            InitializeComponent();
            ConfirmLoginGoogle.email = email;
            txtEmail.Valid = new EmailVaildator();
            txtEmail.Texts = email;
            txtEmail.Enabled = false;
            txtPassword.Valid = new PasswordValidator();
            txtUsername.Valid = new UsernameValidator();
            txtUsername.Focus();
            txtUsername.Texts = name;
            userBLL = new UserBLL(new UserDAO());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            saveToDB();

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private bool validate()
        {
            if (!ValidateTemplate(txtUsername, lblErrorUsername)) return false;
            if (!ValidateTemplate(txtPassword, lblErrorPassword)) return false;

            bool isMatchPass = txtConfirmPassword.Texts.Equals(txtPassword.Texts);
            DisplayError(lblErrorConfirmPassword, "Mật khẩu không khớp", isMatchPass);
            if (!isMatchPass) return false;

            return true;
        }

        private void saveToDB()
        {
            userBLL.AddUser(txtEmail.Texts, txtPassword.Texts, txtUsername.Texts);
            RedisHandler.StoreEmail(txtEmail.Texts); // Lưu email vào Redis
        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            // Ẩn/hiện mật khẩu
            if (txtPassword.PasswordChar)
            {
                txtPassword.PasswordChar = false;
                txtConfirmPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                txtConfirmPassword.PasswordChar = true;
            }
        }

        private bool ValidateTemplate(AdvancedTextBox textBox, Label errLabel, string param = null)
        {
            bool valid = textBox.IsValid(param);
            DisplayError(errLabel, textBox.GetInvalidMessage(), valid);
            return valid;
        }

        private void DisplayError(Label errLabel, string errorMessage, bool isValid)
        {
            if (isValid)
            {
                errLabel.Visible = false;
            }
            else
            {
                errLabel.Text = errorMessage;
                errLabel.Visible = true;
            }
        }

    }
}
