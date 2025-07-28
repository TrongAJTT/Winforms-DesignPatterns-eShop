using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class PaymentBuilder
    {
        private long orderId;
        private DateTime payDate;
        private int amount;
        private string paymentMethod;
        private string paymentDetail;

        public PaymentBuilder SetOrderId(long orderId)
        {
            this.orderId = orderId;
            return this;
        }

        public PaymentBuilder SetPayDate(DateTime payDate)
        {
            this.payDate = payDate;
            return this;
        }

        public PaymentBuilder SetPaymentDetail(string paymentDetail)
        {
            this.paymentDetail = paymentDetail;
            return this;
        }

        public PaymentBuilder SetPaymentMethod(string paymentMethod)
        {
            this.paymentMethod = paymentMethod;
            return this;
        }
        public PaymentBuilder SetAmount(int amount)
        {
            throw new NotImplementedException();
        }
        public PaymentDTO Build()
        {
            return new PaymentDTO(orderId, payDate, amount, paymentMethod, paymentDetail);
        }

        public PaymentDTO FromDataRow(DataRow row)
        {
            return new PaymentDTO
                (
                    Convert.ToInt64(row["order_id"]),
                    DateTime.Parse(row["pay_date"].ToString()),
                    Convert.ToInt32(row["amount"]),
                    row["payment_method"].ToString(),
                    row["payment_detail"].ToString()
                );
        }

        public List<PaymentDTO> FromDataTable(DataTable dt)
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();

            foreach (DataRow row in dt.Rows)
            {
                payments.Add(FromDataRow(row));
            }
            return payments;
        }

       

    }
}
