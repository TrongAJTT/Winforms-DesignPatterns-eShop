namespace _3S_eShop.GUI
{
    partial class SettingControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingControl));
            this.flowActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnRestart = new _3S_eShop.CustomComponents.RoundedButton();
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMore = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblInfoGuestCart = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnStopMyAccount = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnImportGuestCart = new _3S_eShop.CustomComponents.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSectionMore = new System.Windows.Forms.Label();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblInfoLog = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblInfoRecent = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnClearLog = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnClearRecent = new _3S_eShop.CustomComponents.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowActions.SuspendLayout();
            this.cmsCategory.SuspendLayout();
            this.pnlMore.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowActions
            // 
            this.flowActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowActions.Controls.Add(this.btnLogout);
            this.flowActions.Controls.Add(this.btnRestart);
            this.flowActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowActions.Location = new System.Drawing.Point(515, 581);
            this.flowActions.Name = "flowActions";
            this.flowActions.Size = new System.Drawing.Size(460, 59);
            this.flowActions.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(274, 3);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(186, 52);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "     Đăng xuất";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnRestart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnRestart.BorderColor = System.Drawing.Color.White;
            this.btnRestart.BorderRadius = 15;
            this.btnRestart.BorderSize = 0;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Location = new System.Drawing.Point(65, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRestart.Size = new System.Drawing.Size(203, 52);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "     Khởi động lại";
            this.btnRestart.TextColor = System.Drawing.Color.White;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // cmsCategory
            // 
            this.cmsCategory.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReload});
            this.cmsCategory.Name = "cmsCategory";
            this.cmsCategory.Size = new System.Drawing.Size(202, 28);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReload.Image")));
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(201, 24);
            this.tsmiReload.Text = "Làm mới (F5 | Ctrl+R)";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // pnlMore
            // 
            this.pnlMore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlMore.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMore.BorderRadius = 30;
            this.pnlMore.BorderSize = 0;
            this.pnlMore.Controls.Add(this.lblInfoGuestCart);
            this.pnlMore.Controls.Add(this.btnStopMyAccount);
            this.pnlMore.Controls.Add(this.btnImportGuestCart);
            this.pnlMore.Controls.Add(this.label5);
            this.pnlMore.Controls.Add(this.label6);
            this.pnlMore.Controls.Add(this.lblSectionMore);
            this.pnlMore.ForeColor = System.Drawing.Color.White;
            this.pnlMore.Location = new System.Drawing.Point(24, 227);
            this.pnlMore.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMore.Name = "pnlMore";
            this.pnlMore.Size = new System.Drawing.Size(951, 182);
            this.pnlMore.TabIndex = 6;
            this.pnlMore.TextColor = System.Drawing.Color.White;
            // 
            // lblInfoGuestCart
            // 
            this.lblInfoGuestCart.BackColor = System.Drawing.Color.White;
            this.lblInfoGuestCart.BackgroundColor = System.Drawing.Color.White;
            this.lblInfoGuestCart.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblInfoGuestCart.BorderRadius = 15;
            this.lblInfoGuestCart.BorderSize = 0;
            this.lblInfoGuestCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoGuestCart.ForeColor = System.Drawing.Color.Black;
            this.lblInfoGuestCart.Location = new System.Drawing.Point(690, 68);
            this.lblInfoGuestCart.Name = "lblInfoGuestCart";
            this.lblInfoGuestCart.Size = new System.Drawing.Size(134, 36);
            this.lblInfoGuestCart.TabIndex = 5;
            this.lblInfoGuestCart.Text = "0 sản phẩm";
            this.lblInfoGuestCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoGuestCart.TextColor = System.Drawing.Color.Black;
            // 
            // btnStopMyAccount
            // 
            this.btnStopMyAccount.BackColor = System.Drawing.Color.White;
            this.btnStopMyAccount.BackgroundColor = System.Drawing.Color.White;
            this.btnStopMyAccount.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStopMyAccount.BorderRadius = 15;
            this.btnStopMyAccount.BorderSize = 0;
            this.btnStopMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopMyAccount.FlatAppearance.BorderSize = 0;
            this.btnStopMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMyAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMyAccount.ForeColor = System.Drawing.Color.Red;
            this.btnStopMyAccount.Location = new System.Drawing.Point(690, 122);
            this.btnStopMyAccount.Name = "btnStopMyAccount";
            this.btnStopMyAccount.Size = new System.Drawing.Size(237, 36);
            this.btnStopMyAccount.TabIndex = 3;
            this.btnStopMyAccount.Text = "Dừng hoạt động";
            this.btnStopMyAccount.TextColor = System.Drawing.Color.Red;
            this.btnStopMyAccount.UseVisualStyleBackColor = false;
            this.btnStopMyAccount.Click += new System.EventHandler(this.btnStopMyAccount_Click);
            // 
            // btnImportGuestCart
            // 
            this.btnImportGuestCart.BackColor = System.Drawing.Color.White;
            this.btnImportGuestCart.BackgroundColor = System.Drawing.Color.White;
            this.btnImportGuestCart.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImportGuestCart.BorderRadius = 15;
            this.btnImportGuestCart.BorderSize = 0;
            this.btnImportGuestCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportGuestCart.Enabled = false;
            this.btnImportGuestCart.FlatAppearance.BorderSize = 0;
            this.btnImportGuestCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportGuestCart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportGuestCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnImportGuestCart.Location = new System.Drawing.Point(841, 68);
            this.btnImportGuestCart.Name = "btnImportGuestCart";
            this.btnImportGuestCart.Size = new System.Drawing.Size(86, 36);
            this.btnImportGuestCart.TabIndex = 3;
            this.btnImportGuestCart.Text = "Nhập";
            this.btnImportGuestCart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnImportGuestCart.UseVisualStyleBackColor = false;
            this.btnImportGuestCart.Click += new System.EventHandler(this.btnImportGuestCart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dừng hoạt động tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập dữ liệu giỏ hàng từ phiên khách vãn lai";
            // 
            // lblSectionMore
            // 
            this.lblSectionMore.BackColor = System.Drawing.Color.SlateBlue;
            this.lblSectionMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSectionMore.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionMore.Location = new System.Drawing.Point(0, 0);
            this.lblSectionMore.Name = "lblSectionMore";
            this.lblSectionMore.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblSectionMore.Size = new System.Drawing.Size(951, 47);
            this.lblSectionMore.TabIndex = 0;
            this.lblSectionMore.Text = "Tài khoản";
            this.lblSectionMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSectionMore.Click += new System.EventHandler(this.lblSectionMore_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.lblInfoLog);
            this.roundedPanel1.Controls.Add(this.lblInfoRecent);
            this.roundedPanel1.Controls.Add(this.btnClearLog);
            this.roundedPanel1.Controls.Add(this.btnClearRecent);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(24, 24);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(951, 166);
            this.roundedPanel1.TabIndex = 5;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lblInfoLog
            // 
            this.lblInfoLog.BackColor = System.Drawing.Color.White;
            this.lblInfoLog.BackgroundColor = System.Drawing.Color.White;
            this.lblInfoLog.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblInfoLog.BorderRadius = 15;
            this.lblInfoLog.BorderSize = 0;
            this.lblInfoLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoLog.ForeColor = System.Drawing.Color.Black;
            this.lblInfoLog.Location = new System.Drawing.Point(685, 109);
            this.lblInfoLog.Name = "lblInfoLog";
            this.lblInfoLog.Size = new System.Drawing.Size(139, 36);
            this.lblInfoLog.TabIndex = 6;
            this.lblInfoLog.Text = "3 sản phẩm";
            this.lblInfoLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoLog.TextColor = System.Drawing.Color.Black;
            // 
            // lblInfoRecent
            // 
            this.lblInfoRecent.BackColor = System.Drawing.Color.White;
            this.lblInfoRecent.BackgroundColor = System.Drawing.Color.White;
            this.lblInfoRecent.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblInfoRecent.BorderRadius = 15;
            this.lblInfoRecent.BorderSize = 0;
            this.lblInfoRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoRecent.ForeColor = System.Drawing.Color.Black;
            this.lblInfoRecent.Location = new System.Drawing.Point(685, 64);
            this.lblInfoRecent.Name = "lblInfoRecent";
            this.lblInfoRecent.Size = new System.Drawing.Size(139, 36);
            this.lblInfoRecent.TabIndex = 5;
            this.lblInfoRecent.Text = "3 sản phẩm";
            this.lblInfoRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoRecent.TextColor = System.Drawing.Color.Black;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.White;
            this.btnClearLog.BackgroundColor = System.Drawing.Color.White;
            this.btnClearLog.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClearLog.BorderRadius = 15;
            this.btnClearLog.BorderSize = 0;
            this.btnClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLog.FlatAppearance.BorderSize = 0;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnClearLog.Location = new System.Drawing.Point(841, 109);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(86, 36);
            this.btnClearLog.TabIndex = 4;
            this.btnClearLog.Text = "Xóa";
            this.btnClearLog.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnClearRecent
            // 
            this.btnClearRecent.BackColor = System.Drawing.Color.White;
            this.btnClearRecent.BackgroundColor = System.Drawing.Color.White;
            this.btnClearRecent.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClearRecent.BorderRadius = 15;
            this.btnClearRecent.BorderSize = 0;
            this.btnClearRecent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRecent.FlatAppearance.BorderSize = 0;
            this.btnClearRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnClearRecent.Location = new System.Drawing.Point(841, 64);
            this.btnClearRecent.Name = "btnClearRecent";
            this.btnClearRecent.Size = new System.Drawing.Size(86, 36);
            this.btnClearRecent.TabIndex = 3;
            this.btnClearRecent.Text = "Xóa";
            this.btnClearRecent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnClearRecent.UseVisualStyleBackColor = false;
            this.btnClearRecent.Click += new System.EventHandler(this.btnClearRecent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xóa dữ liệu log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xóa các sản phẩm đã xem gần đây";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(951, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dọn dẹp dữ liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ContextMenuStrip = this.cmsCategory;
            this.Controls.Add(this.flowActions);
            this.Controls.Add(this.pnlMore);
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(1000, 660);
            this.Load += new System.EventHandler(this.SettingControl_Load);
            this.flowActions.ResumeLayout(false);
            this.cmsCategory.ResumeLayout(false);
            this.pnlMore.ResumeLayout(false);
            this.pnlMore.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.RoundedButton btnLogout;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedButton btnClearLog;
        private CustomComponents.RoundedButton btnClearRecent;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedPanel pnlMore;
        private CustomComponents.RoundedButton btnStopMyAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSectionMore;
        private CustomComponents.RoundedButton btnRestart;
        private System.Windows.Forms.FlowLayoutPanel flowActions;
        private CustomControls.RoundedLabel lblInfoLog;
        private CustomControls.RoundedLabel lblInfoRecent;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
        private CustomControls.RoundedLabel lblInfoGuestCart;
        private CustomComponents.RoundedButton btnImportGuestCart;
        private System.Windows.Forms.Label label6;
    }
}
