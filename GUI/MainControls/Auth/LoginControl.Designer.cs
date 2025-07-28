namespace _3S_eShop.GUI.MainControls.Auth
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.togglePassChar = new _3S_eShop.CustomComponents.ToggleButton();
            this.loginTitle = new System.Windows.Forms.Label();
            this.txtEmail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.titleEmail = new System.Windows.Forms.Label();
            this.lblPassErr = new System.Windows.Forms.Label();
            this.txtPassword = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblEmailErr = new System.Windows.Forms.Label();
            this.titlePassword = new System.Windows.Forms.Label();
            this.btnSignUp = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnForgetPass = new _3S_eShop.CustomComponents.RoundedButton();
            this.titleOr = new System.Windows.Forms.Label();
            this.btnLogin = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnGoogleAuth = new _3S_eShop.CustomComponents.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.togglePassChar);
            this.roundedPanel1.Controls.Add(this.loginTitle);
            this.roundedPanel1.Controls.Add(this.txtEmail);
            this.roundedPanel1.Controls.Add(this.titleEmail);
            this.roundedPanel1.Controls.Add(this.lblPassErr);
            this.roundedPanel1.Controls.Add(this.txtPassword);
            this.roundedPanel1.Controls.Add(this.lblEmailErr);
            this.roundedPanel1.Controls.Add(this.titlePassword);
            this.roundedPanel1.Controls.Add(this.btnSignUp);
            this.roundedPanel1.Controls.Add(this.btnForgetPass);
            this.roundedPanel1.Controls.Add(this.titleOr);
            this.roundedPanel1.Controls.Add(this.btnLogin);
            this.roundedPanel1.Controls.Add(this.btnGoogleAuth);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(308, 24);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(439, 625);
            this.roundedPanel1.TabIndex = 19;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(299, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hiện mật khẩu";
            // 
            // togglePassChar
            // 
            this.togglePassChar.AutoSize = true;
            this.togglePassChar.Location = new System.Drawing.Point(253, 230);
            this.togglePassChar.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglePassChar.Name = "togglePassChar";
            this.togglePassChar.OffBackColor = System.Drawing.Color.Gray;
            this.togglePassChar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togglePassChar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togglePassChar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togglePassChar.Size = new System.Drawing.Size(45, 22);
            this.togglePassChar.TabIndex = 20;
            this.togglePassChar.UseVisualStyleBackColor = true;
            this.togglePassChar.CheckedChanged += new System.EventHandler(this.togglePassChar_CheckedChanged);
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Segoe UI", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTitle.Location = new System.Drawing.Point(41, 41);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(363, 51);
            this.loginTitle.TabIndex = 18;
            this.loginTitle.Text = "Đăng nhập";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(42, 149);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(362, 45);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Valid = null;
            // 
            // titleEmail
            // 
            this.titleEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleEmail.AutoSize = true;
            this.titleEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.titleEmail.Location = new System.Drawing.Point(53, 115);
            this.titleEmail.Name = "titleEmail";
            this.titleEmail.Size = new System.Drawing.Size(64, 30);
            this.titleEmail.TabIndex = 1;
            this.titleEmail.Text = "Email";
            // 
            // lblPassErr
            // 
            this.lblPassErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassErr.BackColor = System.Drawing.Color.Transparent;
            this.lblPassErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassErr.ForeColor = System.Drawing.Color.Red;
            this.lblPassErr.Location = new System.Drawing.Point(46, 302);
            this.lblPassErr.Name = "lblPassErr";
            this.lblPassErr.Size = new System.Drawing.Size(358, 29);
            this.lblPassErr.TabIndex = 15;
            this.lblPassErr.Text = "Lỗi mật khẩu";
            this.lblPassErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(42, 258);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(362, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.Valid = null;
            // 
            // lblEmailErr
            // 
            this.lblEmailErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmailErr.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailErr.ForeColor = System.Drawing.Color.Red;
            this.lblEmailErr.Location = new System.Drawing.Point(46, 193);
            this.lblEmailErr.Name = "lblEmailErr";
            this.lblEmailErr.Size = new System.Drawing.Size(358, 29);
            this.lblEmailErr.TabIndex = 14;
            this.lblEmailErr.Text = "Lỗi email";
            this.lblEmailErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titlePassword
            // 
            this.titlePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titlePassword.AutoSize = true;
            this.titlePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.titlePassword.Location = new System.Drawing.Point(53, 224);
            this.titlePassword.Name = "titlePassword";
            this.titlePassword.Size = new System.Drawing.Size(103, 30);
            this.titlePassword.TabIndex = 3;
            this.titlePassword.Text = "Mật khẩu";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.White;
            this.btnSignUp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BorderRadius = 15;
            this.btnSignUp.BorderSize = 1;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.Location = new System.Drawing.Point(42, 437);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(362, 45);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.btnSignUp.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnForgetPass.BackColor = System.Drawing.Color.White;
            this.btnForgetPass.BackgroundColor = System.Drawing.Color.White;
            this.btnForgetPass.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnForgetPass.BorderRadius = 15;
            this.btnForgetPass.BorderSize = 0;
            this.btnForgetPass.FlatAppearance.BorderSize = 0;
            this.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgetPass.Location = new System.Drawing.Point(42, 350);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(183, 45);
            this.btnForgetPass.TabIndex = 4;
            this.btnForgetPass.Text = "Quên mật khẩu?";
            this.btnForgetPass.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgetPass.UseVisualStyleBackColor = false;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // titleOr
            // 
            this.titleOr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleOr.BackColor = System.Drawing.Color.Transparent;
            this.titleOr.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOr.ForeColor = System.Drawing.Color.Black;
            this.titleOr.Location = new System.Drawing.Point(42, 496);
            this.titleOr.Name = "titleOr";
            this.titleOr.Size = new System.Drawing.Size(362, 30);
            this.titleOr.TabIndex = 12;
            this.titleOr.Text = "━━━━ hoặc ━━━━";
            this.titleOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.Location = new System.Drawing.Point(261, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGoogleAuth
            // 
            this.btnGoogleAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGoogleAuth.BackColor = System.Drawing.Color.White;
            this.btnGoogleAuth.BackgroundColor = System.Drawing.Color.White;
            this.btnGoogleAuth.BorderColor = System.Drawing.Color.Black;
            this.btnGoogleAuth.BorderRadius = 15;
            this.btnGoogleAuth.BorderSize = 0;
            this.btnGoogleAuth.FlatAppearance.BorderSize = 0;
            this.btnGoogleAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogleAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogleAuth.ForeColor = System.Drawing.Color.Black;
            this.btnGoogleAuth.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogleAuth.Image")));
            this.btnGoogleAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogleAuth.Location = new System.Drawing.Point(42, 541);
            this.btnGoogleAuth.Name = "btnGoogleAuth";
            this.btnGoogleAuth.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGoogleAuth.Size = new System.Drawing.Size(362, 47);
            this.btnGoogleAuth.TabIndex = 11;
            this.btnGoogleAuth.Text = "    Đăng nhập với Google";
            this.btnGoogleAuth.TextColor = System.Drawing.Color.Black;
            this.btnGoogleAuth.UseVisualStyleBackColor = false;
            this.btnGoogleAuth.Click += new System.EventHandler(this.btnGoogleAuth_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtEmail;
        private System.Windows.Forms.Label titleEmail;
        private CustomComponents.AdvancedTextBox txtPassword;
        private System.Windows.Forms.Label titlePassword;
        private CustomComponents.RoundedButton btnForgetPass;
        private CustomComponents.RoundedButton btnLogin;
        private CustomComponents.RoundedButton btnGoogleAuth;
        private System.Windows.Forms.Label titleOr;
        private CustomComponents.RoundedButton btnSignUp;
        private System.Windows.Forms.Label lblEmailErr;
        private System.Windows.Forms.Label lblPassErr;
        private System.Windows.Forms.Label loginTitle;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomComponents.ToggleButton togglePassChar;
        private System.Windows.Forms.Label label2;
    }
}
