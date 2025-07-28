using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class DiscountBuilder
    {
        private long id;
        private UInt32 discountPrice;
        private DateTime startDate;
        private DateTime endDate;

        public DiscountBuilder SetDiscountPrice(uint discountPrice)
        {
            this.discountPrice = discountPrice;
            return this;
        }

        public DiscountBuilder SetEndDate(DateTime endDate)
        {
            this.endDate = endDate;
            return this;
        }

        public DiscountBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public DiscountBuilder SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
            return this;
        }

        public DiscountDTO Build()
        {
            return new DiscountDTO(id, discountPrice, startDate, endDate);
        }

        public DiscountBuilder Default()
        {
            this.id = -1;
            this.startDate = DateTime.Now;
            return this;
        }

        public DiscountDTO FromDataRow(DataRow row)
        {
            return new DiscountDTO(
                (long) row[0],
                Convert.ToUInt32(row[1]),
                Convert.ToDateTime(row[2]),
                Convert.ToDateTime(row[3])
            );
        }

        public List<DiscountDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(x => FromDataRow(x)).ToList();
        }
    }
}
