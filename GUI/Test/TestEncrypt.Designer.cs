namespace _3S_eShop
{
    partial class TestEncrypt
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
            this.txtUp = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtDown = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnEncode = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnDecode = new _3S_eShop.CustomComponents.RoundedButton();
            this.SuspendLayout();
            // 
            // txtUp
            // 
            this.txtUp.BackColor = System.Drawing.SystemColors.Window;
            this.txtUp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUp.BorderRadius = 0;
            this.txtUp.BorderSize = 2;
            this.txtUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUp.Location = new System.Drawing.Point(13, 13);
            this.txtUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtUp.Multiline = true;
            this.txtUp.Name = "txtUp";
            this.txtUp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUp.PasswordChar = false;
            this.txtUp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUp.PlaceholderText = "";
            this.txtUp.Size = new System.Drawing.Size(949, 306);
            this.txtUp.TabIndex = 0;
            this.txtUp.UnderlinedStyle = false;
            // 
            // txtDown
            // 
            this.txtDown.BackColor = System.Drawing.SystemColors.Window;
            this.txtDown.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDown.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDown.BorderRadius = 0;
            this.txtDown.BorderSize = 2;
            this.txtDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDown.Location = new System.Drawing.Point(13, 381);
            this.txtDown.Margin = new System.Windows.Forms.Padding(4);
            this.txtDown.Multiline = true;
            this.txtDown.Name = "txtDown";
            this.txtDown.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDown.PasswordChar = false;
            this.txtDown.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDown.PlaceholderText = "";
            this.txtDown.Size = new System.Drawing.Size(949, 306);
            this.txtDown.TabIndex = 1;
            this.txtDown.UnderlinedStyle = false;
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEncode.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEncode.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnEncode.BorderRadius = 30;
            this.btnEncode.BorderSize = 0;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.Location = new System.Drawing.Point(13, 326);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(449, 48);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.TextColor = System.Drawing.Color.White;
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDecode.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDecode.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnDecode.BorderRadius = 30;
            this.btnDecode.BorderSize = 0;
            this.btnDecode.FlatAppearance.BorderSize = 0;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(513, 326);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(449, 48);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.TextColor = System.Drawing.Color.White;
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 780);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.txtUp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TestForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtUp;
        private CustomComponents.AdvancedTextBox txtDown;
        private CustomComponents.RoundedButton btnEncode;
        private CustomComponents.RoundedButton btnDecode;
    }
}