using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using System;
using System.Collections.Generic;

namespace _3S_eShop.BLL
{
    internal class OrderProductBLL
    {
        private OrderProductDAO dao;

        public OrderProductBLL(OrderProductDAO orderProductDAO)
        {
            this.dao = orderProductDAO;
        }

        internal List<OrderProductDTO> GetListByOrderId(long orderId)
        {
            return dao.FindMatch("order_id", orderId.ToString());
        }
    }
}
