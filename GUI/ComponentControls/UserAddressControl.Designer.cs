namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserAddressControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddressControl));
            this.containerPanel = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblDefault = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdminArea = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cmsAddress = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPick = new _3S_eShop.CustomComponents.RoundedButton();
            this.containerPanel.SuspendLayout();
            this.cmsAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.Transparent;
            this.containerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.containerPanel.BorderRadius = 30;
            this.containerPanel.BorderSize = 2;
            this.containerPanel.Controls.Add(this.btnPick);
            this.containerPanel.Controls.Add(this.lblDefault);
            this.containerPanel.Controls.Add(this.lblRecipient);
            this.containerPanel.Controls.Add(this.lblPhone);
            this.containerPanel.Controls.Add(this.lblAdminArea);
            this.containerPanel.Controls.Add(this.lblStreet);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.ForeColor = System.Drawing.Color.White;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(857, 179);
            this.containerPanel.TabIndex = 0;
            this.containerPanel.TextColor = System.Drawing.Color.White;
            // 
            // lblDefault
            // 
            this.lblDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefault.AutoSize = true;
            this.lblDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblDefault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblDefault.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDefault.BorderRadius = 15;
            this.lblDefault.BorderSize = 0;
            this.lblDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDefault.ForeColor = System.Drawing.Color.White;
            this.lblDefault.Location = new System.Drawing.Point(740, 16);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.lblDefault.Size = new System.Drawing.Size(105, 35);
            this.lblDefault.TabIndex = 21;
            this.lblDefault.Text = "Mặc định";
            this.lblDefault.TextColor = System.Drawing.Color.White;
            // 
            // lblRecipient
            // 
            this.lblRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecipient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRecipient.ForeColor = System.Drawing.Color.Black;
            this.lblRecipient.Image = ((System.Drawing.Image)(resources.GetObject("lblRecipient.Image")));
            this.lblRecipient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRecipient.Location = new System.Drawing.Point(15, 16);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Padding = new System.Windows.Forms.Padding(5);
            this.lblRecipient.Size = new System.Drawing.Size(719, 37);
            this.lblRecipient.TabIndex = 17;
            this.lblRecipient.Text = "      Họ tên người nhận";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(15, 53);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(5);
            this.lblPhone.Size = new System.Drawing.Size(824, 37);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "      Số điện thoại";
            // 
            // lblAdminArea
            // 
            this.lblAdminArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminArea.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAdminArea.ForeColor = System.Drawing.Color.Black;
            this.lblAdminArea.Image = ((System.Drawing.Image)(resources.GetObject("lblAdminArea.Image")));
            this.lblAdminArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdminArea.Location = new System.Drawing.Point(15, 90);
            this.lblAdminArea.Name = "lblAdminArea";
            this.lblAdminArea.Padding = new System.Windows.Forms.Padding(5);
            this.lblAdminArea.Size = new System.Drawing.Size(824, 37);
            this.lblAdminArea.TabIndex = 19;
            this.lblAdminArea.Text = "      Địa chỉ hành chính:";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStreet.ForeColor = System.Drawing.Color.Black;
            this.lblStreet.Image = ((System.Drawing.Image)(resources.GetObject("lblStreet.Image")));
            this.lblStreet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStreet.Location = new System.Drawing.Point(15, 127);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Padding = new System.Windows.Forms.Padding(5);
            this.lblStreet.Size = new System.Drawing.Size(724, 37);
            this.lblStreet.TabIndex = 20;
            this.lblStreet.Text = "      Địa chỉ nhà: ";
            // 
            // cmsAddress
            // 
            this.cmsAddress.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiDefault});
            this.cmsAddress.Name = "cmsAddress";
            this.cmsAddress.Size = new System.Drawing.Size(202, 76);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(201, 24);
            this.tsmiEdit.Text = "Chỉnh sửa địa chỉ này";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(201, 24);
            this.tsmiDelete.Text = "Xóa địa chỉ này";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiDefault
            // 
            this.tsmiDefault.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDefault.Image")));
            this.tsmiDefault.Name = "tsmiDefault";
            this.tsmiDefault.Size = new System.Drawing.Size(201, 24);
            this.tsmiDefault.Text = "Đặt làm mặc định";
            this.tsmiDefault.Click += new System.EventHandler(this.tsmiDefault_Click);
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPick.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPick.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPick.BorderRadius = 15;
            this.btnPick.BorderSize = 0;
            this.btnPick.FlatAppearance.BorderSize = 0;
            this.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPick.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPick.ForeColor = System.Drawing.Color.White;
            this.btnPick.Location = new System.Drawing.Point(739, 127);
            this.btnPick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(100, 38);
            this.btnPick.TabIndex = 37;
            this.btnPick.Text = "Chọn";
            this.btnPick.TextColor = System.Drawing.Color.White;
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Visible = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // UserAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsAddress;
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserAddressControl";
            this.Size = new System.Drawing.Size(857, 179);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.cmsAddress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel containerPanel;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdminArea;
        private System.Windows.Forms.Label lblStreet;
        private CustomControls.RoundedLabel lblDefault;
        private System.Windows.Forms.ContextMenuStrip cmsAddress;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDefault;
        private CustomComponents.RoundedButton btnPick;
    }
}
