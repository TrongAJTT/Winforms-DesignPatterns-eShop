using System;

namespace _3S_eShop.BLL.DTOs
{
    [Serializable]
    public class CustomerChatDTO : BaseDTO<CustomerChatDTO>
    {
        private long userId;
        private bool hasNewMessage;
        private DateTime updatedAt;

        public CustomerChatDTO(long userId, bool hasNewMessage, DateTime updatedAt)
        {
            this.UserId = userId;
            this.HasNewMessage = hasNewMessage;
            this.UpdatedAt = updatedAt;
        }

        public long UserId { get => userId; set => userId = value; }
        public bool HasNewMessage { get => hasNewMessage; set => hasNewMessage = value; }

        public string TableName => "Customers_Chat";

        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }

        public bool Equals(CustomerChatDTO obj)
        {
            return this.userId == obj.userId;
        }

        public object[] GenSaveObject()
        {
            return new object[] { userId, hasNewMessage, DateTime.Now };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { hasNewMessage, DateTime.Now, userId };
        }
    }
}
