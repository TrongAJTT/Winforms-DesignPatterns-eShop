using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class OrderProducts : BaseDTO<OrderProducts>
    {
        private long id;
        private long order_id;
        private long product_id;
        private byte quantity;
        private int origional_price;
        private int final_price;
        public string TableName => "OrderProducts";

        public bool Equals(OrderProducts obj)
        {
            throw new NotImplementedException();
        }

        public object[] GenSaveObject()
        {
            throw new NotImplementedException();
        }

        public object[] GenUpdateObject()
        {
            throw new NotImplementedException();
        }
    }
}
