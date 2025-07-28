namespace _3S_eShop.GUI.ComponentForm
{
    partial class BrandEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnUpload = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtDescription = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtName = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnPickCategory = new _3S_eShop.CustomComponents.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrCategory = new System.Windows.Forms.Label();
            this.lblErrName = new System.Windows.Forms.Label();
            this.lblErrDescription = new System.Windows.Forms.Label();
            this.lblErrImage = new System.Windows.Forms.Label();
            this.loadingControl = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên thương hiệu";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BorderRadius = 30;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 494);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 49);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnUpload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnUpload.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpload.BorderRadius = 30;
            this.btnUpload.BorderSize = 0;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(30, 437);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(191, 49);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Tải ảnh lên";
            this.btnUpload.TextColor = System.Drawing.Color.White;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.InputCharacterValidator = null;
            this.txtDescription.Location = new System.Drawing.Point(30, 251);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(453, 148);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            this.txtDescription.Valid = null;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 2;
            this.txtName.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.InputCharacterValidator = null;
            this.txtName.Location = new System.Drawing.Point(30, 154);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(453, 40);
            this.txtName.TabIndex = 10;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.Valid = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Danh mục";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtCategory.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCategory.BorderRadius = 15;
            this.txtCategory.BorderSize = 2;
            this.txtCategory.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategory.InputCharacterValidator = null;
            this.txtCategory.Location = new System.Drawing.Point(30, 59);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtCategory.PasswordChar = false;
            this.txtCategory.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCategory.PlaceholderText = "";
            this.txtCategory.Size = new System.Drawing.Size(338, 40);
            this.txtCategory.TabIndex = 16;
            this.txtCategory.Texts = "Chưa chọn danh mục";
            this.txtCategory.UnderlinedStyle = false;
            this.txtCategory.Valid = null;
            // 
            // btnPickCategory
            // 
            this.btnPickCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategory.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickCategory.BorderRadius = 30;
            this.btnPickCategory.BorderSize = 0;
            this.btnPickCategory.FlatAppearance.BorderSize = 0;
            this.btnPickCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPickCategory.ForeColor = System.Drawing.Color.White;
            this.btnPickCategory.Location = new System.Drawing.Point(376, 59);
            this.btnPickCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPickCategory.Name = "btnPickCategory";
            this.btnPickCategory.Size = new System.Drawing.Size(107, 40);
            this.btnPickCategory.TabIndex = 18;
            this.btnPickCategory.Text = "Chọn";
            this.btnPickCategory.TextColor = System.Drawing.Color.White;
            this.btnPickCategory.UseVisualStyleBackColor = false;
            this.btnPickCategory.Click += new System.EventHandler(this.btnPickCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 437);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 169);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrCategory
            // 
            this.lblErrCategory.AutoSize = true;
            this.lblErrCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrCategory.ForeColor = System.Drawing.Color.Red;
            this.lblErrCategory.Location = new System.Drawing.Point(122, 34);
            this.lblErrCategory.Name = "lblErrCategory";
            this.lblErrCategory.Size = new System.Drawing.Size(27, 19);
            this.lblErrCategory.TabIndex = 19;
            this.lblErrCategory.Text = "Lỗi";
            // 
            // lblErrName
            // 
            this.lblErrName.AutoSize = true;
            this.lblErrName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrName.ForeColor = System.Drawing.Color.Red;
            this.lblErrName.Location = new System.Drawing.Point(173, 129);
            this.lblErrName.Name = "lblErrName";
            this.lblErrName.Size = new System.Drawing.Size(27, 19);
            this.lblErrName.TabIndex = 20;
            this.lblErrName.Text = "Lỗi";
            // 
            // lblErrDescription
            // 
            this.lblErrDescription.AutoSize = true;
            this.lblErrDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErrDescription.Location = new System.Drawing.Point(91, 226);
            this.lblErrDescription.Name = "lblErrDescription";
            this.lblErrDescription.Size = new System.Drawing.Size(27, 19);
            this.lblErrDescription.TabIndex = 21;
            this.lblErrDescription.Text = "Lỗi";
            // 
            // lblErrImage
            // 
            this.lblErrImage.AutoSize = true;
            this.lblErrImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrImage.ForeColor = System.Drawing.Color.Red;
            this.lblErrImage.Location = new System.Drawing.Point(45, 414);
            this.lblErrImage.Name = "lblErrImage";
            this.lblErrImage.Size = new System.Drawing.Size(27, 19);
            this.lblErrImage.TabIndex = 22;
            this.lblErrImage.Text = "Lỗi";
            // 
            // loadingControl
            // 
            this.loadingControl.AutoSize = true;
            this.loadingControl.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingControl.Location = new System.Drawing.Point(30, 566);
            this.loadingControl.Margin = new System.Windows.Forms.Padding(0);
            this.loadingControl.Message = "Đang xử lý";
            this.loadingControl.Name = "loadingControl";
            this.loadingControl.Size = new System.Drawing.Size(191, 40);
            this.loadingControl.TabIndex = 23;
            this.loadingControl.Visible = false;
            // 
            // BrandEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 638);
            this.Controls.Add(this.loadingControl);
            this.Controls.Add(this.lblErrImage);
            this.Controls.Add(this.lblErrDescription);
            this.Controls.Add(this.lblErrName);
            this.Controls.Add(this.lblErrCategory);
            this.Controls.Add(this.btnPickCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BrandEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa thương hiệu";
            this.Load += new System.EventHandler(this.BrandEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedButton btnSave;
        private CustomComponents.RoundedButton btnUpload;
        private CustomComponents.AdvancedTextBox txtDescription;
        private CustomComponents.AdvancedTextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private CustomComponents.AdvancedTextBox txtCategory;
        private CustomComponents.RoundedButton btnPickCategory;
        private System.Windows.Forms.Label lblErrCategory;
        private System.Windows.Forms.Label lblErrName;
        private System.Windows.Forms.Label lblErrDescription;
        private System.Windows.Forms.Label lblErrImage;
        private ComponentControls.LoadingControl loadingControl;
    }
}