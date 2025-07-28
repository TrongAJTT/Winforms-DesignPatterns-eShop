namespace _3S_eShop.GUI.ComponentControls
{
    partial class PaginationSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginationSelector));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFirst = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnPrev = new _3S_eShop.CustomComponents.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPageCurrent = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtPageMax = new _3S_eShop.CustomControls.RoundedLabel();
            this.btnNext = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnFinal = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtPageSize = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.backSize = new _3S_eShop.CustomControls.RoundedLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnFirst);
            this.flowLayoutPanel1.Controls.Add(this.btnPrev);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnFinal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(122, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 38);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFirst.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFirst.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFirst.BorderRadius = 0;
            this.btnFirst.BorderSize = 0;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(0, 0);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 38);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.TextColor = System.Drawing.Color.White;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrev.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrev.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrev.BorderRadius = 0;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(48, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(38, 38);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.TextColor = System.Drawing.Color.White;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPageCurrent);
            this.panel1.Controls.Add(this.txtPageMax);
            this.panel1.Location = new System.Drawing.Point(116, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 38);
            this.panel1.TabIndex = 14;
            // 
            // txtPageCurrent
            // 
            this.txtPageCurrent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPageCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.txtPageCurrent.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageCurrent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPageCurrent.BorderRadius = 0;
            this.txtPageCurrent.BorderSize = 0;
            this.txtPageCurrent.ContentAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageCurrent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPageCurrent.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageCurrent.InputCharacterValidator = null;
            this.txtPageCurrent.Location = new System.Drawing.Point(5, 3);
            this.txtPageCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageCurrent.Multiline = false;
            this.txtPageCurrent.Name = "txtPageCurrent";
            this.txtPageCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.txtPageCurrent.PasswordChar = false;
            this.txtPageCurrent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPageCurrent.PlaceholderText = "";
            this.txtPageCurrent.Size = new System.Drawing.Size(60, 35);
            this.txtPageCurrent.TabIndex = 13;
            this.txtPageCurrent.Texts = "1";
            this.txtPageCurrent.UnderlinedStyle = false;
            this.txtPageCurrent.Valid = null;
            // 
            // txtPageMax
            // 
            this.txtPageMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPageMax.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageMax.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageMax.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageMax.BorderRadius = 0;
            this.txtPageMax.BorderSize = 0;
            this.txtPageMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPageMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageMax.ForeColor = System.Drawing.Color.White;
            this.txtPageMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPageMax.Location = new System.Drawing.Point(0, 0);
            this.txtPageMax.Name = "txtPageMax";
            this.txtPageMax.Padding = new System.Windows.Forms.Padding(65, 0, 0, 3);
            this.txtPageMax.Size = new System.Drawing.Size(140, 38);
            this.txtPageMax.TabIndex = 12;
            this.txtPageMax.Text = "/ 10";
            this.txtPageMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPageMax.TextColor = System.Drawing.Color.White;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.BorderRadius = 0;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(286, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 38);
            this.btnNext.TabIndex = 15;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFinal.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFinal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFinal.BorderRadius = 0;
            this.btnFinal.BorderSize = 0;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Image = ((System.Drawing.Image)(resources.GetObject("btnFinal.Image")));
            this.btnFinal.Location = new System.Drawing.Point(334, 0);
            this.btnFinal.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(38, 38);
            this.btnFinal.TabIndex = 16;
            this.btnFinal.TextColor = System.Drawing.Color.White;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // txtPageSize
            // 
            this.txtPageSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPageSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPageSize.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageSize.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPageSize.BorderRadius = 0;
            this.txtPageSize.BorderSize = 0;
            this.txtPageSize.ContentAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageSize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPageSize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPageSize.InputCharacterValidator = null;
            this.txtPageSize.Location = new System.Drawing.Point(41, 3);
            this.txtPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageSize.Multiline = false;
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Padding = new System.Windows.Forms.Padding(3);
            this.txtPageSize.PasswordChar = false;
            this.txtPageSize.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPageSize.PlaceholderText = "";
            this.txtPageSize.Size = new System.Drawing.Size(51, 35);
            this.txtPageSize.TabIndex = 7;
            this.txtPageSize.Texts = "20";
            this.txtPageSize.UnderlinedStyle = false;
            this.txtPageSize.Valid = null;
            // 
            // backSize
            // 
            this.backSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backSize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backSize.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.backSize.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.backSize.BorderRadius = 0;
            this.backSize.BorderSize = 0;
            this.backSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSize.Font = new System.Drawing.Font("Segoe UI Semibold", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSize.ForeColor = System.Drawing.Color.White;
            this.backSize.Image = ((System.Drawing.Image)(resources.GetObject("backSize.Image")));
            this.backSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backSize.Location = new System.Drawing.Point(0, 0);
            this.backSize.Name = "backSize";
            this.backSize.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.backSize.Size = new System.Drawing.Size(96, 38);
            this.backSize.TabIndex = 6;
            this.backSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backSize.TextColor = System.Drawing.Color.White;
            // 
            // PaginationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.backSize);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PaginationSelector";
            this.Size = new System.Drawing.Size(494, 38);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtPageSize;
        private CustomControls.RoundedLabel backSize;
        private CustomComponents.RoundedButton btnFirst;
        private CustomComponents.RoundedButton btnPrev;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomComponents.RoundedButton btnNext;
        private CustomComponents.RoundedButton btnFinal;
        private CustomComponents.AdvancedTextBox txtPageCurrent;
        private CustomControls.RoundedLabel txtPageMax;
        private System.Windows.Forms.Panel panel1;
    }
}
