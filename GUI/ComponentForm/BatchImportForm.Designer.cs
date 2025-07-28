namespace _3S_eShop.GUI.ComponentForm
{
    partial class BatchImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchImportForm));
            this.btnDone = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtContent = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnDone.BorderRadius = 15;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(752, 565);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(219, 34);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Hoàn tất (Ctrl+Enter)";
            this.btnDone.TextColor = System.Drawing.Color.White;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.Window;
            this.txtContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtContent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtContent.BorderRadius = 0;
            this.txtContent.BorderSize = 2;
            this.txtContent.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContent.InputCharacterValidator = null;
            this.txtContent.Location = new System.Drawing.Point(13, 13);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContent.PasswordChar = false;
            this.txtContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContent.PlaceholderText = "";
            this.txtContent.Size = new System.Drawing.Size(958, 543);
            this.txtContent.TabIndex = 0;
            this.txtContent.Texts = "";
            this.txtContent.UnderlinedStyle = false;
            this.txtContent.Valid = null;
            // 
            // BatchImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 609);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtContent);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BatchImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập dữ liệu hàng loạt";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BatchImportForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtContent;
        private CustomComponents.RoundedButton btnDone;
    }
}