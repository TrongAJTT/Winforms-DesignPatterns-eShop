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
    internal class OrderProductDAO : ICrudRepository<OrderProductDTO, long>
    {
        public string TableName => "Order_Products";

        public OrderProductDTO Add(OrderProductDTO entity)
        {
            string query = $"INSERT INTO {TableName} (order_id, product_id, variant_id, quantity, original_price, final_price) " +
                $"VALUES (@orderId, @productId, @variantId, @quantity, @originalPrice, @finalPrice)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO AnyMatch OrderProductDAO

            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Count OrderProductDAO

            throw new NotImplementedException();
        }

        public void Delete(OrderProductDTO entity)
        {
            //TODO Delete OrderProductDAO

            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO DeleteById OrderProductDAO

            throw new NotImplementedException();
        }

        public List<OrderProductDTO> FindMatch(string property, string value)
        {
            string query = $"SELECT * FROM {TableName} WHERE {property} like '%{value}%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0) return new List<OrderProductDTO>();
            return new OrderProductBuilder().FromDataTable(dt);
        }

        public List<OrderProductDTO> GetAll()
        {
            //TODO GetAll OrderProductDAO

            throw new NotImplementedException();
        }

        public OrderProductDTO GetById(long id)
        {
            //TODO GetById OrderProductDAO

            throw new NotImplementedException();
        }

        public OrderProductDTO Update(long id, OrderProductDTO entity)
        {
            //TODO Update OrderProductDAO

            throw new NotImplementedException();
        }
    }
}
