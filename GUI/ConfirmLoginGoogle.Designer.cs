namespace _3S_eShop.GUI
{
    partial class ConfirmLoginGoogle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmLoginGoogle));
            this.lblShowPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSignUp = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtConfirmPassword = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtPassword = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtEmail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtUsername = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.SuspendLayout();
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.BackColor = System.Drawing.Color.White;
            this.lblShowPassword.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblShowPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblShowPassword.Location = new System.Drawing.Point(388, 527);
            this.lblShowPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(102, 25);
            this.lblShowPassword.TabIndex = 35;
            this.lblShowPassword.Text = "ẩn/hiện";
            this.lblShowPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblShowPassword.Click += new System.EventHandler(this.lblShowPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12.22642F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(89, 480);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(232, 29);
            this.lblConfirmPassword.TabIndex = 34;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12.22642F);
            this.lblPassword.Location = new System.Drawing.Point(91, 350);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(231, 29);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(91, 87);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(198, 29);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12.22642F);
            this.lblUsername.Location = new System.Drawing.Point(89, 217);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(232, 29);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "Tên người dùng";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorConfirmPassword.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(78, 560);
            this.lblErrorConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(290, 25);
            this.lblErrorConfirmPassword.TabIndex = 30;
            this.lblErrorConfirmPassword.Text = "Thông báo lỗi";
            this.lblErrorConfirmPassword.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorPassword.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorPassword.Location = new System.Drawing.Point(78, 436);
            this.lblErrorPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(422, 25);
            this.lblErrorPassword.TabIndex = 29;
            this.lblErrorPassword.Text = "Thông báo lỗi";
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorEmail.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorEmail.Location = new System.Drawing.Point(78, 172);
            this.lblErrorEmail.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(422, 25);
            this.lblErrorEmail.TabIndex = 28;
            this.lblErrorEmail.Text = "Thông báo lỗi";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorUsername.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorUsername.Location = new System.Drawing.Point(78, 304);
            this.lblErrorUsername.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(422, 25);
            this.lblErrorUsername.TabIndex = 27;
            this.lblErrorUsername.Text = "Thông báo lỗi";
            this.lblErrorUsername.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(83, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(417, 72);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Đăng nhập với Google";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnSignUp.BorderRadius = 30;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(312, 612);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(188, 49);
            this.btnSignUp.TabIndex = 41;
            this.btnSignUp.Text = "Lưu";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.BorderSize = 2;
            this.txtConfirmPassword.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.InputCharacterValidator = null;
            this.txtConfirmPassword.Location = new System.Drawing.Point(83, 517);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(25, 13, 25, 13);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(417, 44);
            this.txtConfirmPassword.TabIndex = 39;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword.UnderlinedStyle = false;
            this.txtConfirmPassword.Valid = null;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.InputCharacterValidator = null;
            this.txtPassword.Location = new System.Drawing.Point(83, 387);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(25, 13, 25, 13);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(417, 44);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.Valid = null;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.InputCharacterValidator = null;
            this.txtEmail.Location = new System.Drawing.Point(83, 124);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(25, 13, 25, 13);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(417, 44);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Valid = null;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.InputCharacterValidator = null;
            this.txtUsername.Location = new System.Drawing.Point(83, 254);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(25, 13, 25, 13);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(417, 44);
            this.txtUsername.TabIndex = 36;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.Valid = null;
            // 
            // ConfirmLoginGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 704);
            this.Controls.Add(this.lblShowPassword);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblErrorConfirmPassword);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmLoginGoogle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tài khoản";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtConfirmPassword;
        private CustomComponents.AdvancedTextBox txtPassword;
        private CustomComponents.AdvancedTextBox txtEmail;
        private CustomComponents.AdvancedTextBox txtUsername;
        private System.Windows.Forms.Label lblShowPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Label lblTitle;
        private CustomComponents.RoundedButton btnSignUp;
    }
}