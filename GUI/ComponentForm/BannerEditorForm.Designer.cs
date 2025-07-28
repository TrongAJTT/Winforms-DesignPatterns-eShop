namespace _3S_eShop.GUI.ComponentForm
{
    partial class BannerEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BannerEditorForm));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.titleProdName = new System.Windows.Forms.Label();
            this.titleCateBrand = new System.Windows.Forms.Label();
            this.titleSort = new System.Windows.Forms.Label();
            this.valueCateBrand = new System.Windows.Forms.Label();
            this.lblProductDgvOverlay = new System.Windows.Forms.Label();
            this.btnDone = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnDeleteCateBrand = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnChooseImage = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnChooseProduct = new _3S_eShop.CustomComponents.RoundedButton();
            this.paginationSelector = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblSelectedInfo = new System.Windows.Forms.Label();
            this.lblHintImage = new System.Windows.Forms.Label();
            this.picSelected = new System.Windows.Forms.PictureBox();
            this.imagePicker = new _3S_eShop.GUI.ComponentControls.ImagePanelPicker();
            this.lblSectionImage = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnSearch = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnProductSort = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnChooseCateBrand = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtSearchProductName = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblSectionProduct = new _3S_eShop.CustomControls.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 231);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 45;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(545, 362);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // titleProdName
            // 
            this.titleProdName.AutoSize = true;
            this.titleProdName.Location = new System.Drawing.Point(19, 87);
            this.titleProdName.Name = "titleProdName";
            this.titleProdName.Size = new System.Drawing.Size(128, 25);
            this.titleProdName.TabIndex = 4;
            this.titleProdName.Text = "Tên sản phẩm";
            // 
            // titleCateBrand
            // 
            this.titleCateBrand.AutoSize = true;
            this.titleCateBrand.Location = new System.Drawing.Point(19, 132);
            this.titleCateBrand.Name = "titleCateBrand";
            this.titleCateBrand.Size = new System.Drawing.Size(119, 25);
            this.titleCateBrand.TabIndex = 5;
            this.titleCateBrand.Text = "Loại và hãng";
            // 
            // titleSort
            // 
            this.titleSort.AutoSize = true;
            this.titleSort.Location = new System.Drawing.Point(19, 178);
            this.titleSort.Name = "titleSort";
            this.titleSort.Size = new System.Drawing.Size(78, 25);
            this.titleSort.TabIndex = 6;
            this.titleSort.Text = "Sắp xếp";
            // 
            // valueCateBrand
            // 
            this.valueCateBrand.AutoSize = true;
            this.valueCateBrand.Location = new System.Drawing.Point(267, 132);
            this.valueCateBrand.Name = "valueCateBrand";
            this.valueCateBrand.Size = new System.Drawing.Size(149, 25);
            this.valueCateBrand.TabIndex = 9;
            this.valueCateBrand.Text = "Tên loại và hãng";
            // 
            // lblProductDgvOverlay
            // 
            this.lblProductDgvOverlay.AutoSize = true;
            this.lblProductDgvOverlay.Location = new System.Drawing.Point(202, 405);
            this.lblProductDgvOverlay.Name = "lblProductDgvOverlay";
            this.lblProductDgvOverlay.Size = new System.Drawing.Size(158, 25);
            this.lblProductDgvOverlay.TabIndex = 19;
            this.lblProductDgvOverlay.Text = "Đang tải dữ liệu...";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDone.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDone.BorderRadius = 30;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(825, 659);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(214, 52);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "THÊM BANNER";
            this.btnDone.TextColor = System.Drawing.Color.White;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDeleteCateBrand
            // 
            this.btnDeleteCateBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteCateBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteCateBrand.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteCateBrand.BorderRadius = 10;
            this.btnDeleteCateBrand.BorderSize = 0;
            this.btnDeleteCateBrand.FlatAppearance.BorderSize = 0;
            this.btnDeleteCateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCateBrand.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCateBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCateBrand.Image")));
            this.btnDeleteCateBrand.Location = new System.Drawing.Point(515, 126);
            this.btnDeleteCateBrand.Name = "btnDeleteCateBrand";
            this.btnDeleteCateBrand.Size = new System.Drawing.Size(42, 36);
            this.btnDeleteCateBrand.TabIndex = 17;
            this.btnDeleteCateBrand.TextColor = System.Drawing.Color.White;
            this.btnDeleteCateBrand.UseVisualStyleBackColor = false;
            this.btnDeleteCateBrand.Click += new System.EventHandler(this.btnDeleteCateBrand_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseImage.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChooseImage.BorderRadius = 30;
            this.btnChooseImage.BorderSize = 0;
            this.btnChooseImage.Enabled = false;
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(591, 659);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(191, 52);
            this.btnChooseImage.TabIndex = 16;
            this.btnChooseImage.Text = "Chọn hình ảnh";
            this.btnChooseImage.TextColor = System.Drawing.Color.White;
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseProduct.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChooseProduct.BorderRadius = 30;
            this.btnChooseProduct.BorderSize = 0;
            this.btnChooseProduct.Enabled = false;
            this.btnChooseProduct.FlatAppearance.BorderSize = 0;
            this.btnChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseProduct.ForeColor = System.Drawing.Color.White;
            this.btnChooseProduct.Location = new System.Drawing.Point(12, 659);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(226, 52);
            this.btnChooseProduct.TabIndex = 15;
            this.btnChooseProduct.Text = "Chọn sản phẩm";
            this.btnChooseProduct.TextColor = System.Drawing.Color.White;
            this.btnChooseProduct.UseVisualStyleBackColor = false;
            this.btnChooseProduct.Click += new System.EventHandler(this.btnChooseProduct_Click);
            // 
            // paginationSelector
            // 
            this.paginationSelector.CurrentPage = ((long)(1));
            this.paginationSelector.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationSelector.Location = new System.Drawing.Point(12, 602);
            this.paginationSelector.Margin = new System.Windows.Forms.Padding(0);
            this.paginationSelector.MaxSize = ((long)(30));
            this.paginationSelector.Name = "paginationSelector";
            this.paginationSelector.PageSize = ((long)(20));
            this.paginationSelector.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.paginationSelector.Size = new System.Drawing.Size(545, 38);
            this.paginationSelector.TabIndex = 14;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.lblSelectedInfo);
            this.roundedPanel1.Controls.Add(this.lblHintImage);
            this.roundedPanel1.Controls.Add(this.picSelected);
            this.roundedPanel1.Controls.Add(this.imagePicker);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(591, 84);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(448, 556);
            this.roundedPanel1.TabIndex = 13;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lblSelectedInfo
            // 
            this.lblSelectedInfo.Location = new System.Drawing.Point(9, 238);
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Size = new System.Drawing.Size(425, 27);
            this.lblSelectedInfo.TabIndex = 15;
            this.lblSelectedInfo.Text = "1920x1080 | 16:9";
            this.lblSelectedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHintImage
            // 
            this.lblHintImage.Location = new System.Drawing.Point(9, 489);
            this.lblHintImage.Name = "lblHintImage";
            this.lblHintImage.Size = new System.Drawing.Size(425, 49);
            this.lblHintImage.TabIndex = 14;
            this.lblHintImage.Text = "Banner nên có tỉ lệ...\r\nKích thước khuyến nghị ...";
            // 
            // picSelected
            // 
            this.picSelected.Location = new System.Drawing.Point(14, 269);
            this.picSelected.Name = "picSelected";
            this.picSelected.Size = new System.Drawing.Size(420, 208);
            this.picSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelected.TabIndex = 13;
            this.picSelected.TabStop = false;
            // 
            // imagePicker
            // 
            this.imagePicker.BackColor = System.Drawing.Color.White;
            this.imagePicker.DefaultPictureSize = new System.Drawing.Size(50, 50);
            this.imagePicker.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePicker.Location = new System.Drawing.Point(14, 18);
            this.imagePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imagePicker.Name = "imagePicker";
            this.imagePicker.SelectecPicture = null;
            this.imagePicker.Size = new System.Drawing.Size(420, 215);
            this.imagePicker.TabIndex = 12;
            // 
            // lblSectionImage
            // 
            this.lblSectionImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionImage.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSectionImage.BorderRadius = 30;
            this.lblSectionImage.BorderSize = 0;
            this.lblSectionImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSectionImage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionImage.ForeColor = System.Drawing.Color.White;
            this.lblSectionImage.Location = new System.Drawing.Point(585, 18);
            this.lblSectionImage.Name = "lblSectionImage";
            this.lblSectionImage.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lblSectionImage.Size = new System.Drawing.Size(454, 51);
            this.lblSectionImage.TabIndex = 11;
            this.lblSectionImage.Text = "Chọn ảnh";
            this.lblSectionImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSectionImage.TextColor = System.Drawing.Color.White;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(515, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 36);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProductSort
            // 
            this.btnProductSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnProductSort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnProductSort.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProductSort.BorderRadius = 30;
            this.btnProductSort.BorderSize = 0;
            this.btnProductSort.FlatAppearance.BorderSize = 0;
            this.btnProductSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSort.ForeColor = System.Drawing.Color.White;
            this.btnProductSort.Location = new System.Drawing.Point(163, 172);
            this.btnProductSort.Name = "btnProductSort";
            this.btnProductSort.Size = new System.Drawing.Size(197, 36);
            this.btnProductSort.TabIndex = 8;
            this.btnProductSort.Text = "Ngày thêm: Tăng dần";
            this.btnProductSort.TextColor = System.Drawing.Color.White;
            this.btnProductSort.UseVisualStyleBackColor = false;
            this.btnProductSort.Click += new System.EventHandler(this.btnProductSort_Click);
            // 
            // btnChooseCateBrand
            // 
            this.btnChooseCateBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseCateBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnChooseCateBrand.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChooseCateBrand.BorderRadius = 30;
            this.btnChooseCateBrand.BorderSize = 0;
            this.btnChooseCateBrand.FlatAppearance.BorderSize = 0;
            this.btnChooseCateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCateBrand.ForeColor = System.Drawing.Color.White;
            this.btnChooseCateBrand.Location = new System.Drawing.Point(163, 126);
            this.btnChooseCateBrand.Name = "btnChooseCateBrand";
            this.btnChooseCateBrand.Size = new System.Drawing.Size(102, 36);
            this.btnChooseCateBrand.TabIndex = 7;
            this.btnChooseCateBrand.Text = "Chọn";
            this.btnChooseCateBrand.TextColor = System.Drawing.Color.White;
            this.btnChooseCateBrand.UseVisualStyleBackColor = false;
            this.btnChooseCateBrand.Click += new System.EventHandler(this.btnChooseCateBrand_Click);
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtSearchProductName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearchProductName.BorderRadius = 10;
            this.txtSearchProductName.BorderSize = 2;
            this.txtSearchProductName.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProductName.InputCharacterValidator = null;
            this.txtSearchProductName.Location = new System.Drawing.Point(163, 84);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProductName.Multiline = false;
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchProductName.PasswordChar = false;
            this.txtSearchProductName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchProductName.PlaceholderText = "";
            this.txtSearchProductName.Size = new System.Drawing.Size(182, 32);
            this.txtSearchProductName.TabIndex = 3;
            this.txtSearchProductName.Texts = "";
            this.txtSearchProductName.UnderlinedStyle = false;
            this.txtSearchProductName.Valid = null;
            // 
            // lblSectionProduct
            // 
            this.lblSectionProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionProduct.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSectionProduct.BorderRadius = 30;
            this.lblSectionProduct.BorderSize = 0;
            this.lblSectionProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSectionProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionProduct.ForeColor = System.Drawing.Color.White;
            this.lblSectionProduct.Location = new System.Drawing.Point(18, 18);
            this.lblSectionProduct.Name = "lblSectionProduct";
            this.lblSectionProduct.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lblSectionProduct.Size = new System.Drawing.Size(539, 51);
            this.lblSectionProduct.TabIndex = 2;
            this.lblSectionProduct.Text = "Chọn sản phẩm";
            this.lblSectionProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSectionProduct.TextColor = System.Drawing.Color.White;
            // 
            // BannerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 733);
            this.Controls.Add(this.lblProductDgvOverlay);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDeleteCateBrand);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.btnChooseProduct);
            this.Controls.Add(this.paginationSelector);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblSectionImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.valueCateBrand);
            this.Controls.Add(this.btnProductSort);
            this.Controls.Add(this.btnChooseCateBrand);
            this.Controls.Add(this.titleSort);
            this.Controls.Add(this.titleCateBrand);
            this.Controls.Add(this.titleProdName);
            this.Controls.Add(this.txtSearchProductName);
            this.Controls.Add(this.lblSectionProduct);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BannerEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa banner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private CustomControls.RoundedLabel lblSectionProduct;
        private CustomComponents.AdvancedTextBox txtSearchProductName;
        private System.Windows.Forms.Label titleProdName;
        private System.Windows.Forms.Label titleCateBrand;
        private System.Windows.Forms.Label titleSort;
        private CustomComponents.RoundedButton btnChooseCateBrand;
        private CustomComponents.RoundedButton btnProductSort;
        private System.Windows.Forms.Label valueCateBrand;
        private CustomComponents.RoundedButton btnSearch;
        private CustomControls.RoundedLabel lblSectionImage;
        private ComponentControls.ImagePanelPicker imagePicker;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox picSelected;
        private System.Windows.Forms.Label lblHintImage;
        private ComponentControls.PaginationSelector paginationSelector;
        private CustomComponents.RoundedButton btnChooseProduct;
        private CustomComponents.RoundedButton btnChooseImage;
        private System.Windows.Forms.Label lblSelectedInfo;
        private CustomComponents.RoundedButton btnDeleteCateBrand;
        private CustomComponents.RoundedButton btnDone;
        private System.Windows.Forms.Label lblProductDgvOverlay;
    }
}