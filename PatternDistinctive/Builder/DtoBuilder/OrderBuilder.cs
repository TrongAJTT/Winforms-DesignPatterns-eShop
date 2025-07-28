using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class OrderBuilder
    {
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
        public OrderDTO Build()
        {
            return new OrderDTO
            (
                this.id,
                this.userId,
                this.totalPrice,
                this.rewardPointsUsed,
                this.couponUsed,
                this.couponDiscountQuantity,
                this.finalPrice,
                this.status,
                this.statusDetail,
                this.recipientName,
                this.recipientPhone,
                this.administrativeArea,
                this.streetAddress,
                this.createdAt
            );
        }

        public OrderDTO FromDataRow(DataRow row)
        {
            return new OrderBuilder()
                .SetId((long)row[0])
                .SetUserId((long)row[1])
                .SetTotalPrice((long)row[2])
                .SetRewardPointsUsed((uint)row[3])
                .SetCouponUsed(row[4].ToString() == "" ? -1 : (long)row[4])
                .SetCouponDiscountQuantity((uint)row[5])
                .SetFinalPrice((long)row[6])
                .SetStatus(row[7].ToString())
                .SetStatusDetail(row[8].ToString())
                .SetRecipientName(row[9].ToString())
                .SetRecipientPhone(row[10].ToString())
                .SetAdministrativeArea(row[11].ToString())
                .SetStreetAddress(row[12].ToString())
                .SetCreatedAt(DateTime.Parse(row[13].ToString()))
                .Build();
        }

        public List<OrderDTO> FromDataTable(DataTable dt)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            foreach (DataRow row in dt.Rows)
            {
                orders.Add(FromDataRow(row));
            }
            return orders;
        }

        public OrderBuilder SetAdministrativeArea(string administrativeArea)
        {
            this.administrativeArea = administrativeArea;
            return this;
        }

        public OrderBuilder SetCouponDiscountQuantity(uint couponDiscountQuantity)
        {
            this.couponDiscountQuantity = couponDiscountQuantity;
            return this;
        }

        public OrderBuilder SetCouponUsed(long couponUsed)
        {
            this.couponUsed = couponUsed;
            return this;
        }

        public OrderBuilder SetCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }

        public OrderBuilder SetFinalPrice(long finalPrice)
        {
            this.finalPrice = finalPrice;
            return this;
        }

        public OrderBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public OrderBuilder SetRecipientName(string recipientName)
        {
            this.recipientName = recipientName;
            return this;
        }

        public OrderBuilder SetRecipientPhone(string recipientPhone)
        {
            this.recipientPhone = recipientPhone;
            return this;
        }

        public OrderBuilder SetRewardPointsUsed(uint rewardPointsUsed)
        {
            this.rewardPointsUsed = rewardPointsUsed;
            return this;
        }

        public OrderBuilder SetStatus(string status)
        {
            this.status = status; 
            return this;
        }

        public OrderBuilder SetStatusDetail(string statusDetail)
        {
            this.statusDetail = statusDetail; 
            return this;
        }

        public OrderBuilder SetStreetAddress(string streetAddress)
        {
            this.streetAddress = streetAddress;
            return this;
        }

        public OrderBuilder SetTotalPrice(long totalPrice)
        {
            this.totalPrice = totalPrice;
            return this;
        }

        public OrderBuilder SetUserId(long userId)
        {
            this.userId = userId; 
            return this;
        }
    }
}
