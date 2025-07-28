using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class UserReviewBuilder
    {
        private long id;
        private long userId;
        private long productId;
        private byte rating;
        private string content;
        private DateTime createdAt;

        public UserReviewBuilder SetCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }

        public UserReviewBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public UserReviewBuilder SetProductId(long productId)
        {
            this.productId = productId;
            return this;
        }

        public UserReviewBuilder SetRating(byte rating)
        {
            this.rating = rating;
            return this;
        }

        public UserReviewBuilder SetContent(string content)
        {
            this.content = content;
            return this;
        }

        public UserReviewBuilder SetUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public UserReviewDTO Build()
        {
            return new UserReviewDTO(id, userId, productId, rating, content, createdAt);
        }

        public UserReviewBuilder Default()
        {
            id = -1;
            userId = -1;
            productId = -1;
            rating = 0;
            content = string.Empty;
            createdAt = DateTime.Now;
            return this;
        }

        public UserReviewDTO FromDataRow(DataRow row)
        {
            return new UserReviewBuilder()
                .SetId(Convert.ToInt64(row[0]))
                .SetUserId(Convert.ToInt64(row[1]))
                .SetProductId(Convert.ToInt64(row[2]))
                .SetRating(Convert.ToByte(row[3]))
                .SetContent(row[4].ToString())
                .SetCreatedAt(Convert.ToDateTime(row[5]))
                .Build();
        }

        public List<UserReviewDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(row => FromDataRow(row)).ToList();
        }
    }
}
