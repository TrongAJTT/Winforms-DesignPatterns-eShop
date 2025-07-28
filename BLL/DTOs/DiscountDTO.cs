using System;

namespace _3S_eShop.BLL.DTOs
{
    internal class DiscountDTO : BaseDTO<DiscountDTO>
    {
        private long id;
        private UInt32 discountPrice;
        private DateTime startDate;
        private DateTime endDate;

        public DiscountDTO(long id, uint discountPrice, DateTime startDate, DateTime endDate)
        {
            this.Id = id;
            this.DiscountPrice = discountPrice;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string TableName => "Discounts";

        public long Id { get => id; set => id = value; }
        public uint DiscountPrice { get => discountPrice; set => discountPrice = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public bool Equals(DiscountDTO obj)
        {
            return this.id == obj.id || (this.discountPrice == obj.discountPrice);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.discountPrice, this.startDate, this.endDate };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.discountPrice, this.startDate, this.endDate, this.id };
        }
    }
}