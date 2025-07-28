using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.Connect;
using _3S_eShop.DAL.Database;
using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.Utilities
{
    internal class EmailHandler
    {
        public static void SendOtpSignUpEmail(String email, String otp)
        {
            // Gửi mã OTP qua email
            Task.Run(() =>
            {
                String msg = "Mã xác thực tài khoản 3S eShop của bạn là: " + otp + "\n" + "Mã này có hiệu lực trong 5 phút.";
                EmailService.Instance.SendSimpleEmail(email, "Xác thực tài khoản 3S eShop", msg);
            });

            // Lưu vào Redis thời gian sống 5 phút
            RedisHandler.StoreEmailOtp(email, otp);
        }

        public static void SendOtpResetPasswordEmail(String email, String otp)
        {
            // Gửi mã OTP qua email
            Task.Run(() =>
            {
                String msg = "Mã xác thực đổi mật khẩu 3S eShop của bạn là: " + otp + "\n" + "Mã này có hiệu lực trong 5 phút.";
                EmailService.Instance.SendSimpleEmail(email, "Xác thực đổi mật khẩu 3S eShop", msg);
            });

            // Lưu vào Redis thời gian sống 5 phút
            RedisHandler.StoreEmailOtp(email, otp);
        }

        public static async Task<bool> sendOTPEditEmailAsync(string email, string otp)
        {
            try
            {
                // Gửi mã OTP qua email
                String msg = "Mã xác thực thay đổi thông tin tài khoản 3S eShop của bạn là: " + otp + "\n" + "Mã này có hiệu lực trong 5 phút.";
                var t1 = EmailService.Instance.SendSimpleEmailAsync(email, "Xác thực thay đổi thông tin tài khoản 3S eShop", msg);
                // Lưu vào Redis thời gian sống 5 phút
                var t2 = RedisHandler.StoreEmailOtpAsync(email, otp);
                await Task.WhenAll(t1, t2);
                // Kiểm tra xem có lỗi gì không
                if (t1.IsCompleted && t2.IsCompleted)
                {
                    return true;
                }
                // Nếu không có lỗi thì trả về true
                return false;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Logger.Instance.LogError("Gửi email thông báo thay đổi thông tin tài khoản thất bại: " + ex.Message);
                return false;
            }
        }

        public static async Task<bool> SendEmailCreateOrder(string email, OrderDTO order, CartItem[] listCarts)
        {
            try
            {
                // Gửi mã OTP qua email
                StringBuilder msg = new StringBuilder();
                msg.AppendLine("Đơn hàng của bạn đã được tạo thành công. Chi tiết đơn hàng như sau: \n" +
                    "- Mã đơn hàng: " + order.Id + "\n" +
                    "- Tổng tiền: " + order.TotalPrice + "\n" +
                    "- Chi tiết đơn hàng:");
                foreach (var cart in listCarts)
                {
                    // Lấy giá sản phẩm
                    string price;
                    if (cart.Variant.Price == cart.Variant.DiscountPrice)
                    {
                        price = StringUtil.FormatCurrency(cart.Variant.Price) + "đ";
                    }
                    else
                    {
                        price = StringUtil.FormatCurrency(cart.Variant.Price) + "đ" + " -> " + StringUtil.FormatCurrency(cart.Variant.DiscountPrice) + "đ)";
                    }
                    // Thêm thông tin sản phẩm vào email
                    msg.AppendLine($"   + Sản phẩm: [{cart.Product.Id}] {cart.Product.Name}");
                    msg.AppendLine($"      • Biến thể: [{cart.Variant.Id}] {cart.Variant.Label}");
                    msg.AppendLine($"      • Số lượng: {cart.Quantity}");
                    msg.AppendLine($"      • Giá: {price}");
                }
                await EmailService.Instance.SendSimpleEmailAsync(email, $"Tạo đơn hàng thành công #{order.Id}", msg.ToString());
                // Nếu không có lỗi thì trả về true
                return true;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Logger.Instance.LogError("Gửi email thông báo tạo đơn hàng thất bại: " + ex.Message);
                return false;
            }
        }

    }
}
