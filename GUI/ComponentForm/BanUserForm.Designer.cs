namespace _3S_eShop.GUI.ComponentForm
{
    partial class BanUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanUserForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtReason = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnBan = new _3S_eShop.CustomComponents.RoundedButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẤM NGƯỜI DÙNG X";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
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
            this.txtReason.Location = new System.Drawing.Point(32, 121);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReason.PasswordChar = false;
            this.txtReason.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReason.PlaceholderText = "Lý do cấm";
            this.txtReason.Size = new System.Drawing.Size(684, 298);
            this.txtReason.TabIndex = 2;
            this.txtReason.Texts = "";
            this.txtReason.UnderlinedStyle = false;
            this.txtReason.Valid = null;
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.Red;
            this.btnBan.BackgroundColor = System.Drawing.Color.Red;
            this.btnBan.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBan.BorderRadius = 15;
            this.btnBan.BorderSize = 0;
            this.btnBan.FlatAppearance.BorderSize = 0;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.Location = new System.Drawing.Point(477, 443);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(239, 45);
            this.btnBan.TabIndex = 3;
            this.btnBan.Text = "Cấm người dùng này";
            this.btnBan.TextColor = System.Drawing.Color.White;
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // BanUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BanUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private CustomComponents.AdvancedTextBox txtReason;
        private CustomComponents.RoundedButton btnBan;
    }
}