namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserOrderHistory
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
            this.flowOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.paginationSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.roundedFlowLayoutPanel1 = new _3S_eShop.CustomControls.RoundedFlowLayoutPanel();
            this.btnAllOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnProcessingOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnShippingOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCompletedOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnCancelledOrders = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.roundedFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowOrders
            // 
            this.flowOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowOrders.AutoScroll = true;
            this.flowOrders.Location = new System.Drawing.Point(15, 91);
            this.flowOrders.Margin = new System.Windows.Forms.Padding(0);
            this.flowOrders.Name = "flowOrders";
            this.flowOrders.Size = new System.Drawing.Size(970, 478);
            this.flowOrders.TabIndex = 0;
            // 
            // paginationSelector
            // 
            this.paginationSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paginationSelector.CurrentPage = ((long)(1));
            this.paginationSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationSelector.Location = new System.Drawing.Point(15, 585);
            this.paginationSelector.Margin = new System.Windows.Forms.Padding(0);
            this.paginationSelector.MaxSize = ((long)(30));
            this.paginationSelector.Name = "paginationSelector";
            this.paginationSelector.PageSize = ((long)(20));
            this.paginationSelector.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.paginationSelector.Size = new System.Drawing.Size(970, 38);
            this.paginationSelector.TabIndex = 8;
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
            this.roundedFlowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.roundedFlowLayoutPanel1.Name = "roundedFlowLayoutPanel1";
            this.roundedFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedFlowLayoutPanel1.Size = new System.Drawing.Size(970, 60);
            this.roundedFlowLayoutPanel1.TabIndex = 6;
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
            // UserOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowOrders);
            this.Controls.Add(this.paginationSelector);
            this.Controls.Add(this.roundedFlowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserOrderHistory";
            this.Size = new System.Drawing.Size(1000, 639);
            this.Resize += new System.EventHandler(this.UserOrderHistory_Resize);
            this.roundedFlowLayoutPanel1.ResumeLayout(false);
            this.roundedFlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.RoundedButton btnProcessingOrders;
        private CustomControls.RoundedFlowLayoutPanel roundedFlowLayoutPanel1;
        private CustomComponents.RoundedButton btnShippingOrders;
        private CustomComponents.RoundedButton btnCompletedOrders;
        private PaginationSelector paginationSelector;
        private System.Windows.Forms.Label lblCurrentStatus;
        private CustomComponents.RoundedButton btnAllOrders;
        private CustomComponents.RoundedButton btnCancelledOrders;
        private System.Windows.Forms.FlowLayoutPanel flowOrders;
    }
}
