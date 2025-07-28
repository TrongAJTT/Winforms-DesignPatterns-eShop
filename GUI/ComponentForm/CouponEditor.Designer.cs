namespace _3S_eShop.GUI.ComponentForm
{
    partial class CouponEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponEditor));
            this.datePickerStartDate = new _3S_eShop.CustomComponents.ColoredDateTimePicker();
            this.datePickerExpirationDate = new _3S_eShop.CustomComponents.ColoredDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiscountPercent = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxDiscountAmount = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRemainingUses = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new _3S_eShop.CustomComponents.RoundedButton();
            this.lbErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerStartDate.BorderSize = 0;
            this.datePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerStartDate.Location = new System.Drawing.Point(324, 275);
            this.datePickerStartDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(200, 35);
            this.datePickerStartDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePickerStartDate.TabIndex = 0;
            this.datePickerStartDate.TextColor = System.Drawing.Color.White;
            // 
            // datePickerExpirationDate
            // 
            this.datePickerExpirationDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerExpirationDate.BorderSize = 0;
            this.datePickerExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerExpirationDate.Location = new System.Drawing.Point(324, 355);
            this.datePickerExpirationDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerExpirationDate.Name = "datePickerExpirationDate";
            this.datePickerExpirationDate.Size = new System.Drawing.Size(200, 35);
            this.datePickerExpirationDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePickerExpirationDate.TabIndex = 1;
            this.datePickerExpirationDate.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // tbDiscountPercent
            // 
            this.tbDiscountPercent.BackColor = System.Drawing.SystemColors.Window;
            this.tbDiscountPercent.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbDiscountPercent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbDiscountPercent.BorderRadius = 0;
            this.tbDiscountPercent.BorderSize = 2;
            this.tbDiscountPercent.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDiscountPercent.InputCharacterValidator = null;
            this.tbDiscountPercent.Location = new System.Drawing.Point(324, 60);
            this.tbDiscountPercent.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiscountPercent.Multiline = false;
            this.tbDiscountPercent.Name = "tbDiscountPercent";
            this.tbDiscountPercent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbDiscountPercent.PasswordChar = false;
            this.tbDiscountPercent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDiscountPercent.PlaceholderText = "";
            this.tbDiscountPercent.Size = new System.Drawing.Size(250, 32);
            this.tbDiscountPercent.TabIndex = 4;
            this.tbDiscountPercent.Texts = "";
            this.tbDiscountPercent.UnderlinedStyle = false;
            this.tbDiscountPercent.Valid = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phần trăm giảm";
            // 
            // tbMaxDiscountAmount
            // 
            this.tbMaxDiscountAmount.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaxDiscountAmount.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbMaxDiscountAmount.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbMaxDiscountAmount.BorderRadius = 0;
            this.tbMaxDiscountAmount.BorderSize = 2;
            this.tbMaxDiscountAmount.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMaxDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaxDiscountAmount.InputCharacterValidator = null;
            this.tbMaxDiscountAmount.Location = new System.Drawing.Point(324, 127);
            this.tbMaxDiscountAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxDiscountAmount.Multiline = false;
            this.tbMaxDiscountAmount.Name = "tbMaxDiscountAmount";
            this.tbMaxDiscountAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbMaxDiscountAmount.PasswordChar = false;
            this.tbMaxDiscountAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMaxDiscountAmount.PlaceholderText = "";
            this.tbMaxDiscountAmount.Size = new System.Drawing.Size(250, 32);
            this.tbMaxDiscountAmount.TabIndex = 6;
            this.tbMaxDiscountAmount.Texts = "";
            this.tbMaxDiscountAmount.UnderlinedStyle = false;
            this.tbMaxDiscountAmount.Valid = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tiền tối đa được giảm";
            // 
            // tbRemainingUses
            // 
            this.tbRemainingUses.BackColor = System.Drawing.SystemColors.Window;
            this.tbRemainingUses.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbRemainingUses.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbRemainingUses.BorderRadius = 0;
            this.tbRemainingUses.BorderSize = 2;
            this.tbRemainingUses.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRemainingUses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemainingUses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRemainingUses.InputCharacterValidator = null;
            this.tbRemainingUses.Location = new System.Drawing.Point(324, 200);
            this.tbRemainingUses.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemainingUses.Multiline = false;
            this.tbRemainingUses.Name = "tbRemainingUses";
            this.tbRemainingUses.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbRemainingUses.PasswordChar = false;
            this.tbRemainingUses.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbRemainingUses.PlaceholderText = "";
            this.tbRemainingUses.Size = new System.Drawing.Size(250, 32);
            this.tbRemainingUses.TabIndex = 8;
            this.tbRemainingUses.Texts = "";
            this.tbRemainingUses.UnderlinedStyle = false;
            this.tbRemainingUses.Valid = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số người dùng còn lại";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BorderRadius = 30;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(231, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbErr.ForeColor = System.Drawing.Color.Red;
            this.lbErr.Location = new System.Drawing.Point(68, 425);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(102, 21);
            this.lbErr.TabIndex = 11;
            this.lbErr.Text = "thông báo lỗi";
            // 
            // CouponEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 565);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRemainingUses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaxDiscountAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDiscountPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerExpirationDate);
            this.Controls.Add(this.datePickerStartDate);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CouponEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chỉnh mã giảm giá";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.ColoredDateTimePicker datePickerStartDate;
        private CustomComponents.ColoredDateTimePicker datePickerExpirationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomComponents.AdvancedTextBox tbDiscountPercent;
        private System.Windows.Forms.Label label3;
        private CustomComponents.AdvancedTextBox tbMaxDiscountAmount;
        private System.Windows.Forms.Label label4;
        private CustomComponents.AdvancedTextBox tbRemainingUses;
        private System.Windows.Forms.Label label5;
        private CustomComponents.RoundedButton btnSave;
        private System.Windows.Forms.Label lbErr;
    }
}