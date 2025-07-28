namespace _3S_eShop.GUI
{
    partial class CategoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.mainFLow = new System.Windows.Forms.FlowLayoutPanel();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.cardCategoryLabel = new _3S_eShop.CustomControls.RoundedLabel();
            this.mainFLow.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.cmsCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFLow
            // 
            this.mainFLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainFLow.AutoScroll = true;
            this.mainFLow.ContextMenuStrip = this.cmsCategory;
            this.mainFLow.Controls.Add(this.cardCategoryLabel);
            this.mainFLow.Location = new System.Drawing.Point(0, 0);
            this.mainFLow.Margin = new System.Windows.Forms.Padding(0);
            this.mainFLow.Name = "mainFLow";
            this.mainFLow.Size = new System.Drawing.Size(1020, 699);
            this.mainFLow.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainContainer.Controls.Add(this.mainFLow);
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1000, 679);
            this.mainContainer.TabIndex = 2;
            // 
            // cmsCategory
            // 
            this.cmsCategory.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReload});
            this.cmsCategory.Name = "cmsCategory";
            this.cmsCategory.Size = new System.Drawing.Size(202, 28);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReload.Image")));
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(201, 24);
            this.tsmiReload.Text = "Làm mới (F5 | Ctrl+R)";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // cardCategoryLabel
            // 
            this.cardCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCategoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardCategoryLabel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardCategoryLabel.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cardCategoryLabel.BorderRadius = 30;
            this.cardCategoryLabel.BorderSize = 0;
            this.cardCategoryLabel.ContextMenuStrip = this.cmsCategory;
            this.cardCategoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardCategoryLabel.ForeColor = System.Drawing.Color.White;
            this.cardCategoryLabel.Location = new System.Drawing.Point(10, 20);
            this.cardCategoryLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.cardCategoryLabel.Name = "cardCategoryLabel";
            this.cardCategoryLabel.Padding = new System.Windows.Forms.Padding(15);
            this.cardCategoryLabel.Size = new System.Drawing.Size(980, 80);
            this.cardCategoryLabel.TabIndex = 2;
            this.cardCategoryLabel.Text = "Phân loại sản phẩm";
            this.cardCategoryLabel.TextColor = System.Drawing.Color.White;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.mainFLow.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.cmsCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFLow;
        private CustomControls.RoundedLabel cardCategoryLabel;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableCategory;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}
