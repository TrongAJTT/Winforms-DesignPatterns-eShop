namespace _3S_eShop.GUI.ComponentControls
{
    partial class ChatController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatController));
            this.pnlChatController = new System.Windows.Forms.Panel();
            this.flowChatHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.overlayLoadHistory = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.btnSend = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtMessage = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.pnlChatController.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChatController
            // 
            this.pnlChatController.BackColor = System.Drawing.Color.White;
            this.pnlChatController.Controls.Add(this.btnSend);
            this.pnlChatController.Controls.Add(this.txtMessage);
            this.pnlChatController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChatController.Location = new System.Drawing.Point(0, 562);
            this.pnlChatController.Name = "pnlChatController";
            this.pnlChatController.Size = new System.Drawing.Size(500, 48);
            this.pnlChatController.TabIndex = 4;
            // 
            // flowChatHistory
            // 
            this.flowChatHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowChatHistory.AutoScroll = true;
            this.flowChatHistory.BackColor = System.Drawing.SystemColors.Control;
            this.flowChatHistory.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowChatHistory.Location = new System.Drawing.Point(0, 0);
            this.flowChatHistory.Margin = new System.Windows.Forms.Padding(0);
            this.flowChatHistory.Name = "flowChatHistory";
            this.flowChatHistory.Padding = new System.Windows.Forms.Padding(5);
            this.flowChatHistory.Size = new System.Drawing.Size(500, 562);
            this.flowChatHistory.TabIndex = 3;
            // 
            // overlayLoadHistory
            // 
            this.overlayLoadHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overlayLoadHistory.AutoSize = true;
            this.overlayLoadHistory.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlayLoadHistory.Location = new System.Drawing.Point(119, 286);
            this.overlayLoadHistory.Margin = new System.Windows.Forms.Padding(0);
            this.overlayLoadHistory.Message = "Đang tải lịch sử tin nhắn";
            this.overlayLoadHistory.Name = "overlayLoadHistory";
            this.overlayLoadHistory.Size = new System.Drawing.Size(270, 40);
            this.overlayLoadHistory.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.BorderRadius = 30;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(455, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 0;
            this.btnSend.TextColor = System.Drawing.Color.White;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.BorderColor = System.Drawing.Color.White;
            this.txtMessage.BorderFocusColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMessage.BorderRadius = 15;
            this.txtMessage.BorderSize = 2;
            this.txtMessage.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMessage.InputCharacterValidator = null;
            this.txtMessage.Location = new System.Drawing.Point(4, 4);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = false;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMessage.PasswordChar = false;
            this.txtMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMessage.PlaceholderText = "Nhập nội dung tin nhắn";
            this.txtMessage.Size = new System.Drawing.Size(444, 40);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Texts = "";
            this.txtMessage.UnderlinedStyle = false;
            this.txtMessage.Valid = null;
            // 
            // ChatController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.overlayLoadHistory);
            this.Controls.Add(this.pnlChatController);
            this.Controls.Add(this.flowChatHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChatController";
            this.Size = new System.Drawing.Size(500, 610);
            this.Resize += new System.EventHandler(this.ChatController_Resize);
            this.pnlChatController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoadingControl overlayLoadHistory;
        private System.Windows.Forms.Panel pnlChatController;
        private CustomComponents.RoundedButton btnSend;
        private CustomComponents.AdvancedTextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel flowChatHistory;
    }
}
