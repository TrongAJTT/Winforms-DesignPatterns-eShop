using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class RewardPointDTO : BaseDTO<RewardPointDTO>
    {
        private long userId;
        private int point;
        private DateTime expirationDate;

        public RewardPointDTO
        (
            long userId, 
            int point, 
            DateTime expirationDate
        )
        {
            this.UserId = userId;
            this.Point = point;
            this.ExpirationDate = expirationDate;
        }

        public string TableName => "Reward_Points";

        public long UserId { get => userId; set => userId = value; }
        public int Point { get => point; set => point = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public bool Equals(RewardPointDTO obj)
        {
            return this.UserId == obj.UserId;
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.UserId, this.Point, this.ExpirationDate };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.Point, this.ExpirationDate, this.UserId };
        }
    }
}
