namespace _3S_eShop.GUI.Test
{
    partial class TestDrive
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
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtFileId = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.imgPicker = new _3S_eShop.GUI.ComponentControls.ImagePanelPicker();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // picDownload
            // 
            this.picDownload.Location = new System.Drawing.Point(568, 99);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(327, 209);
            this.picDownload.TabIndex = 1;
            this.picDownload.TabStop = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(630, 336);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(197, 60);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFileId
            // 
            this.txtFileId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileId.Location = new System.Drawing.Point(613, 416);
            this.txtFileId.Name = "txtFileId";
            this.txtFileId.Size = new System.Drawing.Size(244, 31);
            this.txtFileId.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(115, 432);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(197, 60);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload Drive";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // imgPicker
            // 
            this.imgPicker.DefaultPictureSize = new System.Drawing.Size(50, 50);
            this.imgPicker.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPicker.Location = new System.Drawing.Point(50, 87);
            this.imgPicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.SelectecPicture = null;
            this.imgPicker.Size = new System.Drawing.Size(419, 230);
            this.imgPicker.TabIndex = 7;
            // 
            // TestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 635);
            this.Controls.Add(this.imgPicker);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFileId);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.picDownload);
            this.Name = "TestDrive";
            this.Text = "TestUpload";
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtFileId;
        private System.Windows.Forms.Button btnUpload;
        private ComponentControls.ImagePanelPicker imgPicker;
    }
}