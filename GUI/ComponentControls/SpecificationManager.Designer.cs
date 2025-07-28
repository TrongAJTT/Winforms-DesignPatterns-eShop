namespace _3S_eShop.GUI.ComponentControls
{
    partial class SpecificationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecificationManager));
            this.lblError = new System.Windows.Forms.Label();
            this.pnlContainer = new _3S_eShop.CustomControls.RoundedPanel();
            this.listViewTags = new System.Windows.Forms.ListView();
            this.key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveSpecific = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveP5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveP4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveP2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveN2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveN3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveN4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveN5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveLast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new _3S_eShop.CustomComponents.RoundedButton();
            this.txtValue = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.txtKey = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.pnlContainer.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(3, 51);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 20);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Lỗi";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlContainer.BorderRadius = 15;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.Controls.Add(this.listViewTags);
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 74);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(614, 218);
            this.pnlContainer.TabIndex = 5;
            this.pnlContainer.TextColor = System.Drawing.Color.White;
            // 
            // listViewTags
            // 
            this.listViewTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.key,
            this.value});
            this.listViewTags.ContextMenuStrip = this.contextMenu;
            this.listViewTags.FullRowSelect = true;
            this.listViewTags.HideSelection = false;
            this.listViewTags.Location = new System.Drawing.Point(0, 0);
            this.listViewTags.Name = "listViewTags";
            this.listViewTags.Size = new System.Drawing.Size(614, 215);
            this.listViewTags.TabIndex = 0;
            this.listViewTags.UseCompatibleStateImageBehavior = false;
            this.listViewTags.View = System.Windows.Forms.View.Details;
            this.listViewTags.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewTags_ItemSelectionChanged);
            // 
            // key
            // 
            this.key.Text = "Tên thông số";
            this.key.Width = 300;
            // 
            // value
            // 
            this.value.Text = "Giá trị";
            this.value.Width = 1200;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPosition,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiDeleteAll});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(192, 100);
            // 
            // tsmiPosition
            // 
            this.tsmiPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveFirst,
            this.tsmiMoveUp,
            this.tsmiMoveSpecific,
            this.tsmiMoveDown,
            this.tsmiMoveLast});
            this.tsmiPosition.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPosition.Image")));
            this.tsmiPosition.Name = "tsmiPosition";
            this.tsmiPosition.Size = new System.Drawing.Size(191, 24);
            this.tsmiPosition.Text = "Vị trí";
            // 
            // tsmiMoveFirst
            // 
            this.tsmiMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveFirst.Image")));
            this.tsmiMoveFirst.Name = "tsmiMoveFirst";
            this.tsmiMoveFirst.Size = new System.Drawing.Size(233, 24);
            this.tsmiMoveFirst.Text = "Dời lên trên cùng";
            this.tsmiMoveFirst.Click += new System.EventHandler(this.tsmiMoveFirst_Click);
            // 
            // tsmiMoveUp
            // 
            this.tsmiMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveUp.Image")));
            this.tsmiMoveUp.Name = "tsmiMoveUp";
            this.tsmiMoveUp.Size = new System.Drawing.Size(233, 24);
            this.tsmiMoveUp.Text = "Dời lên trên";
            this.tsmiMoveUp.Click += new System.EventHandler(this.tsmiMoveUp_Click);
            // 
            // tsmiMoveSpecific
            // 
            this.tsmiMoveSpecific.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveP5,
            this.tsmiMoveP4,
            this.tsmiMoveP3,
            this.tsmiMoveP2,
            this.tsmiMoveN2,
            this.tsmiMoveN3,
            this.tsmiMoveN4,
            this.tsmiMoveN5});
            this.tsmiMoveSpecific.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveSpecific.Image")));
            this.tsmiMoveSpecific.Name = "tsmiMoveSpecific";
            this.tsmiMoveSpecific.Size = new System.Drawing.Size(233, 24);
            this.tsmiMoveSpecific.Text = "Dời đi lượng vị trí chỉ định";
            // 
            // tsmiMoveP5
            // 
            this.tsmiMoveP5.Name = "tsmiMoveP5";
            this.tsmiMoveP5.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveP5.Text = "+5";
            this.tsmiMoveP5.Click += new System.EventHandler(this.tsmiMoveP5_Click);
            // 
            // tsmiMoveP4
            // 
            this.tsmiMoveP4.Name = "tsmiMoveP4";
            this.tsmiMoveP4.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveP4.Text = "+4";
            this.tsmiMoveP4.Click += new System.EventHandler(this.tsmiMoveP4_Click);
            // 
            // tsmiMoveP3
            // 
            this.tsmiMoveP3.Name = "tsmiMoveP3";
            this.tsmiMoveP3.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveP3.Text = "+3";
            this.tsmiMoveP3.Click += new System.EventHandler(this.tsmiMoveP3_Click);
            // 
            // tsmiMoveP2
            // 
            this.tsmiMoveP2.Name = "tsmiMoveP2";
            this.tsmiMoveP2.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveP2.Text = "+2";
            this.tsmiMoveP2.Click += new System.EventHandler(this.tsmiMoveP2_Click);
            // 
            // tsmiMoveN2
            // 
            this.tsmiMoveN2.Name = "tsmiMoveN2";
            this.tsmiMoveN2.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveN2.Text = "-2";
            this.tsmiMoveN2.Click += new System.EventHandler(this.tsmiMoveN2_Click);
            // 
            // tsmiMoveN3
            // 
            this.tsmiMoveN3.Name = "tsmiMoveN3";
            this.tsmiMoveN3.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveN3.Text = "-3";
            this.tsmiMoveN3.Click += new System.EventHandler(this.tsmiMoveN3_Click);
            // 
            // tsmiMoveN4
            // 
            this.tsmiMoveN4.Name = "tsmiMoveN4";
            this.tsmiMoveN4.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveN4.Text = "-4";
            this.tsmiMoveN4.Click += new System.EventHandler(this.tsmiMoveN4_Click);
            // 
            // tsmiMoveN5
            // 
            this.tsmiMoveN5.Name = "tsmiMoveN5";
            this.tsmiMoveN5.Size = new System.Drawing.Size(98, 24);
            this.tsmiMoveN5.Text = "-5";
            this.tsmiMoveN5.Click += new System.EventHandler(this.tsmiMoveN5_Click);
            // 
            // tsmiMoveDown
            // 
            this.tsmiMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveDown.Image")));
            this.tsmiMoveDown.Name = "tsmiMoveDown";
            this.tsmiMoveDown.Size = new System.Drawing.Size(233, 24);
            this.tsmiMoveDown.Text = "Dời xuống dưới";
            this.tsmiMoveDown.Click += new System.EventHandler(this.tsmiMoveDown_Click);
            // 
            // tsmiMoveLast
            // 
            this.tsmiMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveLast.Image")));
            this.tsmiMoveLast.Name = "tsmiMoveLast";
            this.tsmiMoveLast.Size = new System.Drawing.Size(233, 24);
            this.tsmiMoveLast.Text = "Dời xuống dưới cùng";
            this.tsmiMoveLast.Click += new System.EventHandler(this.tsmiMoveLast_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(191, 24);
            this.tsmiEdit.Text = "Chỉnh sửa thông số";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(191, 24);
            this.tsmiDelete.Text = "Xóa thông số";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiDeleteAll
            // 
            this.tsmiDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteAll.Image")));
            this.tsmiDeleteAll.Name = "tsmiDeleteAll";
            this.tsmiDeleteAll.Size = new System.Drawing.Size(191, 24);
            this.tsmiDeleteAll.Text = "Xóa tất cả";
            this.tsmiDeleteAll.Click += new System.EventHandler(this.tsmiDeleteAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(566, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtValue.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtValue.BorderRadius = 15;
            this.txtValue.BorderSize = 2;
            this.txtValue.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValue.InputCharacterValidator = null;
            this.txtValue.Location = new System.Drawing.Point(264, 3);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            this.txtValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtValue.PasswordChar = false;
            this.txtValue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValue.PlaceholderText = "Giá trị";
            this.txtValue.Size = new System.Drawing.Size(299, 45);
            this.txtValue.TabIndex = 2;
            this.txtValue.Texts = "";
            this.txtValue.UnderlinedStyle = false;
            this.txtValue.Valid = null;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtKey.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtKey.BorderRadius = 15;
            this.txtKey.BorderSize = 2;
            this.txtKey.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKey.InputCharacterValidator = null;
            this.txtKey.Location = new System.Drawing.Point(3, 3);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtKey.Multiline = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtKey.PasswordChar = false;
            this.txtKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKey.PlaceholderText = "Thông số";
            this.txtKey.Size = new System.Drawing.Size(258, 45);
            this.txtKey.TabIndex = 1;
            this.txtKey.Texts = "";
            this.txtKey.UnderlinedStyle = false;
            this.txtKey.Valid = null;
            // 
            // SpecificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "SpecificationManager";
            this.Size = new System.Drawing.Size(614, 292);
            this.pnlContainer.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.AdvancedTextBox txtKey;
        private CustomComponents.AdvancedTextBox txtValue;
        private CustomComponents.RoundedButton btnAdd;
        private System.Windows.Forms.Label lblError;
        private CustomControls.RoundedPanel pnlContainer;
        private System.Windows.Forms.ListView listViewTags;
        private System.Windows.Forms.ColumnHeader key;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiPosition;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveFirst;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveLast;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveSpecific;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveP5;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveP4;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveP3;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveP2;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveN2;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveN3;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveN4;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveN5;
    }
}
