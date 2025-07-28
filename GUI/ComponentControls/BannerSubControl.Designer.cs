namespace _3S_eShop.GUI.ComponentControls
{
    partial class BannerSubControl
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
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 15;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.picture);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(250, 80);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.TextColor = System.Drawing.Color.White;
            // 
            // picture
            // 
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(250, 80);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // BannerSubControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Name = "BannerSubControl";
            this.Size = new System.Drawing.Size(250, 80);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.PictureBox picture;
    }
}
