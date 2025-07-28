namespace _3S_eShop.GUI.MainControls
{
    partial class EmbedControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbedControl));
            this.topPnl = new System.Windows.Forms.Panel();
            this.sectionLoading = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPnl.Controls.Add(this.sectionLoading);
            this.topPnl.Controls.Add(this.btnBack);
            this.topPnl.Controls.Add(this.lblTitle);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1000, 50);
            this.topPnl.TabIndex = 2;
            // 
            // sectionLoading
            // 
            this.sectionLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionLoading.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.sectionLoading.Location = new System.Drawing.Point(533, 5);
            this.sectionLoading.Name = "sectionLoading";
            this.sectionLoading.Size = new System.Drawing.Size(458, 40);
            this.sectionLoading.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.BorderRadius = 30;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Wheat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.TextColor = System.Drawing.Color.Wheat;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(49, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tên tiêu đề control";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 629);
            this.pnlMain.TabIndex = 3;
            // 
            // EmbedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.topPnl);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EmbedControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.RoundedButton btnBack;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel sectionLoading;
    }
}
