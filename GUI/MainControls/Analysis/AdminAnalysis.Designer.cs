namespace _3S_eShop.GUI.MainControls.Analysis
{
    partial class AdminAnalysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTime = new _3S_eShop.CustomComponents.AdvancedCombobox();
            this.cboTarget = new _3S_eShop.CustomComponents.AdvancedCombobox();
            this.chartAnalysis = new LiveCharts.WinForms.CartesianChart();
            this.btnCreate = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnExport = new _3S_eShop.CustomComponents.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tiêu chí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn thời gian";
            // 
            // cboTime
            // 
            this.cboTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboTime.BorderSize = 1;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.ForeColor = System.Drawing.Color.DimGray;
            this.cboTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboTime.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTime.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTime.Location = new System.Drawing.Point(24, 135);
            this.cboTime.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTime.Name = "cboTime";
            this.cboTime.Padding = new System.Windows.Forms.Padding(1);
            this.cboTime.SelectedIndex = -1;
            this.cboTime.Size = new System.Drawing.Size(263, 38);
            this.cboTime.TabIndex = 1;
            this.cboTime.Texts = "";
            // 
            // cboTarget
            // 
            this.cboTarget.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTarget.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboTarget.BorderSize = 1;
            this.cboTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarget.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTarget.ForeColor = System.Drawing.Color.DimGray;
            this.cboTarget.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cboTarget.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTarget.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTarget.Location = new System.Drawing.Point(24, 61);
            this.cboTarget.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTarget.Name = "cboTarget";
            this.cboTarget.Padding = new System.Windows.Forms.Padding(1);
            this.cboTarget.SelectedIndex = -1;
            this.cboTarget.Size = new System.Drawing.Size(263, 38);
            this.cboTarget.TabIndex = 0;
            this.cboTarget.Texts = "";
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.Location = new System.Drawing.Point(23, 209);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Size = new System.Drawing.Size(947, 440);
            this.chartAnalysis.TabIndex = 4;
            this.chartAnalysis.Text = "cartesianChart1";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 15;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(318, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(188, 50);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Tạo báo cáo";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnExport.BorderColor = System.Drawing.Color.White;
            this.btnExport.BorderRadius = 15;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(318, 123);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(188, 50);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // AdminAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.chartAnalysis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.cboTarget);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminAnalysis";
            this.Size = new System.Drawing.Size(1000, 679);
            this.Load += new System.EventHandler(this.AdminAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.AdvancedCombobox cboTarget;
        private CustomComponents.AdvancedCombobox cboTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart chartAnalysis;
        private CustomComponents.RoundedButton btnCreate;
        private CustomComponents.RoundedButton btnExport;
    }
}
