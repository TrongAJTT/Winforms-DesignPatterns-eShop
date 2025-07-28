namespace _3S_eShop.GUI.ComponentForm
{
    partial class EditUserProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOTP = new System.Windows.Forms.Label();
            this.lblUsernameMsg = new System.Windows.Forms.Label();
            this.lblEmailMsg = new System.Windows.Forms.Label();
            this.lblOTPMsg = new System.Windows.Forms.Label();
            this.btnSend = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnSave = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtOTP = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtEmail = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtUsername = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập mã OTP";
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.Location = new System.Drawing.Point(77, 343);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(44, 16);
            this.lblOTP.TabIndex = 7;
            this.lblOTP.Text = "label4";
            this.lblOTP.Visible = false;
            // 
            // lblUsernameMsg
            // 
            this.lblUsernameMsg.AutoSize = true;
            this.lblUsernameMsg.Location = new System.Drawing.Point(80, 92);
            this.lblUsernameMsg.Name = "lblUsernameMsg";
            this.lblUsernameMsg.Size = new System.Drawing.Size(0, 16);
            this.lblUsernameMsg.TabIndex = 11;
            // 
            // lblEmailMsg
            // 
            this.lblEmailMsg.AutoSize = true;
            this.lblEmailMsg.Location = new System.Drawing.Point(80, 183);
            this.lblEmailMsg.Name = "lblEmailMsg";
            this.lblEmailMsg.Size = new System.Drawing.Size(0, 16);
            this.lblEmailMsg.TabIndex = 12;
            // 
            // lblOTPMsg
            // 
            this.lblOTPMsg.AutoSize = true;
            this.lblOTPMsg.Location = new System.Drawing.Point(77, 290);
            this.lblOTPMsg.Name = "lblOTPMsg";
            this.lblOTPMsg.Size = new System.Drawing.Size(0, 16);
            this.lblOTPMsg.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.BorderRadius = 30;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(231, 251);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 42);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Gửi";
            this.btnSend.TextColor = System.Drawing.Color.White;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.btnSave.Location = new System.Drawing.Point(74, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtOTP.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtOTP.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtOTP.BorderRadius = 0;
            this.txtOTP.BorderSize = 2;
            this.txtOTP.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOTP.InputCharacterValidator = null;
            this.txtOTP.Location = new System.Drawing.Point(77, 251);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOTP.PasswordChar = false;
            this.txtOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOTP.PlaceholderText = "";
            this.txtOTP.Size = new System.Drawing.Size(147, 35);
            this.txtOTP.TabIndex = 4;
            this.txtOTP.Texts = "";
            this.txtOTP.UnderlinedStyle = false;
            this.txtOTP.Valid = null;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.InputCharacterValidator = null;
            this.txtEmail.Location = new System.Drawing.Point(80, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 35);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Valid = null;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.InputCharacterValidator = null;
            this.txtUsername.Location = new System.Drawing.Point(80, 53);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(250, 35);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.Valid = null;
            // 
            // EditUserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 473);
            this.Controls.Add(this.lblOTPMsg);
            this.Controls.Add(this.lblEmailMsg);
            this.Controls.Add(this.lblUsernameMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "EditUserProfileForm";
            this.Text = "EditUserProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomComponents.AdvancedTextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private CustomComponents.AdvancedTextBox txtEmail;
        private CustomComponents.AdvancedTextBox txtOTP;
        private System.Windows.Forms.Label label3;
        private CustomComponents.RoundedButton btnSave;
        private System.Windows.Forms.Label lblOTP;
        private CustomComponents.RoundedButton btnSend;
        private System.Windows.Forms.Label lblUsernameMsg;
        private System.Windows.Forms.Label lblEmailMsg;
        private System.Windows.Forms.Label lblOTPMsg;
    }
}