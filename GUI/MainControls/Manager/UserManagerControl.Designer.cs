namespace _3S_eShop.GUI.MainControls.Manager
{
    partial class UserManagerControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOnline6MonthsLatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBanAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDecreasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagingSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(998, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeeInfo});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(177, 30);
            // 
            // tsmiSeeInfo
            // 
            this.tsmiSeeInfo.Image = global::_3S_eShop.Properties.Resources.information;
            this.tsmiSeeInfo.Name = "tsmiSeeInfo";
            this.tsmiSeeInfo.Size = new System.Drawing.Size(176, 26);
            this.tsmiSeeInfo.Text = "Xem thông tin";
            this.tsmiSeeInfo.Click += new System.EventHandler(this.tsmiSeeInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOnline6MonthsLatesToolStripMenuItem,
            this.showBanAccountToolStripMenuItem,
            this.showToolStripMenuItem,
            this.sortDecreasingToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.filterToolStripMenuItem.Tag = "";
            this.filterToolStripMenuItem.Text = "Filter And Sort";
            // 
            // showOnline6MonthsLatesToolStripMenuItem
            // 
            this.showOnline6MonthsLatesToolStripMenuItem.Name = "showOnline6MonthsLatesToolStripMenuItem";
            this.showOnline6MonthsLatesToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.showOnline6MonthsLatesToolStripMenuItem.Tag = "online";
            this.showOnline6MonthsLatesToolStripMenuItem.Text = "Show Online 6 Months Lates";
            this.showOnline6MonthsLatesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // showBanAccountToolStripMenuItem
            // 
            this.showBanAccountToolStripMenuItem.Name = "showBanAccountToolStripMenuItem";
            this.showBanAccountToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.showBanAccountToolStripMenuItem.Tag = "Ban";
            this.showBanAccountToolStripMenuItem.Text = "Show Ban Account";
            this.showBanAccountToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.showToolStripMenuItem.Tag = "Active";
            this.showToolStripMenuItem.Text = "Show Active Account";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // sortDecreasingToolStripMenuItem
            // 
            this.sortDecreasingToolStripMenuItem.Name = "sortDecreasingToolStripMenuItem";
            this.sortDecreasingToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.sortDecreasingToolStripMenuItem.Tag = "Decreasing";
            this.sortDecreasingToolStripMenuItem.Text = "Sort Decreasing";
            this.sortDecreasingToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // pagingSelector
            // 
            this.pagingSelector.CurrentPage = ((long)(1));
            this.pagingSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagingSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagingSelector.Location = new System.Drawing.Point(0, 492);
            this.pagingSelector.Margin = new System.Windows.Forms.Padding(0);
            this.pagingSelector.MaxSize = ((long)(50));
            this.pagingSelector.Name = "pagingSelector";
            this.pagingSelector.PageSize = ((long)(40));
            this.pagingSelector.PrimaryColor = System.Drawing.Color.DeepSkyBlue;
            this.pagingSelector.Size = new System.Drawing.Size(998, 38);
            this.pagingSelector.TabIndex = 1;
            // 
            // UserManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagingSelector);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserManagerControl";
            this.Size = new System.Drawing.Size(998, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentControls.PaginationSelector pagingSelector;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showOnline6MonthsLatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBanAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDecreasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeeInfo;
    }
}
