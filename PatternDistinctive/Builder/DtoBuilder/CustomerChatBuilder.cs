using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class CustomerChatBuilder
    {
        private long userId;
        private bool hasNewMessage;
        private DateTime updatedAt;

        public CustomerChatBuilder SetHasNewMessage(bool hasNewMessage)
        {
            this.hasNewMessage = hasNewMessage;
            return this;
        }

        public CustomerChatBuilder SetUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public CustomerChatBuilder SetUpdatedAt(DateTime updatedAt)
        {
            this.updatedAt = updatedAt;
            return this;
        }

        public CustomerChatDTO Build()
        {
            return new CustomerChatDTO(userId, hasNewMessage, updatedAt);
        }

        public CustomerChatBuilder Default()
        {
            this.userId = -1;
            this.hasNewMessage = false;
            this.updatedAt = new DateTime(1999, 1, 1);
            return this;
        }

        public CustomerChatDTO FromDataRow(DataRow row)
        {
            return new CustomerChatDTO(
                (long)row[0],
                Convert.ToBoolean(row[1]),
                (DateTime)row[2]
            );
        }

        public List<CustomerChatDTO> FromDataTable(DataTable dt)
        {
            List<CustomerChatDTO> list = new List<CustomerChatDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(FromDataRow(row));
            }
            return list;
        }
    }
}
