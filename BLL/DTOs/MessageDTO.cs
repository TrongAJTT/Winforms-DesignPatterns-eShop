using System;

namespace _3S_eShop.BLL.DTOs
{
    [Serializable]
    public class MessageDTO : BaseDTO<MessageDTO>
    {
        private long id;
        private long chatId;
        private long userId;
        private DateTime sendDate;
        private string content;

        public MessageDTO(long id, long chatId, long userId, DateTime sendDate, string content)
        {
            Id = id;
            ChatId = chatId;
            UserId = userId;
            SendDate = sendDate;
            Content = content;
        }

        public string TableName => "Messages";

        public long Id { get => id; set => id = value; }
        public long ChatId { get => chatId; set => chatId = value; }
        public long UserId { get => userId; set => userId = value; }
        public DateTime SendDate { get => sendDate; set => sendDate = value; }
        public string Content { get => content; set => content = value; }

        public bool Equals(MessageDTO obj)
        {
            return Id == obj.Id;
        }

        public object[] GenSaveObject()
        {
            return new object[] { ChatId, UserId, SendDate, Content };
        }
        public object[] GenUpdateObject()
        {
            return new object[] { Id, ChatId, UserId, SendDate, Content };
        }
    }
}
