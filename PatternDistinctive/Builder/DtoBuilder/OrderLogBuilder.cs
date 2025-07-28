using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class OrderLogBuilder
    {
        private long id;
        private long orderId;
        private string status;
        private string statusDetail;
        private DateTime createdAt;
        public OrderLogDTO Build()
        {
            return new OrderLogDTO
            (
                this.id,
                this.orderId,
                this.status,
                this.statusDetail,
                this.createdAt
            );
        }

        public OrderLogDTO FromDataRow(DataRow row)
        {
            return new OrderLogDTO
            (
                row.Field<long>("id"),
                row.Field<long>("order_id"),
                row.Field<string>("status"),
                row.Field<string>("status_detail"),
                row.Field<DateTime>("created_at")
            );
        }

        public List<OrderLogDTO> FromDataTable(DataTable dt)
        {
            List<OrderLogDTO> logs = new List<OrderLogDTO>();
            foreach (DataRow row in dt.Rows)
            {
                logs.Add(FromDataRow(row));
            }
            return logs;
        }

        public OrderLogBuilder SetCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }

        public OrderLogBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public OrderLogBuilder SetOrderId(long orderId)
        {
            this.orderId = orderId;
            return this;
        }

        public OrderLogBuilder SetStatus(string status)
        {
            this.status = status;
            return this;
        }

        public OrderLogBuilder SetStatusDetail(string statusDetail)
        {
            this.statusDetail = statusDetail;
            return this;
        }
    }
}
