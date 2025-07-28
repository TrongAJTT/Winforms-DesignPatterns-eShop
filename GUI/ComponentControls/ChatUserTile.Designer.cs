namespace _3S_eShop.GUI.ComponentControls
{
    partial class ChatUserTile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUserTile));
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.lblNewMessage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 30;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.iconUser);
            this.pnlContainer.Controls.Add(this.lblNewMessage);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.Black;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(350, 85);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.TextColor = System.Drawing.Color.Black;
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(19, 14);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(24, 24);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.ForeColor = System.Drawing.Color.Black;
            this.lblNewMessage.Location = new System.Drawing.Point(14, 45);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(329, 25);
            this.lblNewMessage.TabIndex = 1;
            this.lblNewMessage.Tag = "35 chữ...";
            this.lblNewMessage.Text = "Tin nhắn gần đây nhất mà hai người...";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(47, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            // 
            // ChatUserTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "ChatUserTile";
            this.Size = new System.Drawing.Size(350, 85);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.Label lblName;
    }
}
