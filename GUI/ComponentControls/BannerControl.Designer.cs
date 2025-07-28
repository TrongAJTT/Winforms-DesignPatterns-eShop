namespace _3S_eShop.GUI.ComponentControls
{
    partial class BannerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BannerControl));
            this.info = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.labelOverlay = new System.Windows.Forms.Label();
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.date = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.ContextMenuStrip = this.contextMenuStrip;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Location = new System.Drawing.Point(3, 242);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(414, 58);
            this.info.TabIndex = 15;
            this.info.Text = "Thông tin sản phẩm";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(102, 52);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(101, 24);
            this.tsmiEdit.Text = "Sửa";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(101, 24);
            this.tsmiDelete.Text = "Xóa";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // picture
            // 
            this.picture.ContextMenuStrip = this.contextMenuStrip;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(420, 208);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 14;
            this.picture.TabStop = false;
            // 
            // labelOverlay
            // 
            this.labelOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.labelOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOverlay.Location = new System.Drawing.Point(140, 89);
            this.labelOverlay.Name = "labelOverlay";
            this.labelOverlay.Size = new System.Drawing.Size(151, 33);
            this.labelOverlay.TabIndex = 16;
            this.labelOverlay.Text = "Đang tải ảnh...";
            this.labelOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.pnlContainer.BorderRadius = 30;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.date);
            this.pnlContainer.Controls.Add(this.picture);
            this.pnlContainer.Controls.Add(this.info);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(10);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(420, 303);
            this.pnlContainer.TabIndex = 17;
            this.pnlContainer.TextColor = System.Drawing.Color.White;
            // 
            // date
            // 
            this.date.ContextMenuStrip = this.contextMenuStrip;
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(3, 211);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(414, 31);
            this.date.TabIndex = 16;
            this.date.Text = "Ngày tạo";
            // 
            // BannerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelOverlay);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BannerControl";
            this.Size = new System.Drawing.Size(420, 303);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label labelOverlay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.Label date;
    }
}
