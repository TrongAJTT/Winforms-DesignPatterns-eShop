namespace _3S_eShop
{
    partial class DatabaseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfig));
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grServer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoSqlServer = new _3S_eShop.CustomComponents.ColoredRadioButton();
            this.rdoMySql = new _3S_eShop.CustomComponents.ColoredRadioButton();
            this.txtPort = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.grAuth = new System.Windows.Forms.GroupBox();
            this.txtPass = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUname = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnCloud = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnBack = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnConnect = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtFail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grServer.SuspendLayout();
            this.grAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 16.26415F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblTenDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTenDangNhap.Location = new System.Drawing.Point(26, 28);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(338, 37);
            this.lblTenDangNhap.TabIndex = 20;
            this.lblTenDangNhap.Text = "CẤU HÌNH KẾT NỐI";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(376, 20);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(329, 50);
            this.lblTrangThai.TabIndex = 25;
            this.lblTrangThai.Text = "Chưa có dữ liệu trạng thái kết nối";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // grServer
            // 
            this.grServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grServer.Controls.Add(this.label4);
            this.grServer.Controls.Add(this.rdoSqlServer);
            this.grServer.Controls.Add(this.rdoMySql);
            this.grServer.Controls.Add(this.txtPort);
            this.grServer.Controls.Add(this.label3);
            this.grServer.Controls.Add(this.txtDatabase);
            this.grServer.Controls.Add(this.label2);
            this.grServer.Controls.Add(this.label1);
            this.grServer.Controls.Add(this.txtHost);
            this.grServer.ForeColor = System.Drawing.Color.White;
            this.grServer.Location = new System.Drawing.Point(32, 76);
            this.grServer.Name = "grServer";
            this.grServer.Size = new System.Drawing.Size(716, 177);
            this.grServer.TabIndex = 29;
            this.grServer.TabStop = false;
            this.grServer.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "RDBMS:";
            // 
            // rdoSqlServer
            // 
            this.rdoSqlServer.AutoSize = true;
            this.rdoSqlServer.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.rdoSqlServer.Location = new System.Drawing.Point(298, 38);
            this.rdoSqlServer.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoSqlServer.Name = "rdoSqlServer";
            this.rdoSqlServer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoSqlServer.Size = new System.Drawing.Size(141, 34);
            this.rdoSqlServer.TabIndex = 7;
            this.rdoSqlServer.TabStop = true;
            this.rdoSqlServer.Text = "SQL Server";
            this.rdoSqlServer.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoSqlServer.UseVisualStyleBackColor = true;
            // 
            // rdoMySql
            // 
            this.rdoMySql.AutoSize = true;
            this.rdoMySql.Checked = true;
            this.rdoMySql.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.rdoMySql.Location = new System.Drawing.Point(159, 38);
            this.rdoMySql.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoMySql.Name = "rdoMySql";
            this.rdoMySql.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoMySql.Size = new System.Drawing.Size(113, 34);
            this.rdoMySql.TabIndex = 6;
            this.rdoMySql.TabStop = true;
            this.rdoMySql.Text = "My SQL";
            this.rdoMySql.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoMySql.UseVisualStyleBackColor = true;
            this.rdoMySql.CheckedChanged += new System.EventHandler(this.rdoMySql_CheckedChanged);
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
            this.txtPort.Location = new System.Drawing.Point(588, 79);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPort.PasswordChar = false;
            this.txtPort.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPort.PlaceholderText = "";
            this.txtPort.Size = new System.Drawing.Size(97, 32);
            this.txtPort.TabIndex = 5;
            this.txtPort.Texts = "";
            this.txtPort.UnderlinedStyle = false;
            this.txtPort._TextChanged += new System.EventHandler(this.txtPort__TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.SystemColors.Window;
            this.txtDatabase.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDatabase.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDatabase.BorderRadius = 0;
            this.txtDatabase.BorderSize = 2;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatabase.Location = new System.Drawing.Point(159, 119);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Multiline = false;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDatabase.PasswordChar = false;
            this.txtDatabase.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDatabase.PlaceholderText = "";
            this.txtDatabase.Size = new System.Drawing.Size(526, 32);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.Texts = "";
            this.txtDatabase.UnderlinedStyle = false;
            this.txtDatabase._TextChanged += new System.EventHandler(this.txtDatabase__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
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
            this.txtHost.Location = new System.Drawing.Point(159, 79);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Multiline = false;
            this.txtHost.Name = "txtHost";
            this.txtHost.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHost.PasswordChar = false;
            this.txtHost.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHost.PlaceholderText = "";
            this.txtHost.Size = new System.Drawing.Size(349, 32);
            this.txtHost.TabIndex = 0;
            this.txtHost.Texts = "";
            this.txtHost.UnderlinedStyle = false;
            this.txtHost._TextChanged += new System.EventHandler(this.txtHost__TextChanged);
            // 
            // grAuth
            // 
            this.grAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grAuth.Controls.Add(this.txtPass);
            this.grAuth.Controls.Add(this.label5);
            this.grAuth.Controls.Add(this.label6);
            this.grAuth.Controls.Add(this.txtUname);
            this.grAuth.ForeColor = System.Drawing.Color.White;
            this.grAuth.Location = new System.Drawing.Point(32, 272);
            this.grAuth.Name = "grAuth";
            this.grAuth.Size = new System.Drawing.Size(716, 133);
            this.grAuth.TabIndex = 30;
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
            this.txtPass._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
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
            this.txtUname._TextChanged += new System.EventHandler(this.txtUname__TextChanged);
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
            this.btnCloud.Location = new System.Drawing.Point(32, 570);
            this.btnCloud.Name = "btnCloud";
            this.btnCloud.Size = new System.Drawing.Size(232, 40);
            this.btnCloud.TabIndex = 31;
            this.btnCloud.Text = "Cấu hình đám mây";
            this.btnCloud.TextColor = System.Drawing.Color.White;
            this.btnCloud.UseVisualStyleBackColor = false;
            this.btnCloud.Click += new System.EventHandler(this.btnCloud_Click);
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
            this.btnBack.Location = new System.Drawing.Point(620, 570);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 40);
            this.btnBack.TabIndex = 28;
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
            this.btnConnect.Location = new System.Drawing.Point(373, 570);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(212, 40);
            this.btnConnect.TabIndex = 27;
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
            this.txtFail.Location = new System.Drawing.Point(32, 434);
            this.txtFail.Margin = new System.Windows.Forms.Padding(4);
            this.txtFail.Multiline = true;
            this.txtFail.Name = "txtFail";
            this.txtFail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFail.PasswordChar = false;
            this.txtFail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFail.PlaceholderText = "";
            this.txtFail.Size = new System.Drawing.Size(716, 104);
            this.txtFail.TabIndex = 26;
            this.txtFail.Texts = "";
            this.txtFail.UnderlinedStyle = false;
            // 
            // DatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(784, 644);
            this.ControlBox = false;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DatabaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connect Config";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grServer.ResumeLayout(false);
            this.grServer.PerformLayout();
            this.grAuth.ResumeLayout(false);
            this.grAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomComponents.AdvancedTextBox txtFail;
        private CustomComponents.RoundedButton btnConnect;
        private CustomComponents.RoundedButton btnBack;
        private System.Windows.Forms.GroupBox grServer;
        private System.Windows.Forms.Label label1;
        private CustomComponents.AdvancedTextBox txtHost;
        private System.Windows.Forms.Label label4;
        private CustomComponents.ColoredRadioButton rdoSqlServer;
        private CustomComponents.ColoredRadioButton rdoMySql;
        private CustomComponents.AdvancedTextBox txtPort;
        private System.Windows.Forms.Label label3;
        private CustomComponents.AdvancedTextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grAuth;
        private CustomComponents.AdvancedTextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomComponents.AdvancedTextBox txtUname;
        private CustomComponents.RoundedButton btnCloud;
    }
}