namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserReviewManagerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReviewManagerControl));
            this.flowSubContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleOrderReviews = new System.Windows.Forms.Label();
            this.lblOrderAccount = new System.Windows.Forms.Label();
            this.flowSubContainer.SuspendLayout();
            this.flowReviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowSubContainer
            // 
            this.flowSubContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowSubContainer.AutoSize = true;
            this.flowSubContainer.Controls.Add(this.flowReviews);
            this.flowSubContainer.Location = new System.Drawing.Point(10, 0);
            this.flowSubContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowSubContainer.MaximumSize = new System.Drawing.Size(980, 0);
            this.flowSubContainer.Name = "flowSubContainer";
            this.flowSubContainer.Size = new System.Drawing.Size(980, 639);
            this.flowSubContainer.TabIndex = 5;
            // 
            // flowReviews
            // 
            this.flowReviews.AutoSize = true;
            this.flowReviews.BackColor = System.Drawing.Color.White;
            this.flowReviews.Controls.Add(this.lblTitleOrderReviews);
            this.flowReviews.Controls.Add(this.lblOrderAccount);
            this.flowReviews.Location = new System.Drawing.Point(5, 20);
            this.flowReviews.Margin = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowReviews.Size = new System.Drawing.Size(973, 99);
            this.flowReviews.TabIndex = 0;
            // 
            // lblTitleOrderReviews
            // 
            this.lblTitleOrderReviews.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitleOrderReviews.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOrderReviews.ForeColor = System.Drawing.Color.White;
            this.lblTitleOrderReviews.Location = new System.Drawing.Point(0, 0);
            this.lblTitleOrderReviews.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleOrderReviews.Name = "lblTitleOrderReviews";
            this.lblTitleOrderReviews.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitleOrderReviews.Size = new System.Drawing.Size(970, 42);
            this.lblTitleOrderReviews.TabIndex = 2;
            this.lblTitleOrderReviews.Text = "Đánh giá các sản phẩm trong đơn hàng #";
            this.lblTitleOrderReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderAccount
            // 
            this.lblOrderAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAccount.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAccount.Image")));
            this.lblOrderAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAccount.Location = new System.Drawing.Point(3, 47);
            this.lblOrderAccount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 10);
            this.lblOrderAccount.Name = "lblOrderAccount";
            this.lblOrderAccount.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAccount.Size = new System.Drawing.Size(967, 37);
            this.lblOrderAccount.TabIndex = 15;
            this.lblOrderAccount.Text = "       Mỗi bài đánh giá mới sẽ mang về cho bạn 5.000 điểm thưởng.";
            // 
            // UserReviewManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowSubContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserReviewManagerControl";
            this.Size = new System.Drawing.Size(1000, 639);
            this.flowSubContainer.ResumeLayout(false);
            this.flowSubContainer.PerformLayout();
            this.flowReviews.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowSubContainer;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private System.Windows.Forms.Label lblTitleOrderReviews;
        private System.Windows.Forms.Label lblOrderAccount;
    }
}
