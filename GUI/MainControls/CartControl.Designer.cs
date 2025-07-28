namespace _3S_eShop.GUI
{
    partial class CartControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartControl));
            this.flowCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPriceSection = new System.Windows.Forms.Panel();
            this.btnApplyVoucher = new _3S_eShop.CustomComponents.RoundedButton();
            this.valueReward = new System.Windows.Forms.Label();
            this.titleReward = new System.Windows.Forms.Label();
            this.toggleReward = new _3S_eShop.CustomComponents.ToggleButton();
            this.btnCreateOrder = new _3S_eShop.CustomComponents.RoundedButton();
            this.titleVoucher = new System.Windows.Forms.Label();
            this.txtVoucher = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.valueFinalPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.cmsCart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPriceSection.SuspendLayout();
            this.cmsCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowCartItems
            // 
            this.flowCartItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowCartItems.AutoScroll = true;
            this.flowCartItems.Location = new System.Drawing.Point(0, 10);
            this.flowCartItems.Name = "flowCartItems";
            this.flowCartItems.Padding = new System.Windows.Forms.Padding(5);
            this.flowCartItems.Size = new System.Drawing.Size(1000, 561);
            this.flowCartItems.TabIndex = 0;
            // 
            // pnlPriceSection
            // 
            this.pnlPriceSection.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPriceSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlPriceSection.Controls.Add(this.btnApplyVoucher);
            this.pnlPriceSection.Controls.Add(this.valueReward);
            this.pnlPriceSection.Controls.Add(this.titleReward);
            this.pnlPriceSection.Controls.Add(this.toggleReward);
            this.pnlPriceSection.Controls.Add(this.btnCreateOrder);
            this.pnlPriceSection.Controls.Add(this.titleVoucher);
            this.pnlPriceSection.Controls.Add(this.txtVoucher);
            this.pnlPriceSection.Controls.Add(this.valueFinalPrice);
            this.pnlPriceSection.Controls.Add(this.lblFinalPrice);
            this.pnlPriceSection.ForeColor = System.Drawing.Color.White;
            this.pnlPriceSection.Location = new System.Drawing.Point(0, 579);
            this.pnlPriceSection.Name = "pnlPriceSection";
            this.pnlPriceSection.Size = new System.Drawing.Size(1000, 100);
            this.pnlPriceSection.TabIndex = 1;
            // 
            // btnApplyVoucher
            // 
            this.btnApplyVoucher.BackColor = System.Drawing.Color.White;
            this.btnApplyVoucher.BackgroundColor = System.Drawing.Color.White;
            this.btnApplyVoucher.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApplyVoucher.BorderRadius = 15;
            this.btnApplyVoucher.BorderSize = 0;
            this.btnApplyVoucher.FlatAppearance.BorderSize = 0;
            this.btnApplyVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyVoucher.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnApplyVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyVoucher.Location = new System.Drawing.Point(485, 9);
            this.btnApplyVoucher.Name = "btnApplyVoucher";
            this.btnApplyVoucher.Size = new System.Drawing.Size(62, 40);
            this.btnApplyVoucher.TabIndex = 10;
            this.btnApplyVoucher.Text = "Áp";
            this.btnApplyVoucher.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnApplyVoucher.UseVisualStyleBackColor = false;
            this.btnApplyVoucher.Click += new System.EventHandler(this.btnApplyVoucher_Click);
            // 
            // valueReward
            // 
            this.valueReward.AutoSize = true;
            this.valueReward.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.valueReward.Location = new System.Drawing.Point(291, 54);
            this.valueReward.Name = "valueReward";
            this.valueReward.Size = new System.Drawing.Size(68, 25);
            this.valueReward.TabIndex = 9;
            this.valueReward.Text = "x điểm";
            // 
            // titleReward
            // 
            this.titleReward.AutoSize = true;
            this.titleReward.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleReward.Location = new System.Drawing.Point(20, 54);
            this.titleReward.Name = "titleReward";
            this.titleReward.Size = new System.Drawing.Size(210, 25);
            this.titleReward.TabIndex = 8;
            this.titleReward.Text = "Sử dụng điểm thưởng";
            // 
            // toggleReward
            // 
            this.toggleReward.AutoSize = true;
            this.toggleReward.Location = new System.Drawing.Point(240, 56);
            this.toggleReward.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleReward.Name = "toggleReward";
            this.toggleReward.OffBackColor = System.Drawing.Color.Gray;
            this.toggleReward.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleReward.OnBackColor = System.Drawing.Color.LimeGreen;
            this.toggleReward.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleReward.Size = new System.Drawing.Size(45, 22);
            this.toggleReward.TabIndex = 7;
            this.toggleReward.UseVisualStyleBackColor = true;
            this.toggleReward.CheckedChanged += new System.EventHandler(this.toggleReward_CheckedChanged);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateOrder.BackgroundColor = System.Drawing.Color.White;
            this.btnCreateOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateOrder.BorderRadius = 15;
            this.btnCreateOrder.BorderSize = 0;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateOrder.Location = new System.Drawing.Point(828, 21);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(156, 58);
            this.btnCreateOrder.TabIndex = 6;
            this.btnCreateOrder.Text = "ĐẶT ĐƠN";
            this.btnCreateOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // titleVoucher
            // 
            this.titleVoucher.AutoSize = true;
            this.titleVoucher.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleVoucher.Location = new System.Drawing.Point(20, 21);
            this.titleVoucher.Name = "titleVoucher";
            this.titleVoucher.Size = new System.Drawing.Size(121, 25);
            this.titleVoucher.TabIndex = 4;
            this.titleVoucher.Text = "Mã giảm giá";
            // 
            // txtVoucher
            // 
            this.txtVoucher.BackColor = System.Drawing.SystemColors.Window;
            this.txtVoucher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtVoucher.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtVoucher.BorderRadius = 0;
            this.txtVoucher.BorderSize = 2;
            this.txtVoucher.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVoucher.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVoucher.InputCharacterValidator = null;
            this.txtVoucher.Location = new System.Drawing.Point(240, 9);
            this.txtVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoucher.Multiline = false;
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVoucher.PasswordChar = false;
            this.txtVoucher.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtVoucher.PlaceholderText = "Nhập mã giảm giá (nếu có)";
            this.txtVoucher.Size = new System.Drawing.Size(238, 40);
            this.txtVoucher.TabIndex = 2;
            this.txtVoucher.Texts = "";
            this.txtVoucher.UnderlinedStyle = false;
            this.txtVoucher.Valid = null;
            // 
            // valueFinalPrice
            // 
            this.valueFinalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.valueFinalPrice.Location = new System.Drawing.Point(570, 41);
            this.valueFinalPrice.Name = "valueFinalPrice";
            this.valueFinalPrice.Size = new System.Drawing.Size(240, 38);
            this.valueFinalPrice.TabIndex = 1;
            this.valueFinalPrice.Text = "6.000.000đ";
            this.valueFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(700, 21);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(113, 25);
            this.lblFinalPrice.TabIndex = 0;
            this.lblFinalPrice.Text = "TỔNG TIỀN";
            // 
            // cmsCart
            // 
            this.cmsCart.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReload});
            this.cmsCart.Name = "cmsCategory";
            this.cmsCart.Size = new System.Drawing.Size(202, 28);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReload.Image")));
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(201, 24);
            this.tsmiReload.Text = "Làm mới (F5 | Ctrl+R)";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsCart;
            this.Controls.Add(this.pnlPriceSection);
            this.Controls.Add(this.flowCartItems);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.Load += new System.EventHandler(this.CartControl_Load);
            this.pnlPriceSection.ResumeLayout(false);
            this.pnlPriceSection.PerformLayout();
            this.cmsCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowCartItems;
        private System.Windows.Forms.Panel pnlPriceSection;
        private System.Windows.Forms.Label valueFinalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label titleVoucher;
        private CustomComponents.AdvancedTextBox txtVoucher;
        private CustomComponents.RoundedButton btnCreateOrder;
        private System.Windows.Forms.Label valueReward;
        private System.Windows.Forms.Label titleReward;
        private CustomComponents.ToggleButton toggleReward;
        private System.Windows.Forms.ContextMenuStrip cmsCart;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
        private CustomComponents.RoundedButton btnApplyVoucher;
    }
}
