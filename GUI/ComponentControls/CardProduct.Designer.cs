namespace _3S_eShop.GUI.ComponentControls
{
    partial class CardProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardProduct));
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscountOrigional = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblBriefInfo = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnViewDetail = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnAddCart = new _3S_eShop.CustomComponents.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.flowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picThumb
            // 
            this.picThumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picThumb.Image = ((System.Drawing.Image)(resources.GetObject("picThumb.Image")));
            this.picThumb.Location = new System.Drawing.Point(6, 6);
            this.picThumb.Margin = new System.Windows.Forms.Padding(6);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(190, 142);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumb.TabIndex = 0;
            this.picThumb.TabStop = false;
            // 
            // flowContainer
            // 
            this.flowContainer.BackColor = System.Drawing.Color.White;
            this.flowContainer.Controls.Add(this.picThumb);
            this.flowContainer.Controls.Add(this.lblName);
            this.flowContainer.Controls.Add(this.lblPrice);
            this.flowContainer.Controls.Add(this.lblDiscountOrigional);
            this.flowContainer.Controls.Add(this.lblDiscountPercent);
            this.flowContainer.Controls.Add(this.lblBriefInfo);
            this.flowContainer.Controls.Add(this.btnViewDetail);
            this.flowContainer.Controls.Add(this.btnAddCart);
            this.flowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContainer.Location = new System.Drawing.Point(0, 0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(202, 376);
            this.flowContainer.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 154);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 63);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Màn hình Samsung LS24C310EAEXXV 24 inch (1920 x 1080 / IPS / 75Hz / 5ms)";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(195)))));
            this.lblPrice.Location = new System.Drawing.Point(6, 223);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(190, 26);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "10.050.000 đ";
            // 
            // lblDiscountOrigional
            // 
            this.lblDiscountOrigional.AutoSize = true;
            this.lblDiscountOrigional.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountOrigional.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountOrigional.Location = new System.Drawing.Point(6, 249);
            this.lblDiscountOrigional.Margin = new System.Windows.Forms.Padding(6, 0, 0, 6);
            this.lblDiscountOrigional.Name = "lblDiscountOrigional";
            this.lblDiscountOrigional.Size = new System.Drawing.Size(92, 20);
            this.lblDiscountOrigional.TabIndex = 3;
            this.lblDiscountOrigional.Text = "10.550.000 đ";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(195)))));
            this.lblDiscountPercent.Location = new System.Drawing.Point(98, 249);
            this.lblDiscountPercent.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(37, 20);
            this.lblDiscountPercent.TabIndex = 4;
            this.lblDiscountPercent.Text = "-4%";
            // 
            // lblBriefInfo
            // 
            this.lblBriefInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblBriefInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lblBriefInfo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBriefInfo.BorderRadius = 15;
            this.lblBriefInfo.BorderSize = 0;
            this.lblBriefInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBriefInfo.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefInfo.ForeColor = System.Drawing.Color.Black;
            this.lblBriefInfo.Location = new System.Drawing.Point(6, 275);
            this.lblBriefInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.lblBriefInfo.Name = "lblBriefInfo";
            this.lblBriefInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lblBriefInfo.Size = new System.Drawing.Size(190, 48);
            this.lblBriefInfo.TabIndex = 5;
            this.lblBriefInfo.Text = "🏿 Intel® Core™ i3-1215U\r\n🗂 Intel UHD";
            this.lblBriefInfo.TextColor = System.Drawing.Color.Black;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.White;
            this.btnViewDetail.BackgroundColor = System.Drawing.Color.White;
            this.btnViewDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewDetail.BorderRadius = 15;
            this.btnViewDetail.BorderSize = 2;
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetail.Image")));
            this.btnViewDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDetail.Location = new System.Drawing.Point(6, 329);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnViewDetail.Size = new System.Drawing.Size(144, 40);
            this.btnViewDetail.TabIndex = 6;
            this.btnViewDetail.Text = "    Chi tiết";
            this.btnViewDetail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddCart.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCart.BorderRadius = 15;
            this.btnAddCart.BorderSize = 0;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.ForeColor = System.Drawing.Color.White;
            this.btnAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCart.Image")));
            this.btnAddCart.Location = new System.Drawing.Point(156, 329);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnAddCart.Size = new System.Drawing.Size(40, 40);
            this.btnAddCart.TabIndex = 7;
            this.btnAddCart.TextColor = System.Drawing.Color.White;
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // CardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(202, 376);
            this.MinimumSize = new System.Drawing.Size(202, 376);
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(202, 376);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.flowContainer.ResumeLayout(false);
            this.flowContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiscountOrigional;
        private System.Windows.Forms.Label lblDiscountPercent;
        private CustomControls.RoundedLabel lblBriefInfo;
        private CustomComponents.RoundedButton btnViewDetail;
        private CustomComponents.RoundedButton btnAddCart;
    }
}
