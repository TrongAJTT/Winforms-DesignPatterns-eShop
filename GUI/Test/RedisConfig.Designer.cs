namespace _3S_eShop.GUI.Test
{
    partial class RedisConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedisConfig));
            this.btnCloud = new _3S_eShop.CustomComponents.RoundedButton();
            this.grAuth = new System.Windows.Forms.GroupBox();
            this.txtPass = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUname = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.grServer = new System.Windows.Forms.GroupBox();
            this.txtPort = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnBack = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnConnect = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtFail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grAuth.SuspendLayout();
            this.grServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloud
            // 
            this.btnCloud.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloud.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCloud.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCloud.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnCloud.BorderRadius = 30;
            this.btnCloud.BorderSize = 0;
            this.btnCloud.FlatAppearance.BorderSize = 0;
            this.btnCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloud.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloud.ForeColor = System.Drawing.Color.White;
            this.btnCloud.Location = new System.Drawing.Point(37, 531);
            this.btnCloud.Name = "btnCloud";
            this.btnCloud.Size = new System.Drawing.Size(232, 40);
            this.btnCloud.TabIndex = 40;
            this.btnCloud.Text = "Cấu hình đám mây";
            this.btnCloud.TextColor = System.Drawing.Color.White;
            this.btnCloud.UseVisualStyleBackColor = false;
            this.btnCloud.Click += new System.EventHandler(this.btnCloud_Click);
            // 
            // grAuth
            // 
            this.grAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grAuth.Controls.Add(this.txtPass);
            this.grAuth.Controls.Add(this.label5);
            this.grAuth.Controls.Add(this.label6);
            this.grAuth.Controls.Add(this.txtUname);
            this.grAuth.ForeColor = System.Drawing.Color.White;
            this.grAuth.Location = new System.Drawing.Point(37, 235);
            this.grAuth.Name = "grAuth";
            this.grAuth.Size = new System.Drawing.Size(716, 133);
            this.grAuth.TabIndex = 39;
            this.grAuth.TabStop = false;
            this.grAuth.Text = "Authentication";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPass.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPass.BorderRadius = 0;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(159, 78);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = false;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.Size = new System.Drawing.Size(526, 32);
            this.txtPass.TabIndex = 3;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username:";
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.SystemColors.Window;
            this.txtUname.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUname.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUname.BorderRadius = 0;
            this.txtUname.BorderSize = 2;
            this.txtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUname.Location = new System.Drawing.Point(159, 38);
            this.txtUname.Margin = new System.Windows.Forms.Padding(4);
            this.txtUname.Multiline = false;
            this.txtUname.Name = "txtUname";
            this.txtUname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUname.PasswordChar = false;
            this.txtUname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUname.PlaceholderText = "";
            this.txtUname.Size = new System.Drawing.Size(526, 32);
            this.txtUname.TabIndex = 0;
            this.txtUname.Texts = "";
            this.txtUname.UnderlinedStyle = false;
            // 
            // grServer
            // 
            this.grServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grServer.Controls.Add(this.txtPort);
            this.grServer.Controls.Add(this.label3);
            this.grServer.Controls.Add(this.label1);
            this.grServer.Controls.Add(this.txtHost);
            this.grServer.ForeColor = System.Drawing.Color.White;
            this.grServer.Location = new System.Drawing.Point(37, 72);
            this.grServer.Name = "grServer";
            this.grServer.Size = new System.Drawing.Size(716, 141);
            this.grServer.TabIndex = 38;
            this.grServer.TabStop = false;
            this.grServer.Text = "Server";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtPort.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPort.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPort.BorderRadius = 0;
            this.txtPort.BorderSize = 2;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPort.Location = new System.Drawing.Point(159, 80);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPort.PasswordChar = false;
            this.txtPort.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPort.PlaceholderText = "";
            this.txtPort.Size = new System.Drawing.Size(526, 32);
            this.txtPort.TabIndex = 5;
            this.txtPort.Texts = "";
            this.txtPort.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Host:";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.SystemColors.Window;
            this.txtHost.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtHost.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtHost.BorderRadius = 0;
            this.txtHost.BorderSize = 2;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHost.Location = new System.Drawing.Point(159, 40);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Multiline = false;
            this.txtHost.Name = "txtHost";
            this.txtHost.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHost.PasswordChar = false;
            this.txtHost.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHost.PlaceholderText = "";
            this.txtHost.Size = new System.Drawing.Size(526, 32);
            this.txtHost.TabIndex = 0;
            this.txtHost.Texts = "";
            this.txtHost.UnderlinedStyle = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnBack.BorderRadius = 30;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Location = new System.Drawing.Point(625, 531);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 40);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConnect.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConnect.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConnect.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnConnect.BorderRadius = 30;
            this.btnConnect.BorderSize = 0;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(378, 531);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(212, 40);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.Text = "Kiểm tra kết nối";
            this.btnConnect.TextColor = System.Drawing.Color.White;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtFail
            // 
            this.txtFail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFail.AutoSize = true;
            this.txtFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFail.BorderColor = System.Drawing.Color.IndianRed;
            this.txtFail.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.txtFail.BorderRadius = 0;
            this.txtFail.BorderSize = 2;
            this.txtFail.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFail.ForeColor = System.Drawing.Color.White;
            this.txtFail.Location = new System.Drawing.Point(37, 396);
            this.txtFail.Margin = new System.Windows.Forms.Padding(4);
            this.txtFail.Multiline = true;
            this.txtFail.Name = "txtFail";
            this.txtFail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFail.PasswordChar = false;
            this.txtFail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFail.PlaceholderText = "";
            this.txtFail.Size = new System.Drawing.Size(716, 104);
            this.txtFail.TabIndex = 35;
            this.txtFail.Texts = "";
            this.txtFail.UnderlinedStyle = false;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 16.26415F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblTenDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTenDangNhap.Location = new System.Drawing.Point(31, 35);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(338, 37);
            this.lblTenDangNhap.TabIndex = 32;
            this.lblTenDangNhap.Text = "CẤU HÌNH KẾT NỐI";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(381, 27);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(329, 50);
            this.lblTrangThai.TabIndex = 34;
            this.lblTrangThai.Text = "Chưa có dữ liệu trạng thái kết nối";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // RedisConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.btnCloud);
            this.Controls.Add(this.grAuth);
            this.Controls.Add(this.grServer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtFail);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RedisConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redis Connect Config";
            this.grAuth.ResumeLayout(false);
            this.grAuth.PerformLayout();
            this.grServer.ResumeLayout(false);
            this.grServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.RoundedButton btnCloud;
        private System.Windows.Forms.GroupBox grAuth;
        private CustomComponents.AdvancedTextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomComponents.AdvancedTextBox txtUname;
        private System.Windows.Forms.GroupBox grServer;
        private CustomComponents.AdvancedTextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CustomComponents.AdvancedTextBox txtHost;
        private CustomComponents.RoundedButton btnBack;
        private CustomComponents.RoundedButton btnConnect;
        private CustomComponents.AdvancedTextBox txtFail;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}