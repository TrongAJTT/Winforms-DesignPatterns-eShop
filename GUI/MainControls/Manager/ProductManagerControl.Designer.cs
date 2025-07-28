namespace _3S_eShop.GUI.MainControls.Manager
{
    partial class ProductManagerControl
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
            this.pagingSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSection1 = new _3S_eShop.CustomControls.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pagingSelector
            // 
            this.pagingSelector.CurrentPage = 1;
            this.pagingSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagingSelector.Location = new System.Drawing.Point(21, 538);
            this.pagingSelector.Margin = new System.Windows.Forms.Padding(0);
            this.pagingSelector.MaxSize = 50;
            this.pagingSelector.Name = "pagingSelector";
            this.pagingSelector.PageSize = 40;
            this.pagingSelector.PrimaryColor = System.Drawing.Color.DeepSkyBlue;
            this.pagingSelector.Size = new System.Drawing.Size(958, 38);
            this.pagingSelector.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(958, 421);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblSection1
            // 
            this.lblSection1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSection1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSection1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSection1.BorderRadius = 30;
            this.lblSection1.BorderSize = 0;
            this.lblSection1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSection1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection1.ForeColor = System.Drawing.Color.White;
            this.lblSection1.Location = new System.Drawing.Point(15, 20);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Padding = new System.Windows.Forms.Padding(5);
            this.lblSection1.Size = new System.Drawing.Size(475, 51);
            this.lblSection1.TabIndex = 4;
            this.lblSection1.Text = "Chọn loại sản phẩm";
            this.lblSection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSection1.TextColor = System.Drawing.Color.White;
            // 
            // ProductManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.pagingSelector);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductManagerControl";
            this.Size = new System.Drawing.Size(1000, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentControls.PaginationSelector pagingSelector;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RoundedLabel lblSection1;
    }
}
