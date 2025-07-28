namespace _3S_eShop.GUI.ComponentForm
{
    partial class TaskProgressWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskProgressWatcher));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tabProgress = new System.Windows.Forms.TabPage();
            this.listViewProgress = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHide = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnExit = new _3S_eShop.CustomComponents.RoundedButton();
            this.chkAutoExit = new _3S_eShop.CustomComponents.ToggleButton();
            this.btnToggleShow = new _3S_eShop.CustomComponents.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabProgress.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLog);
            this.tabControl.Controls.Add(this.tabProgress);
            this.tabControl.Location = new System.Drawing.Point(14, 103);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(745, 278);
            this.tabControl.TabIndex = 0;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 34);
            this.tabLog.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabLog.Size = new System.Drawing.Size(737, 240);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(5, 6);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(727, 228);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // tabProgress
            // 
            this.tabProgress.Controls.Add(this.listViewProgress);
            this.tabProgress.Location = new System.Drawing.Point(4, 34);
            this.tabProgress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabProgress.Name = "tabProgress";
            this.tabProgress.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabProgress.Size = new System.Drawing.Size(737, 240);
            this.tabProgress.TabIndex = 0;
            this.tabProgress.Text = "Tiến trình";
            this.tabProgress.UseVisualStyleBackColor = true;
            // 
            // listViewProgress
            // 
            this.listViewProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProgress.HideSelection = false;
            this.listViewProgress.Location = new System.Drawing.Point(5, 6);
            this.listViewProgress.Name = "listViewProgress";
            this.listViewProgress.Size = new System.Drawing.Size(727, 228);
            this.listViewProgress.TabIndex = 0;
            this.listViewProgress.UseCompatibleStateImageBehavior = false;
            this.listViewProgress.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 59);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(741, 23);
            this.progressBar.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 40);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên tiến trình";
            // 
            // lblPercent
            // 
            this.lblPercent.Location = new System.Drawing.Point(696, 31);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(59, 25);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tự động thoát khi hoàn thành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHide.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHide.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHide.BorderRadius = 30;
            this.btnHide.BorderSize = 0;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(488, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(108, 40);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Ẩn";
            this.btnHide.TextColor = System.Drawing.Color.White;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.BorderRadius = 30;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(602, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkAutoExit
            // 
            this.chkAutoExit.AutoSize = true;
            this.chkAutoExit.Location = new System.Drawing.Point(19, 22);
            this.chkAutoExit.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkAutoExit.Name = "chkAutoExit";
            this.chkAutoExit.OffBackColor = System.Drawing.Color.Gray;
            this.chkAutoExit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.chkAutoExit.OnBackColor = System.Drawing.Color.DeepSkyBlue;
            this.chkAutoExit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.chkAutoExit.Size = new System.Drawing.Size(45, 22);
            this.chkAutoExit.TabIndex = 4;
            this.chkAutoExit.UseVisualStyleBackColor = true;
            // 
            // btnToggleShow
            // 
            this.btnToggleShow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToggleShow.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToggleShow.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToggleShow.BorderRadius = 30;
            this.btnToggleShow.BorderSize = 0;
            this.btnToggleShow.FlatAppearance.BorderSize = 0;
            this.btnToggleShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleShow.ForeColor = System.Drawing.Color.White;
            this.btnToggleShow.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleShow.Image")));
            this.btnToggleShow.Location = new System.Drawing.Point(716, 12);
            this.btnToggleShow.Name = "btnToggleShow";
            this.btnToggleShow.Size = new System.Drawing.Size(40, 40);
            this.btnToggleShow.TabIndex = 8;
            this.btnToggleShow.TextColor = System.Drawing.Color.White;
            this.btnToggleShow.UseVisualStyleBackColor = false;
            this.btnToggleShow.Click += new System.EventHandler(this.btnToggleShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnToggleShow);
            this.panel1.Controls.Add(this.chkAutoExit);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 64);
            this.panel1.TabIndex = 9;
            // 
            // TaskProgressWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 441);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(789, 482);
            this.MinimumSize = new System.Drawing.Size(789, 188);
            this.Name = "TaskProgressWatcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ theo dõi tiến trình";
            this.tabControl.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabProgress.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProgress;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ListView listViewProgress;
        private System.Windows.Forms.RichTextBox txtLog;
        private CustomComponents.ToggleButton chkAutoExit;
        private CustomComponents.RoundedButton btnExit;
        private CustomComponents.RoundedButton btnHide;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedButton btnToggleShow;
        private System.Windows.Forms.Panel panel1;
    }
}