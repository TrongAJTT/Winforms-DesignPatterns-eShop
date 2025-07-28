namespace _3S_eShop.GUI.ComponentControls
{
    partial class ProductVariantsManagerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductVariantsManagerControl));
            this.lblErr = new System.Windows.Forms.Label();
            this.btnAdd = new _3S_eShop.CustomComponents.RoundedButton();
            this.variantEditors = new _3S_eShop.GUI.ComponentControls.ProductVariantControl();
            this.variantEditor = new _3S_eShop.GUI.ComponentControls.ProductVariantControl();
            this.listViewData = new System.Windows.Forms.ListView();
            this.variantName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variantPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variantStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variantDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.White;
            this.lblErr.Location = new System.Drawing.Point(19, 187);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(37, 25);
            this.lblErr.TabIndex = 4;
            this.lblErr.Text = "Lỗi";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(543, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm variant";
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // variantEditors
            // 
            this.variantEditors.BackColor = System.Drawing.Color.Transparent;
            this.variantEditors.ControlButton = true;
            this.variantEditors.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantEditors.Location = new System.Drawing.Point(0, 0);
            this.variantEditors.Name = "variantEditors";
            this.variantEditors.Size = new System.Drawing.Size(782, 187);
            this.variantEditors.TabIndex = 0;
            this.variantEditors.ViewOnly = false;
            // 
            // variantEditor
            // 
            this.variantEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variantEditor.BackColor = System.Drawing.Color.Transparent;
            this.variantEditor.ControlButton = false;
            this.variantEditor.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantEditor.Location = new System.Drawing.Point(0, 0);
            this.variantEditor.Name = "variantEditor";
            this.variantEditor.Size = new System.Drawing.Size(733, 184);
            this.variantEditor.TabIndex = 7;
            this.variantEditor.ViewOnly = false;
            // 
            // listViewData
            // 
            this.listViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.variantName,
            this.variantPrice,
            this.variantStock,
            this.variantDescription});
            this.listViewData.ContextMenuStrip = this.contextMenu;
            this.listViewData.FullRowSelect = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(14, 239);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(698, 203);
            this.listViewData.TabIndex = 8;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listViewData_SelectedIndexChanged);
            // 
            // variantName
            // 
            this.variantName.Text = "Nhãn";
            this.variantName.Width = 200;
            // 
            // variantPrice
            // 
            this.variantPrice.Text = "Giá";
            this.variantPrice.Width = 150;
            // 
            // variantStock
            // 
            this.variantStock.Text = "Số lượng";
            this.variantStock.Width = 100;
            // 
            // variantDescription
            // 
            this.variantDescription.Text = "Mô tả";
            this.variantDescription.Width = 700;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(187, 52);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Enabled = false;
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(186, 24);
            this.tsmiEdit.Text = "Chỉnh sửa biến thể";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Enabled = false;
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(186, 24);
            this.tsmiDelete.Text = "Xóa biến thể";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // ProductVariantsManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.variantEditor);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductVariantsManagerControl";
            this.Size = new System.Drawing.Size(733, 461);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomComponents.RoundedButton btnAdd;
        private System.Windows.Forms.Label lblErr;
        private ProductVariantControl variantEditors;
        private ProductVariantControl variantEditor;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader variantName;
        private System.Windows.Forms.ColumnHeader variantPrice;
        private System.Windows.Forms.ColumnHeader variantStock;
        private System.Windows.Forms.ColumnHeader variantDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}
