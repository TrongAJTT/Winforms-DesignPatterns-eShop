using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.DAL.DAOs
{
    public class RewardPointDAO: ICrudRepository<RewardPointDTO, long>
    {
        public string TableName => "Reward_Points";

        public RewardPointDTO Add(RewardPointDTO entity)
        {
            string query = $"INSERT into {TableName} (user_id, points, expiration_date) values (@userId, @point, @expirationDate)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            return null;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO Tien - AnyMatch - RewardPointDAO
            throw new NotImplementedException();
        }
        public long Count()
        {
            //TODO Tien - Count - RewardPointDAO
            throw new NotImplementedException();
        }
        public void Delete(RewardPointDTO entity)
        {
            //TODO Tien - Delete - RewardPointDAO
            throw new NotImplementedException();
        }
        public void DeleteById(long id)
        {
            //TODO Tien - DeleteById - RewardPointDAO
            throw new NotImplementedException();
        }

        public List<RewardPointDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - RewardPointDAO
            throw new NotImplementedException();
        }

        public List<RewardPointDTO> GetAll()
        {
            //TODO Tien - GetAll - RewardPointDAO
            throw new NotImplementedException();
        }

        public RewardPointDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE user_id = @Id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new RewardPointBuilder().FromDataRow(dt.Rows[0]);
        }

        public RewardPointDTO Update(long id, RewardPointDTO entity)
        {
            entity.UserId = id;
            string query = $"UPDATE {TableName} SET points = @point, expiration_date = @expirationDate WHERE user_id = @Id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }
    }
}
