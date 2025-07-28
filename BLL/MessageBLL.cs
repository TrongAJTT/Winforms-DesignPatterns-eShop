using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace _3S_eShop.BLL
{
    internal class MessageBLL
    {
        private MessageDAO messageDAO;

        public MessageBLL(MessageDAO messageDAO)
        {
            this.messageDAO = messageDAO;
        }

        public List<MessageDTO> GetHistoryChatPage(long chatId, int page)
        {
            String query = new PagingQueryBuilder(messageDAO.TableName, "send_date", "id", true)
                .AddSpecific("chat_id = @chatId")
                .SetPageSize(40)
                .SetPage(page).Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, chatId);
            return new MessageBuilder().FromDataTable(dt);
        }

        public void SendMessage(MessageDTO message)
        {
            CustomerChatDAO ccDao = new CustomerChatDAO();
            // Thêm tin nhắn
            messageDAO.Add(message);
            // Cập nhật trạng thái của chat
            new CustomerChatBLL(ccDao).UpdateChatNewMessage(message.ChatId, message.UserId == MainForm.User.Id);
        }

        public String GetLatestMessageOfChat(long chatId)
        {
            String query = $"SELECT content FROM {messageDAO.TableName} WHERE chat_id = @chatId ORDER BY send_date DESC LIMIT 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, chatId);
            if (dt.Rows.Count == 0) return "";
            return dt.Rows[0].Field<string>("content");
        }

    }
}
