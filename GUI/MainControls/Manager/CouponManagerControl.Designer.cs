namespace _3S_eShop.GUI.MainControls.Manager
{
    partial class CouponManagerControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponManagerControl));
            this.dataCoupons = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRUDMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteUnusable = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnViewUseable = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnViewAll = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnViewExpired = new _3S_eShop.CustomComponents.RoundedButton();
            this.roundedButton2 = new _3S_eShop.CustomComponents.RoundedButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripReload = new System.Windows.Forms.ToolStripButton();
            this.addmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoupons)).BeginInit();
            this.panel1.SuspendLayout();
            this.CRUDMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCoupons
            // 
            this.dataCoupons.AllowUserToAddRows = false;
            this.dataCoupons.AllowUserToDeleteRows = false;
            this.dataCoupons.AllowUserToOrderColumns = true;
            this.dataCoupons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCoupons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCoupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCoupons.Location = new System.Drawing.Point(15, 30);
            this.dataCoupons.Name = "dataCoupons";
            this.dataCoupons.RowHeadersWidth = 45;
            this.dataCoupons.Size = new System.Drawing.Size(970, 518);
            this.dataCoupons.TabIndex = 0;
            this.dataCoupons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataCoupons_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnViewUseable);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.btnViewExpired);
            this.panel1.Controls.Add(this.roundedButton2);
            this.panel1.Location = new System.Drawing.Point(15, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 57);
            this.panel1.TabIndex = 6;
            // 
            // CRUDMenu
            // 
            this.CRUDMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CRUDMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addmToolStripMenuItem,
            this.updatemToolStripMenuItem,
            this.deletemToolStripMenuItem});
            this.CRUDMenu.Name = "CRUDMenu";
            this.CRUDMenu.Size = new System.Drawing.Size(113, 82);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDeleteUnusable
            // 
            this.btnDeleteUnusable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUnusable.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUnusable.BackgroundColor = System.Drawing.Color.Red;
            this.btnDeleteUnusable.BorderColor = System.Drawing.Color.White;
            this.btnDeleteUnusable.BorderRadius = 15;
            this.btnDeleteUnusable.BorderSize = 0;
            this.btnDeleteUnusable.FlatAppearance.BorderSize = 0;
            this.btnDeleteUnusable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnusable.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUnusable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUnusable.Location = new System.Drawing.Point(636, 563);
            this.btnDeleteUnusable.Name = "btnDeleteUnusable";
            this.btnDeleteUnusable.Size = new System.Drawing.Size(349, 51);
            this.btnDeleteUnusable.TabIndex = 6;
            this.btnDeleteUnusable.Text = "Xóa coupon không còn dùng được";
            this.btnDeleteUnusable.TextColor = System.Drawing.Color.White;
            this.btnDeleteUnusable.UseVisualStyleBackColor = false;
            this.btnDeleteUnusable.Click += new System.EventHandler(this.btnDeleteUnusable_Click);
            // 
            // btnViewUseable
            // 
            this.btnViewUseable.BackColor = System.Drawing.Color.White;
            this.btnViewUseable.BackgroundColor = System.Drawing.Color.White;
            this.btnViewUseable.BorderColor = System.Drawing.Color.White;
            this.btnViewUseable.BorderRadius = 15;
            this.btnViewUseable.BorderSize = 0;
            this.btnViewUseable.FlatAppearance.BorderSize = 0;
            this.btnViewUseable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUseable.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnViewUseable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewUseable.Location = new System.Drawing.Point(449, 12);
            this.btnViewUseable.Name = "btnViewUseable";
            this.btnViewUseable.Size = new System.Drawing.Size(122, 35);
            this.btnViewUseable.TabIndex = 5;
            this.btnViewUseable.Text = "Còn hạn";
            this.btnViewUseable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewUseable.UseVisualStyleBackColor = false;
            this.btnViewUseable.Click += new System.EventHandler(this.btnViewUseable_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.White;
            this.btnViewAll.BackgroundColor = System.Drawing.Color.White;
            this.btnViewAll.BorderColor = System.Drawing.Color.White;
            this.btnViewAll.BorderRadius = 15;
            this.btnViewAll.BorderSize = 0;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.ForeColor = System.Drawing.Color.Red;
            this.btnViewAll.Location = new System.Drawing.Point(175, 12);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(122, 35);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "Tất cả";
            this.btnViewAll.TextColor = System.Drawing.Color.Red;
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewExpired
            // 
            this.btnViewExpired.BackColor = System.Drawing.Color.White;
            this.btnViewExpired.BackgroundColor = System.Drawing.Color.White;
            this.btnViewExpired.BorderColor = System.Drawing.Color.White;
            this.btnViewExpired.BorderRadius = 15;
            this.btnViewExpired.BorderSize = 0;
            this.btnViewExpired.FlatAppearance.BorderSize = 0;
            this.btnViewExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExpired.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnViewExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewExpired.Location = new System.Drawing.Point(312, 12);
            this.btnViewExpired.Name = "btnViewExpired";
            this.btnViewExpired.Size = new System.Drawing.Size(122, 35);
            this.btnViewExpired.TabIndex = 4;
            this.btnViewExpired.Text = "Hết hạn";
            this.btnViewExpired.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnViewExpired.UseVisualStyleBackColor = false;
            this.btnViewExpired.Click += new System.EventHandler(this.btnViewExpired_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedButton2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedButton2.BorderRadius = 15;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(3, 3);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.roundedButton2.Size = new System.Drawing.Size(584, 51);
            this.roundedButton2.TabIndex = 3;
            this.roundedButton2.Text = "Chế độ xem";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.updateToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = global::_3S_eShop.Properties.Resources.add_black_32;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.addToolStripMenuItem1.Text = "Thêm";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.deleteToolStripMenuItem1.Text = "Xóa";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.updateToolStripMenuItem1.Text = "Sửa";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripReload
            // 
            this.toolStripReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReload.Image = global::_3S_eShop.Properties.Resources.reload_black_32;
            this.toolStripReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReload.Name = "toolStripReload";
            this.toolStripReload.Size = new System.Drawing.Size(25, 24);
            this.toolStripReload.Text = "toolStripButton1";
            this.toolStripReload.Click += new System.EventHandler(this.toolStripReload_Click);
            // 
            // addmToolStripMenuItem
            // 
            this.addmToolStripMenuItem.Image = global::_3S_eShop.Properties.Resources.add_black_32;
            this.addmToolStripMenuItem.Name = "addmToolStripMenuItem";
            this.addmToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.addmToolStripMenuItem.Text = "Thêm";
            this.addmToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updatemToolStripMenuItem
            // 
            this.updatemToolStripMenuItem.Image = global::_3S_eShop.Properties.Resources.compose_black_24;
            this.updatemToolStripMenuItem.Name = "updatemToolStripMenuItem";
            this.updatemToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.updatemToolStripMenuItem.Text = "Sửa";
            this.updatemToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deletemToolStripMenuItem
            // 
            this.deletemToolStripMenuItem.Image = global::_3S_eShop.Properties.Resources.delete_red_32;
            this.deletemToolStripMenuItem.Name = "deletemToolStripMenuItem";
            this.deletemToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.deletemToolStripMenuItem.Text = "Xóa";
            this.deletemToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CouponManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDeleteUnusable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataCoupons);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CouponManagerControl";
            this.Size = new System.Drawing.Size(1000, 629);
            this.Load += new System.EventHandler(this.CouponManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCoupons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.CRUDMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCoupons;
        private CustomComponents.RoundedButton btnViewAll;
        private CustomComponents.RoundedButton roundedButton2;
        private CustomComponents.RoundedButton btnViewExpired;
        private CustomComponents.RoundedButton btnViewUseable;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.RoundedButton btnDeleteUnusable;
        private System.Windows.Forms.ContextMenuStrip CRUDMenu;
        private System.Windows.Forms.ToolStripMenuItem addmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatemToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripReload;
    }
}
