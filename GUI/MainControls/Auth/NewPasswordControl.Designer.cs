namespace _3S_eShop.GUI.MainControls.Auth
{
    partial class NewPasswordControl
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
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.txtPassConfirm = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.labelNewPassConfirm = new System.Windows.Forms.Label();
            this.lblPassConfirmErr = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.txtPass = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.lblPassErr = new System.Windows.Forms.Label();
            this.btnChange = new _3S_eShop.CustomComponents.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.togglePassChar = new _3S_eShop.CustomComponents.ToggleButton();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.togglePassChar);
            this.roundedPanel1.Controls.Add(this.txtPassConfirm);
            this.roundedPanel1.Controls.Add(this.labelNewPassConfirm);
            this.roundedPanel1.Controls.Add(this.lblPassConfirmErr);
            this.roundedPanel1.Controls.Add(this.loginTitle);
            this.roundedPanel1.Controls.Add(this.txtPass);
            this.roundedPanel1.Controls.Add(this.labelNewPass);
            this.roundedPanel1.Controls.Add(this.lblPassErr);
            this.roundedPanel1.Controls.Add(this.btnChange);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(285, 95);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(440, 494);
            this.roundedPanel1.TabIndex = 21;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtPassConfirm.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassConfirm.BorderRadius = 15;
            this.txtPassConfirm.BorderSize = 2;
            this.txtPassConfirm.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassConfirm.Location = new System.Drawing.Point(42, 282);
            this.txtPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassConfirm.Multiline = false;
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPassConfirm.PasswordChar = true;
            this.txtPassConfirm.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassConfirm.PlaceholderText = "";
            this.txtPassConfirm.Size = new System.Drawing.Size(362, 45);
            this.txtPassConfirm.TabIndex = 19;
            this.txtPassConfirm.Texts = "";
            this.txtPassConfirm.UnderlinedStyle = false;
            this.txtPassConfirm.Valid = null;
            // 
            // labelNewPassConfirm
            // 
            this.labelNewPassConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNewPassConfirm.AutoSize = true;
            this.labelNewPassConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassConfirm.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNewPassConfirm.Location = new System.Drawing.Point(53, 248);
            this.labelNewPassConfirm.Name = "labelNewPassConfirm";
            this.labelNewPassConfirm.Size = new System.Drawing.Size(196, 30);
            this.labelNewPassConfirm.TabIndex = 20;
            this.labelNewPassConfirm.Text = "Xác nhận mật khẩu";
            // 
            // lblPassConfirmErr
            // 
            this.lblPassConfirmErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassConfirmErr.BackColor = System.Drawing.Color.Transparent;
            this.lblPassConfirmErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassConfirmErr.ForeColor = System.Drawing.Color.Red;
            this.lblPassConfirmErr.Location = new System.Drawing.Point(46, 326);
            this.lblPassConfirmErr.Name = "lblPassConfirmErr";
            this.lblPassConfirmErr.Size = new System.Drawing.Size(358, 29);
            this.lblPassConfirmErr.TabIndex = 21;
            this.lblPassConfirmErr.Text = "Lỗi";
            this.lblPassConfirmErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Segoe UI", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTitle.Location = new System.Drawing.Point(41, 54);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(363, 51);
            this.loginTitle.TabIndex = 18;
            this.loginTitle.Text = "Mật khẩu mới";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.txtPass.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPass.BorderRadius = 15;
            this.txtPass.BorderSize = 2;
            this.txtPass.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(42, 172);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPass.PasswordChar = true;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPass.PlaceholderText = "";
            this.txtPass.Size = new System.Drawing.Size(362, 45);
            this.txtPass.TabIndex = 0;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            this.txtPass.Valid = null;
            // 
            // labelNewPass
            // 
            this.labelNewPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNewPass.Location = new System.Drawing.Point(53, 138);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(146, 30);
            this.labelNewPass.TabIndex = 1;
            this.labelNewPass.Text = "Mật khẩu mới";
            // 
            // lblPassErr
            // 
            this.lblPassErr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassErr.BackColor = System.Drawing.Color.Transparent;
            this.lblPassErr.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassErr.ForeColor = System.Drawing.Color.Red;
            this.lblPassErr.Location = new System.Drawing.Point(46, 216);
            this.lblPassErr.Name = "lblPassErr";
            this.lblPassErr.Size = new System.Drawing.Size(358, 29);
            this.lblPassErr.TabIndex = 14;
            this.lblPassErr.Text = "Lỗi";
            this.lblPassErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnChange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnChange.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChange.BorderRadius = 15;
            this.btnChange.BorderSize = 1;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChange.Location = new System.Drawing.Point(42, 388);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(362, 45);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Đổi mật khẩu";
            this.btnChange.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(363, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hiện";
            // 
            // togglePassChar
            // 
            this.togglePassChar.AutoSize = true;
            this.togglePassChar.Location = new System.Drawing.Point(317, 255);
            this.togglePassChar.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglePassChar.Name = "togglePassChar";
            this.togglePassChar.OffBackColor = System.Drawing.Color.Gray;
            this.togglePassChar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togglePassChar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togglePassChar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togglePassChar.Size = new System.Drawing.Size(45, 22);
            this.togglePassChar.TabIndex = 46;
            this.togglePassChar.UseVisualStyleBackColor = true;
            this.togglePassChar.CheckedChanged += new System.EventHandler(this.togglePassChar_CheckedChanged);
            // 
            // ChangePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChangePasswordControl";
            this.Size = new System.Drawing.Size(1000, 679);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label loginTitle;
        private CustomComponents.AdvancedTextBox txtPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label lblPassErr;
        private CustomComponents.RoundedButton btnChange;
        private CustomComponents.AdvancedTextBox txtPassConfirm;
        private System.Windows.Forms.Label labelNewPassConfirm;
        private System.Windows.Forms.Label lblPassConfirmErr;
        private System.Windows.Forms.Label label2;
        private CustomComponents.ToggleButton togglePassChar;
    }
}
