using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class CouponBuilder
    {
        private long id;
        private byte discountPercent;
        private UInt32 maxDiscountAmount;
        private DateTime startDate;
        private bool status;
        private DateTime expirationDate;
        private byte remainingUses;

        public CouponBuilder SetDiscountPercent(byte discountPercent)
        {
            this.discountPercent = discountPercent;
            return this;
        }

        public CouponBuilder SetExpirationDate(DateTime expirationDate)
        {
            this.expirationDate = expirationDate;
            return this;
        }

        public CouponBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public CouponBuilder SetMaxDiscountAmount(uint maxDiscountAmount)
        {
            this.maxDiscountAmount = maxDiscountAmount;
            return this;
        }

        public CouponBuilder SetRemainingUses(byte remainingUses)
        {
            this.remainingUses = remainingUses;
            return this;
        }

        public CouponBuilder SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
            return this;
        }

        public CouponBuilder SetStatus(bool status)
        {
            this.status = status;
            return this;
        }

        public CouponDTO Build()
        {
            return new CouponDTO(id, discountPercent, maxDiscountAmount, startDate, status, expirationDate, remainingUses);
        }

        public CouponBuilder Default()
        {
            this.id = -1;
            this.startDate = DateTime.Now;
            this.status = true;
            return this;
        }

        public CouponDTO FromDataRow(DataRow row)
        {
            return new CouponDTO(
                long.Parse(row[0].ToString()),
                byte.Parse(row[1].ToString()),
                UInt32.Parse(row[2].ToString()),
                DateTime.Parse(row[3].ToString()),
                bool.Parse(row[4].ToString()),
                DateTime.Parse(row[5].ToString()),
                byte.Parse(row[6].ToString())
            );
        }

        public List<CouponDTO> FromDataTable(DataTable dt)
        {
            List<CouponDTO> coupons = new List<CouponDTO>();
            foreach (DataRow row in dt.Rows)
            {
                coupons.Add(FromDataRow(row));
            }
            return coupons;
        }
    }
}
