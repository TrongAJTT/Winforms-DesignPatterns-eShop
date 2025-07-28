namespace _3S_eShop.GUI
{
    partial class AdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCustomService = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnCustomSystem = new _3S_eShop.CustomComponents.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOrder = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblNoCompletedOrder = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNoDeliveringOrder = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNoProcessingOrder = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlProduct = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblProductStopSelling = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnAddProduct = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblProductSoldOut = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblProductSelling = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageProduct = new _3S_eShop.CustomComponents.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCoupon = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblCouponUnusable = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblCouponTotal = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageCoupon = new _3S_eShop.CustomComponents.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUser = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblUserBan = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblUserTotal = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageUser = new _3S_eShop.CustomComponents.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCategory = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblCategoryTotal = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageCategory = new _3S_eShop.CustomComponents.RoundedButton();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlBrand = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblBrandTotal = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageBrand = new _3S_eShop.CustomComponents.RoundedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnSeeAnalysis = new _3S_eShop.CustomComponents.RoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCustomService.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlCoupon.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.cmsCategory.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 836);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 49);
            this.panel1.TabIndex = 18;
            // 
            // pnlCustomService
            // 
            this.pnlCustomService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCustomService.AutoSize = true;
            this.pnlCustomService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlCustomService.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlCustomService.BorderRadius = 15;
            this.pnlCustomService.BorderSize = 0;
            this.pnlCustomService.Controls.Add(this.btnCustomSystem);
            this.pnlCustomService.Controls.Add(this.label5);
            this.pnlCustomService.ForeColor = System.Drawing.Color.White;
            this.pnlCustomService.Location = new System.Drawing.Point(514, 681);
            this.pnlCustomService.Name = "pnlCustomService";
            this.pnlCustomService.Size = new System.Drawing.Size(450, 153);
            this.pnlCustomService.TabIndex = 15;
            this.pnlCustomService.TextColor = System.Drawing.Color.White;
            // 
            // btnCustomSystem
            // 
            this.btnCustomSystem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomSystem.BackColor = System.Drawing.Color.White;
            this.btnCustomSystem.BackgroundColor = System.Drawing.Color.White;
            this.btnCustomSystem.BorderColor = System.Drawing.Color.White;
            this.btnCustomSystem.BorderRadius = 15;
            this.btnCustomSystem.BorderSize = 0;
            this.btnCustomSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomSystem.FlatAppearance.BorderSize = 0;
            this.btnCustomSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCustomSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomSystem.Image")));
            this.btnCustomSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomSystem.Location = new System.Drawing.Point(285, 87);
            this.btnCustomSystem.Name = "btnCustomSystem";
            this.btnCustomSystem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomSystem.Size = new System.Drawing.Size(143, 40);
            this.btnCustomSystem.TabIndex = 9;
            this.btnCustomSystem.Text = "    Quản lý";
            this.btnCustomSystem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCustomSystem.UseVisualStyleBackColor = false;
            this.btnCustomSystem.Click += new System.EventHandler(this.btnCustomSystem_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "     Tùy chỉnh dịch vụ";
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlOrder.AutoSize = true;
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlOrder.BorderRadius = 15;
            this.pnlOrder.BorderSize = 0;
            this.pnlOrder.Controls.Add(this.lblNoCompletedOrder);
            this.pnlOrder.Controls.Add(this.lblNoDeliveringOrder);
            this.pnlOrder.Controls.Add(this.lblNoProcessingOrder);
            this.pnlOrder.Controls.Add(this.btnManageOrders);
            this.pnlOrder.Controls.Add(this.label4);
            this.pnlOrder.ForeColor = System.Drawing.Color.White;
            this.pnlOrder.Location = new System.Drawing.Point(514, 445);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(450, 204);
            this.pnlOrder.TabIndex = 14;
            this.pnlOrder.TextColor = System.Drawing.Color.White;
            // 
            // lblNoCompletedOrder
            // 
            this.lblNoCompletedOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoCompletedOrder.BackColor = System.Drawing.Color.White;
            this.lblNoCompletedOrder.BackgroundColor = System.Drawing.Color.White;
            this.lblNoCompletedOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoCompletedOrder.BorderRadius = 15;
            this.lblNoCompletedOrder.BorderSize = 0;
            this.lblNoCompletedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoCompletedOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCompletedOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoCompletedOrder.Image = ((System.Drawing.Image)(resources.GetObject("lblNoCompletedOrder.Image")));
            this.lblNoCompletedOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoCompletedOrder.Location = new System.Drawing.Point(26, 138);
            this.lblNoCompletedOrder.Name = "lblNoCompletedOrder";
            this.lblNoCompletedOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNoCompletedOrder.Size = new System.Drawing.Size(189, 40);
            this.lblNoCompletedOrder.TabIndex = 12;
            this.lblNoCompletedOrder.Text = "      Đang tải...";
            this.lblNoCompletedOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoCompletedOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblNoDeliveringOrder
            // 
            this.lblNoDeliveringOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoDeliveringOrder.BackColor = System.Drawing.Color.White;
            this.lblNoDeliveringOrder.BackgroundColor = System.Drawing.Color.White;
            this.lblNoDeliveringOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoDeliveringOrder.BorderRadius = 15;
            this.lblNoDeliveringOrder.BorderSize = 0;
            this.lblNoDeliveringOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoDeliveringOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDeliveringOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoDeliveringOrder.Image = ((System.Drawing.Image)(resources.GetObject("lblNoDeliveringOrder.Image")));
            this.lblNoDeliveringOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoDeliveringOrder.Location = new System.Drawing.Point(239, 74);
            this.lblNoDeliveringOrder.Name = "lblNoDeliveringOrder";
            this.lblNoDeliveringOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNoDeliveringOrder.Size = new System.Drawing.Size(189, 40);
            this.lblNoDeliveringOrder.TabIndex = 11;
            this.lblNoDeliveringOrder.Text = "      Đang tải...";
            this.lblNoDeliveringOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoDeliveringOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblNoProcessingOrder
            // 
            this.lblNoProcessingOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoProcessingOrder.BackColor = System.Drawing.Color.White;
            this.lblNoProcessingOrder.BackgroundColor = System.Drawing.Color.White;
            this.lblNoProcessingOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoProcessingOrder.BorderRadius = 15;
            this.lblNoProcessingOrder.BorderSize = 0;
            this.lblNoProcessingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoProcessingOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProcessingOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoProcessingOrder.Image = ((System.Drawing.Image)(resources.GetObject("lblNoProcessingOrder.Image")));
            this.lblNoProcessingOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoProcessingOrder.Location = new System.Drawing.Point(26, 74);
            this.lblNoProcessingOrder.Name = "lblNoProcessingOrder";
            this.lblNoProcessingOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNoProcessingOrder.Size = new System.Drawing.Size(189, 40);
            this.lblNoProcessingOrder.TabIndex = 9;
            this.lblNoProcessingOrder.Text = "      Đang tải...";
            this.lblNoProcessingOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoProcessingOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageOrders.BackColor = System.Drawing.Color.White;
            this.btnManageOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnManageOrders.BorderColor = System.Drawing.Color.White;
            this.btnManageOrders.BorderRadius = 15;
            this.btnManageOrders.BorderSize = 0;
            this.btnManageOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageOrders.FlatAppearance.BorderSize = 0;
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnManageOrders.Image")));
            this.btnManageOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageOrders.Location = new System.Drawing.Point(285, 138);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageOrders.Size = new System.Drawing.Size(143, 40);
            this.btnManageOrders.TabIndex = 9;
            this.btnManageOrders.Text = "    Quản lý";
            this.btnManageOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "     Đơn đặt hàng";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlProduct.AutoSize = true;
            this.pnlProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlProduct.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlProduct.BorderRadius = 15;
            this.pnlProduct.BorderSize = 0;
            this.pnlProduct.Controls.Add(this.lblProductStopSelling);
            this.pnlProduct.Controls.Add(this.btnAddProduct);
            this.pnlProduct.Controls.Add(this.lblProductSoldOut);
            this.pnlProduct.Controls.Add(this.lblProductSelling);
            this.pnlProduct.Controls.Add(this.btnManageProduct);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.ForeColor = System.Drawing.Color.White;
            this.pnlProduct.Location = new System.Drawing.Point(36, 445);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(450, 204);
            this.pnlProduct.TabIndex = 13;
            this.pnlProduct.TextColor = System.Drawing.Color.White;
            // 
            // lblProductStopSelling
            // 
            this.lblProductStopSelling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductStopSelling.BackColor = System.Drawing.Color.White;
            this.lblProductStopSelling.BackgroundColor = System.Drawing.Color.White;
            this.lblProductStopSelling.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblProductStopSelling.BorderRadius = 15;
            this.lblProductStopSelling.BorderSize = 0;
            this.lblProductStopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductStopSelling.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStopSelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblProductStopSelling.Image = ((System.Drawing.Image)(resources.GetObject("lblProductStopSelling.Image")));
            this.lblProductStopSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductStopSelling.Location = new System.Drawing.Point(26, 138);
            this.lblProductStopSelling.Name = "lblProductStopSelling";
            this.lblProductStopSelling.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProductStopSelling.Size = new System.Drawing.Size(189, 40);
            this.lblProductStopSelling.TabIndex = 13;
            this.lblProductStopSelling.Text = "      Đang tải...";
            this.lblProductStopSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductStopSelling.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.BackgroundColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderRadius = 15;
            this.btnAddProduct.BorderSize = 0;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(239, 138);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(40, 40);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductSoldOut
            // 
            this.lblProductSoldOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductSoldOut.BackColor = System.Drawing.Color.White;
            this.lblProductSoldOut.BackgroundColor = System.Drawing.Color.White;
            this.lblProductSoldOut.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblProductSoldOut.BorderRadius = 15;
            this.lblProductSoldOut.BorderSize = 0;
            this.lblProductSoldOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSoldOut.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSoldOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblProductSoldOut.Image = ((System.Drawing.Image)(resources.GetObject("lblProductSoldOut.Image")));
            this.lblProductSoldOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductSoldOut.Location = new System.Drawing.Point(239, 74);
            this.lblProductSoldOut.Name = "lblProductSoldOut";
            this.lblProductSoldOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProductSoldOut.Size = new System.Drawing.Size(189, 40);
            this.lblProductSoldOut.TabIndex = 11;
            this.lblProductSoldOut.Text = "      Đang tải...";
            this.lblProductSoldOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductSoldOut.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblProductSelling
            // 
            this.lblProductSelling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductSelling.BackColor = System.Drawing.Color.White;
            this.lblProductSelling.BackgroundColor = System.Drawing.Color.White;
            this.lblProductSelling.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblProductSelling.BorderRadius = 15;
            this.lblProductSelling.BorderSize = 0;
            this.lblProductSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSelling.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblProductSelling.Image = ((System.Drawing.Image)(resources.GetObject("lblProductSelling.Image")));
            this.lblProductSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductSelling.Location = new System.Drawing.Point(26, 74);
            this.lblProductSelling.Name = "lblProductSelling";
            this.lblProductSelling.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProductSelling.Size = new System.Drawing.Size(189, 40);
            this.lblProductSelling.TabIndex = 9;
            this.lblProductSelling.Text = "      Đang tải...";
            this.lblProductSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductSelling.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageProduct.BackColor = System.Drawing.Color.White;
            this.btnManageProduct.BackgroundColor = System.Drawing.Color.White;
            this.btnManageProduct.BorderColor = System.Drawing.Color.White;
            this.btnManageProduct.BorderRadius = 15;
            this.btnManageProduct.BorderSize = 0;
            this.btnManageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProduct.FlatAppearance.BorderSize = 0;
            this.btnManageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProduct.Image")));
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(285, 138);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageProduct.Size = new System.Drawing.Size(143, 40);
            this.btnManageProduct.TabIndex = 9;
            this.btnManageProduct.Text = "    Quản lý";
            this.btnManageProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "     Sản phẩm";
            // 
            // pnlCoupon
            // 
            this.pnlCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCoupon.AutoSize = true;
            this.pnlCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlCoupon.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlCoupon.BorderRadius = 15;
            this.pnlCoupon.BorderSize = 0;
            this.pnlCoupon.Controls.Add(this.lblCouponUnusable);
            this.pnlCoupon.Controls.Add(this.lblCouponTotal);
            this.pnlCoupon.Controls.Add(this.btnManageCoupon);
            this.pnlCoupon.Controls.Add(this.label2);
            this.pnlCoupon.ForeColor = System.Drawing.Color.White;
            this.pnlCoupon.Location = new System.Drawing.Point(514, 209);
            this.pnlCoupon.Name = "pnlCoupon";
            this.pnlCoupon.Size = new System.Drawing.Size(450, 204);
            this.pnlCoupon.TabIndex = 12;
            this.pnlCoupon.TextColor = System.Drawing.Color.White;
            // 
            // lblCouponUnusable
            // 
            this.lblCouponUnusable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCouponUnusable.BackColor = System.Drawing.Color.White;
            this.lblCouponUnusable.BackgroundColor = System.Drawing.Color.White;
            this.lblCouponUnusable.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCouponUnusable.BorderRadius = 15;
            this.lblCouponUnusable.BorderSize = 0;
            this.lblCouponUnusable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCouponUnusable.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponUnusable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblCouponUnusable.Image = ((System.Drawing.Image)(resources.GetObject("lblCouponUnusable.Image")));
            this.lblCouponUnusable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCouponUnusable.Location = new System.Drawing.Point(239, 74);
            this.lblCouponUnusable.Name = "lblCouponUnusable";
            this.lblCouponUnusable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCouponUnusable.Size = new System.Drawing.Size(189, 40);
            this.lblCouponUnusable.TabIndex = 11;
            this.lblCouponUnusable.Text = "      Đang tải..";
            this.lblCouponUnusable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCouponUnusable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblCouponTotal
            // 
            this.lblCouponTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCouponTotal.BackColor = System.Drawing.Color.White;
            this.lblCouponTotal.BackgroundColor = System.Drawing.Color.White;
            this.lblCouponTotal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCouponTotal.BorderRadius = 15;
            this.lblCouponTotal.BorderSize = 0;
            this.lblCouponTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCouponTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblCouponTotal.Image = ((System.Drawing.Image)(resources.GetObject("lblCouponTotal.Image")));
            this.lblCouponTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCouponTotal.Location = new System.Drawing.Point(26, 74);
            this.lblCouponTotal.Name = "lblCouponTotal";
            this.lblCouponTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCouponTotal.Size = new System.Drawing.Size(189, 40);
            this.lblCouponTotal.TabIndex = 9;
            this.lblCouponTotal.Text = "      Đang tải...";
            this.lblCouponTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCouponTotal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageCoupon
            // 
            this.btnManageCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageCoupon.BackColor = System.Drawing.Color.White;
            this.btnManageCoupon.BackgroundColor = System.Drawing.Color.White;
            this.btnManageCoupon.BorderColor = System.Drawing.Color.White;
            this.btnManageCoupon.BorderRadius = 15;
            this.btnManageCoupon.BorderSize = 0;
            this.btnManageCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCoupon.FlatAppearance.BorderSize = 0;
            this.btnManageCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCoupon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCoupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageCoupon.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCoupon.Image")));
            this.btnManageCoupon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCoupon.Location = new System.Drawing.Point(285, 138);
            this.btnManageCoupon.Name = "btnManageCoupon";
            this.btnManageCoupon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCoupon.Size = new System.Drawing.Size(143, 40);
            this.btnManageCoupon.TabIndex = 9;
            this.btnManageCoupon.Text = "    Quản lý";
            this.btnManageCoupon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageCoupon.UseVisualStyleBackColor = false;
            this.btnManageCoupon.Click += new System.EventHandler(this.btnManageCoupon_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "     Mã giảm giá";
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUser.AutoSize = true;
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlUser.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlUser.BorderRadius = 15;
            this.pnlUser.BorderSize = 0;
            this.pnlUser.Controls.Add(this.lblUserBan);
            this.pnlUser.Controls.Add(this.lblUserTotal);
            this.pnlUser.Controls.Add(this.btnManageUser);
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.ForeColor = System.Drawing.Color.White;
            this.pnlUser.Location = new System.Drawing.Point(36, 209);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(450, 204);
            this.pnlUser.TabIndex = 11;
            this.pnlUser.TextColor = System.Drawing.Color.White;
            // 
            // lblUserBan
            // 
            this.lblUserBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserBan.BackColor = System.Drawing.Color.White;
            this.lblUserBan.BackgroundColor = System.Drawing.Color.White;
            this.lblUserBan.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUserBan.BorderRadius = 15;
            this.lblUserBan.BorderSize = 0;
            this.lblUserBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserBan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblUserBan.Image = ((System.Drawing.Image)(resources.GetObject("lblUserBan.Image")));
            this.lblUserBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserBan.Location = new System.Drawing.Point(239, 74);
            this.lblUserBan.Name = "lblUserBan";
            this.lblUserBan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUserBan.Size = new System.Drawing.Size(189, 40);
            this.lblUserBan.TabIndex = 11;
            this.lblUserBan.Text = "      18";
            this.lblUserBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserBan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblUserTotal
            // 
            this.lblUserTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserTotal.BackColor = System.Drawing.Color.White;
            this.lblUserTotal.BackgroundColor = System.Drawing.Color.White;
            this.lblUserTotal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUserTotal.BorderRadius = 15;
            this.lblUserTotal.BorderSize = 0;
            this.lblUserTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblUserTotal.Image = ((System.Drawing.Image)(resources.GetObject("lblUserTotal.Image")));
            this.lblUserTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserTotal.Location = new System.Drawing.Point(26, 74);
            this.lblUserTotal.Name = "lblUserTotal";
            this.lblUserTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUserTotal.Size = new System.Drawing.Size(189, 40);
            this.lblUserTotal.TabIndex = 9;
            this.lblUserTotal.Text = "      Đang tải...";
            this.lblUserTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserTotal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageUser
            // 
            this.btnManageUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageUser.BackColor = System.Drawing.Color.White;
            this.btnManageUser.BackgroundColor = System.Drawing.Color.White;
            this.btnManageUser.BorderColor = System.Drawing.Color.White;
            this.btnManageUser.BorderRadius = 15;
            this.btnManageUser.BorderSize = 0;
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(285, 138);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageUser.Size = new System.Drawing.Size(143, 40);
            this.btnManageUser.TabIndex = 9;
            this.btnManageUser.Text = "    Quản lý";
            this.btnManageUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "     Danh sách người dùng";
            // 
            // pnlCategory
            // 
            this.pnlCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCategory.AutoSize = true;
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlCategory.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlCategory.BorderRadius = 15;
            this.pnlCategory.BorderSize = 0;
            this.pnlCategory.Controls.Add(this.lblCategoryTotal);
            this.pnlCategory.Controls.Add(this.btnManageCategory);
            this.pnlCategory.Controls.Add(this.label12);
            this.pnlCategory.ForeColor = System.Drawing.Color.White;
            this.pnlCategory.Location = new System.Drawing.Point(36, 39);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(450, 138);
            this.pnlCategory.TabIndex = 9;
            this.pnlCategory.TextColor = System.Drawing.Color.White;
            // 
            // lblCategoryTotal
            // 
            this.lblCategoryTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryTotal.BackColor = System.Drawing.Color.White;
            this.lblCategoryTotal.BackgroundColor = System.Drawing.Color.White;
            this.lblCategoryTotal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCategoryTotal.BorderRadius = 15;
            this.lblCategoryTotal.BorderSize = 0;
            this.lblCategoryTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoryTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblCategoryTotal.Image = ((System.Drawing.Image)(resources.GetObject("lblCategoryTotal.Image")));
            this.lblCategoryTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoryTotal.Location = new System.Drawing.Point(29, 73);
            this.lblCategoryTotal.Name = "lblCategoryTotal";
            this.lblCategoryTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCategoryTotal.Size = new System.Drawing.Size(189, 40);
            this.lblCategoryTotal.TabIndex = 12;
            this.lblCategoryTotal.Text = "      Đang tải...";
            this.lblCategoryTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoryTotal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageCategory.BackColor = System.Drawing.Color.White;
            this.btnManageCategory.BackgroundColor = System.Drawing.Color.White;
            this.btnManageCategory.BorderColor = System.Drawing.Color.White;
            this.btnManageCategory.BorderRadius = 15;
            this.btnManageCategory.BorderSize = 0;
            this.btnManageCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCategory.FlatAppearance.BorderSize = 0;
            this.btnManageCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCategory.Image")));
            this.btnManageCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategory.Location = new System.Drawing.Point(285, 73);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCategory.Size = new System.Drawing.Size(143, 40);
            this.btnManageCategory.TabIndex = 8;
            this.btnManageCategory.Text = "    Quản lý";
            this.btnManageCategory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageCategory.UseVisualStyleBackColor = false;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(27, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(310, 37);
            this.label12.TabIndex = 1;
            this.label12.Text = "     Danh mục sản phẩm";
            // 
            // pnlBrand
            // 
            this.pnlBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBrand.AutoSize = true;
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlBrand.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlBrand.BorderRadius = 15;
            this.pnlBrand.BorderSize = 0;
            this.pnlBrand.Controls.Add(this.lblBrandTotal);
            this.pnlBrand.Controls.Add(this.btnManageBrand);
            this.pnlBrand.Controls.Add(this.label11);
            this.pnlBrand.ForeColor = System.Drawing.Color.White;
            this.pnlBrand.Location = new System.Drawing.Point(514, 39);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(450, 138);
            this.pnlBrand.TabIndex = 10;
            this.pnlBrand.TextColor = System.Drawing.Color.White;
            // 
            // lblBrandTotal
            // 
            this.lblBrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrandTotal.BackColor = System.Drawing.Color.White;
            this.lblBrandTotal.BackgroundColor = System.Drawing.Color.White;
            this.lblBrandTotal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBrandTotal.BorderRadius = 15;
            this.lblBrandTotal.BorderSize = 0;
            this.lblBrandTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblBrandTotal.Image = ((System.Drawing.Image)(resources.GetObject("lblBrandTotal.Image")));
            this.lblBrandTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrandTotal.Location = new System.Drawing.Point(26, 73);
            this.lblBrandTotal.Name = "lblBrandTotal";
            this.lblBrandTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBrandTotal.Size = new System.Drawing.Size(189, 40);
            this.lblBrandTotal.TabIndex = 13;
            this.lblBrandTotal.Text = "      Đang tải...";
            this.lblBrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrandTotal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageBrand
            // 
            this.btnManageBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageBrand.BackColor = System.Drawing.Color.White;
            this.btnManageBrand.BackgroundColor = System.Drawing.Color.White;
            this.btnManageBrand.BorderColor = System.Drawing.Color.White;
            this.btnManageBrand.BorderRadius = 15;
            this.btnManageBrand.BorderSize = 0;
            this.btnManageBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBrand.FlatAppearance.BorderSize = 0;
            this.btnManageBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnManageBrand.Image")));
            this.btnManageBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBrand.Location = new System.Drawing.Point(285, 73);
            this.btnManageBrand.Name = "btnManageBrand";
            this.btnManageBrand.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBrand.Size = new System.Drawing.Size(140, 40);
            this.btnManageBrand.TabIndex = 9;
            this.btnManageBrand.Text = "    Quản lý";
            this.btnManageBrand.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageBrand.UseVisualStyleBackColor = false;
            this.btnManageBrand.Click += new System.EventHandler(this.btnManageBrand_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(24, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "     Danh sách nhãn hàng";
            // 
            // cmsCategory
            // 
            this.cmsCategory.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReload});
            this.cmsCategory.Name = "cmsCategory";
            this.cmsCategory.Size = new System.Drawing.Size(202, 28);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReload.Image")));
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(201, 24);
            this.tsmiReload.Text = "Làm mới (F5 | Ctrl+R)";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.btnSeeAnalysis);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(36, 681);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(450, 153);
            this.roundedPanel1.TabIndex = 22;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnSeeAnalysis
            // 
            this.btnSeeAnalysis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeeAnalysis.BackColor = System.Drawing.Color.White;
            this.btnSeeAnalysis.BackgroundColor = System.Drawing.Color.White;
            this.btnSeeAnalysis.BorderColor = System.Drawing.Color.White;
            this.btnSeeAnalysis.BorderRadius = 15;
            this.btnSeeAnalysis.BorderSize = 0;
            this.btnSeeAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAnalysis.FlatAppearance.BorderSize = 0;
            this.btnSeeAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAnalysis.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeAnalysis.Image")));
            this.btnSeeAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAnalysis.Location = new System.Drawing.Point(285, 87);
            this.btnSeeAnalysis.Name = "btnSeeAnalysis";
            this.btnSeeAnalysis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeeAnalysis.Size = new System.Drawing.Size(143, 40);
            this.btnSeeAnalysis.TabIndex = 9;
            this.btnSeeAnalysis.Text = "    Xem";
            this.btnSeeAnalysis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAnalysis.UseVisualStyleBackColor = false;
            this.btnSeeAnalysis.Click += new System.EventHandler(this.btnSeeAnalysis_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "     Thống kê";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ContextMenuStrip = this.cmsCategory;
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCustomService);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlCoupon);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlBrand);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1000, 1143);
            this.pnlCustomService.ResumeLayout(false);
            this.pnlCustomService.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlCoupon.ResumeLayout(false);
            this.pnlCoupon.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.cmsCategory.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedPanel pnlCategory;
        private System.Windows.Forms.Label label12;
        private CustomControls.RoundedPanel pnlBrand;
        private System.Windows.Forms.Label label11;
        private CustomComponents.RoundedButton btnManageCategory;
        private CustomComponents.RoundedButton btnManageBrand;
        private CustomControls.RoundedPanel pnlUser;
        private CustomControls.RoundedLabel lblUserTotal;
        private CustomComponents.RoundedButton btnManageUser;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedLabel lblUserBan;
        private CustomControls.RoundedLabel lblCategoryTotal;
        private CustomControls.RoundedLabel lblBrandTotal;
        private CustomControls.RoundedPanel pnlCoupon;
        private CustomControls.RoundedLabel lblCouponUnusable;
        private CustomControls.RoundedLabel lblCouponTotal;
        private CustomComponents.RoundedButton btnManageCoupon;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedPanel pnlProduct;
        private CustomComponents.RoundedButton btnAddProduct;
        private CustomControls.RoundedLabel lblProductSoldOut;
        private CustomControls.RoundedLabel lblProductSelling;
        private CustomComponents.RoundedButton btnManageProduct;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedPanel pnlOrder;
        private CustomControls.RoundedLabel lblNoDeliveringOrder;
        private CustomControls.RoundedLabel lblNoProcessingOrder;
        private CustomComponents.RoundedButton btnManageOrders;
        private System.Windows.Forms.Label label4;
        private CustomControls.RoundedLabel lblNoCompletedOrder;
        private CustomControls.RoundedPanel pnlCustomService;
        private CustomComponents.RoundedButton btnCustomSystem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RoundedLabel lblProductStopSelling;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomComponents.RoundedButton btnSeeAnalysis;
        private System.Windows.Forms.Label label6;
    }
}
