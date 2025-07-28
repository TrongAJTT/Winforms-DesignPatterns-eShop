namespace _3S_eShop.GUI.ComponentControls
{
    partial class ProductViewerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewerControl));
            this.flowHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.llblHeaderCategory = new System.Windows.Forms.LinkLabel();
            this.lblHeaderEmbed1 = new System.Windows.Forms.Label();
            this.llblHeaderBrand = new System.Windows.Forms.LinkLabel();
            this.lblHeaderEmbed2 = new System.Windows.Forms.Label();
            this.lblHeaderProductName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.flowProductImages = new System.Windows.Forms.FlowLayoutPanel();
            this.productPictures = new System.Windows.Forms.PictureBox();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowVariants = new System.Windows.Forms.FlowLayoutPanel();
            this.flowActions = new System.Windows.Forms.FlowLayoutPanel();
            this.flowDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleDescription = new System.Windows.Forms.Label();
            this.lblDesctiptionValue = new System.Windows.Forms.Label();
            this.flowSpecifications = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleSpecifications = new System.Windows.Forms.Label();
            this.listViewSpecifications = new System.Windows.Forms.ListView();
            this.specKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowReviewHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRatingInfoContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoRating1 = new System.Windows.Forms.Label();
            this.lblNoRating2 = new System.Windows.Forms.Label();
            this.lblNoRating3 = new System.Windows.Forms.Label();
            this.lblNoRating4 = new System.Windows.Forms.Label();
            this.lblNoRating5 = new System.Windows.Forms.Label();
            this.lblRatingTotal = new System.Windows.Forms.Label();
            this.lblRatingAverage = new System.Windows.Forms.Label();
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.imgPicker = new _3S_eShop.GUI.ComponentControls.ImagePanelPicker();
            this.btnBuy = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnAddCart = new _3S_eShop.CustomComponents.RoundedButton();
            this.btnEdit = new _3S_eShop.CustomComponents.RoundedButton();
            this.flowVariantDescription = new _3S_eShop.CustomControls.RoundedFlowLayoutPanel();
            this.lblVariantDescription = new System.Windows.Forms.Label();
            this.cardProductSimilar = new _3S_eShop.CustomControls.CardSlider();
            this.ratingBar1 = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.ratingBar2 = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.ratingBar3 = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.ratingBar4 = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.ratingBar5 = new _3S_eShop.GUI.ComponentControls.RatingBar();
            this.pagingUserReview = new _3S_eShop.GUI.ComponentControls.PaginationSelector();
            this.productReviewControl1 = new _3S_eShop.GUI.ComponentControls.ProductReviewControl();
            this.flowHeader.SuspendLayout();
            this.flowProductImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictures)).BeginInit();
            this.flowContainer.SuspendLayout();
            this.flowActions.SuspendLayout();
            this.flowDescription.SuspendLayout();
            this.flowSpecifications.SuspendLayout();
            this.flowReviewHeader.SuspendLayout();
            this.panelRatingInfoContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowReviews.SuspendLayout();
            this.flowVariantDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowHeader
            // 
            this.flowHeader.Controls.Add(this.llblHeaderCategory);
            this.flowHeader.Controls.Add(this.lblHeaderEmbed1);
            this.flowHeader.Controls.Add(this.llblHeaderBrand);
            this.flowHeader.Controls.Add(this.lblHeaderEmbed2);
            this.flowHeader.Controls.Add(this.lblHeaderProductName);
            this.flowHeader.Location = new System.Drawing.Point(6, 6);
            this.flowHeader.Name = "flowHeader";
            this.flowHeader.Size = new System.Drawing.Size(968, 26);
            this.flowHeader.TabIndex = 4;
            // 
            // llblHeaderCategory
            // 
            this.llblHeaderCategory.AutoSize = true;
            this.llblHeaderCategory.Location = new System.Drawing.Point(3, 0);
            this.llblHeaderCategory.Name = "llblHeaderCategory";
            this.llblHeaderCategory.Size = new System.Drawing.Size(98, 25);
            this.llblHeaderCategory.TabIndex = 0;
            this.llblHeaderCategory.TabStop = true;
            this.llblHeaderCategory.Text = "Danh mục";
            // 
            // lblHeaderEmbed1
            // 
            this.lblHeaderEmbed1.AutoSize = true;
            this.lblHeaderEmbed1.Location = new System.Drawing.Point(107, 0);
            this.lblHeaderEmbed1.Name = "lblHeaderEmbed1";
            this.lblHeaderEmbed1.Size = new System.Drawing.Size(25, 25);
            this.lblHeaderEmbed1.TabIndex = 2;
            this.lblHeaderEmbed1.Text = ">";
            // 
            // llblHeaderBrand
            // 
            this.llblHeaderBrand.AutoSize = true;
            this.llblHeaderBrand.Location = new System.Drawing.Point(138, 0);
            this.llblHeaderBrand.Name = "llblHeaderBrand";
            this.llblHeaderBrand.Size = new System.Drawing.Size(119, 25);
            this.llblHeaderBrand.TabIndex = 1;
            this.llblHeaderBrand.TabStop = true;
            this.llblHeaderBrand.Text = "Thương hiệu";
            // 
            // lblHeaderEmbed2
            // 
            this.lblHeaderEmbed2.AutoSize = true;
            this.lblHeaderEmbed2.Location = new System.Drawing.Point(263, 0);
            this.lblHeaderEmbed2.Name = "lblHeaderEmbed2";
            this.lblHeaderEmbed2.Size = new System.Drawing.Size(25, 25);
            this.lblHeaderEmbed2.TabIndex = 3;
            this.lblHeaderEmbed2.Text = ">";
            // 
            // lblHeaderProductName
            // 
            this.lblHeaderProductName.AutoSize = true;
            this.lblHeaderProductName.Location = new System.Drawing.Point(294, 0);
            this.lblHeaderProductName.Name = "lblHeaderProductName";
            this.lblHeaderProductName.Size = new System.Drawing.Size(128, 25);
            this.lblHeaderProductName.TabIndex = 4;
            this.lblHeaderProductName.Text = "Tên sản phẩm";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 38);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(968, 35);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // flowProductImages
            // 
            this.flowProductImages.Controls.Add(this.productPictures);
            this.flowProductImages.Controls.Add(this.imgPicker);
            this.flowProductImages.Location = new System.Drawing.Point(6, 79);
            this.flowProductImages.Name = "flowProductImages";
            this.flowProductImages.Size = new System.Drawing.Size(481, 423);
            this.flowProductImages.TabIndex = 8;
            // 
            // productPictures
            // 
            this.productPictures.Location = new System.Drawing.Point(0, 0);
            this.productPictures.Margin = new System.Windows.Forms.Padding(0);
            this.productPictures.Name = "productPictures";
            this.productPictures.Size = new System.Drawing.Size(481, 295);
            this.productPictures.TabIndex = 7;
            this.productPictures.TabStop = false;
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowContainer.BackColor = System.Drawing.Color.White;
            this.flowContainer.Controls.Add(this.flowHeader);
            this.flowContainer.Controls.Add(this.lblProductName);
            this.flowContainer.Controls.Add(this.flowProductImages);
            this.flowContainer.Controls.Add(this.flowVariants);
            this.flowContainer.Controls.Add(this.flowActions);
            this.flowContainer.Controls.Add(this.flowVariantDescription);
            this.flowContainer.Controls.Add(this.cardProductSimilar);
            this.flowContainer.Controls.Add(this.flowDescription);
            this.flowContainer.Controls.Add(this.flowSpecifications);
            this.flowContainer.Controls.Add(this.flowReviewHeader);
            this.flowContainer.Controls.Add(this.flowReviews);
            this.flowContainer.Location = new System.Drawing.Point(0, 0);
            this.flowContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Padding = new System.Windows.Forms.Padding(3);
            this.flowContainer.Size = new System.Drawing.Size(980, 2086);
            this.flowContainer.TabIndex = 9;
            // 
            // flowVariants
            // 
            this.flowVariants.AutoScroll = true;
            this.flowVariants.Location = new System.Drawing.Point(493, 79);
            this.flowVariants.Name = "flowVariants";
            this.flowVariants.Size = new System.Drawing.Size(481, 423);
            this.flowVariants.TabIndex = 9;
            // 
            // flowActions
            // 
            this.flowActions.Controls.Add(this.btnBuy);
            this.flowActions.Controls.Add(this.btnAddCart);
            this.flowActions.Controls.Add(this.btnEdit);
            this.flowActions.Location = new System.Drawing.Point(6, 508);
            this.flowActions.Name = "flowActions";
            this.flowActions.Size = new System.Drawing.Size(481, 110);
            this.flowActions.TabIndex = 11;
            // 
            // flowDescription
            // 
            this.flowDescription.AutoScroll = true;
            this.flowDescription.AutoSize = true;
            this.flowDescription.Controls.Add(this.lblTitleDescription);
            this.flowDescription.Controls.Add(this.lblDesctiptionValue);
            this.flowDescription.Location = new System.Drawing.Point(6, 1155);
            this.flowDescription.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowDescription.Name = "flowDescription";
            this.flowDescription.Size = new System.Drawing.Size(964, 65);
            this.flowDescription.TabIndex = 15;
            // 
            // lblTitleDescription
            // 
            this.lblTitleDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleDescription.Location = new System.Drawing.Point(1, 1);
            this.lblTitleDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.lblTitleDescription.Name = "lblTitleDescription";
            this.lblTitleDescription.Size = new System.Drawing.Size(962, 39);
            this.lblTitleDescription.TabIndex = 6;
            this.lblTitleDescription.Text = "Mô tả sản phẩm";
            this.lblTitleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesctiptionValue
            // 
            this.lblDesctiptionValue.AutoSize = true;
            this.lblDesctiptionValue.Location = new System.Drawing.Point(3, 40);
            this.lblDesctiptionValue.Name = "lblDesctiptionValue";
            this.lblDesctiptionValue.Size = new System.Drawing.Size(144, 25);
            this.lblDesctiptionValue.TabIndex = 7;
            this.lblDesctiptionValue.Text = "Nội dung mô tả";
            // 
            // flowSpecifications
            // 
            this.flowSpecifications.Controls.Add(this.lblTitleSpecifications);
            this.flowSpecifications.Controls.Add(this.listViewSpecifications);
            this.flowSpecifications.Location = new System.Drawing.Point(6, 1253);
            this.flowSpecifications.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flowSpecifications.Name = "flowSpecifications";
            this.flowSpecifications.Size = new System.Drawing.Size(968, 423);
            this.flowSpecifications.TabIndex = 16;
            // 
            // lblTitleSpecifications
            // 
            this.lblTitleSpecifications.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleSpecifications.Location = new System.Drawing.Point(1, 1);
            this.lblTitleSpecifications.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.lblTitleSpecifications.Name = "lblTitleSpecifications";
            this.lblTitleSpecifications.Size = new System.Drawing.Size(962, 39);
            this.lblTitleSpecifications.TabIndex = 7;
            this.lblTitleSpecifications.Text = "Thông số kỹ thuật";
            this.lblTitleSpecifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewSpecifications
            // 
            this.listViewSpecifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.specKey,
            this.specValue});
            this.listViewSpecifications.HideSelection = false;
            this.listViewSpecifications.Location = new System.Drawing.Point(5, 43);
            this.listViewSpecifications.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listViewSpecifications.Name = "listViewSpecifications";
            this.listViewSpecifications.Size = new System.Drawing.Size(958, 375);
            this.listViewSpecifications.TabIndex = 8;
            this.listViewSpecifications.UseCompatibleStateImageBehavior = false;
            this.listViewSpecifications.View = System.Windows.Forms.View.Details;
            // 
            // specKey
            // 
            this.specKey.Text = "Nhãn";
            this.specKey.Width = 200;
            // 
            // specValue
            // 
            this.specValue.Text = "Thông số";
            this.specValue.Width = 1000;
            // 
            // flowReviewHeader
            // 
            this.flowReviewHeader.AutoScroll = true;
            this.flowReviewHeader.Controls.Add(this.label1);
            this.flowReviewHeader.Controls.Add(this.panelRatingInfoContainer);
            this.flowReviewHeader.Controls.Add(this.pagingUserReview);
            this.flowReviewHeader.Location = new System.Drawing.Point(6, 1682);
            this.flowReviewHeader.Name = "flowReviewHeader";
            this.flowReviewHeader.Size = new System.Drawing.Size(968, 252);
            this.flowReviewHeader.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(965, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đánh giá sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRatingInfoContainer
            // 
            this.panelRatingInfoContainer.Controls.Add(this.flowLayoutPanel1);
            this.panelRatingInfoContainer.Controls.Add(this.lblRatingTotal);
            this.panelRatingInfoContainer.Controls.Add(this.lblRatingAverage);
            this.panelRatingInfoContainer.Location = new System.Drawing.Point(3, 43);
            this.panelRatingInfoContainer.Name = "panelRatingInfoContainer";
            this.panelRatingInfoContainer.Size = new System.Drawing.Size(960, 161);
            this.panelRatingInfoContainer.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ratingBar1);
            this.flowLayoutPanel1.Controls.Add(this.lblNoRating1);
            this.flowLayoutPanel1.Controls.Add(this.ratingBar2);
            this.flowLayoutPanel1.Controls.Add(this.lblNoRating2);
            this.flowLayoutPanel1.Controls.Add(this.ratingBar3);
            this.flowLayoutPanel1.Controls.Add(this.lblNoRating3);
            this.flowLayoutPanel1.Controls.Add(this.ratingBar4);
            this.flowLayoutPanel1.Controls.Add(this.lblNoRating4);
            this.flowLayoutPanel1.Controls.Add(this.ratingBar5);
            this.flowLayoutPanel1.Controls.Add(this.lblNoRating5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(389, 156);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblNoRating1
            // 
            this.lblNoRating1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoRating1.Location = new System.Drawing.Point(179, 6);
            this.lblNoRating1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblNoRating1.Name = "lblNoRating1";
            this.lblNoRating1.Size = new System.Drawing.Size(144, 24);
            this.lblNoRating1.TabIndex = 4;
            this.lblNoRating1.Text = "5 đánh giá";
            this.lblNoRating1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoRating2
            // 
            this.lblNoRating2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoRating2.Location = new System.Drawing.Point(179, 36);
            this.lblNoRating2.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblNoRating2.Name = "lblNoRating2";
            this.lblNoRating2.Size = new System.Drawing.Size(144, 24);
            this.lblNoRating2.TabIndex = 5;
            this.lblNoRating2.Text = "5 đánh giá";
            this.lblNoRating2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoRating3
            // 
            this.lblNoRating3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoRating3.Location = new System.Drawing.Point(179, 66);
            this.lblNoRating3.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblNoRating3.Name = "lblNoRating3";
            this.lblNoRating3.Size = new System.Drawing.Size(144, 24);
            this.lblNoRating3.TabIndex = 7;
            this.lblNoRating3.Text = "5 đánh giá";
            this.lblNoRating3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoRating4
            // 
            this.lblNoRating4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoRating4.Location = new System.Drawing.Point(179, 96);
            this.lblNoRating4.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblNoRating4.Name = "lblNoRating4";
            this.lblNoRating4.Size = new System.Drawing.Size(144, 24);
            this.lblNoRating4.TabIndex = 9;
            this.lblNoRating4.Text = "5 đánh giá";
            this.lblNoRating4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoRating5
            // 
            this.lblNoRating5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoRating5.Location = new System.Drawing.Point(179, 126);
            this.lblNoRating5.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblNoRating5.Name = "lblNoRating5";
            this.lblNoRating5.Size = new System.Drawing.Size(144, 24);
            this.lblNoRating5.TabIndex = 11;
            this.lblNoRating5.Text = "5 đánh giá";
            this.lblNoRating5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRatingTotal
            // 
            this.lblRatingTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRatingTotal.Location = new System.Drawing.Point(44, 86);
            this.lblRatingTotal.Name = "lblRatingTotal";
            this.lblRatingTotal.Size = new System.Drawing.Size(144, 29);
            this.lblRatingTotal.TabIndex = 3;
            this.lblRatingTotal.Text = "5 đánh giá";
            this.lblRatingTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRatingAverage
            // 
            this.lblRatingAverage.Font = new System.Drawing.Font("Segoe UI", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingAverage.Location = new System.Drawing.Point(44, 39);
            this.lblRatingAverage.Name = "lblRatingAverage";
            this.lblRatingAverage.Size = new System.Drawing.Size(144, 47);
            this.lblRatingAverage.TabIndex = 2;
            this.lblRatingAverage.Text = "5.0/5";
            this.lblRatingAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowReviews
            // 
            this.flowReviews.AutoScroll = true;
            this.flowReviews.AutoSize = true;
            this.flowReviews.Controls.Add(this.productReviewControl1);
            this.flowReviews.Location = new System.Drawing.Point(6, 1940);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Size = new System.Drawing.Size(627, 143);
            this.flowReviews.TabIndex = 18;
            // 
            // imgPicker
            // 
            this.imgPicker.DefaultPictureSize = new System.Drawing.Size(50, 50);
            this.imgPicker.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPicker.Location = new System.Drawing.Point(0, 305);
            this.imgPicker.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.SelectecPicture = null;
            this.imgPicker.Size = new System.Drawing.Size(481, 117);
            this.imgPicker.TabIndex = 6;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnBuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnBuy.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuy.BorderRadius = 30;
            this.btnBuy.BorderSize = 0;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(0, 0);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(410, 60);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "MUA NGAY";
            this.btnBuy.TextColor = System.Drawing.Color.White;
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnAddCart.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCart.BorderRadius = 30;
            this.btnAddCart.BorderSize = 0;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnAddCart.ForeColor = System.Drawing.Color.White;
            this.btnAddCart.Location = new System.Drawing.Point(421, 0);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(60, 60);
            this.btnAddCart.TabIndex = 11;
            this.btnAddCart.TextColor = System.Drawing.Color.White;
            this.btnAddCart.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEdit.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.BorderRadius = 30;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(0, 70);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(481, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "CHỈNH SỬA SẢN PHẨM";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // flowVariantDescription
            // 
            this.flowVariantDescription.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowVariantDescription.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.flowVariantDescription.BorderRadius = 30;
            this.flowVariantDescription.BorderSize = 0;
            this.flowVariantDescription.Controls.Add(this.lblVariantDescription);
            this.flowVariantDescription.ForeColor = System.Drawing.Color.White;
            this.flowVariantDescription.Location = new System.Drawing.Point(493, 508);
            this.flowVariantDescription.Name = "flowVariantDescription";
            this.flowVariantDescription.Padding = new System.Windows.Forms.Padding(10);
            this.flowVariantDescription.Size = new System.Drawing.Size(481, 110);
            this.flowVariantDescription.TabIndex = 13;
            this.flowVariantDescription.TextColor = System.Drawing.Color.White;
            // 
            // lblVariantDescription
            // 
            this.lblVariantDescription.AutoSize = true;
            this.lblVariantDescription.ForeColor = System.Drawing.Color.White;
            this.lblVariantDescription.Location = new System.Drawing.Point(13, 10);
            this.lblVariantDescription.Name = "lblVariantDescription";
            this.lblVariantDescription.Size = new System.Drawing.Size(135, 25);
            this.lblVariantDescription.TabIndex = 0;
            this.lblVariantDescription.Text = "Mô tả biến thể";
            // 
            // cardProductSimilar
            // 
            this.cardProductSimilar.ActionButtonEnable = true;
            this.cardProductSimilar.BackColor = System.Drawing.Color.Transparent;
            this.cardProductSimilar.BorderRadius = 15;
            this.cardProductSimilar.ButtonCursor = System.Windows.Forms.Cursors.Default;
            this.cardProductSimilar.ChildSize = new System.Drawing.Size(202, 376);
            this.cardProductSimilar.ChildSpacing = 15;
            this.cardProductSimilar.ContainerColor = System.Drawing.Color.White;
            this.cardProductSimilar.ContainerPadding = new System.Windows.Forms.Padding(15);
            this.cardProductSimilar.CustomLabelEnable = false;
            this.cardProductSimilar.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardProductSimilar.LayoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardProductSimilar.LeadingImage = ((System.Drawing.Image)(resources.GetObject("cardProductSimilar.LeadingImage")));
            this.cardProductSimilar.Location = new System.Drawing.Point(6, 641);
            this.cardProductSimilar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.cardProductSimilar.MaxChildren = 10;
            this.cardProductSimilar.Name = "cardProductSimilar";
            this.cardProductSimilar.NavButtonColor = System.Drawing.Color.White;
            this.cardProductSimilar.NavButtonRadius = 15;
            this.cardProductSimilar.NavButtonSize = 40;
            this.cardProductSimilar.NavLeftImage = ((System.Drawing.Image)(resources.GetObject("cardProductSimilar.NavLeftImage")));
            this.cardProductSimilar.NavRightImage = ((System.Drawing.Image)(resources.GetObject("cardProductSimilar.NavRightImage")));
            this.cardProductSimilar.OuterSpace = 15;
            this.cardProductSimilar.Size = new System.Drawing.Size(968, 484);
            this.cardProductSimilar.TabIndex = 14;
            this.cardProductSimilar.TextColor = System.Drawing.Color.White;
            this.cardProductSimilar.Title = "SẢN PHẨM TƯƠNG TỰ";
            this.cardProductSimilar.TitleFont = new System.Drawing.Font("Segoe UI Black", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardProductSimilar.TitleSpacing = 3;
            // 
            // ratingBar1
            // 
            this.ratingBar1.AllowEdit = true;
            this.ratingBar1.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar1.Location = new System.Drawing.Point(6, 6);
            this.ratingBar1.Name = "ratingBar1";
            this.ratingBar1.RatingValue = 1;
            this.ratingBar1.Size = new System.Drawing.Size(164, 24);
            this.ratingBar1.Spacing = 7755;
            this.ratingBar1.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar1.StarSize = 18578;
            this.ratingBar1.TabIndex = 0;
            // 
            // ratingBar2
            // 
            this.ratingBar2.AllowEdit = true;
            this.ratingBar2.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar2.Location = new System.Drawing.Point(6, 36);
            this.ratingBar2.Name = "ratingBar2";
            this.ratingBar2.RatingValue = 2;
            this.ratingBar2.Size = new System.Drawing.Size(164, 24);
            this.ratingBar2.Spacing = 7755;
            this.ratingBar2.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar2.StarSize = 18578;
            this.ratingBar2.TabIndex = 1;
            // 
            // ratingBar3
            // 
            this.ratingBar3.AllowEdit = true;
            this.ratingBar3.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar3.Location = new System.Drawing.Point(6, 66);
            this.ratingBar3.Name = "ratingBar3";
            this.ratingBar3.RatingValue = 3;
            this.ratingBar3.Size = new System.Drawing.Size(164, 24);
            this.ratingBar3.Spacing = 7755;
            this.ratingBar3.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar3.StarSize = 18578;
            this.ratingBar3.TabIndex = 6;
            // 
            // ratingBar4
            // 
            this.ratingBar4.AllowEdit = true;
            this.ratingBar4.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar4.Location = new System.Drawing.Point(6, 96);
            this.ratingBar4.Name = "ratingBar4";
            this.ratingBar4.RatingValue = 4;
            this.ratingBar4.Size = new System.Drawing.Size(164, 24);
            this.ratingBar4.Spacing = 7755;
            this.ratingBar4.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar4.StarSize = 18578;
            this.ratingBar4.TabIndex = 8;
            // 
            // ratingBar5
            // 
            this.ratingBar5.AllowEdit = true;
            this.ratingBar5.BackColor = System.Drawing.Color.Transparent;
            this.ratingBar5.Location = new System.Drawing.Point(6, 126);
            this.ratingBar5.Name = "ratingBar5";
            this.ratingBar5.RatingValue = 5;
            this.ratingBar5.Size = new System.Drawing.Size(164, 24);
            this.ratingBar5.Spacing = 7755;
            this.ratingBar5.StarCursor = System.Windows.Forms.Cursors.Hand;
            this.ratingBar5.StarSize = 18578;
            this.ratingBar5.TabIndex = 10;
            // 
            // pagingUserReview
            // 
            this.pagingUserReview.CurrentPage = ((long)(1));
            this.pagingUserReview.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagingUserReview.Location = new System.Drawing.Point(0, 207);
            this.pagingUserReview.Margin = new System.Windows.Forms.Padding(0);
            this.pagingUserReview.MaxSize = ((long)(30));
            this.pagingUserReview.Name = "pagingUserReview";
            this.pagingUserReview.PageSize = ((long)(20));
            this.pagingUserReview.PrimaryColor = System.Drawing.Color.DeepSkyBlue;
            this.pagingUserReview.Size = new System.Drawing.Size(960, 38);
            this.pagingUserReview.TabIndex = 8;
            // 
            // productReviewControl1
            // 
            this.productReviewControl1.BackColor = System.Drawing.Color.White;
            this.productReviewControl1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productReviewControl1.Location = new System.Drawing.Point(5, 6);
            this.productReviewControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.productReviewControl1.Name = "productReviewControl1";
            this.productReviewControl1.Size = new System.Drawing.Size(617, 131);
            this.productReviewControl1.TabIndex = 0;
            // 
            // ProductViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductViewerControl";
            this.Size = new System.Drawing.Size(1000, 2093);
            this.Load += new System.EventHandler(this.ProductViewerControl_Load);
            this.flowHeader.ResumeLayout(false);
            this.flowHeader.PerformLayout();
            this.flowProductImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPictures)).EndInit();
            this.flowContainer.ResumeLayout(false);
            this.flowContainer.PerformLayout();
            this.flowActions.ResumeLayout(false);
            this.flowDescription.ResumeLayout(false);
            this.flowDescription.PerformLayout();
            this.flowSpecifications.ResumeLayout(false);
            this.flowReviewHeader.ResumeLayout(false);
            this.panelRatingInfoContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowReviews.ResumeLayout(false);
            this.flowVariantDescription.ResumeLayout(false);
            this.flowVariantDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowHeader;
        private System.Windows.Forms.LinkLabel llblHeaderCategory;
        private System.Windows.Forms.Label lblHeaderEmbed1;
        private System.Windows.Forms.LinkLabel llblHeaderBrand;
        private System.Windows.Forms.Label lblHeaderEmbed2;
        private System.Windows.Forms.Label lblHeaderProductName;
        private System.Windows.Forms.Label lblProductName;
        private ImagePanelPicker imgPicker;
        private System.Windows.Forms.PictureBox productPictures;
        private System.Windows.Forms.FlowLayoutPanel flowProductImages;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.FlowLayoutPanel flowVariants;
        private System.Windows.Forms.FlowLayoutPanel flowActions;
        private CustomComponents.RoundedButton btnBuy;
        private CustomComponents.RoundedButton btnAddCart;
        private CustomComponents.RoundedButton btnEdit;
        private System.Windows.Forms.Label lblVariantDescription;
        private CustomControls.RoundedFlowLayoutPanel flowVariantDescription;
        private CustomControls.CardSlider cardProductSimilar;
        private System.Windows.Forms.FlowLayoutPanel flowDescription;
        private System.Windows.Forms.FlowLayoutPanel flowSpecifications;
        private System.Windows.Forms.Label lblTitleDescription;
        private System.Windows.Forms.Label lblDesctiptionValue;
        private System.Windows.Forms.Label lblTitleSpecifications;
        private System.Windows.Forms.ListView listViewSpecifications;
        private System.Windows.Forms.FlowLayoutPanel flowReviewHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRatingInfoContainer;
        private System.Windows.Forms.Label lblRatingTotal;
        private System.Windows.Forms.Label lblRatingAverage;
        private RatingBar ratingBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblNoRating1;
        private RatingBar ratingBar2;
        private System.Windows.Forms.Label lblNoRating2;
        private RatingBar ratingBar3;
        private System.Windows.Forms.Label lblNoRating3;
        private RatingBar ratingBar4;
        private System.Windows.Forms.Label lblNoRating4;
        private RatingBar ratingBar5;
        private System.Windows.Forms.Label lblNoRating5;
        private System.Windows.Forms.ColumnHeader specKey;
        private System.Windows.Forms.ColumnHeader specValue;
        private PaginationSelector pagingUserReview;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private ProductReviewControl productReviewControl1;
    }
}
