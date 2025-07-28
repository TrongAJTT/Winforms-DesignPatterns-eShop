using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;

namespace _3S_eShop.BLL
{
    internal class OrderLogBLL
    {
        private OrderLogDAO dao;

        public OrderLogBLL(OrderLogDAO orderLogDAO)
        {
            this.dao = orderLogDAO;
        }

        internal DateTime GetDateCompletedOfOrder(long orderId)
        {
            string query = new PagingQueryBuilder(dao.TableName, "created_at", "id", true)
                .AddSpecific("status = 'completed'")
                .AddSpecific($"order_id = {orderId}")
                .SetPage(1).SetPageSize(1).Build();
            var dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0) return DateTime.MinValue;
            var orderLog = new OrderLogBuilder().FromDataRow(dt.Rows[0]);
            return orderLog.CreatedAt;
        }

        internal List<OrderLogDTO> GetListStatusOfOrder(long orderId)
        {
            string query = new PagingQueryBuilder(dao.TableName, "created_at", "id", true)
                .AddSpecific($"order_id = {orderId}")
                .SetPage(1).SetPageSize(5).Build();
            var dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0) return new List<OrderLogDTO>();
            var orderLogs = new OrderLogBuilder().FromDataTable(dt);
            return orderLogs;
        }

    }
}
