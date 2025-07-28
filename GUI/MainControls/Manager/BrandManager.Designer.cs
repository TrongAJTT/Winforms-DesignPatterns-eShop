namespace _3S_eShop.GUI.MainControls.Manager
{
    partial class BrandManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandManager));
            this.brandTable = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedLabel1 = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnPickCategory = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblCateoryValue = new System.Windows.Forms.Label();
            this.btnEdit = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnDelete = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnAdd = new _3S_eShop.CustomComponents.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandTable
            // 
            this.brandTable.AllowUserToAddRows = false;
            this.brandTable.AllowUserToDeleteRows = false;
            this.brandTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.brandTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.brandTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.CategoryName,
            this.Description});
            this.brandTable.Location = new System.Drawing.Point(3, 3);
            this.brandTable.Name = "brandTable";
            this.brandTable.ReadOnly = true;
            this.brandTable.RowHeadersVisible = false;
            this.brandTable.RowHeadersWidth = 51;
            this.brandTable.RowTemplate.Height = 24;
            this.brandTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandTable.Size = new System.Drawing.Size(994, 566);
            this.brandTable.TabIndex = 6;
            this.brandTable.SelectionChanged += new System.EventHandler(this.brandTable_SelectionChanged);
            // 
            // image
            // 
            this.image.HeaderText = "Hình Ảnh";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.Width = 113;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Tên thư mục";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 136;
            // 
            // Description
            // 
            this.Description.HeaderText = "Miêu tả";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 98;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedLabel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedLabel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedLabel1.BorderRadius = 30;
            this.roundedLabel1.BorderSize = 0;
            this.roundedLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(2, 2);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.roundedLabel1.Size = new System.Drawing.Size(549, 46);
            this.roundedLabel1.TabIndex = 10;
            this.roundedLabel1.Text = "Danh mục sản phẩm";
            this.roundedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedLabel1.TextColor = System.Drawing.Color.White;
            // 
            // btnPickCategory
            // 
            this.btnPickCategory.BackColor = System.Drawing.Color.White;
            this.btnPickCategory.BackgroundColor = System.Drawing.Color.White;
            this.btnPickCategory.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickCategory.BorderRadius = 10;
            this.btnPickCategory.BorderSize = 0;
            this.btnPickCategory.FlatAppearance.BorderSize = 0;
            this.btnPickCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.Location = new System.Drawing.Point(230, 9);
            this.btnPickCategory.Name = "btnPickCategory";
            this.btnPickCategory.Size = new System.Drawing.Size(79, 32);
            this.btnPickCategory.TabIndex = 11;
            this.btnPickCategory.Text = "Chọn";
            this.btnPickCategory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.UseVisualStyleBackColor = false;
            this.btnPickCategory.Click += new System.EventHandler(this.btnPickCategory_Click);
            // 
            // lblCateoryValue
            // 
            this.lblCateoryValue.AutoSize = true;
            this.lblCateoryValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblCateoryValue.ForeColor = System.Drawing.Color.White;
            this.lblCateoryValue.Location = new System.Drawing.Point(315, 13);
            this.lblCateoryValue.Name = "lblCateoryValue";
            this.lblCateoryValue.Size = new System.Drawing.Size(122, 25);
            this.lblCateoryValue.TabIndex = 12;
            this.lblCateoryValue.Text = "Tên danh mục";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEdit.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.BorderRadius = 30;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(864, 581);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnEdit.Size = new System.Drawing.Size(120, 46);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "    Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDelete.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.BorderRadius = 30;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(720, 580);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(135, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "     Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(581, 581);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.Size = new System.Drawing.Size(126, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "     Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblCateoryValue);
            this.panel1.Controls.Add(this.btnPickCategory);
            this.panel1.Controls.Add(this.roundedLabel1);
            this.panel1.Location = new System.Drawing.Point(10, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 50);
            this.panel1.TabIndex = 13;
            // 
            // BrandManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.brandTable);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BrandManager";
            this.Size = new System.Drawing.Size(1000, 639);
            this.Load += new System.EventHandler(this.BrandManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.RoundedButton btnEdit;
        private CustomComponents.RoundedButton btnDelete;
        private CustomComponents.RoundedButton btnAdd;
        private System.Windows.Forms.DataGridView brandTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private CustomControls.RoundedLabel roundedLabel1;
        private CustomComponents.RoundedButton btnPickCategory;
        private System.Windows.Forms.Label lblCateoryValue;
        private System.Windows.Forms.Panel panel1;
    }
}
