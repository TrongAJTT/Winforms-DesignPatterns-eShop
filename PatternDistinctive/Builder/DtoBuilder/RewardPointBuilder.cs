using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class RewardPointBuilder
    {
        private long userId;
        private int point;
        private DateTime expirationDate;

        public RewardPointBuilder SetExpirationDate(DateTime expirationDate)
        {
            this.expirationDate = expirationDate;
            return this;
        }

        public RewardPointBuilder SetPoint(int point)
        {
            this.point = point;
            return this;
        }

        public RewardPointBuilder SetUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public RewardPointDTO Build()
        {
            return new RewardPointDTO(userId, point, expirationDate);
        }

        public RewardPointBuilder Default()
        {
            this.userId = -1;
            this.point = 0;
            this.expirationDate = DateTime.Now;
            return this;
        }

        public RewardPointDTO FromDataRow(DataRow row)
        {
            return new RewardPointDTO(
                Convert.ToInt64(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToDateTime(row[2])
            );
        }

        public List<RewardPointDTO> FromDataTable(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
