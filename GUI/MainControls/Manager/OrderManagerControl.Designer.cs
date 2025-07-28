namespace _3S_eShop.GUI.ComponentControls
{
    partial class OrderManagerControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.pagingSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện quản lý đơn hàng, có phân trang, xem chi tiết trên Asana";
            // 
            // pagingSelector
            // 
            this.pagingSelector.CurrentPage = ((long)(1));
            this.pagingSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagingSelector.Location = new System.Drawing.Point(21, 542);
            this.pagingSelector.Margin = new System.Windows.Forms.Padding(0);
            this.pagingSelector.MaxSize = ((long)(50));
            this.pagingSelector.Name = "pagingSelector";
            this.pagingSelector.PageSize = ((long)(40));
            this.pagingSelector.PrimaryColor = System.Drawing.Color.DeepSkyBlue;
            this.pagingSelector.Size = new System.Drawing.Size(958, 38);
            this.pagingSelector.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(958, 421);
            this.dataGridView1.TabIndex = 4;
            // 
            // OrderManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagingSelector);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderManagerControl";
            this.Size = new System.Drawing.Size(1000, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PaginationSelector pagingSelector;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
