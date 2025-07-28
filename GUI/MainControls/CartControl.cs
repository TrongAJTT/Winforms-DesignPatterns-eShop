using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.PatternDistinctive.Decorator.PriceCalculator;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class CartControl : UserControl
    {
        private List<CartControlComponent> cartControls = new List<CartControlComponent>();
        private List<CartItem> cartItems = new List<CartItem>();
        private readonly RewardPointDTO rewardPoint;
        private CouponDTO appliedCoupon;

        private long totalPrice, finalPrice;

        public CartControl()
        {
            InitializeComponent();

            valueFinalPrice.Text = "0đ";

            txtVoucher.InputCharacterValidator = new NumberOnlyCharacterStrategy();

            rewardPoint = MainForm.RewardPoint;
            if (rewardPoint != null)
            {
                valueReward.Text = StringUtil.FormatCurrency(rewardPoint.Point);
            }
            else
            {
                valueReward.Text = "Không khả dụng với khách vãn lai";
                toggleReward.Enabled = false;
            }
        }

        private void LoadData()
        {
            // Lấy danh sách sản phẩm trong giỏ hàng
            flowCartItems.Controls.Clear();
            var cartProducts = MySystem.CartHelper.Read();
            if (cartProducts == null || cartProducts.Count == 0)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.no_data_found;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(flowCartItems.Width - 20, 300);
                flowCartItems.Controls.Add(pictureBox);
                valueFinalPrice.Text = "0đ";
                return;
            }
            else
            {
                foreach (var cartProduct in cartProducts)
                {
                    var cartControl = new CartControlComponent(cartProduct);
                    cartControl.Width = flowCartItems.Width - 30;
                    cartControl.Margin = new Padding(5);
                    cartControl.NotifyUpdate += (s, e) => CalcPrice();
                    cartControl.NotifyDataChange += (s, e) => LoadData();
                    flowCartItems.Controls.Add(cartControl);
                    cartControls.Add(cartControl);
                }
                CalcPrice();
            }
        }

        private void CalcPrice()
        {
            CalcTotalPrice();
            CalcFinalPrice();
        }

        private void CalcTotalPrice()
        {
            totalPrice = 0;
            cartItems.Clear();
            foreach (var item in cartControls)
            {
                if (item.IsSelected)
                {
                    cartItems.Add(item.Value);
                    totalPrice += item.Value.Variant.DiscountPrice * item.Quantity;
                }
            }
        }

        private void CalcFinalPrice()
        {
            // Khởi tạo bộ tính giá gốc
            IPriceCalculator calculator = new BaseCartPriceCalculator(cartItems);

            // --- Áp dụng Decorator (theo đúng thứ tự!) ---
            // Thêm kiểm tra coupon hợp lệ
            if (appliedCoupon != null) 
            {
                // Kiểm tra xem coupon có áp dụng được không (ví dụ: còn lượt dùng, còn hạn,...)
                calculator = new CouponDiscountDecorator(calculator, appliedCoupon);
            }

            if (rewardPoint != null && toggleReward.Checked)
            {
                decimal pointsRate = 1.0m; // 1 điểm = 1 VNĐ
                calculator = new RewardPointsDecorator(calculator, rewardPoint.Point, rewardPoint.Point, pointsRate);
            }

            // Lấy kết quả cuối cùng
            finalPrice = Convert.ToInt64(calculator.CalculatePrice());
            valueFinalPrice.Text = $"{StringUtil.FormatCurrency(finalPrice)}đ";
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toggleReward_CheckedChanged(object sender, EventArgs e)
        {
            CalcPrice();
        }

        private void CartControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            // Chế độ áp mã
            if (txtVoucher.Enabled)
            {
                if (string.IsNullOrEmpty(txtVoucher.Texts))
                {
                    MySystem.ShowToastMessageAtTopRight("Vui lòng nhập mã giảm giá", CustomControls.ToastBox.enmType.Warning);
                    return;
                }
                var bll = new CouponBLL(new CouponDAO());
                appliedCoupon = bll.ApplyCoupon(txtVoucher.Texts);
                // Áp mã thành công
                if (appliedCoupon != null)
                {
                    txtVoucher.Enabled = false;
                    btnApplyVoucher.Text = "Hủy";
                    MySystem.ShowToastMessageAtTopRight("Áp dụng mã thành công");
                    CalcFinalPrice();
                }
                else
                {
                    MySystem.ShowToastMessageAtTopRight("Mã không hợp lệ hoặc đã hết hạn sử dụng", CustomControls.ToastBox.enmType.Error);
                }
            }
            // Chế độ xóa mã
            else
            {
                appliedCoupon = null;
                txtVoucher.Enabled = true;
                btnApplyVoucher.Text = "Áp";
                CalcFinalPrice();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MySystem.ShowToastMessageAtTopRight("Vui lòng chọn sản phẩm để thanh toán", CustomControls.ToastBox.enmType.Warning);
                return;
            }
            else
            {
                // Tạo đơn hàng và lấy trang nhúng
                EmbedControl embed = MySystem.CreateOrder(cartItems, appliedCoupon, toggleReward.Checked);
                // Call back sẽ xóa các sản phẩm đã chọn
                embed.OnCallBack += (s, _e) =>
                {
                    cartItems.Clear();
                    foreach (var item in flowCartItems.Controls)
                    {
                        if (item is CartControlComponent cartControl)
                        {
                            if (cartControl.IsSelected)
                            {
                                cartControl.PerformDeleteWithoutNotify();
                            }
                        }
                    }
                    LoadData();
                };
            }
        }
    }
}
