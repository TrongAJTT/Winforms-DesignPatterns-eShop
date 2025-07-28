using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;

namespace _3S_eShop.DAL.DAOs
{
    internal class MessageDAO : ICrudRepository<MessageDTO, long>
    {
        public string TableName => "Messages";

        public MessageDTO Add(MessageDTO entity)
        {
            string query = $"INSERT into {TableName} (chat_id, user_id, send_date, content) values (@chatId, @userId, @sendDate, @content)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(MessageDTO entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public List<MessageDTO> FindMatch(string property, string value)
        {
            throw new NotImplementedException();
        }

        public List<MessageDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public MessageDTO GetById(long id)
        {
            throw new NotImplementedException();
        }

        public MessageDTO Update(long id, MessageDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
