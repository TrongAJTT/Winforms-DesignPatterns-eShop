namespace _3S_eShop.GUI.ComponentControls
{
    partial class CardCategory
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
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.container = new _3S_eShop.CustomControls.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.Color.White;
            this.picThumb.Image = global::_3S_eShop.Properties.Resources.ic_loading_gif;
            this.picThumb.Location = new System.Drawing.Point(31, 31);
            this.picThumb.Margin = new System.Windows.Forms.Padding(31);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(130, 130);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumb.TabIndex = 0;
            this.picThumb.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 63);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Laptop";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.container.BorderRadius = 16;
            this.container.BorderSize = 0;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.ForeColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(196, 250);
            this.container.TabIndex = 2;
            this.container.TextColor = System.Drawing.Color.White;
            // 
            // CardCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picThumb);
            this.Controls.Add(this.container);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CardCategory";
            this.Size = new System.Drawing.Size(196, 250);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Label lblName;
        private CustomControls.RoundedPanel container;
    }
}
