using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class UserReviewDTO : BaseDTO<UserReviewDTO>
    {
        private long id;
        private long userId;
        private long productId;
        private byte rating;
        private string content;
        private DateTime createdAt;

        public UserReviewDTO
        (
            long id, 
            long userId, 
            long productId, 
            byte rating, 
            string content, 
            DateTime createdAt
        )
        {
            this.Id = id;
            this.UserId = userId;
            this.ProductId = productId;
            this.Rating = rating;
            this.Content = content;
            this.CreatedAt = createdAt;
        }

        public string TableName => "User_Review";

        public long Id { get => id; set => id = value; }
        public long UserId { get => userId; set => userId = value; }
        public long ProductId { get => productId; set => productId = value; }
        public byte Rating { get => rating; set => rating = value; }
        public string Content { get => content; set => content = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        public bool Equals(UserReviewDTO obj)
        {
            return this.Id == obj.Id || (this.UserId == obj.UserId && this.ProductId == obj.ProductId);
        }

        public object[] GenSaveObject()
        {
            return new object[] { UserId, ProductId, Rating, Content, CreatedAt };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { Rating, Content, Id };
        }
    }
}
