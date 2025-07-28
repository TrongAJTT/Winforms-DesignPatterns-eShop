namespace _3S_eShop.GUI.ComponentForm
{
    partial class UserChatSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChatSupport));
            this.chatController = new _3S_eShop.GUI.ComponentControls.ChatController();
            this.SuspendLayout();
            // 
            // chatController
            // 
            this.chatController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatController.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatController.Location = new System.Drawing.Point(0, 0);
            this.chatController.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chatController.Name = "chatController";
            this.chatController.Size = new System.Drawing.Size(500, 609);
            this.chatController.TabIndex = 0;
            // 
            // UserChatSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 609);
            this.Controls.Add(this.chatController);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(516, 650);
            this.Name = "UserChatSupport";
            this.Text = "Chăm sóc khách hàng";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserChatSupport_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserChatSupport_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserChatSupport_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentControls.ChatController chatController;
    }
}