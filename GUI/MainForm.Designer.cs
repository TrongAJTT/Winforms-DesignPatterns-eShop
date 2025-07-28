namespace _3S_eShop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowUserInfo = new _3S_eShop.CustomControls.RoundedFlowLayoutPanel();
            this.picAccAvatar = new System.Windows.Forms.PictureBox();
            this.btnSupport = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.btnHome = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCategory = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnBrowse = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCart = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnUser = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnSetting = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnAdmin = new _3S_eShop.CustomComponents.RoundedButton();
            this.sidePanel.SuspendLayout();
            this.flowUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(264, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1000, 679);
            this.contentPanel.TabIndex = 32;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.flowUserInfo);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.btnCategory);
            this.sidePanel.Controls.Add(this.btnBrowse);
            this.sidePanel.Controls.Add(this.btnCart);
            this.sidePanel.Controls.Add(this.btnUser);
            this.sidePanel.Controls.Add(this.btnSetting);
            this.sidePanel.Controls.Add(this.btnAdmin);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(264, 679);
            this.sidePanel.TabIndex = 31;
            // 
            // flowUserInfo
            // 
            this.flowUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.flowUserInfo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.flowUserInfo.BorderRadius = 30;
            this.flowUserInfo.BorderSize = 0;
            this.flowUserInfo.Controls.Add(this.picAccAvatar);
            this.flowUserInfo.Controls.Add(this.btnSupport);
            this.flowUserInfo.Controls.Add(this.lblName);
            this.flowUserInfo.Controls.Add(this.lblRole);
            this.flowUserInfo.Controls.Add(this.lblReward);
            this.flowUserInfo.ForeColor = System.Drawing.Color.White;
            this.flowUserInfo.Location = new System.Drawing.Point(10, 10);
            this.flowUserInfo.Margin = new System.Windows.Forms.Padding(10);
            this.flowUserInfo.Name = "flowUserInfo";
            this.flowUserInfo.Padding = new System.Windows.Forms.Padding(10);
            this.flowUserInfo.Size = new System.Drawing.Size(244, 194);
            this.flowUserInfo.TabIndex = 32;
            this.flowUserInfo.TextColor = System.Drawing.Color.White;
            // 
            // picAccAvatar
            // 
            this.picAccAvatar.Image = global::_3S_eShop.Properties.Resources.profile_png;
            this.picAccAvatar.Location = new System.Drawing.Point(10, 10);
            this.picAccAvatar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.picAccAvatar.Name = "picAccAvatar";
            this.picAccAvatar.Size = new System.Drawing.Size(173, 70);
            this.picAccAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAccAvatar.TabIndex = 0;
            this.picAccAvatar.TabStop = false;
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.White;
            this.btnSupport.BackgroundColor = System.Drawing.Color.White;
            this.btnSupport.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSupport.BorderRadius = 30;
            this.btnSupport.BorderSize = 0;
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Image = ((System.Drawing.Image)(resources.GetObject("btnSupport.Image")));
            this.btnSupport.Location = new System.Drawing.Point(186, 25);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(40, 40);
            this.btnSupport.TabIndex = 4;
            this.btnSupport.TextColor = System.Drawing.Color.White;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 90);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(224, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Chào mừng,";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(10, 120);
            this.lblRole.Margin = new System.Windows.Forms.Padding(0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblRole.Size = new System.Drawing.Size(224, 30);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Khách vãn lai";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReward
            // 
            this.lblReward.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.ForeColor = System.Drawing.Color.White;
            this.lblReward.Location = new System.Drawing.Point(10, 150);
            this.lblReward.Margin = new System.Windows.Forms.Padding(0);
            this.lblReward.Name = "lblReward";
            this.lblReward.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblReward.Size = new System.Drawing.Size(224, 30);
            this.lblReward.TabIndex = 3;
            this.lblReward.Text = "Điểm thưởng: 0";
            this.lblReward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 15;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 244);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10, 30, 10, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(242, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "      Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderRadius = 15;
            this.btnCategory.BorderSize = 0;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(10, 302);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategory.Size = new System.Drawing.Size(242, 48);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "      Danh mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextColor = System.Drawing.Color.White;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnBrowse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowse.BorderColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BorderRadius = 15;
            this.btnBrowse.BorderSize = 0;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(10, 360);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrowse.Size = new System.Drawing.Size(242, 48);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "      Tìm kiếm";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.TextColor = System.Drawing.Color.White;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCart.BorderColor = System.Drawing.Color.Transparent;
            this.btnCart.BorderRadius = 15;
            this.btnCart.BorderSize = 0;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(10, 418);
            this.btnCart.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCart.Size = new System.Drawing.Size(242, 48);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "      Giỏ hàng";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextColor = System.Drawing.Color.White;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnUser.BorderRadius = 15;
            this.btnUser.BorderSize = 0;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(10, 476);
            this.btnUser.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUser.Size = new System.Drawing.Size(242, 48);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "      Người dùng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextColor = System.Drawing.Color.White;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.BorderColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderRadius = 15;
            this.btnSetting.BorderSize = 0;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(10, 534);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetting.Size = new System.Drawing.Size(242, 48);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "      Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderRadius = 15;
            this.btnAdmin.BorderSize = 0;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(10, 592);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdmin.Size = new System.Drawing.Size(242, 48);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "      Quản trị viên";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextColor = System.Drawing.Color.White;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3S eShop";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.sidePanel.ResumeLayout(false);
            this.flowUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAccAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private CustomComponents.RoundedButton btnHome;
        private CustomComponents.RoundedButton btnCategory;
        private CustomComponents.RoundedButton btnBrowse;
        private CustomComponents.RoundedButton btnCart;
        private CustomComponents.RoundedButton btnUser;
        private CustomComponents.RoundedButton btnSetting;
        private CustomComponents.RoundedButton btnAdmin;
        private System.Windows.Forms.PictureBox picAccAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblReward;
        private CustomControls.RoundedFlowLayoutPanel flowUserInfo;
        private CustomComponents.RoundedButton btnSupport;
    }
}