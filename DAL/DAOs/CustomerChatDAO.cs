using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    internal class CustomerChatDAO : ICrudRepository<CustomerChatDTO, long>
    {
        public string TableName => "Customers_Chat";

        /// <summary>
        /// Entity không thay đổi, luôn trả về null.
        /// </summary>
        public CustomerChatDTO Add(CustomerChatDTO entity)
        {
            string query = $"INSERT into {TableName} values (@user, @hasNew, @updated_at)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            return null;
        }

        public bool AnyMatch(string property, string value)
        {
            return DataProvider.Instance.AnyMatch(TableName, property, value);
        }

        public long Count()
        {
            return (long)DataProvider.Instance.CountRows(TableName);
        }

        public void Delete(CustomerChatDTO entity)
        {
            string query = $"delete from {TableName} where user_id = @user";
            DataProvider.Instance.ExecuteNonQuery(query, entity.UserId);
        }

        public void DeleteById(long id)
        {
            string query = $"delete from {TableName} where user_id = @user";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<CustomerChatDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new CustomerChatBuilder().FromDataTable(dt);
        }

        public List<CustomerChatDTO> GetAll()
        {
            string query = $"select * from {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new CustomerChatBuilder().FromDataTable(dt);
        }

        public CustomerChatDTO GetById(long id)
        {
            string query = $"select * from {TableName} where user_id = @user";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new CustomerChatBuilder().FromDataRow(dt.Rows[0]);
        }

        public CustomerChatDTO Update(long id, CustomerChatDTO entity)
        {
            string query = $"UPDATE {TableName} SET has_new_message = @hasNew, updated_at = @upd where user_id = @user";
            entity.UserId = id;
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }
    }
}
