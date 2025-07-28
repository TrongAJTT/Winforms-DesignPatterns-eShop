using System;

namespace _3S_eShop.BLL.DTOs
{
    public class CouponDTO : BaseDTO<CouponDTO>
    {
        private long id;
        private byte discountPercent;
        private UInt32 maxDiscountAmount;
        private DateTime startDate;
        private bool status;
        private DateTime expirationDate;
        private byte remainingUses;

        public CouponDTO(long id, byte discountPercent, uint maxDiscountAmount, DateTime startDate, bool status, DateTime expirationDate, byte remainingUses)
        {
            this.Id = id;
            this.DiscountPercent = discountPercent;
            this.MaxDiscountAmount = maxDiscountAmount;
            this.StartDate = startDate;
            this.Status = status;
            this.ExpirationDate = expirationDate;
            this.RemainingUses = remainingUses;
        }

        public string TableName => "Coupons";

        public long Id { get => id; set => id = value; }
        public byte DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public uint MaxDiscountAmount { get => maxDiscountAmount; set => maxDiscountAmount = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public byte RemainingUses 
        { 
            get => remainingUses; 
            set
            {
                if (value >= 0)
                {
                    remainingUses = value;
                }
            } 
        }

        public bool Equals(CouponDTO obj)
        {
            return this.Id == obj.Id || (this.discountPercent == obj.discountPercent && this.maxDiscountAmount == obj.maxDiscountAmount && this.startDate == obj.startDate && this.status == obj.status && this.expirationDate == obj.expirationDate);
        }

        public object[] GenSaveObject()
        {
            return new object[] { DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(), DiscountPercent, MaxDiscountAmount, StartDate, Status, ExpirationDate, RemainingUses };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { DiscountPercent, MaxDiscountAmount, StartDate, Status, ExpirationDate, RemainingUses, Id };
        }
    }
}
