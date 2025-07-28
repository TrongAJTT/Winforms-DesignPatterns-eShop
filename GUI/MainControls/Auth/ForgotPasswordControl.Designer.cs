namespace _3S_eShop.GUI.MainControls.Auth
{
    partial class ForgotPasswordControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnSendOTP = new _3S_eShop.CustomComponents.RoundedButton();
            this.loginTitle = new System.Windows.Forms.Label();
            this.txtEmail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.titleEmail = new System.Windows.Forms.Label();
            this.lblOtpErr = new System.Windows.Forms.Label();
            this.txtOtp = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblEmailErr = new System.Windows.Forms.Label();
            this.labelOtp = new System.Windows.Forms.Label();
            this.btnContinue = new _3S_eShop.CustomComponents.RoundedButton();
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
            this.roundedPanel1.Controls.Add(this.btnSendOTP);
            this.roundedPanel1.Controls.Add(this.loginTitle);
            this.roundedPanel1.Controls.Add(this.txtEmail);
            this.roundedPanel1.Controls.Add(this.titleEmail);
            this.roundedPanel1.Controls.Add(this.lblOtpErr);
            this.roundedPanel1.Controls.Add(this.txtOtp);
            this.roundedPanel1.Controls.Add(this.lblEmailErr);
            this.roundedPanel1.Controls.Add(this.labelOtp);
            this.roundedPanel1.Controls.Add(this.btnContinue);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(285, 95);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(440, 494);
            this.roundedPanel1.TabIndex = 20;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSendOTP.BackColor = System.Drawing.Color.White;
            this.btnSendOTP.BackgroundColor = System.Drawing.Color.White;
            this.btnSendOTP.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSendOTP.BorderRadius = 15;
            this.btnSendOTP.BorderSize = 0;
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOTP.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.Location = new System.Drawing.Point(298, 281);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(106, 45);
            this.btnSendOTP.TabIndex = 21;
            this.btnSendOTP.Text = "Gửi mã";
            this.btnSendOTP.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOtp_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Segoe UI", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTitle.Location = new System.Drawing.Point(41, 54);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(363, 51);
            this.loginTitle.TabIndex = 18;
            this.loginTitle.Text = "Quên mật khẩu";
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
            this.txtEmail.Location = new System.Drawing.Point(42, 172);
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
            this.titleEmail.Location = new System.Drawing.Point(53, 138);
            this.titleEmail.Name = "titleEmail";
            this.titleEmail.Size = new System.Drawing.Size(64, 30);
            this.titleEmail.TabIndex = 1;
            this.titleEmail.Text = "Email";
            // 
            // lblOtpErr
            // 
            this.lblOtpErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOtpErr.BackColor = System.Drawing.Color.Transparent;
            this.lblOtpErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtpErr.ForeColor = System.Drawing.Color.Red;
            this.lblOtpErr.Location = new System.Drawing.Point(46, 325);
            this.lblOtpErr.Name = "lblOtpErr";
            this.lblOtpErr.Size = new System.Drawing.Size(220, 29);
            this.lblOtpErr.TabIndex = 15;
            this.lblOtpErr.Text = "Lỗi mã";
            this.lblOtpErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOtp
            // 
            this.txtOtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOtp.BackColor = System.Drawing.SystemColors.Window;
            this.txtOtp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtOtp.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtOtp.BorderRadius = 15;
            this.txtOtp.BorderSize = 2;
            this.txtOtp.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOtp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOtp.Location = new System.Drawing.Point(42, 281);
            this.txtOtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtp.Multiline = false;
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtOtp.PasswordChar = false;
            this.txtOtp.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtOtp.PlaceholderText = "";
            this.txtOtp.Size = new System.Drawing.Size(224, 45);
            this.txtOtp.TabIndex = 2;
            this.txtOtp.Texts = "";
            this.txtOtp.UnderlinedStyle = false;
            this.txtOtp.Valid = null;
            // 
            // lblEmailErr
            // 
            this.lblEmailErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmailErr.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailErr.ForeColor = System.Drawing.Color.Red;
            this.lblEmailErr.Location = new System.Drawing.Point(46, 216);
            this.lblEmailErr.Name = "lblEmailErr";
            this.lblEmailErr.Size = new System.Drawing.Size(358, 29);
            this.lblEmailErr.TabIndex = 14;
            this.lblEmailErr.Text = "Lỗi";
            this.lblEmailErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOtp
            // 
            this.labelOtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOtp.AutoSize = true;
            this.labelOtp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtp.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelOtp.Location = new System.Drawing.Point(53, 247);
            this.labelOtp.Name = "labelOtp";
            this.labelOtp.Size = new System.Drawing.Size(88, 30);
            this.labelOtp.TabIndex = 3;
            this.labelOtp.Text = "Mã OTP";
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnContinue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.BorderRadius = 15;
            this.btnContinue.BorderSize = 1;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.Location = new System.Drawing.Point(42, 388);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(362, 45);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // ForgotPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ForgotPasswordControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label loginTitle;
        private CustomComponents.AdvancedTextBox txtEmail;
        private System.Windows.Forms.Label titleEmail;
        private System.Windows.Forms.Label lblOtpErr;
        private CustomComponents.AdvancedTextBox txtOtp;
        private System.Windows.Forms.Label lblEmailErr;
        private System.Windows.Forms.Label labelOtp;
        private CustomComponents.RoundedButton btnContinue;
        private CustomComponents.RoundedButton btnSendOTP;
    }
}
