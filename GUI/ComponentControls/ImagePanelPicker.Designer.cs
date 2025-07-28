namespace _3S_eShop.GUI.ComponentControls
{
    partial class ImagePanelPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePanelPicker));
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbChange = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Location = new System.Drawing.Point(0, 32);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContent.Size = new System.Drawing.Size(419, 198);
            this.pnlContent.TabIndex = 0;
            // 
            // tsBar
            // 
            this.tsBar.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbChange,
            this.tsbDelete});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(419, 32);
            this.tsBar.TabIndex = 1;
            this.tsBar.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Margin = new System.Windows.Forms.Padding(0, 1, 7, 2);
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 29);
            this.tsbAdd.Text = "Thêm ảnh";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbChange
            // 
            this.tsbChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange.Enabled = false;
            this.tsbChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange.Image")));
            this.tsbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange.Margin = new System.Windows.Forms.Padding(0, 1, 7, 2);
            this.tsbChange.Name = "tsbChange";
            this.tsbChange.Size = new System.Drawing.Size(29, 29);
            this.tsbChange.Text = "Sửa ảnh";
            this.tsbChange.Click += new System.EventHandler(this.tsbChange_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(0, 1, 7, 2);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 29);
            this.tsbDelete.Text = "Xóa ảnh";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // ImagePanelPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ImagePanelPicker";
            this.Size = new System.Drawing.Size(419, 230);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContent;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbChange;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}
