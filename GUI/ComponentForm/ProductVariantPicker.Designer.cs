namespace _3S_eShop.CustomControls
{
    partial class ProductVariantPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductVariantPicker));
            this.flowVariants = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnPick = new _3S_eShop.CustomComponents.RoundedButton();
            this.productThumb = new System.Windows.Forms.PictureBox();
            this.lblVariantDescription = new _3S_eShop.CustomControls.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // flowVariants
            // 
            this.flowVariants.Location = new System.Drawing.Point(15, 97);
            this.flowVariants.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowVariants.Name = "flowVariants";
            this.flowVariants.Size = new System.Drawing.Size(520, 447);
            this.flowVariants.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(95, 15);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(440, 70);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPick.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnPick.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPick.BorderRadius = 15;
            this.btnPick.BorderSize = 0;
            this.btnPick.FlatAppearance.BorderSize = 0;
            this.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPick.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.ForeColor = System.Drawing.Color.White;
            this.btnPick.Location = new System.Drawing.Point(385, 553);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(150, 66);
            this.btnPick.TabIndex = 3;
            this.btnPick.Text = "Chọn";
            this.btnPick.TextColor = System.Drawing.Color.White;
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // productThumb
            // 
            this.productThumb.Location = new System.Drawing.Point(15, 15);
            this.productThumb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.productThumb.Name = "productThumb";
            this.productThumb.Size = new System.Drawing.Size(70, 70);
            this.productThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productThumb.TabIndex = 1;
            this.productThumb.TabStop = false;
            // 
            // lblVariantDescription
            // 
            this.lblVariantDescription.BackColor = System.Drawing.Color.LimeGreen;
            this.lblVariantDescription.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.lblVariantDescription.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVariantDescription.BorderRadius = 15;
            this.lblVariantDescription.BorderSize = 0;
            this.lblVariantDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVariantDescription.ForeColor = System.Drawing.Color.White;
            this.lblVariantDescription.Location = new System.Drawing.Point(15, 553);
            this.lblVariantDescription.Name = "lblVariantDescription";
            this.lblVariantDescription.Padding = new System.Windows.Forms.Padding(5);
            this.lblVariantDescription.Size = new System.Drawing.Size(356, 66);
            this.lblVariantDescription.TabIndex = 4;
            this.lblVariantDescription.Text = "Thông tin biến thể";
            this.lblVariantDescription.TextColor = System.Drawing.Color.White;
            // 
            // ProductVariantPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 631);
            this.Controls.Add(this.lblVariantDescription);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.productThumb);
            this.Controls.Add(this.flowVariants);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductVariantPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bộ chọn biến thể sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.productThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowVariants;
        private System.Windows.Forms.PictureBox productThumb;
        private System.Windows.Forms.Label lblProductName;
        private CustomComponents.RoundedButton btnPick;
        private RoundedLabel lblVariantDescription;
    }
}