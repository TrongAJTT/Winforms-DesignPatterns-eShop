namespace _3S_eShop.GUI.Test
{
    partial class SetUpConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRedis = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnDb = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnSecret = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnContinue = new _3S_eShop.CustomComponents.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 100);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ghi chú:\r\n- Hiện màu xanh là ok.\r\n- Hiện màu đỏ là bị lỗi.\r\n- Không tương tác đượ" +
    "c là chức năng chưa có.";
            // 
            // btnRedis
            // 
            this.btnRedis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRedis.BackColor = System.Drawing.Color.Red;
            this.btnRedis.BackgroundColor = System.Drawing.Color.Red;
            this.btnRedis.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnRedis.BorderRadius = 30;
            this.btnRedis.BorderSize = 0;
            this.btnRedis.FlatAppearance.BorderSize = 0;
            this.btnRedis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedis.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedis.ForeColor = System.Drawing.Color.White;
            this.btnRedis.Image = ((System.Drawing.Image)(resources.GetObject("btnRedis.Image")));
            this.btnRedis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedis.Location = new System.Drawing.Point(12, 83);
            this.btnRedis.Name = "btnRedis";
            this.btnRedis.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRedis.Size = new System.Drawing.Size(232, 54);
            this.btnRedis.TabIndex = 4;
            this.btnRedis.Text = "       Redis";
            this.btnRedis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedis.TextColor = System.Drawing.Color.White;
            this.btnRedis.UseVisualStyleBackColor = false;
            this.btnRedis.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnDb
            // 
            this.btnDb.BackColor = System.Drawing.Color.Lime;
            this.btnDb.BackgroundColor = System.Drawing.Color.Lime;
            this.btnDb.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnDb.BorderRadius = 30;
            this.btnDb.BorderSize = 0;
            this.btnDb.FlatAppearance.BorderSize = 0;
            this.btnDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDb.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDb.ForeColor = System.Drawing.Color.White;
            this.btnDb.Image = ((System.Drawing.Image)(resources.GetObject("btnDb.Image")));
            this.btnDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDb.Location = new System.Drawing.Point(12, 17);
            this.btnDb.Name = "btnDb";
            this.btnDb.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDb.Size = new System.Drawing.Size(232, 54);
            this.btnDb.TabIndex = 2;
            this.btnDb.Text = "       Database";
            this.btnDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDb.TextColor = System.Drawing.Color.White;
            this.btnDb.UseVisualStyleBackColor = false;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnSecret
            // 
            this.btnSecret.AllowDrop = true;
            this.btnSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSecret.BackColor = System.Drawing.Color.Red;
            this.btnSecret.BackgroundColor = System.Drawing.Color.Red;
            this.btnSecret.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnSecret.BorderRadius = 30;
            this.btnSecret.BorderSize = 0;
            this.btnSecret.FlatAppearance.BorderSize = 0;
            this.btnSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecret.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecret.ForeColor = System.Drawing.Color.White;
            this.btnSecret.Image = ((System.Drawing.Image)(resources.GetObject("btnSecret.Image")));
            this.btnSecret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecret.Location = new System.Drawing.Point(12, 146);
            this.btnSecret.Name = "btnSecret";
            this.btnSecret.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSecret.Size = new System.Drawing.Size(232, 54);
            this.btnSecret.TabIndex = 8;
            this.btnSecret.Text = "       Secret";
            this.btnSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecret.TextColor = System.Drawing.Color.White;
            this.btnSecret.UseVisualStyleBackColor = false;
            this.btnSecret.Click += new System.EventHandler(this.btnSecret_Click);
            this.btnSecret.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnSecret_DragDrop);
            this.btnSecret.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnSecret_DragEnter);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnContinue.BackColor = System.Drawing.Color.Yellow;
            this.btnContinue.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnContinue.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnContinue.BorderRadius = 30;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinue.Location = new System.Drawing.Point(616, 174);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(86, 37);
            this.btnContinue.TabIndex = 10;
            this.btnContinue.Text = "Done";
            this.btnContinue.TextColor = System.Drawing.Color.Black;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // SetUpConfig
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(723, 216);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRedis);
            this.Controls.Add(this.btnDb);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(739, 200);
            this.Name = "SetUpConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomComponents.RoundedButton btnDb;
        private CustomComponents.RoundedButton btnRedis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomComponents.RoundedButton btnSecret;
        private CustomComponents.RoundedButton btnContinue;
    }
}