namespace _3S_eShop.GUI.ComponentForm
{
    partial class UserAddressPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddressPicker));
            this.flowAddress = new System.Windows.Forms.FlowLayoutPanel();
            this.contextChooseAddress = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmiPick = new System.Windows.Forms.ToolStripMenuItem();
            this.contextChooseAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowAddress
            // 
            this.flowAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowAddress.AutoScroll = true;
            this.flowAddress.Location = new System.Drawing.Point(8, 12);
            this.flowAddress.Name = "flowAddress";
            this.flowAddress.Padding = new System.Windows.Forms.Padding(5);
            this.flowAddress.Size = new System.Drawing.Size(969, 616);
            this.flowAddress.TabIndex = 37;
            // 
            // contextChooseAddress
            // 
            this.contextChooseAddress.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextChooseAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmiPick});
            this.contextChooseAddress.Name = "contextChooseAddress";
            this.contextChooseAddress.Size = new System.Drawing.Size(173, 26);
            // 
            // csmiPick
            // 
            this.csmiPick.Name = "csmiPick";
            this.csmiPick.Size = new System.Drawing.Size(172, 22);
            this.csmiPick.Text = "Chọn địa chỉ này";
            // 
            // UserAddressPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Controls.Add(this.flowAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserAddressPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bộ chọn địa chỉ";
            this.Load += new System.EventHandler(this.UserAddressPicker_Load);
            this.contextChooseAddress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowAddress;
        private System.Windows.Forms.ContextMenuStrip contextChooseAddress;
        private System.Windows.Forms.ToolStripMenuItem csmiPick;
    }
}