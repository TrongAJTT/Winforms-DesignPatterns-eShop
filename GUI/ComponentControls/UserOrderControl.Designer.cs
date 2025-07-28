namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderControl));
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblDateOrder = new _3S_eShop.CustomControls.RoundedLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPriceFirstVariant = new System.Windows.Forms.Label();
            this.lblOrigionalPriceFirstVariant = new System.Windows.Forms.Label();
            this.flowAction = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewDetail = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnBuyAgain = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnRating = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblTotalPrice = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblQuantityFirstVariant = new System.Windows.Forms.Label();
            this.lblNumberOtherProduct = new System.Windows.Forms.Label();
            this.lblLabelFirstVariant = new System.Windows.Forms.Label();
            this.lblOrderStatus = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNameFirstProduct = new System.Windows.Forms.Label();
            this.picFirstProduct = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 30;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.lblDateOrder);
            this.pnlContainer.Controls.Add(this.flowLayoutPanel1);
            this.pnlContainer.Controls.Add(this.flowAction);
            this.pnlContainer.Controls.Add(this.lblTotalPrice);
            this.pnlContainer.Controls.Add(this.lblQuantityFirstVariant);
            this.pnlContainer.Controls.Add(this.lblNumberOtherProduct);
            this.pnlContainer.Controls.Add(this.lblLabelFirstVariant);
            this.pnlContainer.Controls.Add(this.lblOrderStatus);
            this.pnlContainer.Controls.Add(this.lblNameFirstProduct);
            this.pnlContainer.Controls.Add(this.picFirstProduct);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(950, 200);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.TextColor = System.Drawing.Color.White;
            // 
            // lblDateOrder
            // 
            this.lblDateOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateOrder.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateOrder.BorderRadius = 15;
            this.lblDateOrder.BorderSize = 0;
            this.lblDateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateOrder.ForeColor = System.Drawing.Color.White;
            this.lblDateOrder.Image = ((System.Drawing.Image)(resources.GetObject("lblDateOrder.Image")));
            this.lblDateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateOrder.Location = new System.Drawing.Point(343, 145);
            this.lblDateOrder.Name = "lblDateOrder";
            this.lblDateOrder.Padding = new System.Windows.Forms.Padding(7);
            this.lblDateOrder.Size = new System.Drawing.Size(201, 42);
            this.lblDateOrder.TabIndex = 14;
            this.lblDateOrder.Text = "      23/03/2025 11:18";
            this.lblDateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateOrder.TextColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.lblPriceFirstVariant);
            this.flowLayoutPanel1.Controls.Add(this.lblOrigionalPriceFirstVariant);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(607, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 30);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // lblPriceFirstVariant
            // 
            this.lblPriceFirstVariant.AutoSize = true;
            this.lblPriceFirstVariant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceFirstVariant.ForeColor = System.Drawing.Color.Black;
            this.lblPriceFirstVariant.Location = new System.Drawing.Point(142, 0);
            this.lblPriceFirstVariant.Name = "lblPriceFirstVariant";
            this.lblPriceFirstVariant.Size = new System.Drawing.Size(128, 30);
            this.lblPriceFirstVariant.TabIndex = 10;
            this.lblPriceFirstVariant.Text = "10.000.000đ";
            this.lblPriceFirstVariant.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrigionalPriceFirstVariant
            // 
            this.lblOrigionalPriceFirstVariant.AutoSize = true;
            this.lblOrigionalPriceFirstVariant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigionalPriceFirstVariant.ForeColor = System.Drawing.Color.Black;
            this.lblOrigionalPriceFirstVariant.Location = new System.Drawing.Point(8, 0);
            this.lblOrigionalPriceFirstVariant.Name = "lblOrigionalPriceFirstVariant";
            this.lblOrigionalPriceFirstVariant.Size = new System.Drawing.Size(128, 30);
            this.lblOrigionalPriceFirstVariant.TabIndex = 12;
            this.lblOrigionalPriceFirstVariant.Text = "10.000.000đ";
            this.lblOrigionalPriceFirstVariant.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowAction
            // 
            this.flowAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowAction.Controls.Add(this.btnViewDetail);
            this.flowAction.Controls.Add(this.btnBuyAgain);
            this.flowAction.Controls.Add(this.btnRating);
            this.flowAction.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowAction.Location = new System.Drawing.Point(595, 141);
            this.flowAction.Margin = new System.Windows.Forms.Padding(0);
            this.flowAction.Name = "flowAction";
            this.flowAction.Size = new System.Drawing.Size(334, 49);
            this.flowAction.TabIndex = 11;
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
            this.btnViewDetail.Location = new System.Drawing.Point(232, 3);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(99, 42);
            this.btnViewDetail.TabIndex = 7;
            this.btnViewDetail.Text = "Chi tiết";
            this.btnViewDetail.TextColor = System.Drawing.Color.White;
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnBuyAgain
            // 
            this.btnBuyAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnBuyAgain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnBuyAgain.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuyAgain.BorderRadius = 15;
            this.btnBuyAgain.BorderSize = 0;
            this.btnBuyAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyAgain.FlatAppearance.BorderSize = 0;
            this.btnBuyAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyAgain.ForeColor = System.Drawing.Color.White;
            this.btnBuyAgain.Location = new System.Drawing.Point(128, 3);
            this.btnBuyAgain.Name = "btnBuyAgain";
            this.btnBuyAgain.Size = new System.Drawing.Size(98, 42);
            this.btnBuyAgain.TabIndex = 9;
            this.btnBuyAgain.Text = "Mua lại";
            this.btnBuyAgain.TextColor = System.Drawing.Color.White;
            this.btnBuyAgain.UseVisualStyleBackColor = false;
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRating.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRating.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRating.BorderRadius = 15;
            this.btnRating.BorderSize = 0;
            this.btnRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.Location = new System.Drawing.Point(12, 3);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(110, 42);
            this.btnRating.TabIndex = 8;
            this.btnRating.Text = "Đánh giá";
            this.btnRating.TextColor = System.Drawing.Color.White;
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Visible = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalPrice.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalPrice.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTotalPrice.BorderRadius = 15;
            this.lblTotalPrice.BorderSize = 0;
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalPrice.Image")));
            this.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalPrice.Location = new System.Drawing.Point(163, 145);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(7);
            this.lblTotalPrice.Size = new System.Drawing.Size(174, 42);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "      100.000.000 đ";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalPrice.TextColor = System.Drawing.Color.White;
            // 
            // lblQuantityFirstVariant
            // 
            this.lblQuantityFirstVariant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantityFirstVariant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityFirstVariant.ForeColor = System.Drawing.Color.Black;
            this.lblQuantityFirstVariant.Location = new System.Drawing.Point(886, 50);
            this.lblQuantityFirstVariant.Name = "lblQuantityFirstVariant";
            this.lblQuantityFirstVariant.Size = new System.Drawing.Size(51, 30);
            this.lblQuantityFirstVariant.TabIndex = 5;
            this.lblQuantityFirstVariant.Text = "x1";
            this.lblQuantityFirstVariant.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumberOtherProduct
            // 
            this.lblNumberOtherProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOtherProduct.BackColor = System.Drawing.Color.LightGray;
            this.lblNumberOtherProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOtherProduct.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOtherProduct.Location = new System.Drawing.Point(147, 93);
            this.lblNumberOtherProduct.Name = "lblNumberOtherProduct";
            this.lblNumberOtherProduct.Size = new System.Drawing.Size(779, 42);
            this.lblNumberOtherProduct.TabIndex = 4;
            this.lblNumberOtherProduct.Text = "và 7 sản phẩm khác";
            this.lblNumberOtherProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelFirstVariant
            // 
            this.lblLabelFirstVariant.AutoSize = true;
            this.lblLabelFirstVariant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelFirstVariant.ForeColor = System.Drawing.Color.Black;
            this.lblLabelFirstVariant.Location = new System.Drawing.Point(141, 50);
            this.lblLabelFirstVariant.Name = "lblLabelFirstVariant";
            this.lblLabelFirstVariant.Size = new System.Drawing.Size(148, 30);
            this.lblLabelFirstVariant.TabIndex = 3;
            this.lblLabelFirstVariant.Text = "Nhãn biến thể";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderStatus.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderStatus.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblOrderStatus.BorderRadius = 15;
            this.lblOrderStatus.BorderSize = 0;
            this.lblOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderStatus.ForeColor = System.Drawing.Color.White;
            this.lblOrderStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderStatus.Image")));
            this.lblOrderStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderStatus.Location = new System.Drawing.Point(10, 145);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Padding = new System.Windows.Forms.Padding(7);
            this.lblOrderStatus.Size = new System.Drawing.Size(147, 42);
            this.lblOrderStatus.TabIndex = 2;
            this.lblOrderStatus.Text = "      Đang chờ";
            this.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderStatus.TextColor = System.Drawing.Color.White;
            // 
            // lblNameFirstProduct
            // 
            this.lblNameFirstProduct.AutoSize = true;
            this.lblNameFirstProduct.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirstProduct.ForeColor = System.Drawing.Color.Black;
            this.lblNameFirstProduct.Location = new System.Drawing.Point(141, 15);
            this.lblNameFirstProduct.Name = "lblNameFirstProduct";
            this.lblNameFirstProduct.Size = new System.Drawing.Size(177, 35);
            this.lblNameFirstProduct.TabIndex = 1;
            this.lblNameFirstProduct.Text = "Tên sản phẩm";
            // 
            // picFirstProduct
            // 
            this.picFirstProduct.Location = new System.Drawing.Point(15, 15);
            this.picFirstProduct.Name = "picFirstProduct";
            this.picFirstProduct.Size = new System.Drawing.Size(120, 120);
            this.picFirstProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirstProduct.TabIndex = 0;
            this.picFirstProduct.TabStop = false;
            // 
            // UserOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserOrderControl";
            this.Size = new System.Drawing.Size(950, 200);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFirstProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private CustomControls.RoundedLabel lblOrderStatus;
        private System.Windows.Forms.Label lblNameFirstProduct;
        private System.Windows.Forms.PictureBox picFirstProduct;
        private CustomControls.RoundedLabel lblTotalPrice;
        private System.Windows.Forms.Label lblQuantityFirstVariant;
        private System.Windows.Forms.Label lblNumberOtherProduct;
        private System.Windows.Forms.Label lblLabelFirstVariant;
        private CustomComponents.RoundedButton btnBuyAgain;
        private CustomComponents.RoundedButton btnRating;
        private CustomComponents.RoundedButton btnViewDetail;
        private System.Windows.Forms.FlowLayoutPanel flowAction;
        private System.Windows.Forms.Label lblPriceFirstVariant;
        private System.Windows.Forms.Label lblOrigionalPriceFirstVariant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RoundedLabel lblDateOrder;
    }
}
