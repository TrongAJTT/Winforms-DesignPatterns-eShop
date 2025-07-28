namespace _3S_eShop.GUI.ComponentControls
{
    partial class RatingBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingBar));
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            this.picStar5 = new System.Windows.Forms.PictureBox();
            this.flowContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowContainer
            // 
            this.flowContainer.Controls.Add(this.picStar1);
            this.flowContainer.Controls.Add(this.picStar2);
            this.flowContainer.Controls.Add(this.picStar3);
            this.flowContainer.Controls.Add(this.picStar4);
            this.flowContainer.Controls.Add(this.picStar5);
            this.flowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContainer.Location = new System.Drawing.Point(0, 0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(200, 32);
            this.flowContainer.TabIndex = 19;
            // 
            // picStar1
            // 
            this.picStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar1.Image = ((System.Drawing.Image)(resources.GetObject("picStar1.Image")));
            this.picStar1.Location = new System.Drawing.Point(0, 0);
            this.picStar1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(32, 32);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar1.TabIndex = 17;
            this.picStar1.TabStop = false;
            this.picStar1.Click += new System.EventHandler(this.picStar1_Click);
            // 
            // picStar2
            // 
            this.picStar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar2.Image = ((System.Drawing.Image)(resources.GetObject("picStar2.Image")));
            this.picStar2.Location = new System.Drawing.Point(42, 0);
            this.picStar2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(32, 32);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar2.TabIndex = 18;
            this.picStar2.TabStop = false;
            this.picStar2.Click += new System.EventHandler(this.picStar2_Click);
            // 
            // picStar3
            // 
            this.picStar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar3.Image = ((System.Drawing.Image)(resources.GetObject("picStar3.Image")));
            this.picStar3.Location = new System.Drawing.Point(84, 0);
            this.picStar3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(32, 32);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar3.TabIndex = 19;
            this.picStar3.TabStop = false;
            this.picStar3.Click += new System.EventHandler(this.picStar3_Click);
            // 
            // picStar4
            // 
            this.picStar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar4.Image = ((System.Drawing.Image)(resources.GetObject("picStar4.Image")));
            this.picStar4.Location = new System.Drawing.Point(126, 0);
            this.picStar4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(32, 32);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar4.TabIndex = 20;
            this.picStar4.TabStop = false;
            this.picStar4.Click += new System.EventHandler(this.picStar4_Click);
            // 
            // picStar5
            // 
            this.picStar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar5.Image = ((System.Drawing.Image)(resources.GetObject("picStar5.Image")));
            this.picStar5.Location = new System.Drawing.Point(168, 0);
            this.picStar5.Margin = new System.Windows.Forms.Padding(0);
            this.picStar5.Name = "picStar5";
            this.picStar5.Size = new System.Drawing.Size(32, 32);
            this.picStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar5.TabIndex = 21;
            this.picStar5.TabStop = false;
            this.picStar5.Click += new System.EventHandler(this.picStar5_Click);
            // 
            // RatingBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowContainer);
            this.Name = "RatingBar";
            this.Size = new System.Drawing.Size(200, 32);
            this.flowContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar4;
        private System.Windows.Forms.PictureBox picStar5;
    }
}
