using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3S_eShop.BLL
{
    internal class UserReviewBLL
    {
        private UserReviewDAO dao;

        public UserReviewBLL(UserReviewDAO userReviewDAO)
        {
            this.dao = userReviewDAO;
        }

        internal int GetReviewCountByUserId(long userId)
        {
            string query = "SELECT COUNT(*) FROM User_Review WHERE user_id = @UserId";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, userId));
        }

        internal long GetReviewCountByProductId(long productId)
        {
            string query = "SELECT COUNT(*) FROM User_Review WHERE product_id = @ProductId";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, productId));
        }

        internal float GetAverageRatingByProductId(long productId)
        {
            string query = "SELECT AVG(rating) FROM User_Review WHERE product_id = @ProductId";
            object result = DataProvider.Instance.ExecuteScalar(query, productId);
            return result == DBNull.Value ? 0 : Convert.ToSingle(result);
        }

        internal long GetReviewCountByProductIdAndRatingValue(long productId, byte ratingValue)
        {
            string query = "SELECT COUNT(*) FROM User_Review WHERE product_id = @ProductId AND rating = @RatingValue";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, productId, ratingValue));
        }

        internal List<UserReviewDTO> GetReviewsOfProductPaging(long productId, long page, long pageSize)
        {
            string query = new PagingQueryBuilder("User_Review", "created_at")
                .AddSpecific("product_id = @ProductId")
                .SetPage(page)
                .SetPageSize(pageSize)
                .SetDesc(true).Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, productId);
            if (dt.Rows.Count == 0) return null;
            return new UserReviewBuilder().FromDataTable(dt);
        }

        internal List<UserReviewDTO> Get2LatestReviewByUserId(long userId)
        {
            string query = new PagingQueryBuilder("User_Review", "id")
                .AddSpecific("user_id = @UserId")
                .SetPage(1)
                .SetPageSize(2)
                .SetDesc(true).Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, userId);
            if (dt.Rows.Count == 0) return null;
            return new UserReviewBuilder().FromDataTable(dt);
        }

        internal UserReviewDTO GetProductReviewFromUser(long userId, long productId)
        {
            string query = $"SELECT * FROM {dao.TableName} WHERE user_id = @UserId AND product_id = @ProductId";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, userId, productId);
            if (dt.Rows.Count == 0) return null;
            return new UserReviewBuilder().FromDataRow(dt.Rows[0]);
        }
    }
}
