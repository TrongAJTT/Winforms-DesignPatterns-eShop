using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class MessageBuilder 
    {
        private long id;
        private long chatId;
        private long userId;
        private DateTime sendDate;
        private string content;

        // Xây dựng đối tượng MessageDTO từ dữ liệu đã thiết lập
        public  MessageDTO Build()
        {
            return new MessageDTO
            (
                this.id,
                this.chatId,
                this.userId,
                this.sendDate,
                this.content
            );
        }

        // Chuyển đổi một DataRow thành MessageDTO
        public MessageDTO FromDataRow(DataRow row)
        {
            return new MessageDTO
            (
                row.Field<long>("id"),
                row.Field<long>("chat_id"),
                row.Field<long>("user_id"),
                row.Field<DateTime>("send_date"),
                row.Field<string>("content")
            );
        }

        // Chuyển đổi toàn bộ DataTable thành danh sách MessageDTO
        public  List<MessageDTO> FromDataTable(DataTable dt)
        {
            return dt.Select().Select(row => FromDataRow(row)).ToList();
        }

        // Các phương thức Set để thiết lập dữ liệu
        public MessageBuilder setId(long id)
        {
            this.id = id;
            return this;
        }

        public MessageBuilder setChatId(long chatId)
        {
            this.chatId = chatId;
            return this;
        }

        public MessageBuilder setUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public  MessageBuilder setSendDate(DateTime sendDate)
        {
            this.sendDate = sendDate;
            return this;
        }

        public MessageBuilder setContent(string content)
        {
            this.content = content;
            return this;
        }

        public MessageBuilder Default()
        {
            throw new NotImplementedException();
        }

    }

}
