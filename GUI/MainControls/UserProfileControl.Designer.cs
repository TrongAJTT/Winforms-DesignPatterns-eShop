namespace _3S_eShop.GUI
{
    partial class UserProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileControl));
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.roundedPanel8 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblLatestReview = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNoReview = new _3S_eShop.CustomControls.RoundedLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSeeAllReviews = new _3S_eShop.CustomComponents.RoundedButton();
            this.roundedPanel4 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblNoOrders = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnSeeAllOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.roundedPanel7 = new _3S_eShop.CustomControls.RoundedPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNoCompletedOrder = new System.Windows.Forms.Label();
            this.roundedPanel6 = new _3S_eShop.CustomControls.RoundedPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNoDeliveringOrder = new System.Windows.Forms.Label();
            this.roundedPanel5 = new _3S_eShop.CustomControls.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoProcessingOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblRewardPointsWarranty = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNoRewardPoints = new _3S_eShop.CustomControls.RoundedLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAddress = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnToggleAddress = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblAddressInfo = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblNoAddressInfo = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnManageAddress = new _3S_eShop.CustomComponents.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnChangePassword = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblAccountInfo = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnEditInformation = new _3S_eShop.CustomComponents.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.invisibleLabel = new _3S_eShop.CustomControls.RoundedLabel();
            this.cmsCategory.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // roundedPanel8
            // 
            this.roundedPanel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel8.AutoSize = true;
            this.roundedPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel8.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel8.BorderRadius = 15;
            this.roundedPanel8.BorderSize = 0;
            this.roundedPanel8.Controls.Add(this.lblLatestReview);
            this.roundedPanel8.Controls.Add(this.lblNoReview);
            this.roundedPanel8.Controls.Add(this.label11);
            this.roundedPanel8.Controls.Add(this.btnSeeAllReviews);
            this.roundedPanel8.ForeColor = System.Drawing.Color.White;
            this.roundedPanel8.Location = new System.Drawing.Point(26, 735);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(928, 221);
            this.roundedPanel8.TabIndex = 8;
            this.roundedPanel8.TextColor = System.Drawing.Color.White;
            // 
            // lblLatestReview
            // 
            this.lblLatestReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLatestReview.BackColor = System.Drawing.Color.White;
            this.lblLatestReview.BackgroundColor = System.Drawing.Color.White;
            this.lblLatestReview.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLatestReview.BorderRadius = 15;
            this.lblLatestReview.BorderSize = 0;
            this.lblLatestReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLatestReview.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblLatestReview.Location = new System.Drawing.Point(21, 83);
            this.lblLatestReview.Name = "lblLatestReview";
            this.lblLatestReview.Padding = new System.Windows.Forms.Padding(10);
            this.lblLatestReview.Size = new System.Drawing.Size(882, 111);
            this.lblLatestReview.TabIndex = 7;
            this.lblLatestReview.Text = "Chưa có dữ liệu đánh giá";
            this.lblLatestReview.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblNoReview
            // 
            this.lblNoReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoReview.BackColor = System.Drawing.Color.White;
            this.lblNoReview.BackgroundColor = System.Drawing.Color.White;
            this.lblNoReview.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoReview.BorderRadius = 15;
            this.lblNoReview.BorderSize = 0;
            this.lblNoReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoReview.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoReview.Location = new System.Drawing.Point(525, 25);
            this.lblNoReview.Name = "lblNoReview";
            this.lblNoReview.Size = new System.Drawing.Size(175, 40);
            this.lblNoReview.TabIndex = 4;
            this.lblNoReview.Text = "10 sản phẩm";
            this.lblNoReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoReview.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(23, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "     Đánh giá";
            // 
            // btnSeeAllReviews
            // 
            this.btnSeeAllReviews.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeeAllReviews.BackColor = System.Drawing.Color.White;
            this.btnSeeAllReviews.BackgroundColor = System.Drawing.Color.White;
            this.btnSeeAllReviews.BorderColor = System.Drawing.Color.White;
            this.btnSeeAllReviews.BorderRadius = 15;
            this.btnSeeAllReviews.BorderSize = 0;
            this.btnSeeAllReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAllReviews.FlatAppearance.BorderSize = 0;
            this.btnSeeAllReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAllReviews.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllReviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAllReviews.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeAllReviews.Image")));
            this.btnSeeAllReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAllReviews.Location = new System.Drawing.Point(719, 25);
            this.btnSeeAllReviews.Name = "btnSeeAllReviews";
            this.btnSeeAllReviews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeeAllReviews.Size = new System.Drawing.Size(184, 40);
            this.btnSeeAllReviews.TabIndex = 8;
            this.btnSeeAllReviews.Text = "    Xem tất cả";
            this.btnSeeAllReviews.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAllReviews.UseVisualStyleBackColor = false;
            this.btnSeeAllReviews.Click += new System.EventHandler(this.btnSeeAllReviews_Click);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel4.AutoSize = true;
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel4.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel4.BorderRadius = 15;
            this.roundedPanel4.BorderSize = 0;
            this.roundedPanel4.Controls.Add(this.lblNoOrders);
            this.roundedPanel4.Controls.Add(this.btnSeeAllOrders);
            this.roundedPanel4.Controls.Add(this.roundedPanel7);
            this.roundedPanel4.Controls.Add(this.roundedPanel6);
            this.roundedPanel4.Controls.Add(this.roundedPanel5);
            this.roundedPanel4.Controls.Add(this.label4);
            this.roundedPanel4.ForeColor = System.Drawing.Color.White;
            this.roundedPanel4.Location = new System.Drawing.Point(26, 354);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(928, 240);
            this.roundedPanel4.TabIndex = 8;
            this.roundedPanel4.TextColor = System.Drawing.Color.White;
            // 
            // lblNoOrders
            // 
            this.lblNoOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoOrders.BackColor = System.Drawing.Color.White;
            this.lblNoOrders.BackgroundColor = System.Drawing.Color.White;
            this.lblNoOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoOrders.BorderRadius = 15;
            this.lblNoOrders.BorderSize = 0;
            this.lblNoOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoOrders.Location = new System.Drawing.Point(525, 23);
            this.lblNoOrders.Name = "lblNoOrders";
            this.lblNoOrders.Size = new System.Drawing.Size(175, 40);
            this.lblNoOrders.TabIndex = 9;
            this.lblNoOrders.Text = "10 đơn tất cả";
            this.lblNoOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnSeeAllOrders
            // 
            this.btnSeeAllOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeeAllOrders.BackColor = System.Drawing.Color.White;
            this.btnSeeAllOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnSeeAllOrders.BorderColor = System.Drawing.Color.White;
            this.btnSeeAllOrders.BorderRadius = 15;
            this.btnSeeAllOrders.BorderSize = 0;
            this.btnSeeAllOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAllOrders.FlatAppearance.BorderSize = 0;
            this.btnSeeAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAllOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAllOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeAllOrders.Image")));
            this.btnSeeAllOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAllOrders.Location = new System.Drawing.Point(719, 23);
            this.btnSeeAllOrders.Name = "btnSeeAllOrders";
            this.btnSeeAllOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeeAllOrders.Size = new System.Drawing.Size(184, 40);
            this.btnSeeAllOrders.TabIndex = 7;
            this.btnSeeAllOrders.Text = "    Xem tất cả";
            this.btnSeeAllOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSeeAllOrders.UseVisualStyleBackColor = false;
            this.btnSeeAllOrders.Click += new System.EventHandler(this.btnSeeAllOrders_Click);
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel7.BackColor = System.Drawing.Color.White;
            this.roundedPanel7.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel7.BorderRadius = 15;
            this.roundedPanel7.BorderSize = 0;
            this.roundedPanel7.Controls.Add(this.pictureBox3);
            this.roundedPanel7.Controls.Add(this.label8);
            this.roundedPanel7.Controls.Add(this.lblNoCompletedOrder);
            this.roundedPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel7.Location = new System.Drawing.Point(623, 76);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(280, 139);
            this.roundedPanel7.TabIndex = 4;
            this.roundedPanel7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(166, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đơn đã giao";
            // 
            // lblNoCompletedOrder
            // 
            this.lblNoCompletedOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoCompletedOrder.AutoSize = true;
            this.lblNoCompletedOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCompletedOrder.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCompletedOrder.Location = new System.Drawing.Point(7, 8);
            this.lblNoCompletedOrder.Name = "lblNoCompletedOrder";
            this.lblNoCompletedOrder.Size = new System.Drawing.Size(81, 94);
            this.lblNoCompletedOrder.TabIndex = 3;
            this.lblNoCompletedOrder.Text = "0";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel6.BackColor = System.Drawing.Color.White;
            this.roundedPanel6.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel6.BorderRadius = 15;
            this.roundedPanel6.BorderSize = 0;
            this.roundedPanel6.Controls.Add(this.pictureBox2);
            this.roundedPanel6.Controls.Add(this.label7);
            this.roundedPanel6.Controls.Add(this.lblNoDeliveringOrder);
            this.roundedPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel6.Location = new System.Drawing.Point(321, 76);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(280, 139);
            this.roundedPanel6.TabIndex = 3;
            this.roundedPanel6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(166, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn đang giao";
            // 
            // lblNoDeliveringOrder
            // 
            this.lblNoDeliveringOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoDeliveringOrder.AutoSize = true;
            this.lblNoDeliveringOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblNoDeliveringOrder.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDeliveringOrder.Location = new System.Drawing.Point(10, 8);
            this.lblNoDeliveringOrder.Name = "lblNoDeliveringOrder";
            this.lblNoDeliveringOrder.Size = new System.Drawing.Size(81, 94);
            this.lblNoDeliveringOrder.TabIndex = 2;
            this.lblNoDeliveringOrder.Text = "0";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel5.BorderRadius = 15;
            this.roundedPanel5.BorderSize = 0;
            this.roundedPanel5.Controls.Add(this.pictureBox1);
            this.roundedPanel5.Controls.Add(this.label6);
            this.roundedPanel5.Controls.Add(this.lblNoProcessingOrder);
            this.roundedPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel5.Location = new System.Drawing.Point(19, 76);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(280, 139);
            this.roundedPanel5.TabIndex = 2;
            this.roundedPanel5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn đang chờ";
            // 
            // lblNoProcessingOrder
            // 
            this.lblNoProcessingOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoProcessingOrder.AutoSize = true;
            this.lblNoProcessingOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblNoProcessingOrder.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProcessingOrder.Location = new System.Drawing.Point(8, 8);
            this.lblNoProcessingOrder.Name = "lblNoProcessingOrder";
            this.lblNoProcessingOrder.Size = new System.Drawing.Size(81, 94);
            this.lblNoProcessingOrder.TabIndex = 0;
            this.lblNoProcessingOrder.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "     Đơn hàng";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel3.AutoSize = true;
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel3.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.BorderSize = 0;
            this.roundedPanel3.Controls.Add(this.lblRewardPointsWarranty);
            this.roundedPanel3.Controls.Add(this.lblNoRewardPoints);
            this.roundedPanel3.Controls.Add(this.label3);
            this.roundedPanel3.ForeColor = System.Drawing.Color.White;
            this.roundedPanel3.Location = new System.Drawing.Point(26, 621);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(928, 87);
            this.roundedPanel3.TabIndex = 7;
            this.roundedPanel3.TextColor = System.Drawing.Color.White;
            // 
            // lblRewardPointsWarranty
            // 
            this.lblRewardPointsWarranty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRewardPointsWarranty.BackColor = System.Drawing.Color.White;
            this.lblRewardPointsWarranty.BackgroundColor = System.Drawing.Color.White;
            this.lblRewardPointsWarranty.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRewardPointsWarranty.BorderRadius = 15;
            this.lblRewardPointsWarranty.BorderSize = 0;
            this.lblRewardPointsWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRewardPointsWarranty.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardPointsWarranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblRewardPointsWarranty.Location = new System.Drawing.Point(478, 24);
            this.lblRewardPointsWarranty.Name = "lblRewardPointsWarranty";
            this.lblRewardPointsWarranty.Size = new System.Drawing.Size(429, 40);
            this.lblRewardPointsWarranty.TabIndex = 5;
            this.lblRewardPointsWarranty.Text = "Hết hạn vào 30/12/2025";
            this.lblRewardPointsWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRewardPointsWarranty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblNoRewardPoints
            // 
            this.lblNoRewardPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoRewardPoints.BackColor = System.Drawing.Color.White;
            this.lblNoRewardPoints.BackgroundColor = System.Drawing.Color.White;
            this.lblNoRewardPoints.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoRewardPoints.BorderRadius = 15;
            this.lblNoRewardPoints.BorderSize = 0;
            this.lblNoRewardPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoRewardPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRewardPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoRewardPoints.Location = new System.Drawing.Point(284, 24);
            this.lblNoRewardPoints.Name = "lblNoRewardPoints";
            this.lblNoRewardPoints.Size = new System.Drawing.Size(166, 40);
            this.lblNoRewardPoints.TabIndex = 4;
            this.lblNoRewardPoints.Text = "438.000";
            this.lblNoRewardPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoRewardPoints.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "     Điểm thưởng";
            // 
            // pnlAddress
            // 
            this.pnlAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAddress.AutoSize = true;
            this.pnlAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnlAddress.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlAddress.BorderRadius = 15;
            this.pnlAddress.BorderSize = 0;
            this.pnlAddress.Controls.Add(this.btnToggleAddress);
            this.pnlAddress.Controls.Add(this.lblAddressInfo);
            this.pnlAddress.Controls.Add(this.lblNoAddressInfo);
            this.pnlAddress.Controls.Add(this.btnManageAddress);
            this.pnlAddress.Controls.Add(this.label2);
            this.pnlAddress.ForeColor = System.Drawing.Color.White;
            this.pnlAddress.Location = new System.Drawing.Point(504, 26);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(450, 300);
            this.pnlAddress.TabIndex = 1;
            this.pnlAddress.TextColor = System.Drawing.Color.White;
            // 
            // btnToggleAddress
            // 
            this.btnToggleAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToggleAddress.BackColor = System.Drawing.Color.White;
            this.btnToggleAddress.BackgroundColor = System.Drawing.Color.White;
            this.btnToggleAddress.BorderColor = System.Drawing.Color.White;
            this.btnToggleAddress.BorderRadius = 15;
            this.btnToggleAddress.BorderSize = 0;
            this.btnToggleAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleAddress.FlatAppearance.BorderSize = 0;
            this.btnToggleAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnToggleAddress.Location = new System.Drawing.Point(216, 239);
            this.btnToggleAddress.Name = "btnToggleAddress";
            this.btnToggleAddress.Size = new System.Drawing.Size(75, 40);
            this.btnToggleAddress.TabIndex = 6;
            this.btnToggleAddress.Text = "Hiện";
            this.btnToggleAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnToggleAddress.UseVisualStyleBackColor = false;
            this.btnToggleAddress.Click += new System.EventHandler(this.btnToggleAddress_Click);
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddressInfo.BackColor = System.Drawing.Color.White;
            this.lblAddressInfo.BackgroundColor = System.Drawing.Color.White;
            this.lblAddressInfo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAddressInfo.BorderRadius = 15;
            this.lblAddressInfo.BorderSize = 0;
            this.lblAddressInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddressInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblAddressInfo.Location = new System.Drawing.Point(27, 76);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Padding = new System.Windows.Forms.Padding(10);
            this.lblAddressInfo.Size = new System.Drawing.Size(402, 147);
            this.lblAddressInfo.TabIndex = 5;
            this.lblAddressInfo.Text = "Tên người nhận\r\nSố điện Thoại\r\nĐịa chỉ hành chính\r\nĐịa chỉ đường";
            this.lblAddressInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // lblNoAddressInfo
            // 
            this.lblNoAddressInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoAddressInfo.BackColor = System.Drawing.Color.White;
            this.lblNoAddressInfo.BackgroundColor = System.Drawing.Color.White;
            this.lblNoAddressInfo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNoAddressInfo.BorderRadius = 15;
            this.lblNoAddressInfo.BorderSize = 0;
            this.lblNoAddressInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoAddressInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAddressInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblNoAddressInfo.Location = new System.Drawing.Point(309, 21);
            this.lblNoAddressInfo.Name = "lblNoAddressInfo";
            this.lblNoAddressInfo.Size = new System.Drawing.Size(120, 40);
            this.lblNoAddressInfo.TabIndex = 4;
            this.lblNoAddressInfo.Text = "3 địa chỉ";
            this.lblNoAddressInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoAddressInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnManageAddress
            // 
            this.btnManageAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageAddress.BackColor = System.Drawing.Color.White;
            this.btnManageAddress.BackgroundColor = System.Drawing.Color.White;
            this.btnManageAddress.BorderColor = System.Drawing.Color.White;
            this.btnManageAddress.BorderRadius = 15;
            this.btnManageAddress.BorderSize = 0;
            this.btnManageAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAddress.FlatAppearance.BorderSize = 0;
            this.btnManageAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageAddress.Location = new System.Drawing.Point(309, 239);
            this.btnManageAddress.Name = "btnManageAddress";
            this.btnManageAddress.Size = new System.Drawing.Size(120, 40);
            this.btnManageAddress.TabIndex = 2;
            this.btnManageAddress.Text = "Quản lý";
            this.btnManageAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnManageAddress.UseVisualStyleBackColor = false;
            this.btnManageAddress.Click += new System.EventHandler(this.btnManageAddress_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "     Địa chỉ nhận hàng";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.btnChangePassword);
            this.roundedPanel1.Controls.Add(this.lblAccountInfo);
            this.roundedPanel1.Controls.Add(this.btnEditInformation);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(26, 26);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(450, 300);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.BackgroundColor = System.Drawing.Color.White;
            this.btnChangePassword.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.BorderRadius = 15;
            this.btnChangePassword.BorderSize = 0;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChangePassword.Location = new System.Drawing.Point(122, 239);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(165, 40);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccountInfo.BackColor = System.Drawing.Color.White;
            this.lblAccountInfo.BackgroundColor = System.Drawing.Color.White;
            this.lblAccountInfo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAccountInfo.BorderRadius = 15;
            this.lblAccountInfo.BorderSize = 0;
            this.lblAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblAccountInfo.Location = new System.Drawing.Point(21, 76);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Padding = new System.Windows.Forms.Padding(10);
            this.lblAccountInfo.Size = new System.Drawing.Size(407, 147);
            this.lblAccountInfo.TabIndex = 6;
            this.lblAccountInfo.Text = "Tên tài khoản\r\nEmail";
            this.lblAccountInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // btnEditInformation
            // 
            this.btnEditInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditInformation.BackColor = System.Drawing.Color.White;
            this.btnEditInformation.BackgroundColor = System.Drawing.Color.White;
            this.btnEditInformation.BorderColor = System.Drawing.Color.White;
            this.btnEditInformation.BorderRadius = 15;
            this.btnEditInformation.BorderSize = 0;
            this.btnEditInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInformation.FlatAppearance.BorderSize = 0;
            this.btnEditInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEditInformation.Location = new System.Drawing.Point(308, 239);
            this.btnEditInformation.Name = "btnEditInformation";
            this.btnEditInformation.Size = new System.Drawing.Size(120, 40);
            this.btnEditInformation.TabIndex = 1;
            this.btnEditInformation.Text = "Chỉnh sửa";
            this.btnEditInformation.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEditInformation.UseVisualStyleBackColor = false;
            this.btnEditInformation.Click += new System.EventHandler(this.btnEditInformation_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Thông tin tài khoản";
            // 
            // invisibleLabel
            // 
            this.invisibleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invisibleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.invisibleLabel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.invisibleLabel.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.invisibleLabel.BorderRadius = 15;
            this.invisibleLabel.BorderSize = 0;
            this.invisibleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invisibleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invisibleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.invisibleLabel.Location = new System.Drawing.Point(829, 959);
            this.invisibleLabel.Name = "invisibleLabel";
            this.invisibleLabel.Size = new System.Drawing.Size(125, 40);
            this.invisibleLabel.TabIndex = 5;
            this.invisibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invisibleLabel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            // 
            // UserProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ContextMenuStrip = this.cmsCategory;
            this.Controls.Add(this.roundedPanel8);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.invisibleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserProfileControl";
            this.Size = new System.Drawing.Size(981, 1268);
            this.cmsCategory.ResumeLayout(false);
            this.roundedPanel8.ResumeLayout(false);
            this.roundedPanel8.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel pnlAddress;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedButton btnEditInformation;
        private CustomComponents.RoundedButton btnManageAddress;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedLabel lblNoAddressInfo;
        private CustomComponents.RoundedButton btnToggleAddress;
        private CustomControls.RoundedLabel lblAddressInfo;
        private CustomControls.RoundedLabel lblAccountInfo;
        private CustomControls.RoundedPanel roundedPanel3;
        private CustomControls.RoundedLabel lblNoRewardPoints;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label4;
        private CustomControls.RoundedPanel roundedPanel6;
        private CustomControls.RoundedPanel roundedPanel5;
        private CustomControls.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNoProcessingOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoCompletedOrder;
        private System.Windows.Forms.Label lblNoDeliveringOrder;
        private CustomControls.RoundedPanel roundedPanel8;
        private CustomControls.RoundedLabel lblNoReview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomComponents.RoundedButton btnSeeAllOrders;
        private CustomControls.RoundedLabel invisibleLabel;
        private CustomControls.RoundedLabel lblRewardPointsWarranty;
        private CustomControls.RoundedLabel lblLatestReview;
        private CustomComponents.RoundedButton btnChangePassword;
        private CustomComponents.RoundedButton btnSeeAllReviews;
        private CustomControls.RoundedLabel lblNoOrders;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}
