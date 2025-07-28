namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserReviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReviewControl));
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblErrContent = new System.Windows.Forms.Label();
            this.lblDateCreate = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblReviewLock = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnSaveReview = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtContent = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.ratingBar = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnViewDetail = new _3S_eShop.CustomComponents.RoundedButton();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 0;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.lblErrContent);
            this.pnlContainer.Controls.Add(this.lblDateCreate);
            this.pnlContainer.Controls.Add(this.lblReviewLock);
            this.pnlContainer.Controls.Add(this.btnSaveReview);
            this.pnlContainer.Controls.Add(this.txtContent);
            this.pnlContainer.Controls.Add(this.ratingBar);
            this.pnlContainer.Controls.Add(this.lblProductName);
            this.pnlContainer.Controls.Add(this.picProduct);
            this.pnlContainer.Controls.Add(this.btnViewDetail);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(950, 337);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.TextColor = System.Drawing.SystemColors.Control;
            // 
            // lblErrContent
            // 
            this.lblErrContent.AutoSize = true;
            this.lblErrContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblErrContent.ForeColor = System.Drawing.Color.Red;
            this.lblErrContent.Location = new System.Drawing.Point(745, 242);
            this.lblErrContent.Name = "lblErrContent";
            this.lblErrContent.Size = new System.Drawing.Size(29, 20);
            this.lblErrContent.TabIndex = 21;
            this.lblErrContent.Text = "Lỗi";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.BackColor = System.Drawing.Color.DimGray;
            this.lblDateCreate.BackgroundColor = System.Drawing.Color.DimGray;
            this.lblDateCreate.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateCreate.BorderRadius = 15;
            this.lblDateCreate.BorderSize = 0;
            this.lblDateCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateCreate.ForeColor = System.Drawing.Color.White;
            this.lblDateCreate.Image = ((System.Drawing.Image)(resources.GetObject("lblDateCreate.Image")));
            this.lblDateCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateCreate.Location = new System.Drawing.Point(14, 282);
            this.lblDateCreate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDateCreate.Size = new System.Drawing.Size(246, 42);
            this.lblDateCreate.TabIndex = 20;
            this.lblDateCreate.Text = "      dd/MM/yyyy HH:mm";
            this.lblDateCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateCreate.TextColor = System.Drawing.Color.White;
            this.lblDateCreate.Visible = false;
            // 
            // lblReviewLock
            // 
            this.lblReviewLock.BackColor = System.Drawing.Color.Salmon;
            this.lblReviewLock.BackgroundColor = System.Drawing.Color.Salmon;
            this.lblReviewLock.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblReviewLock.BorderRadius = 15;
            this.lblReviewLock.BorderSize = 0;
            this.lblReviewLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReviewLock.ForeColor = System.Drawing.Color.White;
            this.lblReviewLock.Image = global::_3S_eShop.Properties.Resources.lock_white_24;
            this.lblReviewLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReviewLock.Location = new System.Drawing.Point(274, 282);
            this.lblReviewLock.Margin = new System.Windows.Forms.Padding(0);
            this.lblReviewLock.Name = "lblReviewLock";
            this.lblReviewLock.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblReviewLock.Size = new System.Drawing.Size(303, 42);
            this.lblReviewLock.TabIndex = 19;
            this.lblReviewLock.Text = "      Không thể sửa sau 7 ngày";
            this.lblReviewLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReviewLock.TextColor = System.Drawing.Color.White;
            this.lblReviewLock.Visible = false;
            // 
            // btnSaveReview
            // 
            this.btnSaveReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSaveReview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSaveReview.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveReview.BorderRadius = 15;
            this.btnSaveReview.BorderSize = 0;
            this.btnSaveReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveReview.FlatAppearance.BorderSize = 0;
            this.btnSaveReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReview.ForeColor = System.Drawing.Color.White;
            this.btnSaveReview.Location = new System.Drawing.Point(749, 282);
            this.btnSaveReview.Name = "btnSaveReview";
            this.btnSaveReview.Size = new System.Drawing.Size(187, 42);
            this.btnSaveReview.TabIndex = 18;
            this.btnSaveReview.Text = "Lưu đánh giá";
            this.btnSaveReview.TextColor = System.Drawing.Color.White;
            this.btnSaveReview.UseVisualStyleBackColor = false;
            this.btnSaveReview.Visible = false;
            this.btnSaveReview.Click += new System.EventHandler(this.btnSaveReview_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.Control;
            this.txtContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtContent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtContent.BorderRadius = 0;
            this.txtContent.BorderSize = 2;
            this.txtContent.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContent.InputCharacterValidator = null;
            this.txtContent.Location = new System.Drawing.Point(15, 130);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContent.PasswordChar = false;
            this.txtContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContent.PlaceholderText = "Đưa ra nhận xét";
            this.txtContent.Size = new System.Drawing.Size(921, 141);
            this.txtContent.TabIndex = 17;
            this.txtContent.Texts = "";
            this.txtContent.UnderlinedStyle = false;
            this.txtContent.Valid = null;
            // 
            // ratingBar
            // 
            this.ratingBar.AllowEdit = true;
            this.ratingBar.BackColor = System.Drawing.SystemColors.Control;
            this.ratingBar.Location = new System.Drawing.Point(127, 73);
            this.ratingBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.RatingValue = 3;
            this.ratingBar.Size = new System.Drawing.Size(339, 42);
            this.ratingBar.Spacing = 4653;
            this.ratingBar.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar.StarSize = 14570;
            this.ratingBar.TabIndex = 10;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(121, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(177, 35);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(15, 15);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(100, 100);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 14;
            this.picProduct.TabStop = false;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewDetail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewDetail.BorderRadius = 15;
            this.btnViewDetail.BorderSize = 0;
            this.btnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(749, 73);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(187, 42);
            this.btnViewDetail.TabIndex = 7;
            this.btnViewDetail.Text = "Xem trên cửa hàng";
            this.btnViewDetail.TextColor = System.Drawing.Color.White;
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // UserReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Name = "UserReviewControl";
            this.Size = new System.Drawing.Size(950, 337);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private CustomComponents.RoundedButton btnViewDetail;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox picProduct;
        private RatingBar ratingBar;
        private CustomComponents.RoundedButton btnSaveReview;
        private CustomComponents.AdvancedTextBox txtContent;
        private CustomControls.RoundedLabel lblReviewLock;
        private CustomControls.RoundedLabel lblDateCreate;
        private System.Windows.Forms.Label lblErrContent;
    }
}
