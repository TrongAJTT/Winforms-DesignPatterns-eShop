using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.DAL.DAOs
{
    internal class OrderDAO : ICrudRepository<OrderDTO, long>
    {
        public string TableName => "Orders";

        public OrderDTO Add(OrderDTO entity)
        {
            string query = $"INSERT INTO {TableName} (user_id, total_price, reward_points_used, coupon_used, coupon_discount_quantity, final_price, status, status_detail, recipient_name, recipient_phone, administrative_area, street_address) " +
                $"VALUES (@userId, @totalPrice, @rewardPointsUsed, @couponUsed, @couponDiscountQuantity, @finalPrice, @status, @statusDetail, @recipientName, @recipientPhone, @administrativeArea, @streetAddress)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO AnyMatch OrderDAO
            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Count OrderDAO
            throw new NotImplementedException();
        }

        public void Delete(OrderDTO entity)
        {
            //TODO Delete OrderDAO
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO DeleteById OrderDAO
            throw new NotImplementedException();
        }

        public List<OrderDTO> FindMatch(string property, string value)
        {
            //TODO FindMatch OrderDAO
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetAll()
        {
            //TODO getAll orderDAO
            throw new NotImplementedException();
        }

        public OrderDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new OrderBuilder().FromDataRow(dt.Rows[0]);
        }

        public OrderDTO Update(long id, OrderDTO entity)
        {
            //TODO Update OrderDAO
            throw new NotImplementedException();
        }

        public int GetOrderCountByStatusOfUser(long userId, string status)
        {
            string query = $"SELECT COUNT(*) FROM {TableName} WHERE user_id = @userId AND status like @Stat";
            return Convert.ToInt32(
                DataProvider.Instance.ExecuteScalar(query, userId, status));
        }

        public int GetOrderCountByStatus(string status)
        {
            string query = $"SELECT COUNT(*) FROM {TableName} WHERE status like @Stat";
            return Convert.ToInt32(
                DataProvider.Instance.ExecuteScalar(query, status));
        }

    }
}
