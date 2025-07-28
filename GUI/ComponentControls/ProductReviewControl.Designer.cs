namespace _3S_eShop.GUI.ComponentControls
{
    partial class ProductReviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductReviewControl));
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconDate = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.ratingBar = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.flowContainerContent = new _3S_eShop.CustomControls.RoundedFlowLayoutPanel();
            this.contentReview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDate)).BeginInit();
            this.flowContainerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(3, 3);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(24, 24);
            this.iconUser.TabIndex = 4;
            this.iconUser.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(33, 1);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(146, 25);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Tên khách hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.iconUser);
            this.flowLayoutPanel1.Controls.Add(this.lblCustomerName);
            this.flowLayoutPanel1.Controls.Add(this.iconDate);
            this.flowLayoutPanel1.Controls.Add(this.lblDate);
            this.flowLayoutPanel1.Controls.Add(this.ratingBar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(611, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // iconDate
            // 
            this.iconDate.Image = ((System.Drawing.Image)(resources.GetObject("iconDate.Image")));
            this.iconDate.Location = new System.Drawing.Point(185, 3);
            this.iconDate.Name = "iconDate";
            this.iconDate.Size = new System.Drawing.Size(24, 24);
            this.iconDate.TabIndex = 5;
            this.iconDate.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(215, 1);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(163, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Thời gian bình luận";
            // 
            // ratingBar
            // 
            this.ratingBar.AllowEdit = true;
            this.ratingBar.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar.Location = new System.Drawing.Point(384, 1);
            this.ratingBar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.RatingValue = 3;
            this.ratingBar.Size = new System.Drawing.Size(164, 24);
            this.ratingBar.Spacing = 6;
            this.ratingBar.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar.StarSize = 24;
            this.ratingBar.TabIndex = 7;
            // 
            // flowContainerContent
            // 
            this.flowContainerContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowContainerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.flowContainerContent.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.flowContainerContent.BorderRadius = 15;
            this.flowContainerContent.BorderSize = 0;
            this.flowContainerContent.Controls.Add(this.contentReview);
            this.flowContainerContent.ForeColor = System.Drawing.Color.White;
            this.flowContainerContent.Location = new System.Drawing.Point(18, 38);
            this.flowContainerContent.Name = "flowContainerContent";
            this.flowContainerContent.Padding = new System.Windows.Forms.Padding(10);
            this.flowContainerContent.Size = new System.Drawing.Size(596, 90);
            this.flowContainerContent.TabIndex = 6;
            this.flowContainerContent.TextColor = System.Drawing.Color.White;
            // 
            // contentReview
            // 
            this.contentReview.AutoSize = true;
            this.contentReview.Location = new System.Drawing.Point(13, 10);
            this.contentReview.Name = "contentReview";
            this.contentReview.Size = new System.Drawing.Size(159, 25);
            this.contentReview.TabIndex = 0;
            this.contentReview.Text = "Nội dung nhận xét";
            // 
            // ProductReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowContainerContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductReviewControl";
            this.Size = new System.Drawing.Size(617, 131);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDate)).EndInit();
            this.flowContainerContent.ResumeLayout(false);
            this.flowContainerContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox iconDate;
        private System.Windows.Forms.Label lblDate;
        private RatingBar ratingBar;
        private CustomControls.RoundedFlowLayoutPanel flowContainerContent;
        private System.Windows.Forms.Label contentReview;
    }
}
