using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.DAL.DAOs
{
    public class UserAddressDAO: ICrudRepository<UserAddressDTO, long>
    {
        public string TableName => "User_Address";

        public UserAddressDTO Add(UserAddressDTO entity)
        {
            string query = $"INSERT INTO {TableName} (user_id, recipient_name, recipient_phone, administrative_area, street_address, is_default) VALUES (@user_id, @recipient_name, @recipient_phone, @administrative_area, @street_address, @is_default)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }
        public bool AnyMatch(string property, string value)
        {
            string query = $"SELECT COUNT(*) FROM {TableName} WHERE {property} like @value";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, value)) > 0;
        }

        public long Count()
        {
            //TODO Tien - Count - UserAddressDAO
            throw new NotImplementedException();
        }

        public void Delete(UserAddressDTO entity)
        {
            //TODO Tien - Delete - UserAddressDAO
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO Tien - DeleteById - UserAddressDAO
            throw new NotImplementedException();
        }
        public List<UserAddressDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - UserAddressDAO
            throw new NotImplementedException();
        }
        public List<UserAddressDTO> GetAll()
        {
            string query = "SELECT * FROM User_Address";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new UserAddressBuilder().FromDataTable(dt);
        }

        public UserAddressDTO GetById(long id)
        {
            string query = "SELECT * FROM User_Address WHERE id = @Id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new UserAddressBuilder().FromDataRow(dt.Rows[0]);
        }

        public UserAddressDTO Update(long id, UserAddressDTO entity)
        {
            entity.Id = id;
            string query = $"UPDATE {TableName} SET user_id = @user_id, recipient_name = @recipient_name, recipient_phone = @recipient_phone, administrative_area = @administrative_area, street_address = @street_address, is_default = @is_default WHERE id = @Id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }

        public List<UserAddressDTO> GetByUserId(long userId)
        {
            string query = $"SELECT * FROM {TableName} WHERE user_id = @Id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, userId);
            if (dt.Rows.Count == 0) return null;
            return new UserAddressBuilder().FromDataTable(dt);
        }

    }
}
