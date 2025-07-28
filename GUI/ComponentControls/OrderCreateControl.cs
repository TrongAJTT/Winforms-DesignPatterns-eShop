using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.Connect;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.GUI.MainControls.Auth;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Decorator.PriceCalculator;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class OrderCreateControl : UserControl
    {
        private List<CartItem> itemLists;
        private CouponDTO appliedCoupon;
        private RewardPointDTO rewardPoint;
        private UserAddressDTO address;

        private long totalPrice, finalPrice;
        private uint couponDiscountQuantity = 0 , rewardPointUsed = 0;

        public OrderCreateControl(
            List<CartItem> itemLists,
            CouponDTO coupon = null,
            bool useRewardPoint = false)
        {
            InitializeComponent();
            this.itemLists = itemLists;
            this.appliedCoupon = coupon;
            toggleReward.Checked = useRewardPoint;

            var maxSize = flowContainer.MaximumSize;
            maxSize.Width = 970;
            flowContainer.MaximumSize = maxSize;
            flowContainer.AutoSize = true;
            flowContainer.Anchor = AnchorStyles.Top;
        }

        private void OrderCreateControl_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadOrderProducts();
            LoadCouponAndReward();
            SetUpAddress();
        }

        private void LoadOrderProducts()
        {
            foreach (var item in itemLists)
            {
                var orderProd = new OrderProductBuilder()
                    .SetProductId(item.Variant.ProductId)
                    .SetVariantId(item.Variant.Id)
                    .SetQuantity((byte)item.Quantity)
                    .SetOriginalPrice((uint)item.Variant.Price)
                    .SetFinalPrice((uint)item.Variant.DiscountPrice)
                    .Build();
                var orderProductControl = new UserOrderProductControl(orderProd);
                orderProductControl.Margin = new Padding(5, 0, 5, 10);
                orderProductControl.Width -= 10;
                flowOrderDetails.Controls.Add(orderProductControl);
            }
            flowOrderDetails.Controls.SetChildIndex(
                titleTotalPrice, 
                flowOrderDetails.Controls.Count-1);
            CalcTotalPrice();
        }

        private void LoadCouponAndReward()
        {
            rewardPoint = MainForm.RewardPoint;
            if (rewardPoint != null)
            {
                valueReward.Text = StringUtil.FormatCurrency(rewardPoint.Point);
            }

            if (appliedCoupon != null)
            {
                txtCoupon.Focus();
                txtCoupon.Texts = appliedCoupon.Id.ToString();
                btnApplyCoupon.PerformClick();
            }
        }

        private void SetUpAddress()
        {
            UserAddressBLL addressBll = new UserAddressBLL(new UserAddressDAO());
            var listAddress = addressBll.GetAddressOfUser(MainForm.User.Id);
            foreach (var item in listAddress)
            {
                if (item.IsDefault)
                {
                    address = item;
                    break;
                }
            }
            LoadAddress();
        }

        private void LoadAddress()
        {
            if (address != null)
            {
                userAddressControl.Value = address;
                return;
            }
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            // Chế độ áp mã
            if (txtCoupon.Enabled)
            {
                if (string.IsNullOrEmpty(txtCoupon.Texts))
                {
                    MySystem.ShowToastMessageAtTopRight("Vui lòng nhập mã giảm giá", CustomControls.ToastBox.enmType.Warning);
                    return;
                }
                var bll = new CouponBLL(new CouponDAO());
                appliedCoupon = bll.ApplyCoupon(txtCoupon.Texts);
                // Áp mã thành công
                if (appliedCoupon != null)
                {
                    txtCoupon.Enabled = false;
                    btnApplyCoupon.Text = "Hủy";
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
                txtCoupon.Enabled = true;
                btnApplyCoupon.Text = "Áp";
                CalcFinalPrice();
            }
        }

        private void btnChangeUserAddress_Click(object sender, EventArgs e)
        {
            UserAddressPicker picker = new UserAddressPicker();
            picker.ShowDialog();
            if (picker.DialogResult == DialogResult.OK)
            {
                address = picker.PickedAddress;
                LoadAddress();
            }
        }

        private void CalcTotalPrice()
        {
            totalPrice = 0;
            foreach (var item in itemLists)
            {
                totalPrice += item.Variant.DiscountPrice * item.Quantity;
            }
            titleTotalPrice.Text = $"Thành tiền: {StringUtil.FormatCurrency(totalPrice)}đ";
            titleTotalPrice.Visible = true;
            valuePriceTotal.LoadValue("Thành tiền", totalPrice);
            CalcFinalPrice();
        }

        private void toggleReward_CheckedChanged(object sender, EventArgs e)
        {
            CalcFinalPrice();
        }

        private void llblEula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MySystem.SetChildControl(new EULA(), "Điều khoản sử dụng");
        }

        private void CalcFinalPrice()
        {
            // Khởi tạo bộ tính giá gốc
            IPriceCalculator calculator = new BaseCartPriceCalculator(itemLists);

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
            else
            {
                rewardPointUsed = 0;
            }

            // Lấy kết quả cuối cùng
            finalPrice = Convert.ToInt64(calculator.CalculatePrice());
            valueFinalPrice.Text = $"{StringUtil.FormatCurrency(finalPrice)}đ";

            // Clear Flow Order Prices
            foreach (Control item in flowOrderPrices.Controls)
            {
                if (!item.Tag.ToString().Equals("not_remove"))
                {
                    item.Dispose();
                }
            }
            // Thêm các điều chỉnh vào Flow Order Prices
            foreach (var item in calculator.GetAdjustments())
            {
                if (item.Amount > 0)
                {
                    // Thêm điều chỉnh vào Flow Order Prices
                    var orderPriceControl = new OrderPriceDetailControl(item.Description, Convert.ToInt64(item.Amount), true);
                    orderPriceControl.Width = valuePriceTotal.Width;
                    orderPriceControl.Margin = valuePriceTotal.Margin;
                    orderPriceControl.Tag = string.Empty;
                    flowOrderPrices.Controls.Add(orderPriceControl);
                    // Lấy số lượng coupon và điểm thưởng đã dùng
                    if (item.Type == "Coupon")
                    {
                        couponDiscountQuantity = Convert.ToUInt32(item.Amount);
                    }
                    else if (item.Type == "RewardPoints")
                    {
                        rewardPointUsed = Convert.ToUInt32(item.Amount);
                    }
                }
            }

            // Cập nhật giá giảm
            lblReducePrice.Text = $"{StringUtil.FormatCurrency(totalPrice-finalPrice)}đ";
        }

        private async void btnCreateOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có địa chỉ giao hàng không
            if (address == null)
            {
                MySystem.ShowToastMessageAtTopRight("Vui lòng chọn địa chỉ giao hàng", CustomControls.ToastBox.enmType.Warning);
                return;
            }

            // Thiết lập để người dùng không thể tương tác với giao diện
            btnCreateOrder.Enabled = false;
            EmbedControl.SetVisibleBackButton(this, false);
            EmbedControl.SetLoadingForThisControl(this, "Đang tạo đơn hàng");

            // Tạo đơn hàng
            var orderDao = new OrderDAO();
            var orderBll = new OrderBLL(orderDao);
            var orderBuilder = new OrderBuilder()
                .SetUserId(MainForm.User.Id)
                .SetTotalPrice(totalPrice)
                .SetRewardPointsUsed(rewardPointUsed)
                .SetFinalPrice(finalPrice)
                .SetStatus(OrderDTO.STATUS_PROCESSING)
                .SetStatusDetail(string.Empty)
                .SetRecipientName(address.RecipientName)
                .SetRecipientPhone(address.RecipientPhone)
                .SetAdministrativeArea(address.AdministrativeArea)
                .SetStreetAddress(address.StreetAddress)
                .SetCouponDiscountQuantity(0);
            // Nếu có mã giảm giá thì thêm vào đơn hàng
            if (appliedCoupon != null)
            {
                orderBuilder.SetCouponUsed(appliedCoupon.Id);
                orderBuilder.SetCouponDiscountQuantity((uint)couponDiscountQuantity);
                // Cập nhật lượt dùng của mã giảm giá
                var couponDao = new CouponDAO();
                appliedCoupon.RemainingUses--;
                couponDao.Update(appliedCoupon.Id, appliedCoupon);
            }

            var order = orderDao.Add(orderBuilder.Build());

            // Xử lý nhật ký đơn hàng
            EmbedControl.UpdateLoadingMessageForThisControl(this, "Đang xử lý nhật ký đơn hàng");
            var orderLogDao = new OrderLogDAO();
            await Task.Run(() =>
            {
                var orderLog = new OrderLogBuilder()
                .SetOrderId(order.Id)
                .SetStatus(OrderDTO.STATUS_PROCESSING)
                .SetStatusDetail(string.Empty)
                .SetCreatedAt(DateTime.Now)
                .Build();
                orderLogDao.Add(orderLog);
            });

            // Xử lý chi tiết đơn hàng
            EmbedControl.UpdateLoadingMessageForThisControl(this, "Đang xử lý chi tiết đơn hàng");
            var orderProductDao = new OrderProductDAO();
            await Task.Run(() =>
            {
                foreach (var item in itemLists)
                {
                    var orderProduct = new OrderProductBuilder()
                        .SetOrderId(order.Id)
                        .SetProductId(item.Variant.ProductId)
                        .SetVariantId(item.Variant.Id)
                        .SetQuantity((byte)item.Quantity)
                        .SetOriginalPrice((uint)item.Variant.Price)
                        .SetFinalPrice((uint)item.Variant.DiscountPrice)
                        .Build();
                    orderProductDao.Add(orderProduct);
                }
            });

            // Xóa các sản phẩm đã đặt ở trang giỏ hàng
            EmbedControl.UpdateLoadingMessageForThisControl(this, "Đang xử lý các bước cuối cùng");
            var embed = EmbedControl.GetEmbedControl(this);
            embed.OnCallBack?.Invoke(null, null);

            // Gửi email thông báo đơn hàng
            _ = await EmailHandler.SendEmailCreateOrder(MainForm.User.Email, order, itemLists.ToArray());

            // Chờ 1s để Control khác dọn dẹp giao diện
            await Task.Delay(1000);

            // Hiện thông báo thành công
            MySystem.ShowToastMessageAtTopRight("Tạo đơn hàng thành công", CustomControls.ToastBox.enmType.Success);
            embed.BackToParent();
        }
    }
}
