namespace _3S_eShop.GUI
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.loadingControl1 = new _3S_eShop.GUI.ComponentControls.LoadingControl();
            this.SuspendLayout();
            // 
            // loadingControl1
            // 
            this.loadingControl1.AutoSize = true;
            this.loadingControl1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingControl1.Location = new System.Drawing.Point(9, 9);
            this.loadingControl1.Margin = new System.Windows.Forms.Padding(0);
            this.loadingControl1.Message = "Đang tải dữ liệu, xin vui lòng chờ";
            this.loadingControl1.Name = "loadingControl1";
            this.loadingControl1.Size = new System.Drawing.Size(346, 40);
            this.loadingControl1.TabIndex = 0;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 59);
            this.ControlBox = false;
            this.Controls.Add(this.loadingControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3S eShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentControls.LoadingControl loadingControl1;
    }
}