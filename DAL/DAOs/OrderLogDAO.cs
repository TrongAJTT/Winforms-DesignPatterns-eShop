using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.DAL.DAOs
{
    internal class OrderLogDAO : ICrudRepository<OrderLogDTO, long>
    {
        public string TableName => "Order_Logs";

        public OrderLogDTO Add(OrderLogDTO entity)
        {
            string query = $"INSERT INTO {TableName} (order_id, status, status_detail, created_at) " +
                $"VALUES (@orderId, @status, @statusDetail, @createdAt)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO AnyMatch OrderLogDAO
            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Count OrderLogDAO
            throw new NotImplementedException();
        }

        public void Delete(OrderLogDTO entity)
        {
            //TODO Delete OrderLogDAO
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO DeleteById OrderLogDAO
            throw new NotImplementedException();
        }

        public List<OrderLogDTO> FindMatch(string property, string value)
        {
            //TODO FindMatch OrderLogDAO

            throw new NotImplementedException();
        }

        public List<OrderLogDTO> GetAll()
        {
            //TODO GetAll OrderLogDAO

            throw new NotImplementedException();
        }

        public OrderLogDTO GetById(long id)
        {
            //TODO GetById OrderLogDAO

            throw new NotImplementedException();
        }

        public OrderLogDTO Update(long id, OrderLogDTO entity)
        {
            //TODO Update OrderLogDAO

            throw new NotImplementedException();
        }
    }
}
