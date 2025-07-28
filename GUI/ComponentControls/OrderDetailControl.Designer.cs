namespace _3S_eShop.GUI.ComponentControls
{
    partial class OrderDetailControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailControl));
            this.flowHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleOrderLog = new System.Windows.Forms.Label();
            this.flowProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleProductList = new System.Windows.Forms.Label();
            this.flowSubContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderAccount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderAddressRecipient = new System.Windows.Forms.Label();
            this.lblOrderAddressPhone = new System.Windows.Forms.Label();
            this.lblOrderAddressAdmin = new System.Windows.Forms.Label();
            this.lblOrderAddressStreet = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.lblRatingNote = new System.Windows.Forms.Label();
            this.roundedButton1 = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnRating = new _3S_eShop.CustomComponents.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowHistory.SuspendLayout();
            this.flowProductList.SuspendLayout();
            this.flowSubContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowHistory
            // 
            this.flowHistory.AutoSize = true;
            this.flowHistory.BackColor = System.Drawing.SystemColors.Control;
            this.flowHistory.Controls.Add(this.lblTitleOrderLog);
            this.flowHistory.Location = new System.Drawing.Point(15, 377);
            this.flowHistory.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.flowHistory.Name = "flowHistory";
            this.flowHistory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowHistory.Size = new System.Drawing.Size(950, 52);
            this.flowHistory.TabIndex = 0;
            // 
            // lblTitleOrderLog
            // 
            this.lblTitleOrderLog.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitleOrderLog.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOrderLog.ForeColor = System.Drawing.Color.White;
            this.lblTitleOrderLog.Location = new System.Drawing.Point(0, 0);
            this.lblTitleOrderLog.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitleOrderLog.Name = "lblTitleOrderLog";
            this.lblTitleOrderLog.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitleOrderLog.Size = new System.Drawing.Size(950, 42);
            this.lblTitleOrderLog.TabIndex = 2;
            this.lblTitleOrderLog.Text = "Lịch sử cập nhật";
            this.lblTitleOrderLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowProductList
            // 
            this.flowProductList.AutoSize = true;
            this.flowProductList.BackColor = System.Drawing.SystemColors.Control;
            this.flowProductList.Controls.Add(this.lblTitleProductList);
            this.flowProductList.Location = new System.Drawing.Point(15, 449);
            this.flowProductList.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.flowProductList.Name = "flowProductList";
            this.flowProductList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowProductList.Size = new System.Drawing.Size(950, 52);
            this.flowProductList.TabIndex = 3;
            // 
            // lblTitleProductList
            // 
            this.lblTitleProductList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitleProductList.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProductList.ForeColor = System.Drawing.Color.White;
            this.lblTitleProductList.Location = new System.Drawing.Point(0, 0);
            this.lblTitleProductList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitleProductList.Name = "lblTitleProductList";
            this.lblTitleProductList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitleProductList.Size = new System.Drawing.Size(950, 42);
            this.lblTitleProductList.TabIndex = 2;
            this.lblTitleProductList.Text = "Danh sách sản phẩm";
            this.lblTitleProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowSubContainer
            // 
            this.flowSubContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowSubContainer.AutoScroll = true;
            this.flowSubContainer.AutoSize = true;
            this.flowSubContainer.Controls.Add(this.flowLayoutPanel2);
            this.flowSubContainer.Controls.Add(this.flowLayoutPanel1);
            this.flowSubContainer.Controls.Add(this.flowHistory);
            this.flowSubContainer.Controls.Add(this.flowProductList);
            this.flowSubContainer.Controls.Add(this.lblTotalPrice);
            this.flowSubContainer.Controls.Add(this.pnlAction);
            this.flowSubContainer.Location = new System.Drawing.Point(10, 0);
            this.flowSubContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowSubContainer.MaximumSize = new System.Drawing.Size(980, 0);
            this.flowSubContainer.Name = "flowSubContainer";
            this.flowSubContainer.Size = new System.Drawing.Size(980, 705);
            this.flowSubContainer.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.lblOrderId);
            this.flowLayoutPanel2.Controls.Add(this.lblOrderDate);
            this.flowLayoutPanel2.Controls.Add(this.lblOrderAccount);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 20);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(950, 121);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // lblOrderId
            // 
            this.lblOrderId.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.Color.White;
            this.lblOrderId.Location = new System.Drawing.Point(0, 0);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOrderId.Size = new System.Drawing.Size(950, 42);
            this.lblOrderId.TabIndex = 2;
            this.lblOrderId.Text = "Đơn hàng #";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderDate.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderDate.Image")));
            this.lblOrderDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderDate.Location = new System.Drawing.Point(3, 42);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderDate.Size = new System.Drawing.Size(944, 37);
            this.lblOrderDate.TabIndex = 13;
            this.lblOrderDate.Text = "      Thời gian đặt";
            // 
            // lblOrderAccount
            // 
            this.lblOrderAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAccount.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAccount.Image")));
            this.lblOrderAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAccount.Location = new System.Drawing.Point(3, 79);
            this.lblOrderAccount.Name = "lblOrderAccount";
            this.lblOrderAccount.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAccount.Size = new System.Drawing.Size(944, 37);
            this.lblOrderAccount.TabIndex = 14;
            this.lblOrderAccount.Text = "      Tài khoản đặt";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderAddressRecipient);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderAddressPhone);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderAddressAdmin);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderAddressStreet);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 161);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 196);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(950, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin giao hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderAddressRecipient
            // 
            this.lblOrderAddressRecipient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAddressRecipient.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAddressRecipient.Image")));
            this.lblOrderAddressRecipient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAddressRecipient.Location = new System.Drawing.Point(3, 42);
            this.lblOrderAddressRecipient.Name = "lblOrderAddressRecipient";
            this.lblOrderAddressRecipient.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAddressRecipient.Size = new System.Drawing.Size(944, 37);
            this.lblOrderAddressRecipient.TabIndex = 13;
            this.lblOrderAddressRecipient.Text = "      Họ tên người nhận";
            // 
            // lblOrderAddressPhone
            // 
            this.lblOrderAddressPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAddressPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAddressPhone.Image")));
            this.lblOrderAddressPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAddressPhone.Location = new System.Drawing.Point(3, 79);
            this.lblOrderAddressPhone.Name = "lblOrderAddressPhone";
            this.lblOrderAddressPhone.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAddressPhone.Size = new System.Drawing.Size(944, 37);
            this.lblOrderAddressPhone.TabIndex = 14;
            this.lblOrderAddressPhone.Text = "      Số điện thoại";
            // 
            // lblOrderAddressAdmin
            // 
            this.lblOrderAddressAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAddressAdmin.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAddressAdmin.Image")));
            this.lblOrderAddressAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAddressAdmin.Location = new System.Drawing.Point(3, 116);
            this.lblOrderAddressAdmin.Name = "lblOrderAddressAdmin";
            this.lblOrderAddressAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAddressAdmin.Size = new System.Drawing.Size(944, 37);
            this.lblOrderAddressAdmin.TabIndex = 15;
            this.lblOrderAddressAdmin.Text = "      Địa chỉ hành chính:";
            // 
            // lblOrderAddressStreet
            // 
            this.lblOrderAddressStreet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrderAddressStreet.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderAddressStreet.Image")));
            this.lblOrderAddressStreet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderAddressStreet.Location = new System.Drawing.Point(3, 153);
            this.lblOrderAddressStreet.Name = "lblOrderAddressStreet";
            this.lblOrderAddressStreet.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrderAddressStreet.Size = new System.Drawing.Size(944, 37);
            this.lblOrderAddressStreet.TabIndex = 16;
            this.lblOrderAddressStreet.Text = "      Địa chỉ nhà: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 521);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTotalPrice.Size = new System.Drawing.Size(950, 42);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Tổng giá";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAction
            // 
            this.pnlAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlAction.Controls.Add(this.lblRatingNote);
            this.pnlAction.Controls.Add(this.roundedButton1);
            this.pnlAction.Controls.Add(this.btnRating);
            this.pnlAction.Location = new System.Drawing.Point(15, 583);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(950, 122);
            this.pnlAction.TabIndex = 13;
            this.pnlAction.Visible = false;
            // 
            // lblRatingNote
            // 
            this.lblRatingNote.AutoSize = true;
            this.lblRatingNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRatingNote.Location = new System.Drawing.Point(9, 11);
            this.lblRatingNote.Name = "lblRatingNote";
            this.lblRatingNote.Padding = new System.Windows.Forms.Padding(5);
            this.lblRatingNote.Size = new System.Drawing.Size(615, 30);
            this.lblRatingNote.TabIndex = 12;
            this.lblRatingNote.Text = "Lưu ý: Bạn chỉ có thể đánh giá trong vòng 21 ngày sau khi đơn hàng được giao thàn" +
    "h công";
            this.lblRatingNote.Visible = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(846, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(98, 42);
            this.roundedButton1.TabIndex = 11;
            this.roundedButton1.Text = "Mua lại";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // btnRating
            // 
            this.btnRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnRating.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnRating.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRating.BorderRadius = 15;
            this.btnRating.BorderSize = 0;
            this.btnRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.Location = new System.Drawing.Point(640, 5);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(200, 42);
            this.btnRating.TabIndex = 10;
            this.btnRating.Text = "Đánh giá đơn hàng";
            this.btnRating.TextColor = System.Drawing.Color.White;
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Visible = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowSubContainer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 908);
            this.panel1.TabIndex = 5;
            // 
            // OrderDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderDetailControl";
            this.Size = new System.Drawing.Size(1000, 858);
            this.Resize += new System.EventHandler(this.OrderDetailControl_Resize);
            this.flowHistory.ResumeLayout(false);
            this.flowProductList.ResumeLayout(false);
            this.flowSubContainer.ResumeLayout(false);
            this.flowSubContainer.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowHistory;
        private System.Windows.Forms.Label lblTitleOrderLog;
        private System.Windows.Forms.FlowLayoutPanel flowProductList;
        private System.Windows.Forms.Label lblTitleProductList;
        private System.Windows.Forms.FlowLayoutPanel flowSubContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderAccount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblRatingNote;
        private CustomComponents.RoundedButton roundedButton1;
        private CustomComponents.RoundedButton btnRating;
        private System.Windows.Forms.Label lblOrderAddressRecipient;
        private System.Windows.Forms.Label lblOrderAddressPhone;
        private System.Windows.Forms.Label lblOrderAddressAdmin;
        private System.Windows.Forms.Label lblOrderAddressStreet;
    }
}
