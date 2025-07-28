using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _3S_eShop.BLL
{
    class CustomerChatBLL
    {
        private CustomerChatDAO dao;

        public CustomerChatBLL(CustomerChatDAO dao)
        {
            this.dao = dao;
        }

        public void AddChatForNewUser(long userId)
        {
            CustomerChatDTO chat = new CustomerChatBuilder().Default()
                .SetUserId(userId).Build();
            dao.Add(chat);
        }

        public List<CustomerChatDTO> GetListCustomerChatsAtPage(long page)
        {
            string query = new PagingQueryBuilder(dao.TableName, "updated_at", "user_id", true).AddSpecific("updated_at >= '2000-01-01'")
                .SetDesc(true)
                .SetPageSize(25)
                .SetPage(page)
                .Build();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new CustomerChatBuilder().FromDataTable(dt);
        }

        public void UpdateChatNewMessage(long userId, bool hasNewMessage)
        {
            dao.Update(userId, new CustomerChatBuilder().Default().SetHasNewMessage(true).Build());
        }

    }
}
