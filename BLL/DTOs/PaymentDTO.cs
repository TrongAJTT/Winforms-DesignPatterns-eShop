using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class PaymentDTO : BaseDTO<PaymentDTO>
    {
 
        private long orderId;
        private DateTime payDate;
        private int amount;
        private string paymentMethod;
        private string paymentDetail;

        public PaymentDTO( long orderId, DateTime payDate, int amount, string paymentMethod, string paymentDetail)
        {
           
            OrderId = orderId;
            PayDate = payDate;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDetail = paymentDetail;
        }

        public string TableName => "Payments";


        public long OrderId { get => orderId; set => orderId = value; }
        public DateTime PayDate { get => payDate; set => payDate = value; }
        public int Amount { get => amount; set => amount = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string PaymentDetail { get => paymentDetail; set => paymentDetail = value; }

        public bool Equals(PaymentDTO obj)
        {
            return orderId == obj.orderId;
        }

        public object[] GenSaveObject()
        {
            return new object[]
            {
           
            OrderId,
            PayDate,
            Amount,
            PaymentMethod,
            PaymentDetail,
            };
        }

        public object[] GenUpdateObject()
        {
            return new object[]
            {
            OrderId,
            PayDate,
            Amount,
            PaymentMethod,
            PaymentDetail,
            };
        }
    }

}
