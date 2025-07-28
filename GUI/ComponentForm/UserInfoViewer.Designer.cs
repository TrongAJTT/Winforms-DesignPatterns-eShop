namespace _3S_eShop.GUI.ComponentForm
{
    partial class UserInfoViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoViewer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valueLatestLogin = new System.Windows.Forms.Label();
            this.valueCreated = new System.Windows.Forms.Label();
            this.valueEmail = new System.Windows.Forms.Label();
            this.valueName = new System.Windows.Forms.Label();
            this.titleLastestLogin = new System.Windows.Forms.Label();
            this.titleCreated = new System.Windows.Forms.Label();
            this.titleEmail = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowAddress = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.paginationSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.roundedFlowLayoutPanel1 = new _3S_eShop.CustomControls.RoundedFlowLayoutPanel();
            this.btnAllOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnProcessingOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnShippingOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCompletedOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCancelledOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.picOverlayP4 = new System.Windows.Forms.PictureBox();
            this.paginationSelector1 = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.roundedFlowLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlayP4)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.valueLatestLogin);
            this.tabPage1.Controls.Add(this.valueCreated);
            this.tabPage1.Controls.Add(this.valueEmail);
            this.tabPage1.Controls.Add(this.valueName);
            this.tabPage1.Controls.Add(this.titleLastestLogin);
            this.tabPage1.Controls.Add(this.titleCreated);
            this.tabPage1.Controls.Add(this.titleEmail);
            this.tabPage1.Controls.Add(this.titleName);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tổng quan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // valueLatestLogin
            // 
            this.valueLatestLogin.AutoSize = true;
            this.valueLatestLogin.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLatestLogin.Location = new System.Drawing.Point(326, 147);
            this.valueLatestLogin.Name = "valueLatestLogin";
            this.valueLatestLogin.Size = new System.Drawing.Size(102, 25);
            this.valueLatestLogin.TabIndex = 7;
            this.valueLatestLogin.Text = "Đang tải...";
            // 
            // valueCreated
            // 
            this.valueCreated.AutoSize = true;
            this.valueCreated.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCreated.Location = new System.Drawing.Point(326, 103);
            this.valueCreated.Name = "valueCreated";
            this.valueCreated.Size = new System.Drawing.Size(102, 25);
            this.valueCreated.TabIndex = 6;
            this.valueCreated.Text = "Đang tải...";
            // 
            // valueEmail
            // 
            this.valueEmail.AutoSize = true;
            this.valueEmail.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueEmail.Location = new System.Drawing.Point(326, 59);
            this.valueEmail.Name = "valueEmail";
            this.valueEmail.Size = new System.Drawing.Size(102, 25);
            this.valueEmail.TabIndex = 5;
            this.valueEmail.Text = "Đang tải...";
            // 
            // valueName
            // 
            this.valueName.AutoSize = true;
            this.valueName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueName.Location = new System.Drawing.Point(326, 19);
            this.valueName.Name = "valueName";
            this.valueName.Size = new System.Drawing.Size(102, 25);
            this.valueName.TabIndex = 4;
            this.valueName.Text = "Đang tải...";
            // 
            // titleLastestLogin
            // 
            this.titleLastestLogin.AutoSize = true;
            this.titleLastestLogin.Location = new System.Drawing.Point(23, 147);
            this.titleLastestLogin.Name = "titleLastestLogin";
            this.titleLastestLogin.Size = new System.Drawing.Size(267, 25);
            this.titleLastestLogin.TabIndex = 3;
            this.titleLastestLogin.Text = "Thời gian đăng nhập gần nhất";
            // 
            // titleCreated
            // 
            this.titleCreated.AutoSize = true;
            this.titleCreated.Location = new System.Drawing.Point(23, 103);
            this.titleCreated.Name = "titleCreated";
            this.titleCreated.Size = new System.Drawing.Size(162, 25);
            this.titleCreated.TabIndex = 2;
            this.titleCreated.Text = "Thời gian đăng ký";
            // 
            // titleEmail
            // 
            this.titleEmail.AutoSize = true;
            this.titleEmail.Location = new System.Drawing.Point(23, 59);
            this.titleEmail.Name = "titleEmail";
            this.titleEmail.Size = new System.Drawing.Size(58, 25);
            this.titleEmail.TabIndex = 1;
            this.titleEmail.Text = "Email";
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Location = new System.Drawing.Point(23, 19);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(124, 25);
            this.titleName.TabIndex = 0;
            this.titleName.Text = "Tên tài khoản";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Địa chỉ nhận hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowAddress
            // 
            this.flowAddress.AutoScroll = true;
            this.flowAddress.Location = new System.Drawing.Point(2, 2);
            this.flowAddress.Name = "flowAddress";
            this.flowAddress.Padding = new System.Windows.Forms.Padding(5);
            this.flowAddress.Size = new System.Drawing.Size(950, 593);
            this.flowAddress.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowOrders);
            this.tabPage3.Controls.Add(this.paginationSelector);
            this.tabPage3.Controls.Add(this.roundedFlowLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(956, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đơn hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowOrders
            // 
            this.flowOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowOrders.AutoScroll = true;
            this.flowOrders.Location = new System.Drawing.Point(3, 72);
            this.flowOrders.Margin = new System.Windows.Forms.Padding(0);
            this.flowOrders.Name = "flowOrders";
            this.flowOrders.Size = new System.Drawing.Size(970, 478);
            this.flowOrders.TabIndex = 9;
            // 
            // paginationSelector
            // 
            this.paginationSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paginationSelector.CurrentPage = ((long)(1));
            this.paginationSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationSelector.Location = new System.Drawing.Point(0, 559);
            this.paginationSelector.Margin = new System.Windows.Forms.Padding(0);
            this.paginationSelector.MaxSize = ((long)(30));
            this.paginationSelector.Name = "paginationSelector";
            this.paginationSelector.PageSize = ((long)(20));
            this.paginationSelector.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.paginationSelector.Size = new System.Drawing.Size(956, 38);
            this.paginationSelector.TabIndex = 10;
            // 
            // roundedFlowLayoutPanel1
            // 
            this.roundedFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedFlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedFlowLayoutPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedFlowLayoutPanel1.BorderRadius = 15;
            this.roundedFlowLayoutPanel1.BorderSize = 0;
            this.roundedFlowLayoutPanel1.Controls.Add(this.btnAllOrders);
            this.roundedFlowLayoutPanel1.Controls.Add(this.btnProcessingOrders);
            this.roundedFlowLayoutPanel1.Controls.Add(this.btnShippingOrders);
            this.roundedFlowLayoutPanel1.Controls.Add(this.btnCompletedOrders);
            this.roundedFlowLayoutPanel1.Controls.Add(this.btnCancelledOrders);
            this.roundedFlowLayoutPanel1.Controls.Add(this.lblCurrentStatus);
            this.roundedFlowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedFlowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.roundedFlowLayoutPanel1.Name = "roundedFlowLayoutPanel1";
            this.roundedFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedFlowLayoutPanel1.Size = new System.Drawing.Size(950, 60);
            this.roundedFlowLayoutPanel1.TabIndex = 7;
            this.roundedFlowLayoutPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.BackColor = System.Drawing.Color.White;
            this.btnAllOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnAllOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAllOrders.BorderRadius = 15;
            this.btnAllOrders.BorderSize = 0;
            this.btnAllOrders.FlatAppearance.BorderSize = 0;
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAllOrders.Location = new System.Drawing.Point(10, 10);
            this.btnAllOrders.Margin = new System.Windows.Forms.Padding(5);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(84, 40);
            this.btnAllOrders.TabIndex = 9;
            this.btnAllOrders.Text = "Tất cả";
            this.btnAllOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAllOrders.UseVisualStyleBackColor = false;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnProcessingOrders
            // 
            this.btnProcessingOrders.BackColor = System.Drawing.Color.White;
            this.btnProcessingOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnProcessingOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProcessingOrders.BorderRadius = 15;
            this.btnProcessingOrders.BorderSize = 0;
            this.btnProcessingOrders.FlatAppearance.BorderSize = 0;
            this.btnProcessingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnProcessingOrders.Location = new System.Drawing.Point(104, 10);
            this.btnProcessingOrders.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcessingOrders.Name = "btnProcessingOrders";
            this.btnProcessingOrders.Size = new System.Drawing.Size(162, 40);
            this.btnProcessingOrders.TabIndex = 5;
            this.btnProcessingOrders.Text = "Đơn đang chờ";
            this.btnProcessingOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnProcessingOrders.UseVisualStyleBackColor = false;
            this.btnProcessingOrders.Click += new System.EventHandler(this.btnProcessingOrders_Click);
            // 
            // btnShippingOrders
            // 
            this.btnShippingOrders.BackColor = System.Drawing.Color.White;
            this.btnShippingOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnShippingOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShippingOrders.BorderRadius = 15;
            this.btnShippingOrders.BorderSize = 0;
            this.btnShippingOrders.FlatAppearance.BorderSize = 0;
            this.btnShippingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShippingOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShippingOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnShippingOrders.Location = new System.Drawing.Point(276, 10);
            this.btnShippingOrders.Margin = new System.Windows.Forms.Padding(5);
            this.btnShippingOrders.Name = "btnShippingOrders";
            this.btnShippingOrders.Size = new System.Drawing.Size(181, 40);
            this.btnShippingOrders.TabIndex = 6;
            this.btnShippingOrders.Text = "Đơn đang giao";
            this.btnShippingOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnShippingOrders.UseVisualStyleBackColor = false;
            this.btnShippingOrders.Click += new System.EventHandler(this.btnShippingOrders_Click);
            // 
            // btnCompletedOrders
            // 
            this.btnCompletedOrders.BackColor = System.Drawing.Color.White;
            this.btnCompletedOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnCompletedOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompletedOrders.BorderRadius = 15;
            this.btnCompletedOrders.BorderSize = 0;
            this.btnCompletedOrders.FlatAppearance.BorderSize = 0;
            this.btnCompletedOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletedOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletedOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCompletedOrders.Location = new System.Drawing.Point(467, 10);
            this.btnCompletedOrders.Margin = new System.Windows.Forms.Padding(5);
            this.btnCompletedOrders.Name = "btnCompletedOrders";
            this.btnCompletedOrders.Size = new System.Drawing.Size(151, 40);
            this.btnCompletedOrders.TabIndex = 7;
            this.btnCompletedOrders.Text = "Đơn đã giao";
            this.btnCompletedOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCompletedOrders.UseVisualStyleBackColor = false;
            this.btnCompletedOrders.Click += new System.EventHandler(this.btnCompletedOrders_Click);
            // 
            // btnCancelledOrders
            // 
            this.btnCancelledOrders.BackColor = System.Drawing.Color.White;
            this.btnCancelledOrders.BackgroundColor = System.Drawing.Color.White;
            this.btnCancelledOrders.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelledOrders.BorderRadius = 15;
            this.btnCancelledOrders.BorderSize = 0;
            this.btnCancelledOrders.FlatAppearance.BorderSize = 0;
            this.btnCancelledOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelledOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelledOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCancelledOrders.Location = new System.Drawing.Point(628, 10);
            this.btnCancelledOrders.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelledOrders.Name = "btnCancelledOrders";
            this.btnCancelledOrders.Size = new System.Drawing.Size(131, 40);
            this.btnCancelledOrders.TabIndex = 10;
            this.btnCancelledOrders.Text = "Đơn bị hủy";
            this.btnCancelledOrders.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCancelledOrders.UseVisualStyleBackColor = false;
            this.btnCancelledOrders.Click += new System.EventHandler(this.btnCancelledOrders_Click);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(779, 15);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(71, 30);
            this.lblCurrentStatus.TabIndex = 8;
            this.lblCurrentStatus.Text = "Tất cả";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.picOverlayP4);
            this.tabPage4.Controls.Add(this.paginationSelector1);
            this.tabPage4.Controls.Add(this.pnlContainer);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(956, 597);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Đánh giá";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // picOverlayP4
            // 
            this.picOverlayP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOverlayP4.Image = global::_3S_eShop.Properties.Resources.ic_loading_gif;
            this.picOverlayP4.Location = new System.Drawing.Point(350, 170);
            this.picOverlayP4.Margin = new System.Windows.Forms.Padding(0);
            this.picOverlayP4.Name = "picOverlayP4";
            this.picOverlayP4.Size = new System.Drawing.Size(200, 200);
            this.picOverlayP4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOverlayP4.TabIndex = 3;
            this.picOverlayP4.TabStop = false;
            // 
            // paginationSelector1
            // 
            this.paginationSelector1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paginationSelector1.CurrentPage = ((long)(1));
            this.paginationSelector1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationSelector1.Location = new System.Drawing.Point(0, 559);
            this.paginationSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.paginationSelector1.MaxSize = ((long)(30));
            this.paginationSelector1.Name = "paginationSelector1";
            this.paginationSelector1.PageSize = ((long)(20));
            this.paginationSelector1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.paginationSelector1.Size = new System.Drawing.Size(956, 38);
            this.paginationSelector1.TabIndex = 13;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlContainer.Controls.Add(this.flowReviews);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(956, 550);
            this.pnlContainer.TabIndex = 12;
            // 
            // flowReviews
            // 
            this.flowReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowReviews.AutoScroll = true;
            this.flowReviews.Location = new System.Drawing.Point(0, 0);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowReviews.Size = new System.Drawing.Size(976, 550);
            this.flowReviews.TabIndex = 10;
            // 
            // UserInfoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "UserInfoViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem thông tin người dùng";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.roundedFlowLayoutPanel1.ResumeLayout(false);
            this.roundedFlowLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOverlayP4)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label titleCreated;
        private System.Windows.Forms.Label titleEmail;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Label titleLastestLogin;
        private System.Windows.Forms.Label valueLatestLogin;
        private System.Windows.Forms.Label valueCreated;
        private System.Windows.Forms.Label valueEmail;
        private System.Windows.Forms.Label valueName;
        private System.Windows.Forms.FlowLayoutPanel flowAddress;
        private CustomControls.RoundedFlowLayoutPanel roundedFlowLayoutPanel1;
        private CustomComponents.RoundedButton btnAllOrders;
        private CustomComponents.RoundedButton btnProcessingOrders;
        private CustomComponents.RoundedButton btnShippingOrders;
        private CustomComponents.RoundedButton btnCompletedOrders;
        private CustomComponents.RoundedButton btnCancelledOrders;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.FlowLayoutPanel flowOrders;
        private ComponentControls.PaginationSelector paginationSelector;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private ComponentControls.PaginationSelector paginationSelector1;
        private System.Windows.Forms.PictureBox picOverlayP4;
    }
}