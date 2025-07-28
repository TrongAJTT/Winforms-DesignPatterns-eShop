namespace _3S_eShop.GUI.ComponentControls
{
    partial class ProductEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditorControl));
            this.btnSave = new _3S_eShop.CustomComponents.RoundedButton();
            this.roundedPanel6 = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnBatchImportVariants = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnExportVariants = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnImportVariants = new _3S_eShop.CustomComponents.RoundedButton();
            this.variantManager = new _3S_eShop.GUI.ComponentControls.ProductVariantsManagerControl();
            this.lblErrVariant = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedPanel5 = new _3S_eShop.CustomControls.RoundedPanel();
            this.btnBatchImportSpec = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnExportSpec = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnImportSpec = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnPullSpecTemplate = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnSaveSpecTemplate = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblErrSpec = new System.Windows.Forms.Label();
            this.specManager = new _3S_eShop.GUI.ComponentControls.SpecificationManager();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblErrDesc = new System.Windows.Forms.Label();
            this.txtDescription = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblErrWarranty = new System.Windows.Forms.Label();
            this.lblErrName = new System.Windows.Forms.Label();
            this.lblErrCategoryBrand = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.toggleWarrantyLifetime = new _3S_eShop.CustomComponents.ToggleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWarranty = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.roundedPanel3 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picBrand = new System.Windows.Forms.PictureBox();
            this.lblSectionBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.btnPickCategoryAndBrand = new _3S_eShop.CustomComponents.RoundedButton();
            this.lblSectionCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new _3S_eShop.CustomControls.RoundedPanel();
            this.lblErrImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgPicker = new _3S_eShop.GUI.ComponentControls.ImagePanelPicker();
            this.picView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrTotal = new System.Windows.Forms.Label();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BorderRadius = 30;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(693, 2171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(284, 56);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Thêm sản phẩm";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel6.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel6.BorderRadius = 15;
            this.roundedPanel6.BorderSize = 0;
            this.roundedPanel6.Controls.Add(this.btnBatchImportVariants);
            this.roundedPanel6.Controls.Add(this.btnExportVariants);
            this.roundedPanel6.Controls.Add(this.btnImportVariants);
            this.roundedPanel6.Controls.Add(this.variantManager);
            this.roundedPanel6.Controls.Add(this.lblErrVariant);
            this.roundedPanel6.Controls.Add(this.label11);
            this.roundedPanel6.ForeColor = System.Drawing.Color.White;
            this.roundedPanel6.Location = new System.Drawing.Point(15, 1600);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(962, 544);
            this.roundedPanel6.TabIndex = 10;
            this.roundedPanel6.TextColor = System.Drawing.Color.White;
            // 
            // btnBatchImportVariants
            // 
            this.btnBatchImportVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchImportVariants.BackColor = System.Drawing.Color.White;
            this.btnBatchImportVariants.BackgroundColor = System.Drawing.Color.White;
            this.btnBatchImportVariants.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBatchImportVariants.BorderRadius = 15;
            this.btnBatchImportVariants.BorderSize = 0;
            this.btnBatchImportVariants.FlatAppearance.BorderSize = 0;
            this.btnBatchImportVariants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchImportVariants.ForeColor = System.Drawing.Color.White;
            this.btnBatchImportVariants.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchImportVariants.Image")));
            this.btnBatchImportVariants.Location = new System.Drawing.Point(825, 15);
            this.btnBatchImportVariants.Name = "btnBatchImportVariants";
            this.btnBatchImportVariants.Size = new System.Drawing.Size(32, 32);
            this.btnBatchImportVariants.TabIndex = 30;
            this.btnBatchImportVariants.TextColor = System.Drawing.Color.White;
            this.btnBatchImportVariants.UseVisualStyleBackColor = false;
            this.btnBatchImportVariants.Click += new System.EventHandler(this.btnBatchImportVariants_Click);
            // 
            // btnExportVariants
            // 
            this.btnExportVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVariants.BackColor = System.Drawing.Color.White;
            this.btnExportVariants.BackgroundColor = System.Drawing.Color.White;
            this.btnExportVariants.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExportVariants.BorderRadius = 15;
            this.btnExportVariants.BorderSize = 0;
            this.btnExportVariants.FlatAppearance.BorderSize = 0;
            this.btnExportVariants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportVariants.ForeColor = System.Drawing.Color.White;
            this.btnExportVariants.Image = ((System.Drawing.Image)(resources.GetObject("btnExportVariants.Image")));
            this.btnExportVariants.Location = new System.Drawing.Point(912, 15);
            this.btnExportVariants.Name = "btnExportVariants";
            this.btnExportVariants.Size = new System.Drawing.Size(32, 32);
            this.btnExportVariants.TabIndex = 29;
            this.btnExportVariants.TextColor = System.Drawing.Color.White;
            this.btnExportVariants.UseVisualStyleBackColor = false;
            this.btnExportVariants.Click += new System.EventHandler(this.btnExportVariants_Click);
            // 
            // btnImportVariants
            // 
            this.btnImportVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportVariants.BackColor = System.Drawing.Color.White;
            this.btnImportVariants.BackgroundColor = System.Drawing.Color.White;
            this.btnImportVariants.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImportVariants.BorderRadius = 15;
            this.btnImportVariants.BorderSize = 0;
            this.btnImportVariants.FlatAppearance.BorderSize = 0;
            this.btnImportVariants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportVariants.ForeColor = System.Drawing.Color.White;
            this.btnImportVariants.Image = ((System.Drawing.Image)(resources.GetObject("btnImportVariants.Image")));
            this.btnImportVariants.Location = new System.Drawing.Point(874, 15);
            this.btnImportVariants.Name = "btnImportVariants";
            this.btnImportVariants.Size = new System.Drawing.Size(32, 32);
            this.btnImportVariants.TabIndex = 28;
            this.btnImportVariants.TextColor = System.Drawing.Color.White;
            this.btnImportVariants.UseVisualStyleBackColor = false;
            this.btnImportVariants.Click += new System.EventHandler(this.btnImportVariants_Click);
            // 
            // variantManager
            // 
            this.variantManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.variantManager.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantManager.Location = new System.Drawing.Point(19, 50);
            this.variantManager.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.variantManager.Name = "variantManager";
            this.variantManager.Size = new System.Drawing.Size(918, 461);
            this.variantManager.TabIndex = 25;
            this.variantManager.Value = new System.Collections.Generic.List<_3S_eShop.BLL.DTOs.ProductVariantDTO>();
            // 
            // lblErrVariant
            // 
            this.lblErrVariant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrVariant.ForeColor = System.Drawing.Color.Red;
            this.lblErrVariant.Location = new System.Drawing.Point(143, 15);
            this.lblErrVariant.Name = "lblErrVariant";
            this.lblErrVariant.Size = new System.Drawing.Size(799, 29);
            this.lblErrVariant.TabIndex = 24;
            this.lblErrVariant.Text = "Lỗi";
            this.lblErrVariant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "VARIANTS";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel5.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel5.BorderRadius = 15;
            this.roundedPanel5.BorderSize = 2;
            this.roundedPanel5.Controls.Add(this.btnBatchImportSpec);
            this.roundedPanel5.Controls.Add(this.btnExportSpec);
            this.roundedPanel5.Controls.Add(this.btnImportSpec);
            this.roundedPanel5.Controls.Add(this.btnPullSpecTemplate);
            this.roundedPanel5.Controls.Add(this.btnSaveSpecTemplate);
            this.roundedPanel5.Controls.Add(this.lblErrSpec);
            this.roundedPanel5.Controls.Add(this.specManager);
            this.roundedPanel5.Controls.Add(this.label10);
            this.roundedPanel5.ForeColor = System.Drawing.Color.White;
            this.roundedPanel5.Location = new System.Drawing.Point(15, 660);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(962, 526);
            this.roundedPanel5.TabIndex = 6;
            this.roundedPanel5.TextColor = System.Drawing.Color.White;
            // 
            // btnBatchImportSpec
            // 
            this.btnBatchImportSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchImportSpec.BackColor = System.Drawing.Color.White;
            this.btnBatchImportSpec.BackgroundColor = System.Drawing.Color.White;
            this.btnBatchImportSpec.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBatchImportSpec.BorderRadius = 15;
            this.btnBatchImportSpec.BorderSize = 0;
            this.btnBatchImportSpec.FlatAppearance.BorderSize = 0;
            this.btnBatchImportSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchImportSpec.ForeColor = System.Drawing.Color.White;
            this.btnBatchImportSpec.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchImportSpec.Image")));
            this.btnBatchImportSpec.Location = new System.Drawing.Point(747, 12);
            this.btnBatchImportSpec.Name = "btnBatchImportSpec";
            this.btnBatchImportSpec.Size = new System.Drawing.Size(32, 32);
            this.btnBatchImportSpec.TabIndex = 27;
            this.btnBatchImportSpec.TextColor = System.Drawing.Color.White;
            this.btnBatchImportSpec.UseVisualStyleBackColor = false;
            this.btnBatchImportSpec.Click += new System.EventHandler(this.btnBatchImportSpec_Click);
            // 
            // btnExportSpec
            // 
            this.btnExportSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSpec.BackColor = System.Drawing.Color.White;
            this.btnExportSpec.BackgroundColor = System.Drawing.Color.White;
            this.btnExportSpec.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExportSpec.BorderRadius = 15;
            this.btnExportSpec.BorderSize = 0;
            this.btnExportSpec.FlatAppearance.BorderSize = 0;
            this.btnExportSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportSpec.ForeColor = System.Drawing.Color.White;
            this.btnExportSpec.Image = ((System.Drawing.Image)(resources.GetObject("btnExportSpec.Image")));
            this.btnExportSpec.Location = new System.Drawing.Point(834, 12);
            this.btnExportSpec.Name = "btnExportSpec";
            this.btnExportSpec.Size = new System.Drawing.Size(32, 32);
            this.btnExportSpec.TabIndex = 26;
            this.btnExportSpec.TextColor = System.Drawing.Color.White;
            this.btnExportSpec.UseVisualStyleBackColor = false;
            this.btnExportSpec.Click += new System.EventHandler(this.btnExportSpec_Click);
            // 
            // btnImportSpec
            // 
            this.btnImportSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportSpec.BackColor = System.Drawing.Color.White;
            this.btnImportSpec.BackgroundColor = System.Drawing.Color.White;
            this.btnImportSpec.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImportSpec.BorderRadius = 15;
            this.btnImportSpec.BorderSize = 0;
            this.btnImportSpec.FlatAppearance.BorderSize = 0;
            this.btnImportSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportSpec.ForeColor = System.Drawing.Color.White;
            this.btnImportSpec.Image = ((System.Drawing.Image)(resources.GetObject("btnImportSpec.Image")));
            this.btnImportSpec.Location = new System.Drawing.Point(796, 12);
            this.btnImportSpec.Name = "btnImportSpec";
            this.btnImportSpec.Size = new System.Drawing.Size(32, 32);
            this.btnImportSpec.TabIndex = 25;
            this.btnImportSpec.TextColor = System.Drawing.Color.White;
            this.btnImportSpec.UseVisualStyleBackColor = false;
            this.btnImportSpec.Click += new System.EventHandler(this.btnImportSpec_Click);
            // 
            // btnPullSpecTemplate
            // 
            this.btnPullSpecTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPullSpecTemplate.BackColor = System.Drawing.Color.White;
            this.btnPullSpecTemplate.BackgroundColor = System.Drawing.Color.White;
            this.btnPullSpecTemplate.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPullSpecTemplate.BorderRadius = 15;
            this.btnPullSpecTemplate.BorderSize = 0;
            this.btnPullSpecTemplate.FlatAppearance.BorderSize = 0;
            this.btnPullSpecTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPullSpecTemplate.ForeColor = System.Drawing.Color.White;
            this.btnPullSpecTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnPullSpecTemplate.Image")));
            this.btnPullSpecTemplate.Location = new System.Drawing.Point(881, 11);
            this.btnPullSpecTemplate.Name = "btnPullSpecTemplate";
            this.btnPullSpecTemplate.Size = new System.Drawing.Size(32, 32);
            this.btnPullSpecTemplate.TabIndex = 24;
            this.btnPullSpecTemplate.TextColor = System.Drawing.Color.White;
            this.btnPullSpecTemplate.UseVisualStyleBackColor = false;
            this.btnPullSpecTemplate.Click += new System.EventHandler(this.btnPullTemplate_Click);
            // 
            // btnSaveSpecTemplate
            // 
            this.btnSaveSpecTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSpecTemplate.BackColor = System.Drawing.Color.White;
            this.btnSaveSpecTemplate.BackgroundColor = System.Drawing.Color.White;
            this.btnSaveSpecTemplate.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveSpecTemplate.BorderRadius = 15;
            this.btnSaveSpecTemplate.BorderSize = 0;
            this.btnSaveSpecTemplate.FlatAppearance.BorderSize = 0;
            this.btnSaveSpecTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSpecTemplate.ForeColor = System.Drawing.Color.White;
            this.btnSaveSpecTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSpecTemplate.Image")));
            this.btnSaveSpecTemplate.Location = new System.Drawing.Point(919, 11);
            this.btnSaveSpecTemplate.Name = "btnSaveSpecTemplate";
            this.btnSaveSpecTemplate.Size = new System.Drawing.Size(32, 32);
            this.btnSaveSpecTemplate.TabIndex = 23;
            this.btnSaveSpecTemplate.TextColor = System.Drawing.Color.White;
            this.btnSaveSpecTemplate.UseVisualStyleBackColor = false;
            this.btnSaveSpecTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // lblErrSpec
            // 
            this.lblErrSpec.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrSpec.ForeColor = System.Drawing.Color.Red;
            this.lblErrSpec.Location = new System.Drawing.Point(277, 15);
            this.lblErrSpec.Name = "lblErrSpec";
            this.lblErrSpec.Size = new System.Drawing.Size(378, 29);
            this.lblErrSpec.TabIndex = 22;
            this.lblErrSpec.Text = "Lỗi";
            this.lblErrSpec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // specManager
            // 
            this.specManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specManager.AutoScroll = true;
            this.specManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.specManager.Column = 1;
            this.specManager.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specManager.Location = new System.Drawing.Point(19, 49);
            this.specManager.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.specManager.Name = "specManager";
            this.specManager.Size = new System.Drawing.Size(919, 451);
            this.specManager.TabIndex = 5;
            this.specManager.Value = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("specManager.Value")));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "THÔNG SỐ KỸ THUẬT";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel4.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel4.BorderRadius = 15;
            this.roundedPanel4.BorderSize = 0;
            this.roundedPanel4.Controls.Add(this.lblErrDesc);
            this.roundedPanel4.Controls.Add(this.txtDescription);
            this.roundedPanel4.Controls.Add(this.label9);
            this.roundedPanel4.ForeColor = System.Drawing.Color.White;
            this.roundedPanel4.Location = new System.Drawing.Point(15, 1212);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(962, 364);
            this.roundedPanel4.TabIndex = 5;
            this.roundedPanel4.TextColor = System.Drawing.Color.White;
            // 
            // lblErrDesc
            // 
            this.lblErrDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrDesc.ForeColor = System.Drawing.Color.Red;
            this.lblErrDesc.Location = new System.Drawing.Point(105, 14);
            this.lblErrDesc.Name = "lblErrDesc";
            this.lblErrDesc.Size = new System.Drawing.Size(824, 29);
            this.lblErrDesc.TabIndex = 23;
            this.lblErrDesc.Text = "Lỗi";
            this.lblErrDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.InputCharacterValidator = null;
            this.txtDescription.Location = new System.Drawing.Point(19, 49);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(919, 294);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            this.txtDescription.Valid = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 4;
            this.label9.Text = "MÔ TẢ";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.lblErrWarranty);
            this.roundedPanel2.Controls.Add(this.lblErrName);
            this.roundedPanel2.Controls.Add(this.lblErrCategoryBrand);
            this.roundedPanel2.Controls.Add(this.label14);
            this.roundedPanel2.Controls.Add(this.toggleWarrantyLifetime);
            this.roundedPanel2.Controls.Add(this.label13);
            this.roundedPanel2.Controls.Add(this.label12);
            this.roundedPanel2.Controls.Add(this.txtWarranty);
            this.roundedPanel2.Controls.Add(this.label8);
            this.roundedPanel2.Controls.Add(this.txtName);
            this.roundedPanel2.Controls.Add(this.roundedPanel3);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.ForeColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(555, 15);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(422, 617);
            this.roundedPanel2.TabIndex = 5;
            this.roundedPanel2.TextColor = System.Drawing.Color.White;
            // 
            // lblErrWarranty
            // 
            this.lblErrWarranty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrWarranty.ForeColor = System.Drawing.Color.Red;
            this.lblErrWarranty.Location = new System.Drawing.Point(19, 563);
            this.lblErrWarranty.Name = "lblErrWarranty";
            this.lblErrWarranty.Size = new System.Drawing.Size(378, 29);
            this.lblErrWarranty.TabIndex = 21;
            this.lblErrWarranty.Text = "Lỗi";
            this.lblErrWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrName
            // 
            this.lblErrName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrName.ForeColor = System.Drawing.Color.Red;
            this.lblErrName.Location = new System.Drawing.Point(19, 442);
            this.lblErrName.Name = "lblErrName";
            this.lblErrName.Size = new System.Drawing.Size(378, 29);
            this.lblErrName.TabIndex = 20;
            this.lblErrName.Text = "Lỗi";
            this.lblErrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrCategoryBrand
            // 
            this.lblErrCategoryBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrCategoryBrand.ForeColor = System.Drawing.Color.Red;
            this.lblErrCategoryBrand.Location = new System.Drawing.Point(19, 270);
            this.lblErrCategoryBrand.Name = "lblErrCategoryBrand";
            this.lblErrCategoryBrand.Size = new System.Drawing.Size(378, 29);
            this.lblErrCategoryBrand.TabIndex = 19;
            this.lblErrCategoryBrand.Text = "Lỗi";
            this.lblErrCategoryBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(279, 519);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 40);
            this.label14.TabIndex = 18;
            this.label14.Text = "trọn đời";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleWarrantyLifetime
            // 
            this.toggleWarrantyLifetime.AutoSize = true;
            this.toggleWarrantyLifetime.Location = new System.Drawing.Point(228, 530);
            this.toggleWarrantyLifetime.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleWarrantyLifetime.Name = "toggleWarrantyLifetime";
            this.toggleWarrantyLifetime.OffBackColor = System.Drawing.Color.Gray;
            this.toggleWarrantyLifetime.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleWarrantyLifetime.OnBackColor = System.Drawing.Color.Teal;
            this.toggleWarrantyLifetime.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleWarrantyLifetime.Size = new System.Drawing.Size(45, 22);
            this.toggleWarrantyLifetime.TabIndex = 17;
            this.toggleWarrantyLifetime.UseVisualStyleBackColor = true;
            this.toggleWarrantyLifetime.CheckedChanged += new System.EventHandler(this.toggleWarrantyLifetime_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(122, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 40);
            this.label13.TabIndex = 16;
            this.label13.Text = "năm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(374, 40);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tên sản phẩm";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarranty.BackColor = System.Drawing.SystemColors.Window;
            this.txtWarranty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtWarranty.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtWarranty.BorderRadius = 15;
            this.txtWarranty.BorderSize = 2;
            this.txtWarranty.ContentAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWarranty.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWarranty.InputCharacterValidator = null;
            this.txtWarranty.Location = new System.Drawing.Point(23, 518);
            this.txtWarranty.Margin = new System.Windows.Forms.Padding(4);
            this.txtWarranty.Multiline = true;
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWarranty.PasswordChar = false;
            this.txtWarranty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWarranty.PlaceholderText = "";
            this.txtWarranty.Size = new System.Drawing.Size(92, 41);
            this.txtWarranty.TabIndex = 14;
            this.txtWarranty.Texts = "1";
            this.txtWarranty.UnderlinedStyle = false;
            this.txtWarranty.Valid = null;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 40);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hạn bảo hành";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 2;
            this.txtName.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.InputCharacterValidator = null;
            this.txtName.Location = new System.Drawing.Point(23, 339);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(379, 99);
            this.txtName.TabIndex = 8;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.Valid = null;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel3.BorderRadius = 30;
            this.roundedPanel3.BorderSize = 0;
            this.roundedPanel3.Controls.Add(this.lblBrand);
            this.roundedPanel3.Controls.Add(this.picBrand);
            this.roundedPanel3.Controls.Add(this.lblSectionBrand);
            this.roundedPanel3.Controls.Add(this.lblCategory);
            this.roundedPanel3.Controls.Add(this.picCategory);
            this.roundedPanel3.Controls.Add(this.btnPickCategoryAndBrand);
            this.roundedPanel3.Controls.Add(this.lblSectionCategory);
            this.roundedPanel3.ForeColor = System.Drawing.Color.White;
            this.roundedPanel3.Location = new System.Drawing.Point(19, 51);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(379, 216);
            this.roundedPanel3.TabIndex = 7;
            this.roundedPanel3.TextColor = System.Drawing.Color.White;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblBrand.Location = new System.Drawing.Point(77, 143);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(278, 40);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Tên hãng";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBrand
            // 
            this.picBrand.Location = new System.Drawing.Point(31, 143);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(40, 40);
            this.picBrand.TabIndex = 10;
            this.picBrand.TabStop = false;
            // 
            // lblSectionBrand
            // 
            this.lblSectionBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSectionBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionBrand.Location = new System.Drawing.Point(26, 103);
            this.lblSectionBrand.Name = "lblSectionBrand";
            this.lblSectionBrand.Size = new System.Drawing.Size(329, 40);
            this.lblSectionBrand.TabIndex = 9;
            this.lblSectionBrand.Text = "Hãng sản xuất";
            this.lblSectionBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblCategory.Location = new System.Drawing.Point(77, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(278, 40);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Danh mục";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCategory
            // 
            this.picCategory.Location = new System.Drawing.Point(31, 60);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(40, 40);
            this.picCategory.TabIndex = 7;
            this.picCategory.TabStop = false;
            // 
            // btnPickCategoryAndBrand
            // 
            this.btnPickCategoryAndBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickCategoryAndBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategoryAndBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnPickCategoryAndBrand.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPickCategoryAndBrand.BorderRadius = 30;
            this.btnPickCategoryAndBrand.BorderSize = 0;
            this.btnPickCategoryAndBrand.FlatAppearance.BorderSize = 0;
            this.btnPickCategoryAndBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCategoryAndBrand.ForeColor = System.Drawing.Color.White;
            this.btnPickCategoryAndBrand.Location = new System.Drawing.Point(245, 17);
            this.btnPickCategoryAndBrand.Name = "btnPickCategoryAndBrand";
            this.btnPickCategoryAndBrand.Size = new System.Drawing.Size(115, 40);
            this.btnPickCategoryAndBrand.TabIndex = 6;
            this.btnPickCategoryAndBrand.Text = "Chọn";
            this.btnPickCategoryAndBrand.TextColor = System.Drawing.Color.White;
            this.btnPickCategoryAndBrand.UseVisualStyleBackColor = false;
            this.btnPickCategoryAndBrand.Click += new System.EventHandler(this.btnPickCategoryAndBrand_Click);
            // 
            // lblSectionCategory
            // 
            this.lblSectionCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSectionCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblSectionCategory.Location = new System.Drawing.Point(26, 17);
            this.lblSectionCategory.Name = "lblSectionCategory";
            this.lblSectionCategory.Size = new System.Drawing.Size(208, 40);
            this.lblSectionCategory.TabIndex = 5;
            this.lblSectionCategory.Text = "Danh mục";
            this.lblSectionCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.lblErrImage);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.imgPicker);
            this.roundedPanel1.Controls.Add(this.picView);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(15, 15);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(519, 617);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lblErrImage
            // 
            this.lblErrImage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrImage.ForeColor = System.Drawing.Color.Red;
            this.lblErrImage.Location = new System.Drawing.Point(208, 15);
            this.lblErrImage.Name = "lblErrImage";
            this.lblErrImage.Size = new System.Drawing.Size(291, 29);
            this.lblErrImage.TabIndex = 22;
            this.lblErrImage.Text = "Lỗi";
            this.lblErrImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ẢNH SẢN PHẨM";
            // 
            // imgPicker
            // 
            this.imgPicker.BackColor = System.Drawing.Color.White;
            this.imgPicker.DefaultPictureSize = new System.Drawing.Size(50, 50);
            this.imgPicker.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPicker.Location = new System.Drawing.Point(19, 51);
            this.imgPicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.SelectecPicture = null;
            this.imgPicker.Size = new System.Drawing.Size(480, 167);
            this.imgPicker.TabIndex = 1;
            // 
            // picView
            // 
            this.picView.BackColor = System.Drawing.Color.White;
            this.picView.Location = new System.Drawing.Point(19, 236);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(480, 360);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView.TabIndex = 0;
            this.picView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(683, 2243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 25;
            // 
            // lblErrTotal
            // 
            this.lblErrTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblErrTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErrTotal.Location = new System.Drawing.Point(30, 2188);
            this.lblErrTotal.Name = "lblErrTotal";
            this.lblErrTotal.Size = new System.Drawing.Size(358, 29);
            this.lblErrTotal.TabIndex = 26;
            this.lblErrTotal.Text = "Có lỗi, vui lòng kiểm tra bên trên";
            this.lblErrTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblErrTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ProductEditorControl";
            this.Size = new System.Drawing.Size(1000, 2256);
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picView;
        private ImagePanelPicker imgPicker;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedPanel roundedPanel3;
        private CustomComponents.RoundedButton btnPickCategoryAndBrand;
        private System.Windows.Forms.Label lblSectionCategory;
        private System.Windows.Forms.Label lblSectionBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox picCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox picBrand;
        private CustomComponents.AdvancedTextBox txtName;
        private System.Windows.Forms.Label label8;
        private CustomControls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label9;
        private CustomControls.RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label label10;
        private CustomComponents.AdvancedTextBox txtDescription;
        private CustomControls.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Label label11;
        private SpecificationManager specManager;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CustomComponents.AdvancedTextBox txtWarranty;
        private CustomComponents.RoundedButton btnSave;
        private System.Windows.Forms.Label label14;
        private CustomComponents.ToggleButton toggleWarrantyLifetime;
        private System.Windows.Forms.Label lblErrSpec;
        private System.Windows.Forms.Label lblErrWarranty;
        private System.Windows.Forms.Label lblErrName;
        private System.Windows.Forms.Label lblErrCategoryBrand;
        private System.Windows.Forms.Label lblErrVariant;
        private System.Windows.Forms.Label lblErrDesc;
        private System.Windows.Forms.Label lblErrImage;
        private CustomComponents.RoundedButton btnPullSpecTemplate;
        private CustomComponents.RoundedButton btnSaveSpecTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrTotal;
        private ProductVariantsManagerControl variantManager;
        private CustomComponents.RoundedButton btnImportSpec;
        private CustomComponents.RoundedButton btnExportSpec;
        private CustomComponents.RoundedButton btnBatchImportVariants;
        private CustomComponents.RoundedButton btnExportVariants;
        private CustomComponents.RoundedButton btnImportVariants;
        private CustomComponents.RoundedButton btnBatchImportSpec;
    }
}
