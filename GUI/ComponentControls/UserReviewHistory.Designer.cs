namespace _3S_eShop.GUI.ComponentControls
{
    partial class UserReviewHistory
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
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.picOverlay = new System.Windows.Forms.PictureBox();
            this.paginationSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).BeginInit();
            this.SuspendLayout();
            // 
            // flowReviews
            // 
            this.flowReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowReviews.AutoScroll = true;
            this.flowReviews.Location = new System.Drawing.Point(0, 0);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowReviews.Size = new System.Drawing.Size(990, 550);
            this.flowReviews.TabIndex = 10;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlContainer.Controls.Add(this.flowReviews);
            this.pnlContainer.Location = new System.Drawing.Point(15, 15);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(970, 550);
            this.pnlContainer.TabIndex = 11;
            // 
            // picOverlay
            // 
            this.picOverlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOverlay.Image = global::_3S_eShop.Properties.Resources.ic_loading_gif;
            this.picOverlay.Location = new System.Drawing.Point(400, 219);
            this.picOverlay.Margin = new System.Windows.Forms.Padding(0);
            this.picOverlay.Name = "picOverlay";
            this.picOverlay.Size = new System.Drawing.Size(200, 200);
            this.picOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOverlay.TabIndex = 2;
            this.picOverlay.TabStop = false;
            // 
            // paginationSelector
            // 
            this.paginationSelector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paginationSelector.CurrentPage = ((long)(1));
            this.paginationSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationSelector.Location = new System.Drawing.Point(15, 583);
            this.paginationSelector.Margin = new System.Windows.Forms.Padding(0);
            this.paginationSelector.MaxSize = ((long)(30));
            this.paginationSelector.Name = "paginationSelector";
            this.paginationSelector.PageSize = ((long)(20));
            this.paginationSelector.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.paginationSelector.Size = new System.Drawing.Size(970, 38);
            this.paginationSelector.TabIndex = 9;
            // 
            // UserReviewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picOverlay);
            this.Controls.Add(this.paginationSelector);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserReviewHistory";
            this.Size = new System.Drawing.Size(1000, 639);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PaginationSelector paginationSelector;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox picOverlay;
    }
}
