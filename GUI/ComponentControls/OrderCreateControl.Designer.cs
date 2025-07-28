namespace _3S_eShop.GUI.ComponentControls
{
    partial class OrderCreateControl
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
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowAddress = new System.Windows.Forms.Panel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.flowOrderDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.titleOrderLog = new System.Windows.Forms.Label();
            this.titleTotalPrice = new System.Windows.Forms.Label();
            this.flowPaymentMethods = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePaymentMethod = new System.Windows.Forms.Label();
            this.flowCouponAndRewards = new System.Windows.Forms.FlowLayoutPanel();
            this.titleCouponAndReward = new System.Windows.Forms.Label();
            this.pnlCoupon = new System.Windows.Forms.Panel();
            this.pnlReward = new System.Windows.Forms.Panel();
            this.valueReward = new System.Windows.Forms.Label();
            this.titleReward = new System.Windows.Forms.Label();
            this.flowOrderPrices = new System.Windows.Forms.FlowLayoutPanel();
            this.titleOrderPrices = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.flowEula = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmbed1 = new System.Windows.Forms.Label();
            this.llblEula = new System.Windows.Forms.LinkLabel();
            this.lblEmbed2 = new System.Windows.Forms.Label();
            this.flowFinal = new System.Windows.Forms.FlowLayoutPanel();
            this.valueFinalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowReduce = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReducePrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChangeUserAddress = new _3S_eShop.CustomComponents.RoundedButton();
            this.userAddressControl = new _3S_eShop.GUI.ComponentControls.UserAddressControl();
            this.rdoCOD = new _3S_eShop.CustomComponents.ColoredRadioButton();
            this.txtCoupon = new _3S_eShop.CustomComponents.AdvancedTextBox();
            this.btnApplyCoupon = new _3S_eShop.CustomComponents.RoundedButton();
            this.toggleReward = new _3S_eShop.CustomComponents.ToggleButton();
            this.valuePriceTotal = new _3S_eShop.GUI.ComponentControls.OrderPriceDetailControl();
            this.btnCreateOrder = new _3S_eShop.CustomComponents.RoundedButton();
            this.flowContainer.SuspendLayout();
            this.flowAddress.SuspendLayout();
            this.flowOrderDetails.SuspendLayout();
            this.flowPaymentMethods.SuspendLayout();
            this.flowCouponAndRewards.SuspendLayout();
            this.pnlCoupon.SuspendLayout();
            this.pnlReward.SuspendLayout();
            this.flowOrderPrices.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.flowEula.SuspendLayout();
            this.flowFinal.SuspendLayout();
            this.flowReduce.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowContainer
            // 
            this.flowContainer.Controls.Add(this.flowAddress);
            this.flowContainer.Controls.Add(this.flowOrderDetails);
            this.flowContainer.Controls.Add(this.flowPaymentMethods);
            this.flowContainer.Controls.Add(this.flowCouponAndRewards);
            this.flowContainer.Controls.Add(this.flowOrderPrices);
            this.flowContainer.Controls.Add(this.pnlOrder);
            this.flowContainer.Location = new System.Drawing.Point(10, 0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Padding = new System.Windows.Forms.Padding(10);
            this.flowContainer.Size = new System.Drawing.Size(970, 1037);
            this.flowContainer.TabIndex = 0;
            // 
            // flowAddress
            // 
            this.flowAddress.BackColor = System.Drawing.SystemColors.Control;
            this.flowAddress.Controls.Add(this.btnChangeUserAddress);
            this.flowAddress.Controls.Add(this.userAddressControl);
            this.flowAddress.Controls.Add(this.lblOrderId);
            this.flowAddress.Location = new System.Drawing.Point(10, 10);
            this.flowAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowAddress.Name = "flowAddress";
            this.flowAddress.Size = new System.Drawing.Size(950, 231);
            this.flowAddress.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.Color.White;
            this.lblOrderId.Location = new System.Drawing.Point(0, 0);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOrderId.Size = new System.Drawing.Size(950, 42);
            this.lblOrderId.TabIndex = 3;
            this.lblOrderId.Text = "Thông tin giao hàng";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowOrderDetails
            // 
            this.flowOrderDetails.AutoSize = true;
            this.flowOrderDetails.BackColor = System.Drawing.SystemColors.Control;
            this.flowOrderDetails.Controls.Add(this.titleOrderLog);
            this.flowOrderDetails.Controls.Add(this.titleTotalPrice);
            this.flowOrderDetails.Location = new System.Drawing.Point(10, 261);
            this.flowOrderDetails.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowOrderDetails.Name = "flowOrderDetails";
            this.flowOrderDetails.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowOrderDetails.Size = new System.Drawing.Size(950, 99);
            this.flowOrderDetails.TabIndex = 1;
            // 
            // titleOrderLog
            // 
            this.titleOrderLog.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.titleOrderLog.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOrderLog.ForeColor = System.Drawing.Color.White;
            this.titleOrderLog.Location = new System.Drawing.Point(0, 0);
            this.titleOrderLog.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleOrderLog.Name = "titleOrderLog";
            this.titleOrderLog.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleOrderLog.Size = new System.Drawing.Size(950, 42);
            this.titleOrderLog.TabIndex = 2;
            this.titleOrderLog.Text = "Chi tiết đơn hàng";
            this.titleOrderLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTotalPrice
            // 
            this.titleTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.titleTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleTotalPrice.ForeColor = System.Drawing.Color.White;
            this.titleTotalPrice.Location = new System.Drawing.Point(0, 47);
            this.titleTotalPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleTotalPrice.Name = "titleTotalPrice";
            this.titleTotalPrice.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleTotalPrice.Size = new System.Drawing.Size(950, 42);
            this.titleTotalPrice.TabIndex = 3;
            this.titleTotalPrice.Text = "Thành tiền: 500.000đ";
            this.titleTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleTotalPrice.Visible = false;
            // 
            // flowPaymentMethods
            // 
            this.flowPaymentMethods.AutoSize = true;
            this.flowPaymentMethods.BackColor = System.Drawing.SystemColors.Control;
            this.flowPaymentMethods.Controls.Add(this.titlePaymentMethod);
            this.flowPaymentMethods.Controls.Add(this.rdoCOD);
            this.flowPaymentMethods.Location = new System.Drawing.Point(10, 380);
            this.flowPaymentMethods.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowPaymentMethods.Name = "flowPaymentMethods";
            this.flowPaymentMethods.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowPaymentMethods.Size = new System.Drawing.Size(950, 87);
            this.flowPaymentMethods.TabIndex = 3;
            // 
            // titlePaymentMethod
            // 
            this.titlePaymentMethod.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.titlePaymentMethod.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePaymentMethod.ForeColor = System.Drawing.Color.White;
            this.titlePaymentMethod.Location = new System.Drawing.Point(0, 0);
            this.titlePaymentMethod.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titlePaymentMethod.Name = "titlePaymentMethod";
            this.titlePaymentMethod.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titlePaymentMethod.Size = new System.Drawing.Size(950, 42);
            this.titlePaymentMethod.TabIndex = 2;
            this.titlePaymentMethod.Text = "Phương thức thanh toán";
            this.titlePaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowCouponAndRewards
            // 
            this.flowCouponAndRewards.AutoSize = true;
            this.flowCouponAndRewards.BackColor = System.Drawing.SystemColors.Control;
            this.flowCouponAndRewards.Controls.Add(this.titleCouponAndReward);
            this.flowCouponAndRewards.Controls.Add(this.pnlCoupon);
            this.flowCouponAndRewards.Controls.Add(this.pnlReward);
            this.flowCouponAndRewards.Location = new System.Drawing.Point(10, 487);
            this.flowCouponAndRewards.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowCouponAndRewards.Name = "flowCouponAndRewards";
            this.flowCouponAndRewards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowCouponAndRewards.Size = new System.Drawing.Size(950, 154);
            this.flowCouponAndRewards.TabIndex = 4;
            // 
            // titleCouponAndReward
            // 
            this.titleCouponAndReward.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.titleCouponAndReward.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCouponAndReward.ForeColor = System.Drawing.Color.White;
            this.titleCouponAndReward.Location = new System.Drawing.Point(0, 0);
            this.titleCouponAndReward.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleCouponAndReward.Name = "titleCouponAndReward";
            this.titleCouponAndReward.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titleCouponAndReward.Size = new System.Drawing.Size(950, 42);
            this.titleCouponAndReward.TabIndex = 2;
            this.titleCouponAndReward.Text = "Mã giảm giá && Điểm thưởng";
            this.titleCouponAndReward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCoupon
            // 
            this.pnlCoupon.Controls.Add(this.txtCoupon);
            this.pnlCoupon.Controls.Add(this.btnApplyCoupon);
            this.pnlCoupon.Location = new System.Drawing.Point(10, 51);
            this.pnlCoupon.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.pnlCoupon.Name = "pnlCoupon";
            this.pnlCoupon.Size = new System.Drawing.Size(925, 43);
            this.pnlCoupon.TabIndex = 13;
            // 
            // pnlReward
            // 
            this.pnlReward.Controls.Add(this.valueReward);
            this.pnlReward.Controls.Add(this.titleReward);
            this.pnlReward.Controls.Add(this.toggleReward);
            this.pnlReward.Location = new System.Drawing.Point(10, 102);
            this.pnlReward.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.pnlReward.Name = "pnlReward";
            this.pnlReward.Size = new System.Drawing.Size(925, 43);
            this.pnlReward.TabIndex = 5;
            // 
            // valueReward
            // 
            this.valueReward.AutoSize = true;
            this.valueReward.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.valueReward.Location = new System.Drawing.Point(275, 9);
            this.valueReward.Name = "valueReward";
            this.valueReward.Size = new System.Drawing.Size(68, 25);
            this.valueReward.TabIndex = 12;
            this.valueReward.Text = "x điểm";
            // 
            // titleReward
            // 
            this.titleReward.AutoSize = true;
            this.titleReward.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleReward.Location = new System.Drawing.Point(4, 9);
            this.titleReward.Name = "titleReward";
            this.titleReward.Size = new System.Drawing.Size(210, 25);
            this.titleReward.TabIndex = 11;
            this.titleReward.Text = "Sử dụng điểm thưởng";
            // 
            // flowOrderPrices
            // 
            this.flowOrderPrices.AutoSize = true;
            this.flowOrderPrices.BackColor = System.Drawing.SystemColors.Control;
            this.flowOrderPrices.Controls.Add(this.titleOrderPrices);
            this.flowOrderPrices.Controls.Add(this.valuePriceTotal);
            this.flowOrderPrices.Location = new System.Drawing.Point(10, 661);
            this.flowOrderPrices.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowOrderPrices.Name = "flowOrderPrices";
            this.flowOrderPrices.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowOrderPrices.Size = new System.Drawing.Size(950, 89);
            this.flowOrderPrices.TabIndex = 5;
            // 
            // titleOrderPrices
            // 
            this.titleOrderPrices.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.titleOrderPrices.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOrderPrices.ForeColor = System.Drawing.Color.White;
            this.titleOrderPrices.Location = new System.Drawing.Point(0, 0);
            this.titleOrderPrices.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleOrderPrices.Name = "titleOrderPrices";
            this.titleOrderPrices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titleOrderPrices.Size = new System.Drawing.Size(950, 42);
            this.titleOrderPrices.TabIndex = 2;
            this.titleOrderPrices.Tag = "not_remove";
            this.titleOrderPrices.Text = "Chi tiết thanh toán";
            this.titleOrderPrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.btnCreateOrder);
            this.pnlOrder.Controls.Add(this.flowEula);
            this.pnlOrder.Controls.Add(this.flowFinal);
            this.pnlOrder.Controls.Add(this.flowReduce);
            this.pnlOrder.Location = new System.Drawing.Point(10, 770);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(950, 166);
            this.pnlOrder.TabIndex = 6;
            // 
            // flowEula
            // 
            this.flowEula.AutoSize = true;
            this.flowEula.BackColor = System.Drawing.Color.White;
            this.flowEula.Controls.Add(this.lblEmbed1);
            this.flowEula.Controls.Add(this.llblEula);
            this.flowEula.Controls.Add(this.lblEmbed2);
            this.flowEula.Location = new System.Drawing.Point(0, 0);
            this.flowEula.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowEula.Name = "flowEula";
            this.flowEula.Padding = new System.Windows.Forms.Padding(5);
            this.flowEula.Size = new System.Drawing.Size(950, 55);
            this.flowEula.TabIndex = 6;
            // 
            // lblEmbed1
            // 
            this.lblEmbed1.AutoSize = true;
            this.lblEmbed1.Location = new System.Drawing.Point(8, 5);
            this.lblEmbed1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmbed1.Name = "lblEmbed1";
            this.lblEmbed1.Size = new System.Drawing.Size(477, 25);
            this.lblEmbed1.TabIndex = 0;
            this.lblEmbed1.Text = "Khi nhấn nút \'Đặt hàng\', bạn xác nhận rằng bạn đồng ý với";
            // 
            // llblEula
            // 
            this.llblEula.AutoSize = true;
            this.llblEula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblEula.Location = new System.Drawing.Point(485, 5);
            this.llblEula.Margin = new System.Windows.Forms.Padding(0);
            this.llblEula.Name = "llblEula";
            this.llblEula.Size = new System.Drawing.Size(102, 25);
            this.llblEula.TabIndex = 2;
            this.llblEula.TabStop = true;
            this.llblEula.Text = "Điều khoản";
            this.llblEula.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEula_LinkClicked);
            // 
            // lblEmbed2
            // 
            this.lblEmbed2.AutoSize = true;
            this.lblEmbed2.Location = new System.Drawing.Point(587, 5);
            this.lblEmbed2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblEmbed2.Name = "lblEmbed2";
            this.lblEmbed2.Size = new System.Drawing.Size(124, 25);
            this.lblEmbed2.TabIndex = 1;
            this.lblEmbed2.Text = "của 3S eShop.";
            // 
            // flowFinal
            // 
            this.flowFinal.AutoSize = true;
            this.flowFinal.BackColor = System.Drawing.Color.White;
            this.flowFinal.Controls.Add(this.valueFinalPrice);
            this.flowFinal.Controls.Add(this.label6);
            this.flowFinal.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowFinal.Location = new System.Drawing.Point(521, 78);
            this.flowFinal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowFinal.Name = "flowFinal";
            this.flowFinal.Padding = new System.Windows.Forms.Padding(5);
            this.flowFinal.Size = new System.Drawing.Size(258, 35);
            this.flowFinal.TabIndex = 7;
            // 
            // valueFinalPrice
            // 
            this.valueFinalPrice.AutoSize = true;
            this.valueFinalPrice.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.valueFinalPrice.Location = new System.Drawing.Point(161, 5);
            this.valueFinalPrice.Name = "valueFinalPrice";
            this.valueFinalPrice.Size = new System.Drawing.Size(84, 25);
            this.valueFinalPrice.TabIndex = 4;
            this.valueFinalPrice.Text = "15.000đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng cộng:";
            // 
            // flowReduce
            // 
            this.flowReduce.AutoSize = true;
            this.flowReduce.BackColor = System.Drawing.Color.White;
            this.flowReduce.Controls.Add(this.lblReducePrice);
            this.flowReduce.Controls.Add(this.label9);
            this.flowReduce.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowReduce.Location = new System.Drawing.Point(589, 111);
            this.flowReduce.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowReduce.Name = "flowReduce";
            this.flowReduce.Padding = new System.Windows.Forms.Padding(5);
            this.flowReduce.Size = new System.Drawing.Size(190, 30);
            this.flowReduce.TabIndex = 8;
            // 
            // lblReducePrice
            // 
            this.lblReducePrice.AutoSize = true;
            this.lblReducePrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReducePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblReducePrice.Location = new System.Drawing.Point(110, 5);
            this.lblReducePrice.Name = "lblReducePrice";
            this.lblReducePrice.Size = new System.Drawing.Size(67, 20);
            this.lblReducePrice.TabIndex = 4;
            this.lblReducePrice.Text = "15.000đ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(31, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiết kiệm:";
            // 
            // btnChangeUserAddress
            // 
            this.btnChangeUserAddress.BackColor = System.Drawing.Color.White;
            this.btnChangeUserAddress.BackgroundColor = System.Drawing.Color.White;
            this.btnChangeUserAddress.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChangeUserAddress.BorderRadius = 15;
            this.btnChangeUserAddress.BorderSize = 0;
            this.btnChangeUserAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUserAddress.FlatAppearance.BorderSize = 0;
            this.btnChangeUserAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUserAddress.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUserAddress.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChangeUserAddress.Location = new System.Drawing.Point(871, 5);
            this.btnChangeUserAddress.Name = "btnChangeUserAddress";
            this.btnChangeUserAddress.Size = new System.Drawing.Size(74, 32);
            this.btnChangeUserAddress.TabIndex = 5;
            this.btnChangeUserAddress.Text = "Đổi";
            this.btnChangeUserAddress.TextColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChangeUserAddress.UseVisualStyleBackColor = false;
            this.btnChangeUserAddress.Click += new System.EventHandler(this.btnChangeUserAddress_Click);
            // 
            // userAddressControl
            // 
            this.userAddressControl.AllowEdit = true;
            this.userAddressControl.ContainerBackColor = System.Drawing.Color.White;
            this.userAddressControl.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.userAddressControl.EnableContextMenu = true;
            this.userAddressControl.EnablePickButton = false;
            this.userAddressControl.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAddressControl.Location = new System.Drawing.Point(5, 46);
            this.userAddressControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userAddressControl.Name = "userAddressControl";
            this.userAddressControl.Size = new System.Drawing.Size(940, 179);
            this.userAddressControl.TabIndex = 4;
            this.userAddressControl.Value = null;
            // 
            // rdoCOD
            // 
            this.rdoCOD.AutoSize = true;
            this.rdoCOD.Checked = true;
            this.rdoCOD.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdoCOD.Location = new System.Drawing.Point(10, 50);
            this.rdoCOD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rdoCOD.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoCOD.Name = "rdoCOD";
            this.rdoCOD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoCOD.Size = new System.Drawing.Size(266, 29);
            this.rdoCOD.TabIndex = 4;
            this.rdoCOD.TabStop = true;
            this.rdoCOD.Text = "Trả tiền khi nhận hàng (COD)";
            this.rdoCOD.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoCOD.UseVisualStyleBackColor = true;
            // 
            // txtCoupon
            // 
            this.txtCoupon.BackColor = System.Drawing.SystemColors.Window;
            this.txtCoupon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.txtCoupon.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCoupon.BorderRadius = 0;
            this.txtCoupon.BorderSize = 2;
            this.txtCoupon.ContentAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCoupon.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCoupon.InputCharacterValidator = null;
            this.txtCoupon.Location = new System.Drawing.Point(0, 1);
            this.txtCoupon.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.txtCoupon.Multiline = false;
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCoupon.PasswordChar = false;
            this.txtCoupon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCoupon.PlaceholderText = "Nhập mã giảm giá (nếu có)";
            this.txtCoupon.Size = new System.Drawing.Size(238, 40);
            this.txtCoupon.TabIndex = 11;
            this.txtCoupon.Texts = "";
            this.txtCoupon.UnderlinedStyle = false;
            this.txtCoupon.Valid = null;
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.BackColor = System.Drawing.Color.White;
            this.btnApplyCoupon.BackgroundColor = System.Drawing.Color.White;
            this.btnApplyCoupon.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApplyCoupon.BorderRadius = 15;
            this.btnApplyCoupon.BorderSize = 0;
            this.btnApplyCoupon.FlatAppearance.BorderSize = 0;
            this.btnApplyCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyCoupon.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyCoupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnApplyCoupon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyCoupon.Location = new System.Drawing.Point(245, 1);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(62, 40);
            this.btnApplyCoupon.TabIndex = 12;
            this.btnApplyCoupon.Text = "Áp";
            this.btnApplyCoupon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnApplyCoupon.UseVisualStyleBackColor = false;
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);
            // 
            // toggleReward
            // 
            this.toggleReward.AutoSize = true;
            this.toggleReward.Location = new System.Drawing.Point(224, 11);
            this.toggleReward.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleReward.Name = "toggleReward";
            this.toggleReward.OffBackColor = System.Drawing.Color.Gray;
            this.toggleReward.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleReward.OnBackColor = System.Drawing.Color.LimeGreen;
            this.toggleReward.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleReward.Size = new System.Drawing.Size(45, 22);
            this.toggleReward.TabIndex = 10;
            this.toggleReward.UseVisualStyleBackColor = true;
            this.toggleReward.CheckedChanged += new System.EventHandler(this.toggleReward_CheckedChanged);
            // 
            // valuePriceTotal
            // 
            this.valuePriceTotal.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePriceTotal.Location = new System.Drawing.Point(10, 51);
            this.valuePriceTotal.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.valuePriceTotal.Name = "valuePriceTotal";
            this.valuePriceTotal.Size = new System.Drawing.Size(925, 29);
            this.valuePriceTotal.TabIndex = 3;
            this.valuePriceTotal.Tag = "not_remove";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreateOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnCreateOrder.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateOrder.BorderRadius = 15;
            this.btnCreateOrder.BorderSize = 0;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(785, 78);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(162, 63);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Đặt hàng";
            this.btnCreateOrder.TextColor = System.Drawing.Color.White;
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // OrderCreateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OrderCreateControl";
            this.Size = new System.Drawing.Size(1000, 1136);
            this.Load += new System.EventHandler(this.OrderCreateControl_Load);
            this.flowContainer.ResumeLayout(false);
            this.flowContainer.PerformLayout();
            this.flowAddress.ResumeLayout(false);
            this.flowOrderDetails.ResumeLayout(false);
            this.flowPaymentMethods.ResumeLayout(false);
            this.flowPaymentMethods.PerformLayout();
            this.flowCouponAndRewards.ResumeLayout(false);
            this.pnlCoupon.ResumeLayout(false);
            this.pnlReward.ResumeLayout(false);
            this.pnlReward.PerformLayout();
            this.flowOrderPrices.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.flowEula.ResumeLayout(false);
            this.flowEula.PerformLayout();
            this.flowFinal.ResumeLayout(false);
            this.flowFinal.PerformLayout();
            this.flowReduce.ResumeLayout(false);
            this.flowReduce.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Panel flowAddress;
        private CustomComponents.RoundedButton btnChangeUserAddress;
        private UserAddressControl userAddressControl;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.FlowLayoutPanel flowOrderDetails;
        private System.Windows.Forms.Label titleOrderLog;
        private System.Windows.Forms.FlowLayoutPanel flowPaymentMethods;
        private System.Windows.Forms.Label titlePaymentMethod;
        private System.Windows.Forms.FlowLayoutPanel flowCouponAndRewards;
        private System.Windows.Forms.Label titleCouponAndReward;
        private System.Windows.Forms.Panel pnlCoupon;
        private CustomComponents.AdvancedTextBox txtCoupon;
        private CustomComponents.RoundedButton btnApplyCoupon;
        private System.Windows.Forms.Panel pnlReward;
        private System.Windows.Forms.Label valueReward;
        private System.Windows.Forms.Label titleReward;
        private CustomComponents.ToggleButton toggleReward;
        private System.Windows.Forms.FlowLayoutPanel flowOrderPrices;
        private System.Windows.Forms.Label titleOrderPrices;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.FlowLayoutPanel flowEula;
        private CustomComponents.RoundedButton btnCreateOrder;
        private System.Windows.Forms.Label lblEmbed1;
        private System.Windows.Forms.LinkLabel llblEula;
        private System.Windows.Forms.Label lblEmbed2;
        private System.Windows.Forms.FlowLayoutPanel flowFinal;
        private System.Windows.Forms.Label valueFinalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowReduce;
        private System.Windows.Forms.Label lblReducePrice;
        private System.Windows.Forms.Label label9;
        private CustomComponents.ColoredRadioButton rdoCOD;
        private System.Windows.Forms.Label titleTotalPrice;
        private OrderPriceDetailControl valuePriceTotal;
    }
}
