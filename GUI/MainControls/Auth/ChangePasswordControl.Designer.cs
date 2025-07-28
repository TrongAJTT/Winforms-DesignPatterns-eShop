namespace _3S_eShop.GUI.MainControls.Auth
{
    partial class ChangePasswordControl
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
            this.btnForgotPass = new _3S_eShop.CustomComponents.RoundedButton();
            this.loginTitle = new System.Windows.Forms.Label();
            this.txtPass = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.titlePass = new System.Windows.Forms.Label();
            this.lblPassErr = new System.Windows.Forms.Label();
            this.btnContinue = new _3S_eShop.CustomComponents.RoundedButton();
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
            this.roundedPanel1.Controls.Add(this.btnForgotPass);
            this.roundedPanel1.Controls.Add(this.loginTitle);
            this.roundedPanel1.Controls.Add(this.txtPass);
            this.roundedPanel1.Controls.Add(this.titlePass);
            this.roundedPanel1.Controls.Add(this.lblPassErr);
            this.roundedPanel1.Controls.Add(this.btnContinue);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(285, 95);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(440, 494);
            this.roundedPanel1.TabIndex = 21;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnForgotPass.BackColor = System.Drawing.Color.White;
            this.btnForgotPass.BackgroundColor = System.Drawing.Color.White;
            this.btnForgotPass.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnForgotPass.BorderRadius = 15;
            this.btnForgotPass.BorderSize = 0;
            this.btnForgotPass.FlatAppearance.BorderSize = 0;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgotPass.Location = new System.Drawing.Point(42, 299);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(362, 45);
            this.btnForgotPass.TabIndex = 22;
            this.btnForgotPass.Text = "Quên mật khẩu?";
            this.btnForgotPass.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
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
            this.loginTitle.Text = "Đổi mật khẩu";
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
            // titlePass
            // 
            this.titlePass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titlePass.AutoSize = true;
            this.titlePass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.titlePass.Location = new System.Drawing.Point(53, 138);
            this.titlePass.Name = "titlePass";
            this.titlePass.Size = new System.Drawing.Size(179, 30);
            this.titlePass.TabIndex = 1;
            this.titlePass.Text = "Mật khẩu hiện tại";
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
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnContinue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.BorderRadius = 15;
            this.btnContinue.BorderSize = 1;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.Location = new System.Drawing.Point(42, 374);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(362, 45);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(359, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hiện";
            // 
            // togglePassChar
            // 
            this.togglePassChar.AutoSize = true;
            this.togglePassChar.Location = new System.Drawing.Point(313, 143);
            this.togglePassChar.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglePassChar.Name = "togglePassChar";
            this.togglePassChar.OffBackColor = System.Drawing.Color.Gray;
            this.togglePassChar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togglePassChar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togglePassChar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togglePassChar.Size = new System.Drawing.Size(45, 22);
            this.togglePassChar.TabIndex = 48;
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
        private System.Windows.Forms.Label titlePass;
        private System.Windows.Forms.Label lblPassErr;
        private CustomComponents.RoundedButton btnContinue;
        private CustomComponents.RoundedButton btnForgotPass;
        private System.Windows.Forms.Label label2;
        private CustomComponents.ToggleButton togglePassChar;
    }
}
