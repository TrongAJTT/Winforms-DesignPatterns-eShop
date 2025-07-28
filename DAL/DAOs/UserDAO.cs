using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    public class UserDAO : ICrudRepository<UserDTO, long>
    {
        public string TableName { get => "Users"; }

        public UserDTO Add(UserDTO entity)
        {
            String query = $"insert into {TableName} (role_id, email, password, username, created_date, last_login_date)" +
                "values (@role_id, @email, @password, @username, @created_at, @updated_at)";
            DataProvider.Instance.ExecuteQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public long Count()
        {
            return (long) DataProvider.Instance.CountRows(TableName);
        }

        public void Delete(UserDTO entity)
        {
            string query = $"delete from {TableName} where id = @id";
            DataProvider.Instance.ExecuteQuery(query, entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"delete from {TableName} where id = @id";
            DataProvider.Instance.ExecuteQuery(query, id);
        }

        public List<UserDTO> GetAll()
        {
            string query = $"select * from {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new UserBuilder().FromDataTable(dt);
        }

        public UserDTO GetById(long id)
        {
            string query = $"select * from {TableName} where id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new UserBuilder().FromDataRow(dt.Rows[0]);
        }

        public UserDTO Update(long id, UserDTO entity)
        {
            entity.Id = id;
            string query = $"UPDATE {TableName} " +
                $"SET email = @email, password = @password, username = @username, is_active = @Active, ban_reason = @Ban, last_login_date = @updated_at " +
                $"WHERE id = @id";
            DataProvider.Instance.ExecuteQuery(query, entity.GenUpdateObject());
            return entity;
        }

        public void UpdateActive(long id, bool isActive, string banReason)
        {
            string query = $"UPDATE {TableName} SET is_active = @is_active, ban_reason = @ban_reason WHERE id = @id";
            DataProvider.Instance.ExecuteQuery(query, new object[] { isActive, banReason, id });
        }

        public bool AnyMatch(string property, string value)
        {
            return DataProvider.Instance.AnyMatch(TableName, property, value);
        }

        public List<UserDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new UserBuilder().FromDataTable(dt);
        }
    }
}
