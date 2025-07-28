namespace _3S_eShop.GUI.ComponentForm
{
    partial class EulaPublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EulaPublisherForm));
            this.titleLastUpdated = new System.Windows.Forms.Label();
            this.dateEula = new System.Windows.Forms.Label();
            this.contentEula = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new _3S_eShop.CustomComponents.RoundedButton();
            this.loadingControl = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.SuspendLayout();
            // 
            // titleLastUpdated
            // 
            this.titleLastUpdated.AutoSize = true;
            this.titleLastUpdated.Location = new System.Drawing.Point(12, 624);
            this.titleLastUpdated.Name = "titleLastUpdated";
            this.titleLastUpdated.Size = new System.Drawing.Size(165, 25);
            this.titleLastUpdated.TabIndex = 0;
            this.titleLastUpdated.Text = "Lần cập nhật cuối:";
            this.titleLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateEula
            // 
            this.dateEula.AutoSize = true;
            this.dateEula.Location = new System.Drawing.Point(183, 624);
            this.dateEula.Name = "dateEula";
            this.dateEula.Size = new System.Drawing.Size(95, 25);
            this.dateEula.TabIndex = 1;
            this.dateEula.Text = "Đang tải...";
            this.dateEula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentEula
            // 
            this.contentEula.Location = new System.Drawing.Point(17, 20);
            this.contentEula.Name = "contentEula";
            this.contentEula.Size = new System.Drawing.Size(1224, 575);
            this.contentEula.TabIndex = 2;
            this.contentEula.Text = "Đang tải...";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1056, 615);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpdate.Size = new System.Drawing.Size(185, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "    Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // loadingControl
            // 
            this.loadingControl.AutoSize = true;
            this.loadingControl.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingControl.Location = new System.Drawing.Point(473, 615);
            this.loadingControl.Margin = new System.Windows.Forms.Padding(0);
            this.loadingControl.Message = "Đang tải";
            this.loadingControl.Name = "loadingControl";
            this.loadingControl.Size = new System.Drawing.Size(134, 40);
            this.loadingControl.TabIndex = 11;
            this.loadingControl.Visible = false;
            // 
            // EulaPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.loadingControl);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.contentEula);
            this.Controls.Add(this.dateEula);
            this.Controls.Add(this.titleLastUpdated);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "EulaPublisherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều chỉnh Điều khoản dịch vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLastUpdated;
        private System.Windows.Forms.Label dateEula;
        private System.Windows.Forms.RichTextBox contentEula;
        private CustomComponents.RoundedButton btnUpdate;
        private ComponentControls.LoadingControl loadingControl;
    }
}