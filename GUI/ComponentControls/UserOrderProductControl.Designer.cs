namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserOrderProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderProductControl));
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnViewDetail = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblPrice = new _3S_eShop.CustomControls.RoundedLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVariantPrice = new System.Windows.Forms.Label();
            this.lblVariantOrigionalPrice = new System.Windows.Forms.Label();
            this.lblVariantQuantity = new System.Windows.Forms.Label();
            this.lblVariantLabel = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 0;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.btnViewDetail);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.flowLayoutPanel1);
            this.pnlContainer.Controls.Add(this.lblVariantQuantity);
            this.pnlContainer.Controls.Add(this.lblVariantLabel);
            this.pnlContainer.Controls.Add(this.lblProductName);
            this.pnlContainer.Controls.Add(this.picProduct);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(950, 150);
            this.pnlContainer.TabIndex = 1;
            this.pnlContainer.TextColor = System.Drawing.SystemColors.Control;
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
            this.btnViewDetail.Location = new System.Drawing.Point(561, 93);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(195, 42);
            this.btnViewDetail.TabIndex = 7;
            this.btnViewDetail.Text = "Xem trên cửa hàng";
            this.btnViewDetail.TextColor = System.Drawing.Color.White;
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPrice.BorderRadius = 15;
            this.lblPrice.BorderSize = 0;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Image = ((System.Drawing.Image)(resources.GetObject("lblPrice.Image")));
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(762, 92);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(7);
            this.lblPrice.Size = new System.Drawing.Size(174, 42);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "      100.000.000 đ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.TextColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.lblVariantPrice);
            this.flowLayoutPanel1.Controls.Add(this.lblVariantOrigionalPrice);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(606, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 30);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // lblVariantPrice
            // 
            this.lblVariantPrice.AutoSize = true;
            this.lblVariantPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantPrice.ForeColor = System.Drawing.Color.Black;
            this.lblVariantPrice.Location = new System.Drawing.Point(142, 0);
            this.lblVariantPrice.Name = "lblVariantPrice";
            this.lblVariantPrice.Size = new System.Drawing.Size(128, 30);
            this.lblVariantPrice.TabIndex = 10;
            this.lblVariantPrice.Text = "10.000.000đ";
            this.lblVariantPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVariantOrigionalPrice
            // 
            this.lblVariantOrigionalPrice.AutoSize = true;
            this.lblVariantOrigionalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantOrigionalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblVariantOrigionalPrice.Location = new System.Drawing.Point(8, 0);
            this.lblVariantOrigionalPrice.Name = "lblVariantOrigionalPrice";
            this.lblVariantOrigionalPrice.Size = new System.Drawing.Size(128, 30);
            this.lblVariantOrigionalPrice.TabIndex = 12;
            this.lblVariantOrigionalPrice.Text = "10.000.000đ";
            this.lblVariantOrigionalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVariantQuantity
            // 
            this.lblVariantQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVariantQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblVariantQuantity.Location = new System.Drawing.Point(885, 50);
            this.lblVariantQuantity.Name = "lblVariantQuantity";
            this.lblVariantQuantity.Size = new System.Drawing.Size(51, 30);
            this.lblVariantQuantity.TabIndex = 18;
            this.lblVariantQuantity.Text = "x1";
            this.lblVariantQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVariantLabel
            // 
            this.lblVariantLabel.AutoSize = true;
            this.lblVariantLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantLabel.ForeColor = System.Drawing.Color.Black;
            this.lblVariantLabel.Location = new System.Drawing.Point(140, 50);
            this.lblVariantLabel.Name = "lblVariantLabel";
            this.lblVariantLabel.Size = new System.Drawing.Size(148, 30);
            this.lblVariantLabel.TabIndex = 16;
            this.lblVariantLabel.Text = "Nhãn biến thể";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(140, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(177, 35);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(15, 15);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(120, 120);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 14;
            this.picProduct.TabStop = false;
            // 
            // UserOrderProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserOrderProductControl";
            this.Size = new System.Drawing.Size(950, 150);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblVariantPrice;
        private System.Windows.Forms.Label lblVariantOrigionalPrice;
        private System.Windows.Forms.Label lblVariantQuantity;
        private System.Windows.Forms.Label lblVariantLabel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox picProduct;
        private CustomComponents.RoundedButton btnViewDetail;
        private CustomControls.RoundedLabel lblPrice;
    }
}
