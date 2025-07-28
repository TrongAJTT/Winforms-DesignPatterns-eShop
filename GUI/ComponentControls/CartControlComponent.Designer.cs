namespace _3S_eShop.GUI.ComponentControls
{
    partial class CartControlComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartControlComponent));
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.roundedTopRight = new _3S_eShop.CustomControls.RoundedLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtQuantity = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnSubtract = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblOutOfStock = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnDelete = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnChangeVariant = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblPrice = new _3S_eShop.CustomControls.RoundedLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVariantPrice = new System.Windows.Forms.Label();
            this.lblVariantOrigionalPrice = new System.Windows.Forms.Label();
            this.lblVariantLabel = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.pnlContainer.Controls.Add(this.chkSelect);
            this.pnlContainer.Controls.Add(this.roundedTopRight);
            this.pnlContainer.Controls.Add(this.flowLayoutPanel2);
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.btnChangeVariant);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.flowLayoutPanel1);
            this.pnlContainer.Controls.Add(this.lblVariantLabel);
            this.pnlContainer.Controls.Add(this.lblProductName);
            this.pnlContainer.Controls.Add(this.picProduct);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(950, 150);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.TextColor = System.Drawing.SystemColors.Control;
            // 
            // chkSelect
            // 
            this.chkSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkSelect.AutoSize = true;
            this.chkSelect.BackColor = System.Drawing.Color.Transparent;
            this.chkSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelect.Location = new System.Drawing.Point(921, 15);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(15, 14);
            this.chkSelect.TabIndex = 28;
            this.chkSelect.UseVisualStyleBackColor = false;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // roundedTopRight
            // 
            this.roundedTopRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundedTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedTopRight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedTopRight.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedTopRight.BorderRadius = 30;
            this.roundedTopRight.BorderSize = 0;
            this.roundedTopRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedTopRight.ForeColor = System.Drawing.Color.White;
            this.roundedTopRight.Location = new System.Drawing.Point(899, -10);
            this.roundedTopRight.Name = "roundedTopRight";
            this.roundedTopRight.Size = new System.Drawing.Size(83, 57);
            this.roundedTopRight.TabIndex = 27;
            this.roundedTopRight.TextColor = System.Drawing.Color.White;
            this.roundedTopRight.Click += new System.EventHandler(this.roundedTopRight_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.txtQuantity);
            this.flowLayoutPanel2.Controls.Add(this.btnSubtract);
            this.flowLayoutPanel2.Controls.Add(this.lblOutOfStock);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(463, 93);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(279, 44);
            this.flowLayoutPanel2.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(237, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 42);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.ContentAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.InputCharacterValidator = null;
            this.txtQuantity.Location = new System.Drawing.Point(190, 0);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(42, 42);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.Texts = "1";
            this.txtQuantity.UnderlinedStyle = false;
            this.txtQuantity.Valid = null;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSubtract.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSubtract.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSubtract.BorderRadius = 15;
            this.btnSubtract.BorderSize = 0;
            this.btnSubtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtract.Image")));
            this.btnSubtract.Location = new System.Drawing.Point(143, 0);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(42, 42);
            this.btnSubtract.TabIndex = 24;
            this.btnSubtract.TextColor = System.Drawing.Color.White;
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutOfStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutOfStock.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblOutOfStock.BorderRadius = 15;
            this.lblOutOfStock.BorderSize = 0;
            this.lblOutOfStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutOfStock.FlatAppearance.BorderSize = 0;
            this.lblOutOfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutOfStock.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStock.Location = new System.Drawing.Point(4, 0);
            this.lblOutOfStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(134, 42);
            this.lblOutOfStock.TabIndex = 26;
            this.lblOutOfStock.Text = "Hết hàng";
            this.lblOutOfStock.TextColor = System.Drawing.Color.White;
            this.lblOutOfStock.UseVisualStyleBackColor = false;
            this.lblOutOfStock.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(310, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 42);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeVariant
            // 
            this.btnChangeVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChangeVariant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChangeVariant.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChangeVariant.BorderRadius = 15;
            this.btnChangeVariant.BorderSize = 0;
            this.btnChangeVariant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeVariant.FlatAppearance.BorderSize = 0;
            this.btnChangeVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeVariant.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeVariant.ForeColor = System.Drawing.Color.White;
            this.btnChangeVariant.Location = new System.Drawing.Point(151, 93);
            this.btnChangeVariant.Name = "btnChangeVariant";
            this.btnChangeVariant.Size = new System.Drawing.Size(142, 42);
            this.btnChangeVariant.TabIndex = 7;
            this.btnChangeVariant.Text = "Đổi biến thể";
            this.btnChangeVariant.TextColor = System.Drawing.Color.White;
            this.btnChangeVariant.UseVisualStyleBackColor = false;
            this.btnChangeVariant.Click += new System.EventHandler(this.btnChangeVariant_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(663, 50);
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
            // lblVariantLabel
            // 
            this.lblVariantLabel.AutoSize = true;
            this.lblVariantLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantLabel.ForeColor = System.Drawing.Color.Black;
            this.lblVariantLabel.Location = new System.Drawing.Point(145, 50);
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
            this.lblProductName.Location = new System.Drawing.Point(145, 15);
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
            // CartControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CartControlComponent";
            this.Size = new System.Drawing.Size(950, 150);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private CustomComponents.RoundedButton btnChangeVariant;
        private CustomControls.RoundedLabel lblPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblVariantPrice;
        private System.Windows.Forms.Label lblVariantOrigionalPrice;
        private System.Windows.Forms.Label lblVariantLabel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox picProduct;
        private CustomComponents.RoundedButton btnDelete;
        private CustomComponents.RoundedButton btnSubtract;
        private CustomComponents.RoundedButton btnAdd;
        private CustomComponents.AdvancedTextBox txtQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox chkSelect;
        private CustomControls.RoundedLabel roundedTopRight;
        private CustomComponents.RoundedButton lblOutOfStock;
    }
}
