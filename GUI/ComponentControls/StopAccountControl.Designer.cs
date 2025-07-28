namespace _3S_eShop.GUI.ComponentControls
{
    partial class StopAccountControl
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
            this.btnStopMyAccount = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtReason = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStopMyAccount
            // 
            this.btnStopMyAccount.BackColor = System.Drawing.Color.Red;
            this.btnStopMyAccount.BackgroundColor = System.Drawing.Color.Red;
            this.btnStopMyAccount.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStopMyAccount.BorderRadius = 15;
            this.btnStopMyAccount.BorderSize = 0;
            this.btnStopMyAccount.Enabled = false;
            this.btnStopMyAccount.FlatAppearance.BorderSize = 0;
            this.btnStopMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMyAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnStopMyAccount.Location = new System.Drawing.Point(736, 345);
            this.btnStopMyAccount.Name = "btnStopMyAccount";
            this.btnStopMyAccount.Size = new System.Drawing.Size(206, 45);
            this.btnStopMyAccount.TabIndex = 7;
            this.btnStopMyAccount.Text = "Dừng tài khoản";
            this.btnStopMyAccount.TextColor = System.Drawing.Color.White;
            this.btnStopMyAccount.UseVisualStyleBackColor = false;
            this.btnStopMyAccount.Click += new System.EventHandler(this.btnStopMyAccount_Click);
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.SystemColors.Window;
            this.txtReason.BorderColor = System.Drawing.Color.Red;
            this.txtReason.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtReason.BorderRadius = 15;
            this.txtReason.BorderSize = 2;
            this.txtReason.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReason.InputCharacterValidator = null;
            this.txtReason.Location = new System.Drawing.Point(49, 108);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReason.PasswordChar = false;
            this.txtReason.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReason.PlaceholderText = "Lý do bạn dừng tài khoản của mình? (Không bắt buộc)";
            this.txtReason.Size = new System.Drawing.Size(893, 170);
            this.txtReason.TabIndex = 6;
            this.txtReason.Texts = "";
            this.txtReason.UnderlinedStyle = false;
            this.txtReason.Valid = null;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 47);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "DỪNG TÀI KHOẢN CỦA TÔI";
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(49, 293);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(766, 29);
            this.chkAgree.TabIndex = 8;
            this.chkAgree.Text = "Tôi hiểu rằng thông qua việc này, tôi không thể tự mình truy cập vào tài khoản nà" +
    "y được nữa";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckedChanged += new System.EventHandler(this.chkAgree_CheckedChanged);
            // 
            // StopAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.btnStopMyAccount);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StopAccountControl";
            this.Size = new System.Drawing.Size(1000, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.RoundedButton btnStopMyAccount;
        private CustomComponents.AdvancedTextBox txtReason;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkAgree;
    }
}
