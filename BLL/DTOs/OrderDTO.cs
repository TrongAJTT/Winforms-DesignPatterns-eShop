using System;

namespace _3S_eShop.BLL.DTOs
{
    public class OrderDTO : BaseDTO<OrderDTO>
    {
        public static string STATUS_PROCESSING = "processing", 
            STATUS_SHIPPING = "shipping", 
            STATUS_COMPLETED = "completed", 
            STATIC_CANCELLED = "cancelled";

        private long id;
        private long userId;
        private long totalPrice;
        private uint rewardPointsUsed;
        private long couponUsed;
        private uint couponDiscountQuantity;
        private long finalPrice;
        private string status;
        private string statusDetail;
        private string recipientName;
        private string recipientPhone;
        private string administrativeArea;
        private string streetAddress;
        private DateTime createdAt;

        public OrderDTO(long id, long userId, long totalPrice, uint rewardPointsUsed, long couponUsed, uint couponDiscountQuantity, long finalPrice, string status, string statusDetail, string recipientName, string recipientPhone, string administrativeArea, string streetAddress, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            TotalPrice = totalPrice;
            RewardPointsUsed = rewardPointsUsed;
            CouponUsed = couponUsed;
            CouponDiscountQuantity = couponDiscountQuantity;
            FinalPrice = finalPrice;
            Status = status;
            StatusDetail = statusDetail;
            RecipientName = recipientName;
            RecipientPhone = recipientPhone;
            AdministrativeArea = administrativeArea;
            StreetAddress = streetAddress;
            CreatedAt = createdAt;
        }

        public string TableName => "Order_Products";

        public long Id { get => id; set => id = value; }
        public long UserId { get => userId; set => userId = value; }
        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public uint RewardPointsUsed { get => rewardPointsUsed; set => rewardPointsUsed = value; }
        public long CouponUsed { get => couponUsed; set => couponUsed = value; }
        public uint CouponDiscountQuantity { get => couponDiscountQuantity; set => couponDiscountQuantity = value; }
        public long FinalPrice { get => finalPrice; set => finalPrice = value; }
        public string Status { get => status; set => status = value; }
        public string StatusDetail { get => statusDetail; set => statusDetail = value; }
        public string RecipientName { get => recipientName; set => recipientName = value; }
        public string RecipientPhone { get => recipientPhone; set => recipientPhone = value; }
        public string AdministrativeArea { get => administrativeArea; set => administrativeArea = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        public bool Equals(OrderDTO obj)
        {
            return Id == obj.Id;
        }

        public object[] GenSaveObject()
        {
            return new object[] 
            {
                UserId,
                TotalPrice,
                RewardPointsUsed,
                CouponUsed,
                CouponDiscountQuantity,
                FinalPrice,
                Status,
                StatusDetail,
                RecipientName,
                RecipientPhone,
                AdministrativeArea,
                StreetAddress,
                DateTime.Now
            };
        }

        public object[] GenUpdateObject()
        {
            return new object[]
            {
            Id,
            UserId,
            TotalPrice,
            RewardPointsUsed,
            CouponUsed,
            CouponDiscountQuantity,
            FinalPrice,
            Status,
            StatusDetail,
            RecipientName,
            RecipientPhone,
            AdministrativeArea,
            StreetAddress,
            CreatedAt,
            };
        }
    }
}
