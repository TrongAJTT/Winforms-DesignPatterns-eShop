namespace _3S_eShop.GUI.ComponentForm
{
    partial class BannerManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BannerManagerForm));
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOverlay = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnAddBanner = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblNoBanner = new _3S_eShop.CustomControls.RoundedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowMain.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMain
            // 
            this.flowMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMain.AutoScroll = true;
            this.flowMain.Controls.Add(this.lblOverlay);
            this.flowMain.Location = new System.Drawing.Point(0, -20);
            this.flowMain.Name = "flowMain";
            this.flowMain.Padding = new System.Windows.Forms.Padding(10);
            this.flowMain.Size = new System.Drawing.Size(1030, 491);
            this.flowMain.TabIndex = 14;
            // 
            // lblOverlay
            // 
            this.lblOverlay.AutoSize = true;
            this.lblOverlay.Location = new System.Drawing.Point(20, 20);
            this.lblOverlay.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblOverlay.Name = "lblOverlay";
            this.lblOverlay.Size = new System.Drawing.Size(163, 25);
            this.lblOverlay.TabIndex = 0;
            this.lblOverlay.Text = "Đang tải dữ liệu ...";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.flowMain);
            this.pnlContainer.Location = new System.Drawing.Point(0, 89);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1015, 470);
            this.pnlContainer.TabIndex = 15;
            // 
            // btnAddBanner
            // 
            this.btnAddBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddBanner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddBanner.BorderColor = System.Drawing.Color.White;
            this.btnAddBanner.BorderRadius = 15;
            this.btnAddBanner.BorderSize = 0;
            this.btnAddBanner.FlatAppearance.BorderSize = 0;
            this.btnAddBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBanner.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBanner.ForeColor = System.Drawing.Color.White;
            this.btnAddBanner.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBanner.Image")));
            this.btnAddBanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBanner.Location = new System.Drawing.Point(20, 20);
            this.btnAddBanner.Name = "btnAddBanner";
            this.btnAddBanner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddBanner.Size = new System.Drawing.Size(157, 48);
            this.btnAddBanner.TabIndex = 13;
            this.btnAddBanner.Text = "    Thêm";
            this.btnAddBanner.TextColor = System.Drawing.Color.White;
            this.btnAddBanner.UseVisualStyleBackColor = false;
            this.btnAddBanner.Click += new System.EventHandler(this.btnAddBanner_Click);
            // 
            // lblNoBanner
            // 
            this.lblNoBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoBanner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoBanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoBanner.BorderRadius = 30;
            this.lblNoBanner.BorderSize = 0;
            this.lblNoBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoBanner.ForeColor = System.Drawing.Color.White;
            this.lblNoBanner.Location = new System.Drawing.Point(760, 21);
            this.lblNoBanner.Name = "lblNoBanner";
            this.lblNoBanner.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblNoBanner.Size = new System.Drawing.Size(231, 48);
            this.lblNoBanner.TabIndex = 16;
            this.lblNoBanner.Text = "Số lượng banner: ";
            this.lblNoBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoBanner.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(190, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click phải chuột để sửa hoặc xóa banner.\r\nLà banner phụ thì số lượng banner nên l" +
    "à bội số của 2.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BannerManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 559);
            this.Controls.Add(this.lblNoBanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnAddBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "BannerManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều chỉnh banner quảng cáo";
            this.flowMain.ResumeLayout(false);
            this.flowMain.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.RoundedButton btnAddBanner;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblOverlay;
        private CustomControls.RoundedLabel lblNoBanner;
        private System.Windows.Forms.Label label1;
    }
}