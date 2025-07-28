namespace _3S_eShop.GUI.ComponentForm
{
    partial class AddressEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressEditorForm));
            this.lblErrName = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.Label();
            this.errPhone = new System.Windows.Forms.Label();
            this.titlePhone = new System.Windows.Forms.Label();
            this.errAdminArea = new System.Windows.Forms.Label();
            this.titleAdminArea = new System.Windows.Forms.Label();
            this.errAddress = new System.Windows.Forms.Label();
            this.titleAddress = new System.Windows.Forms.Label();
            this.titleDefault = new System.Windows.Forms.Label();
            this.toggleDefault = new _3S_eShop.CustomComponents.ToggleButton();
            this.btnSave = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtAddress = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.cboWard = new _3S_eShop.CustomComponents.AdvancedCombobox();
            this.cboDistrict = new _3S_eShop.CustomComponents.AdvancedCombobox();
            this.cboCity = new _3S_eShop.CustomComponents.AdvancedCombobox();
            this.txtPhone = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtName = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.loadingControl = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.SuspendLayout();
            // 
            // lblErrName
            // 
            this.lblErrName.AutoSize = true;
            this.lblErrName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrName.ForeColor = System.Drawing.Color.Red;
            this.lblErrName.Location = new System.Drawing.Point(193, 30);
            this.lblErrName.Name = "lblErrName";
            this.lblErrName.Size = new System.Drawing.Size(27, 19);
            this.lblErrName.TabIndex = 23;
            this.lblErrName.Text = "Lỗi";
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Location = new System.Drawing.Point(25, 24);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(170, 25);
            this.titleName.TabIndex = 22;
            this.titleName.Text = "Họ tên người nhận";
            // 
            // errPhone
            // 
            this.errPhone.AutoSize = true;
            this.errPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errPhone.ForeColor = System.Drawing.Color.Red;
            this.errPhone.Location = new System.Drawing.Point(148, 122);
            this.errPhone.Name = "errPhone";
            this.errPhone.Size = new System.Drawing.Size(27, 19);
            this.errPhone.TabIndex = 26;
            this.errPhone.Text = "Lỗi";
            // 
            // titlePhone
            // 
            this.titlePhone.AutoSize = true;
            this.titlePhone.Location = new System.Drawing.Point(25, 116);
            this.titlePhone.Name = "titlePhone";
            this.titlePhone.Size = new System.Drawing.Size(123, 25);
            this.titlePhone.TabIndex = 25;
            this.titlePhone.Text = "Số điện thoại";
            // 
            // errAdminArea
            // 
            this.errAdminArea.AutoSize = true;
            this.errAdminArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errAdminArea.ForeColor = System.Drawing.Color.Red;
            this.errAdminArea.Location = new System.Drawing.Point(201, 218);
            this.errAdminArea.Name = "errAdminArea";
            this.errAdminArea.Size = new System.Drawing.Size(27, 19);
            this.errAdminArea.TabIndex = 31;
            this.errAdminArea.Text = "Lỗi";
            // 
            // titleAdminArea
            // 
            this.titleAdminArea.AutoSize = true;
            this.titleAdminArea.Location = new System.Drawing.Point(25, 212);
            this.titleAdminArea.Name = "titleAdminArea";
            this.titleAdminArea.Size = new System.Drawing.Size(170, 25);
            this.titleAdminArea.TabIndex = 30;
            this.titleAdminArea.Text = "Địa chỉ hành chính";
            // 
            // errAddress
            // 
            this.errAddress.AutoSize = true;
            this.errAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errAddress.ForeColor = System.Drawing.Color.Red;
            this.errAddress.Location = new System.Drawing.Point(193, 382);
            this.errAddress.Name = "errAddress";
            this.errAddress.Size = new System.Drawing.Size(27, 19);
            this.errAddress.TabIndex = 34;
            this.errAddress.Text = "Lỗi";
            // 
            // titleAddress
            // 
            this.titleAddress.AutoSize = true;
            this.titleAddress.Location = new System.Drawing.Point(25, 376);
            this.titleAddress.Name = "titleAddress";
            this.titleAddress.Size = new System.Drawing.Size(166, 25);
            this.titleAddress.TabIndex = 33;
            this.titleAddress.Text = "Số nhà, tên đường";
            // 
            // titleDefault
            // 
            this.titleDefault.AutoSize = true;
            this.titleDefault.Location = new System.Drawing.Point(81, 481);
            this.titleDefault.Name = "titleDefault";
            this.titleDefault.Size = new System.Drawing.Size(221, 25);
            this.titleDefault.TabIndex = 37;
            this.titleDefault.Text = "Đặt làm địa chỉ mặc định";
            // 
            // toggleDefault
            // 
            this.toggleDefault.AutoSize = true;
            this.toggleDefault.Location = new System.Drawing.Point(30, 483);
            this.toggleDefault.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleDefault.Name = "toggleDefault";
            this.toggleDefault.OffBackColor = System.Drawing.Color.Gray;
            this.toggleDefault.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleDefault.OnBackColor = System.Drawing.Color.DeepSkyBlue;
            this.toggleDefault.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleDefault.Size = new System.Drawing.Size(45, 22);
            this.toggleDefault.TabIndex = 36;
            this.toggleDefault.UseVisualStyleBackColor = true;
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
            this.btnSave.Location = new System.Drawing.Point(356, 468);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.InputCharacterValidator = null;
            this.txtAddress.Location = new System.Drawing.Point(30, 407);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(453, 40);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            this.txtAddress.Valid = null;
            // 
            // cboWard
            // 
            this.cboWard.BackColor = System.Drawing.Color.White;
            this.cboWard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboWard.BorderSize = 1;
            this.cboWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboWard.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWard.ForeColor = System.Drawing.Color.DimGray;
            this.cboWard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboWard.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboWard.ListTextColor = System.Drawing.Color.DimGray;
            this.cboWard.Location = new System.Drawing.Point(30, 322);
            this.cboWard.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboWard.Name = "cboWard";
            this.cboWard.Padding = new System.Windows.Forms.Padding(1);
            this.cboWard.SelectedIndex = -1;
            this.cboWard.Size = new System.Drawing.Size(453, 35);
            this.cboWard.TabIndex = 29;
            this.cboWard.Texts = "";
            // 
            // cboDistrict
            // 
            this.cboDistrict.BackColor = System.Drawing.Color.White;
            this.cboDistrict.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboDistrict.BorderSize = 1;
            this.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDistrict.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrict.ForeColor = System.Drawing.Color.DimGray;
            this.cboDistrict.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboDistrict.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboDistrict.ListTextColor = System.Drawing.Color.DimGray;
            this.cboDistrict.Location = new System.Drawing.Point(30, 281);
            this.cboDistrict.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Padding = new System.Windows.Forms.Padding(1);
            this.cboDistrict.SelectedIndex = -1;
            this.cboDistrict.Size = new System.Drawing.Size(453, 35);
            this.cboDistrict.TabIndex = 28;
            this.cboDistrict.Texts = "";
            // 
            // cboCity
            // 
            this.cboCity.BackColor = System.Drawing.Color.White;
            this.cboCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboCity.BorderSize = 1;
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCity.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.ForeColor = System.Drawing.Color.DimGray;
            this.cboCity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboCity.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCity.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCity.Location = new System.Drawing.Point(30, 240);
            this.cboCity.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCity.Name = "cboCity";
            this.cboCity.Padding = new System.Windows.Forms.Padding(1);
            this.cboCity.SelectedIndex = -1;
            this.cboCity.Size = new System.Drawing.Size(453, 35);
            this.cboCity.TabIndex = 27;
            this.cboCity.Texts = "";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPhone.BorderRadius = 15;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.InputCharacterValidator = null;
            this.txtPhone.Location = new System.Drawing.Point(30, 147);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(453, 40);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            this.txtPhone.Valid = null;
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
            this.txtName.Location = new System.Drawing.Point(30, 55);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(453, 40);
            this.txtName.TabIndex = 21;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.Valid = null;
            // 
            // loadingControl
            // 
            this.loadingControl.AutoSize = true;
            this.loadingControl.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingControl.Location = new System.Drawing.Point(266, 9);
            this.loadingControl.Margin = new System.Windows.Forms.Padding(0);
            this.loadingControl.Message = "Đang xủ lý dữ liệu";
            this.loadingControl.Name = "loadingControl";
            this.loadingControl.Size = new System.Drawing.Size(217, 40);
            this.loadingControl.TabIndex = 38;
            this.loadingControl.Visible = false;
            // 
            // AddressEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 543);
            this.Controls.Add(this.loadingControl);
            this.Controls.Add(this.titleDefault);
            this.Controls.Add(this.toggleDefault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.errAddress);
            this.Controls.Add(this.titleAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.errAdminArea);
            this.Controls.Add(this.titleAdminArea);
            this.Controls.Add(this.cboWard);
            this.Controls.Add(this.cboDistrict);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.errPhone);
            this.Controls.Add(this.titlePhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblErrName);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddressEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa địa chỉ";
            this.Load += new System.EventHandler(this.AddressEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrName;
        private System.Windows.Forms.Label titleName;
        private CustomComponents.AdvancedTextBox txtName;
        private System.Windows.Forms.Label errPhone;
        private System.Windows.Forms.Label titlePhone;
        private CustomComponents.AdvancedTextBox txtPhone;
        private CustomComponents.AdvancedCombobox cboCity;
        private CustomComponents.AdvancedCombobox cboDistrict;
        private CustomComponents.AdvancedCombobox cboWard;
        private System.Windows.Forms.Label errAdminArea;
        private System.Windows.Forms.Label titleAdminArea;
        private System.Windows.Forms.Label errAddress;
        private System.Windows.Forms.Label titleAddress;
        private CustomComponents.AdvancedTextBox txtAddress;
        private CustomComponents.RoundedButton btnSave;
        private CustomComponents.ToggleButton toggleDefault;
        private System.Windows.Forms.Label titleDefault;
        private ComponentControls.LoadingControl loadingControl;
    }
}