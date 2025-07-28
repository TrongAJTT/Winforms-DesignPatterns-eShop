namespace _3S_eShop.GUI.MainControls
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.mainContainer = new System.Windows.Forms.Panel();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowSubBanner = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFiller = new System.Windows.Forms.Panel();
            this.mainBanner = new _3S_eShop.GUI.ComponentControls.BannerMainControl();
            this.cardSales = new _3S_eShop.CustomControls.CardSlider();
            this.cardNew = new _3S_eShop.CustomControls.CardSlider();
            this.cardRecent = new _3S_eShop.CustomControls.CardSlider();
            this.mainContainer.SuspendLayout();
            this.flowMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainContainer.Controls.Add(this.flowMain);
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1000, 2354);
            this.mainContainer.TabIndex = 1;
            // 
            // flowMain
            // 
            this.flowMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowMain.AutoScroll = true;
            this.flowMain.Controls.Add(this.mainBanner);
            this.flowMain.Controls.Add(this.flowSubBanner);
            this.flowMain.Controls.Add(this.cardSales);
            this.flowMain.Controls.Add(this.cardNew);
            this.flowMain.Controls.Add(this.cardRecent);
            this.flowMain.Controls.Add(this.panelFiller);
            this.flowMain.Location = new System.Drawing.Point(0, 0);
            this.flowMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowMain.Name = "flowMain";
            this.flowMain.Size = new System.Drawing.Size(1015, 2369);
            this.flowMain.TabIndex = 11;
            // 
            // flowSubBanner
            // 
            this.flowSubBanner.BackColor = System.Drawing.Color.LightCyan;
            this.flowSubBanner.Location = new System.Drawing.Point(0, 373);
            this.flowSubBanner.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.flowSubBanner.Name = "flowSubBanner";
            this.flowSubBanner.Padding = new System.Windows.Forms.Padding(10);
            this.flowSubBanner.Size = new System.Drawing.Size(1000, 133);
            this.flowSubBanner.TabIndex = 9;
            // 
            // panelFiller
            // 
            this.panelFiller.Location = new System.Drawing.Point(3, 2071);
            this.panelFiller.Name = "panelFiller";
            this.panelFiller.Size = new System.Drawing.Size(224, 25);
            this.panelFiller.TabIndex = 14;
            // 
            // mainBanner
            // 
            this.mainBanner.BackColor = System.Drawing.Color.Transparent;
            this.mainBanner.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBanner.Location = new System.Drawing.Point(0, 0);
            this.mainBanner.Margin = new System.Windows.Forms.Padding(0);
            this.mainBanner.Name = "mainBanner";
            this.mainBanner.Size = new System.Drawing.Size(1000, 353);
            this.mainBanner.TabIndex = 10;
            // 
            // cardSales
            // 
            this.cardSales.ActionButtonEnable = true;
            this.cardSales.BackColor = System.Drawing.Color.Transparent;
            this.cardSales.BorderRadius = 15;
            this.cardSales.ButtonCursor = System.Windows.Forms.Cursors.Default;
            this.cardSales.ChildSize = new System.Drawing.Size(202, 310);
            this.cardSales.ChildSpacing = 15;
            this.cardSales.ContainerColor = System.Drawing.Color.White;
            this.cardSales.ContainerPadding = new System.Windows.Forms.Padding(15);
            this.cardSales.CustomLabelEnable = true;
            this.cardSales.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardSales.LayoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardSales.LeadingImage = ((System.Drawing.Image)(resources.GetObject("cardSales.LeadingImage")));
            this.cardSales.Location = new System.Drawing.Point(10, 546);
            this.cardSales.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.cardSales.MaxChildren = 10;
            this.cardSales.Name = "cardSales";
            this.cardSales.NavButtonColor = System.Drawing.Color.White;
            this.cardSales.NavButtonRadius = 15;
            this.cardSales.NavButtonSize = 40;
            this.cardSales.NavLeftImage = ((System.Drawing.Image)(resources.GetObject("cardSales.NavLeftImage")));
            this.cardSales.NavRightImage = ((System.Drawing.Image)(resources.GetObject("cardSales.NavRightImage")));
            this.cardSales.OuterSpace = 15;
            this.cardSales.Size = new System.Drawing.Size(980, 474);
            this.cardSales.TabIndex = 11;
            this.cardSales.TextColor = System.Drawing.Color.White;
            this.cardSales.Title = "ĐANG GIẢM GIÁ";
            this.cardSales.TitleFont = new System.Drawing.Font("Segoe UI Black", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardSales.TitleSpacing = 3;
            // 
            // cardNew
            // 
            this.cardNew.ActionButtonEnable = true;
            this.cardNew.BackColor = System.Drawing.Color.Transparent;
            this.cardNew.BorderRadius = 15;
            this.cardNew.ButtonCursor = System.Windows.Forms.Cursors.Default;
            this.cardNew.ChildSize = new System.Drawing.Size(202, 310);
            this.cardNew.ChildSpacing = 15;
            this.cardNew.ContainerColor = System.Drawing.Color.White;
            this.cardNew.ContainerPadding = new System.Windows.Forms.Padding(15);
            this.cardNew.CustomLabelEnable = true;
            this.cardNew.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNew.LayoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardNew.LeadingImage = ((System.Drawing.Image)(resources.GetObject("cardNew.LeadingImage")));
            this.cardNew.Location = new System.Drawing.Point(10, 1060);
            this.cardNew.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.cardNew.MaxChildren = 10;
            this.cardNew.Name = "cardNew";
            this.cardNew.NavButtonColor = System.Drawing.Color.White;
            this.cardNew.NavButtonRadius = 15;
            this.cardNew.NavButtonSize = 40;
            this.cardNew.NavLeftImage = ((System.Drawing.Image)(resources.GetObject("cardNew.NavLeftImage")));
            this.cardNew.NavRightImage = ((System.Drawing.Image)(resources.GetObject("cardNew.NavRightImage")));
            this.cardNew.OuterSpace = 15;
            this.cardNew.Size = new System.Drawing.Size(980, 474);
            this.cardNew.TabIndex = 12;
            this.cardNew.TextColor = System.Drawing.Color.White;
            this.cardNew.Title = "SẢN PHẨM MỚI";
            this.cardNew.TitleFont = new System.Drawing.Font("Segoe UI Black", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNew.TitleSpacing = 3;
            // 
            // cardRecent
            // 
            this.cardRecent.ActionButtonEnable = true;
            this.cardRecent.BackColor = System.Drawing.Color.Transparent;
            this.cardRecent.BorderRadius = 15;
            this.cardRecent.ButtonCursor = System.Windows.Forms.Cursors.Default;
            this.cardRecent.ChildSize = new System.Drawing.Size(202, 310);
            this.cardRecent.ChildSpacing = 15;
            this.cardRecent.ContainerColor = System.Drawing.Color.White;
            this.cardRecent.ContainerPadding = new System.Windows.Forms.Padding(15);
            this.cardRecent.CustomLabelEnable = true;
            this.cardRecent.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardRecent.LayoutColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.cardRecent.LeadingImage = ((System.Drawing.Image)(resources.GetObject("cardRecent.LeadingImage")));
            this.cardRecent.Location = new System.Drawing.Point(10, 1574);
            this.cardRecent.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.cardRecent.MaxChildren = 10;
            this.cardRecent.Name = "cardRecent";
            this.cardRecent.NavButtonColor = System.Drawing.Color.White;
            this.cardRecent.NavButtonRadius = 15;
            this.cardRecent.NavButtonSize = 40;
            this.cardRecent.NavLeftImage = ((System.Drawing.Image)(resources.GetObject("cardRecent.NavLeftImage")));
            this.cardRecent.NavRightImage = ((System.Drawing.Image)(resources.GetObject("cardRecent.NavRightImage")));
            this.cardRecent.OuterSpace = 15;
            this.cardRecent.Size = new System.Drawing.Size(980, 474);
            this.cardRecent.TabIndex = 13;
            this.cardRecent.TextColor = System.Drawing.Color.White;
            this.cardRecent.Title = "ĐÃ XEM GẦN ĐÂY";
            this.cardRecent.TitleFont = new System.Drawing.Font("Segoe UI Black", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardRecent.TitleSpacing = 3;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1000, 2354);
            this.mainContainer.ResumeLayout(false);
            this.flowMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private ComponentControls.BannerMainControl mainBannerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowSubBanner;
        private ComponentControls.BannerMainControl mainBanner;
        private CustomControls.CardSlider cardSales;
        private CustomControls.CardSlider cardNew;
        private CustomControls.CardSlider cardRecent;
        private System.Windows.Forms.Panel panelFiller;
    }
}
