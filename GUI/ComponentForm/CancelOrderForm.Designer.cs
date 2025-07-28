namespace _3S_eShop.GUI.ComponentForm
{
    partial class CancelOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrderForm));
            this.btnCancel = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtReason = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(484, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(239, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cấm người dùng này";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.txtReason.Location = new System.Drawing.Point(39, 99);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReason.PasswordChar = false;
            this.txtReason.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReason.PlaceholderText = "Lý do hủy";
            this.txtReason.Size = new System.Drawing.Size(684, 326);
            this.txtReason.TabIndex = 6;
            this.txtReason.Texts = "";
            this.txtReason.UnderlinedStyle = false;
            this.txtReason.Valid = null;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 47);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "HỦY ĐƠN HÀNG X";
            // 
            // CancelOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CancelOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hủy đơn hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.RoundedButton btnCancel;
        private CustomComponents.AdvancedTextBox txtReason;
        private System.Windows.Forms.Label lblTitle;
    }
}