namespace _3S_eShop.GUI.ComponentControls
{
    partial class ProductVariant
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
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.variantPrice = new System.Windows.Forms.Label();
            this.variantLabel = new System.Windows.Forms.Label();
            this.lblOutOfStock = new _3S_eShop.CustomControls.RoundedLabel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 30;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.lblOutOfStock);
            this.pnlContainer.Controls.Add(this.variantPrice);
            this.pnlContainer.Controls.Add(this.variantLabel);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainer.Size = new System.Drawing.Size(462, 75);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.TextColor = System.Drawing.Color.White;
            // 
            // variantPrice
            // 
            this.variantPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.variantPrice.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantPrice.ForeColor = System.Drawing.Color.Black;
            this.variantPrice.Location = new System.Drawing.Point(13, 40);
            this.variantPrice.Name = "variantPrice";
            this.variantPrice.Size = new System.Drawing.Size(336, 24);
            this.variantPrice.TabIndex = 1;
            this.variantPrice.Text = "Giá tiền";
            // 
            // variantLabel
            // 
            this.variantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.variantLabel.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantLabel.ForeColor = System.Drawing.Color.Black;
            this.variantLabel.Location = new System.Drawing.Point(13, 10);
            this.variantLabel.Name = "variantLabel";
            this.variantLabel.Size = new System.Drawing.Size(436, 30);
            this.variantLabel.TabIndex = 0;
            this.variantLabel.Text = "Nội dung nhãn biến thể";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutOfStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutOfStock.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblOutOfStock.BorderRadius = 10;
            this.lblOutOfStock.BorderSize = 0;
            this.lblOutOfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutOfStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOutOfStock.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStock.Location = new System.Drawing.Point(355, 40);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Padding = new System.Windows.Forms.Padding(2);
            this.lblOutOfStock.Size = new System.Drawing.Size(94, 24);
            this.lblOutOfStock.TabIndex = 2;
            this.lblOutOfStock.Text = "Đã hết hàng";
            this.lblOutOfStock.TextColor = System.Drawing.Color.White;
            this.lblOutOfStock.Visible = false;
            // 
            // ProductVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductVariant";
            this.Size = new System.Drawing.Size(462, 75);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.Label variantPrice;
        private System.Windows.Forms.Label variantLabel;
        private CustomControls.RoundedLabel lblOutOfStock;
    }
}
