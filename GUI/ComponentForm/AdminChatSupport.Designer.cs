namespace _3S_eShop.GUI.ComponentForm
{
    partial class AdminChatSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChatSupport));
            this.flowChatHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.chatController = new _3S_eShop.GUI.ComponentControls.ChatController();
            this.pnlBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowChatHeader
            // 
            this.flowChatHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowChatHeader.AutoScroll = true;
            this.flowChatHeader.BackColor = System.Drawing.Color.DarkGray;
            this.flowChatHeader.ForeColor = System.Drawing.Color.Black;
            this.flowChatHeader.Location = new System.Drawing.Point(1, 42);
            this.flowChatHeader.Margin = new System.Windows.Forms.Padding(0);
            this.flowChatHeader.Name = "flowChatHeader";
            this.flowChatHeader.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.flowChatHeader.Size = new System.Drawing.Size(395, 568);
            this.flowChatHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBackGround.BackColor = System.Drawing.Color.DarkGray;
            this.pnlBackGround.Controls.Add(this.label1);
            this.pnlBackGround.Controls.Add(this.flowChatHeader);
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(380, 610);
            this.pnlBackGround.TabIndex = 3;
            // 
            // chatController
            // 
            this.chatController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatController.Enabled = false;
            this.chatController.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatController.Location = new System.Drawing.Point(386, 0);
            this.chatController.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chatController.Name = "chatController";
            this.chatController.Size = new System.Drawing.Size(501, 610);
            this.chatController.TabIndex = 2;
            this.chatController.Visible = false;
            // 
            // AdminChatSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 609);
            this.Controls.Add(this.chatController);
            this.Controls.Add(this.pnlBackGround);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(903, 650);
            this.Name = "AdminChatSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chăm sóc khách hàng";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminChatSupport_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminChatSupport_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AdminChatSupport_KeyUp);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlBackGround.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowChatHeader;
        private System.Windows.Forms.Label label1;
        private ComponentControls.ChatController chatController;
        private System.Windows.Forms.Panel pnlBackGround;
    }
}