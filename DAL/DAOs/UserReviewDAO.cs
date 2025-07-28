using System;
using System.Collections.Generic;
using _3S_eShop.BLL.DTOs;

namespace _3S_eShop.DAL.DAOs
{
    public class UserReviewDAO: ICrudRepository<UserReviewDTO, long>
    {
        public string TableName => "User_Review";

        public UserReviewDTO Add(UserReviewDTO entity)
        {
            string query = $"INSERT INTO {TableName} (user_id, product_id, rating, content, created_at) VALUES (@user, @prod, @rate, @content, @createDate)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO Tien - AnyMatch - UserReviewDAO
            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Tien - Count - UserReviewDAO
            throw new NotImplementedException();
        }

        public void Delete(UserReviewDTO entity)
        {
            //TODO Tien - Delete - UserReviewDAO
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO Tien - DeleteById - UserReviewDAO
            throw new NotImplementedException();
        }

        public List<UserReviewDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - UserReviewDAO
            throw new NotImplementedException();
        }

        public List<UserReviewDTO> GetAll()
        {
            //TODO Tien - GetAll - UserReviewDAO
            throw new NotImplementedException();
        }

        public UserReviewDTO GetById(long id)
        {
            //TODO Tien - GetById - UserReviewDAO
            throw new NotImplementedException();
        }

        public UserReviewDTO Update(long id, UserReviewDTO entity)
        {
            entity.Id = id;
            string query = $"UPDATE {TableName} SET rating = @rate, content = @content WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }
    }
}
