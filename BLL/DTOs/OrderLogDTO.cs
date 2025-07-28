using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class OrderLogDTO : BaseDTO<OrderLogDTO>
    {
        private long id;
        private long orderId;
        private string status;
        private string statusDetail;
        private DateTime createdAt;

        public OrderLogDTO(long id, long orderId, string status, string statusDetail, DateTime createdAt)
        {
            Id = id;
            OrderId = orderId;
            Status = status;
            StatusDetail = statusDetail;
            CreatedAt = createdAt;
        }

        public string TableName => "Order_Logs";

        public long Id { get => id; set => id = value; }
        public long OrderId { get => orderId; set => orderId = value; }
        public string Status { get => status; set => status = value; }
        public string StatusDetail { get => statusDetail; set => statusDetail = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        public bool Equals(OrderLogDTO obj)
        {
            return Id == obj.Id;
        }

        public object[] GenSaveObject()
        {
            return new object[]
            {
                OrderId,
                Status,
                StatusDetail,
                CreatedAt,
            };
        }

        public object[] GenUpdateObject()
        {
            return new object[]
            {
            Id,
            OrderId,
            Status,
            StatusDetail,
            CreatedAt,
            };
        }
    }

}
