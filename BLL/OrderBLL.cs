using _3S_eShop.DAL.DAOs;
using System;

namespace _3S_eShop.BLL
{
    internal class OrderBLL
    {
        private OrderDAO dao;

        public OrderBLL(OrderDAO orderDAO)
        {
            this.dao = orderDAO;
        }

        #region Get Count

        public int GetProcessingOrderCountOfUser(long userId)
        {
            return dao.GetOrderCountByStatusOfUser(userId, "processing");
        }

        public int GetDeliveringOrderCountOfUser(long userId)
        {
            return dao.GetOrderCountByStatusOfUser(userId, "shipping");
        }

        public int GetCompletedOrderCountOfUser(long userId)
        {
            return dao.GetOrderCountByStatusOfUser(userId, "completed");
        }

        public int GetTotalOrderCountOfUser(long userId)
        {
            return dao.GetOrderCountByStatusOfUser(userId, "%%");
        }

        public int GetProcessingOrderCount()
        {
            return dao.GetOrderCountByStatus("processing");
        }

        public int GetDeliveringOrderCount()
        {
            return dao.GetOrderCountByStatus("shipping");
        }

        public int GetCompletedCount()
        {
            return dao.GetOrderCountByStatus("completed");
        }

        #endregion

    }
}
