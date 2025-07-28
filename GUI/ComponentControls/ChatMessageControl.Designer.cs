namespace _3S_eShop.GUI.ComponentControls
{
    partial class ChatMessageControl
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
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMessage = new _3S_eShop.CustomControls.RoundedLabel();
            this.cmsChatBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChatCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.flowContainer.SuspendLayout();
            this.cmsChatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowContainer
            // 
            this.flowContainer.AutoSize = true;
            this.flowContainer.Controls.Add(this.lblMessage);
            this.flowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowContainer.Location = new System.Drawing.Point(0, 0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(500, 39);
            this.flowContainer.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblMessage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblMessage.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMessage.BorderRadius = 10;
            this.lblMessage.BorderSize = 0;
            this.lblMessage.ContextMenuStrip = this.cmsChatBox;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(316, 3);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(4);
            this.lblMessage.Size = new System.Drawing.Size(174, 33);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Nội dung tin nhắn";
            this.lblMessage.TextColor = System.Drawing.Color.White;
            // 
            // cmsChatBox
            // 
            this.cmsChatBox.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsChatBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChatCopy});
            this.cmsChatBox.Name = "cmsChatBox";
            this.cmsChatBox.Size = new System.Drawing.Size(193, 50);
            // 
            // tsmiChatCopy
            // 
            this.tsmiChatCopy.Name = "tsmiChatCopy";
            this.tsmiChatCopy.Size = new System.Drawing.Size(192, 22);
            this.tsmiChatCopy.Text = "Sao chép";
            this.tsmiChatCopy.Click += new System.EventHandler(this.tsmiChatCopy_Click);
            // 
            // ChatMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChatMessageControl";
            this.Size = new System.Drawing.Size(500, 39);
            this.flowContainer.ResumeLayout(false);
            this.flowContainer.PerformLayout();
            this.cmsChatBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private CustomControls.RoundedLabel lblMessage;
        private System.Windows.Forms.ContextMenuStrip cmsChatBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiChatCopy;
    }
}
