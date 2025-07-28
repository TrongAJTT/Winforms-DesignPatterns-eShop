namespace _3S_eShop.GUI.MainControls.Auth
{
    partial class SignUpControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTitle = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblErrorOTP = new System.Windows.Forms.Label();
            this.lblOTP = new System.Windows.Forms.Label();
            this.txtOTP = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtConfirmPassword = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtPassword = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnSignUp = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtEmail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtUsername = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.lblEULA = new System.Windows.Forms.LinkLabel();
            this.btnSendOTP = new _3S_eShop.CustomComponents.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.togglePassChar = new _3S_eShop.CustomComponents.ToggleButton();
            this.roundedPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Segoe UI", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTitle.Location = new System.Drawing.Point(37, 26);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(599, 51);
            this.loginTitle.TabIndex = 32;
            this.loginTitle.Text = "Đăng ký tài khoản";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEmail.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(50, 294);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(347, 29);
            this.lblErrorEmail.TabIndex = 29;
            this.lblErrorEmail.Text = "Lỗi email";
            this.lblErrorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorUsername.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsername.Location = new System.Drawing.Point(50, 175);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(347, 29);
            this.lblErrorUsername.TabIndex = 28;
            this.lblErrorUsername.Text = "Lỗi username";
            this.lblErrorUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(57, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 30);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblUsername.Location = new System.Drawing.Point(57, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(164, 30);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Tên người dùng";
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPassword.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(50, 419);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(269, 29);
            this.lblErrorPassword.TabIndex = 35;
            this.lblErrorPassword.Text = "Lỗi mật khẩu";
            this.lblErrorPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPassword.Location = new System.Drawing.Point(57, 341);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 30);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(356, 419);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(280, 29);
            this.lblErrorConfirmPassword.TabIndex = 38;
            this.lblErrorConfirmPassword.Text = "Lỗi mật khẩu";
            this.lblErrorConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblConfirmPassword.Location = new System.Drawing.Point(363, 341);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(196, 30);
            this.lblConfirmPassword.TabIndex = 37;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // lblErrorOTP
            // 
            this.lblErrorOTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorOTP.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOTP.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOTP.Location = new System.Drawing.Point(433, 294);
            this.lblErrorOTP.Name = "lblErrorOTP";
            this.lblErrorOTP.Size = new System.Drawing.Size(203, 29);
            this.lblErrorOTP.TabIndex = 41;
            this.lblErrorOTP.Text = "Lỗi OTP";
            this.lblErrorOTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOTP
            // 
            this.lblOTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOTP.AutoSize = true;
            this.lblOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTP.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblOTP.Location = new System.Drawing.Point(440, 216);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(130, 30);
            this.lblOTP.TabIndex = 40;
            this.lblOTP.Text = "Mã xác thực";
            // 
            // txtOTP
            // 
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtOTP.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtOTP.BorderRadius = 15;
            this.txtOTP.BorderSize = 2;
            this.txtOTP.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold);
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOTP.Location = new System.Drawing.Point(429, 250);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtOTP.PasswordChar = false;
            this.txtOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOTP.PlaceholderText = "";
            this.txtOTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOTP.Size = new System.Drawing.Size(207, 45);
            this.txtOTP.TabIndex = 42;
            this.txtOTP.Texts = "";
            this.txtOTP.UnderlinedStyle = false;
            this.txtOTP.Valid = null;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.BorderSize = 2;
            this.txtConfirmPassword.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(352, 375);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(284, 45);
            this.txtConfirmPassword.TabIndex = 36;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword.UnderlinedStyle = false;
            this.txtConfirmPassword.Valid = null;
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
            this.txtPassword.Location = new System.Drawing.Point(46, 375);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(273, 45);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.Valid = null;
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
            this.btnSignUp.Location = new System.Drawing.Point(467, 474);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(169, 45);
            this.btnSignUp.TabIndex = 24;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(46, 250);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(351, 45);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Valid = null;
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(46, 131);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(351, 45);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.Valid = null;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.btnSendOTP);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.togglePassChar);
            this.roundedPanel1.Controls.Add(this.loginTitle);
            this.roundedPanel1.Controls.Add(this.txtOTP);
            this.roundedPanel1.Controls.Add(this.txtUsername);
            this.roundedPanel1.Controls.Add(this.lblErrorOTP);
            this.roundedPanel1.Controls.Add(this.lblUsername);
            this.roundedPanel1.Controls.Add(this.lblOTP);
            this.roundedPanel1.Controls.Add(this.txtEmail);
            this.roundedPanel1.Controls.Add(this.lblErrorConfirmPassword);
            this.roundedPanel1.Controls.Add(this.lblEmail);
            this.roundedPanel1.Controls.Add(this.lblConfirmPassword);
            this.roundedPanel1.Controls.Add(this.btnSignUp);
            this.roundedPanel1.Controls.Add(this.txtConfirmPassword);
            this.roundedPanel1.Controls.Add(this.lblErrorUsername);
            this.roundedPanel1.Controls.Add(this.lblErrorPassword);
            this.roundedPanel1.Controls.Add(this.lblErrorEmail);
            this.roundedPanel1.Controls.Add(this.lblPassword);
            this.roundedPanel1.Controls.Add(this.txtPassword);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(191, 43);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(673, 547);
            this.roundedPanel1.TabIndex = 43;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkAgree);
            this.flowLayoutPanel1.Controls.Add(this.lblEULA);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 483);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 33);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkAgree.ForeColor = System.Drawing.Color.Black;
            this.chkAgree.Location = new System.Drawing.Point(3, 3);
            this.chkAgree.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(214, 27);
            this.chkAgree.TabIndex = 0;
            this.chkAgree.Text = "Tôi đã đọc và đồng ý với";
            this.chkAgree.UseVisualStyleBackColor = true;
            // 
            // lblEULA
            // 
            this.lblEULA.AutoSize = true;
            this.lblEULA.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEULA.Location = new System.Drawing.Point(217, 4);
            this.lblEULA.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblEULA.Name = "lblEULA";
            this.lblEULA.Size = new System.Drawing.Size(164, 23);
            this.lblEULA.TabIndex = 1;
            this.lblEULA.TabStop = true;
            this.lblEULA.Text = "Điều khoản sử dụng";
            this.lblEULA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEULA_LinkClicked);
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSendOTP.BackColor = System.Drawing.Color.White;
            this.btnSendOTP.BackgroundColor = System.Drawing.Color.White;
            this.btnSendOTP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.BorderRadius = 15;
            this.btnSendOTP.BorderSize = 1;
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.Location = new System.Drawing.Point(573, 258);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(55, 30);
            this.btnSendOTP.TabIndex = 45;
            this.btnSendOTP.Text = "Gửi";
            this.btnSendOTP.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(274, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hiện";
            // 
            // togglePassChar
            // 
            this.togglePassChar.AutoSize = true;
            this.togglePassChar.Location = new System.Drawing.Point(228, 347);
            this.togglePassChar.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglePassChar.Name = "togglePassChar";
            this.togglePassChar.OffBackColor = System.Drawing.Color.Gray;
            this.togglePassChar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togglePassChar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togglePassChar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togglePassChar.Size = new System.Drawing.Size(45, 22);
            this.togglePassChar.TabIndex = 44;
            this.togglePassChar.UseVisualStyleBackColor = true;
            this.togglePassChar.CheckedChanged += new System.EventHandler(this.togglePassChar_CheckedChanged);
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorUsername;
        private CustomComponents.RoundedButton btnSignUp;
        private System.Windows.Forms.Label lblEmail;
        private CustomComponents.AdvancedTextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private CustomComponents.AdvancedTextBox txtUsername;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblPassword;
        private CustomComponents.AdvancedTextBox txtPassword;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private CustomComponents.AdvancedTextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblErrorOTP;
        private System.Windows.Forms.Label lblOTP;
        private CustomComponents.AdvancedTextBox txtOTP;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private CustomComponents.ToggleButton togglePassChar;
        private CustomComponents.RoundedButton btnSendOTP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.LinkLabel lblEULA;
    }
}
