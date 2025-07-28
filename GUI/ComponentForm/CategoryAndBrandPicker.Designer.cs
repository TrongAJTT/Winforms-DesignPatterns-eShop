namespace _3S_eShop.GUI.ComponentForm
{
    partial class CategoryAndBrandPicker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAndBrandPicker));
            this.listCategory = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSection1 = new _3S_eShop.CustomControls.RoundedLabel();
            this.lblSection2 = new _3S_eShop.CustomControls.RoundedLabel();
            this.listBrand = new System.Windows.Forms.ListView();
            this.brandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brandDesctiption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPickCategory = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnPickBrand = new _3S_eShop.CustomComponents.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingCategory = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.loadingBrand = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.flowCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowBrand = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDone = new _3S_eShop.CustomComponents.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowCategory.SuspendLayout();
            this.flowBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCategory
            // 
            this.listCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.desc});
            this.listCategory.FullRowSelect = true;
            this.listCategory.HideSelection = false;
            this.listCategory.Location = new System.Drawing.Point(6, 79);
            this.listCategory.Margin = new System.Windows.Forms.Padding(6, 20, 6, 4);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(470, 462);
            this.listCategory.TabIndex = 0;
            this.listCategory.UseCompatibleStateImageBehavior = false;
            this.listCategory.View = System.Windows.Forms.View.Details;
            this.listCategory.DoubleClick += new System.EventHandler(this.listCategory_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Tên loại";
            this.name.Width = 150;
            // 
            // desc
            // 
            this.desc.Text = "Mô tả";
            this.desc.Width = 500;
            // 
            // lblSection1
            // 
            this.lblSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSection1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSection1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSection1.BorderRadius = 30;
            this.lblSection1.BorderSize = 0;
            this.lblSection1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSection1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection1.ForeColor = System.Drawing.Color.White;
            this.lblSection1.Location = new System.Drawing.Point(4, 4);
            this.lblSection1.Margin = new System.Windows.Forms.Padding(4);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblSection1.Size = new System.Drawing.Size(475, 51);
            this.lblSection1.TabIndex = 1;
            this.lblSection1.Text = "1. Loại sản phẩm";
            this.lblSection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSection1.TextColor = System.Drawing.Color.White;
            // 
            // lblSection2
            // 
            this.lblSection2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSection2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSection2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSection2.BorderRadius = 30;
            this.lblSection2.BorderSize = 0;
            this.lblSection2.Enabled = false;
            this.lblSection2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSection2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection2.ForeColor = System.Drawing.Color.White;
            this.lblSection2.Location = new System.Drawing.Point(4, 4);
            this.lblSection2.Margin = new System.Windows.Forms.Padding(4);
            this.lblSection2.Name = "lblSection2";
            this.lblSection2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblSection2.Size = new System.Drawing.Size(475, 51);
            this.lblSection2.TabIndex = 4;
            this.lblSection2.Text = "2. Nhà sản xuất";
            this.lblSection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSection2.TextColor = System.Drawing.Color.White;
            // 
            // listBrand
            // 
            this.listBrand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandName,
            this.brandDesctiption});
            this.listBrand.Enabled = false;
            this.listBrand.FullRowSelect = true;
            this.listBrand.HideSelection = false;
            this.listBrand.Location = new System.Drawing.Point(6, 79);
            this.listBrand.Margin = new System.Windows.Forms.Padding(6, 20, 6, 4);
            this.listBrand.Name = "listBrand";
            this.listBrand.Size = new System.Drawing.Size(470, 462);
            this.listBrand.TabIndex = 3;
            this.listBrand.UseCompatibleStateImageBehavior = false;
            this.listBrand.View = System.Windows.Forms.View.Details;
            this.listBrand.DoubleClick += new System.EventHandler(this.listBrand_DoubleClick);
            // 
            // brandName
            // 
            this.brandName.Text = "Nhà sản xuất";
            this.brandName.Width = 150;
            // 
            // brandDesctiption
            // 
            this.brandDesctiption.Text = "Mô tả";
            this.brandDesctiption.Width = 500;
            // 
            // btnPickCategory
            // 
            this.btnPickCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickCategory.BorderRadius = 15;
            this.btnPickCategory.BorderSize = 0;
            this.btnPickCategory.FlatAppearance.BorderSize = 0;
            this.btnPickCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnPickCategory.ForeColor = System.Drawing.Color.White;
            this.btnPickCategory.Location = new System.Drawing.Point(160, 555);
            this.btnPickCategory.Margin = new System.Windows.Forms.Padding(160, 10, 4, 4);
            this.btnPickCategory.Name = "btnPickCategory";
            this.btnPickCategory.Size = new System.Drawing.Size(150, 40);
            this.btnPickCategory.TabIndex = 6;
            this.btnPickCategory.Text = "Chọn";
            this.btnPickCategory.TextColor = System.Drawing.Color.White;
            this.btnPickCategory.UseVisualStyleBackColor = false;
            this.btnPickCategory.Click += new System.EventHandler(this.btnPickCategory_Click);
            // 
            // btnPickBrand
            // 
            this.btnPickBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickBrand.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickBrand.BorderRadius = 15;
            this.btnPickBrand.BorderSize = 0;
            this.btnPickBrand.Enabled = false;
            this.btnPickBrand.FlatAppearance.BorderSize = 0;
            this.btnPickBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnPickBrand.ForeColor = System.Drawing.Color.White;
            this.btnPickBrand.Location = new System.Drawing.Point(160, 555);
            this.btnPickBrand.Margin = new System.Windows.Forms.Padding(160, 10, 4, 4);
            this.btnPickBrand.Name = "btnPickBrand";
            this.btnPickBrand.Size = new System.Drawing.Size(150, 40);
            this.btnPickBrand.TabIndex = 7;
            this.btnPickBrand.Text = "Chọn";
            this.btnPickBrand.TextColor = System.Drawing.Color.White;
            this.btnPickBrand.UseVisualStyleBackColor = false;
            this.btnPickBrand.Click += new System.EventHandler(this.btnPickBrand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // loadingCategory
            // 
            this.loadingCategory.AutoSize = true;
            this.loadingCategory.BackColor = System.Drawing.SystemColors.Window;
            this.loadingCategory.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingCategory.Location = new System.Drawing.Point(176, 315);
            this.loadingCategory.Margin = new System.Windows.Forms.Padding(0);
            this.loadingCategory.Message = "Đang tải dữ liệu";
            this.loadingCategory.Name = "loadingCategory";
            this.loadingCategory.Size = new System.Drawing.Size(200, 40);
            this.loadingCategory.TabIndex = 9;
            // 
            // loadingBrand
            // 
            this.loadingBrand.AutoSize = true;
            this.loadingBrand.BackColor = System.Drawing.Color.Transparent;
            this.loadingBrand.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingBrand.Location = new System.Drawing.Point(769, 315);
            this.loadingBrand.Margin = new System.Windows.Forms.Padding(0);
            this.loadingBrand.Message = "Đang tải dữ liệu";
            this.loadingBrand.Name = "loadingBrand";
            this.loadingBrand.Size = new System.Drawing.Size(200, 40);
            this.loadingBrand.TabIndex = 10;
            // 
            // flowCategory
            // 
            this.flowCategory.Controls.Add(this.lblSection1);
            this.flowCategory.Controls.Add(this.listCategory);
            this.flowCategory.Controls.Add(this.btnPickCategory);
            this.flowCategory.Location = new System.Drawing.Point(30, 27);
            this.flowCategory.Name = "flowCategory";
            this.flowCategory.Size = new System.Drawing.Size(480, 603);
            this.flowCategory.TabIndex = 11;
            // 
            // flowBrand
            // 
            this.flowBrand.Controls.Add(this.lblSection2);
            this.flowBrand.Controls.Add(this.listBrand);
            this.flowBrand.Controls.Add(this.btnPickBrand);
            this.flowBrand.Location = new System.Drawing.Point(616, 27);
            this.flowBrand.Name = "flowBrand";
            this.flowBrand.Size = new System.Drawing.Size(480, 603);
            this.flowBrand.TabIndex = 12;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDone.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDone.BorderRadius = 15;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(493, 619);
            this.btnDone.Margin = new System.Windows.Forms.Padding(160, 10, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(150, 40);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Lưu";
            this.btnDone.TextColor = System.Drawing.Color.White;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // CategoryAndBrandPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 672);
            this.Controls.Add(this.loadingBrand);
            this.Controls.Add(this.loadingCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.flowCategory);
            this.Controls.Add(this.flowBrand);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CategoryAndBrandPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn loại sản phẩm và hãng";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryAndBrandPicker_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowCategory.ResumeLayout(false);
            this.flowBrand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCategory;
        private CustomControls.RoundedLabel lblSection1;
        private CustomControls.RoundedLabel lblSection2;
        private System.Windows.Forms.ListView listBrand;
        private CustomComponents.RoundedButton btnPickCategory;
        private CustomComponents.RoundedButton btnPickBrand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader brandName;
        private System.Windows.Forms.ColumnHeader brandDesctiption;
        private ComponentControls.LoadingControl loadingCategory;
        private ComponentControls.LoadingControl loadingBrand;
        private System.Windows.Forms.FlowLayoutPanel flowCategory;
        private System.Windows.Forms.FlowLayoutPanel flowBrand;
        private CustomComponents.RoundedButton btnDone;
    }
}