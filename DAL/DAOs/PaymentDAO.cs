using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.DAL.DAOs
{
    internal class PaymentDAO : ICrudRepository<PaymentDTO, long>
    {
        public string TableName => throw new NotImplementedException();

        public PaymentDTO Add(PaymentDTO entity)
        {
            //TODO Add PaymentDAO

            throw new NotImplementedException();
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO AnyMatch PaymentDAO

            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Count PaymentDAO

            throw new NotImplementedException();
        }

        public void Delete(PaymentDTO entity)
        {
            //TODO Delete PaymentDAO

            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO DeleteById PaymentDAO

            throw new NotImplementedException();
        }

        public List<PaymentDTO> FindMatch(string property, string value)
        {
            //TODO FindMatch PaymentDAO

            throw new NotImplementedException();
        }

        public List<PaymentDTO> GetAll()
        {
            //TODO GetAll PaymentDAO

            throw new NotImplementedException();
        }

        public PaymentDTO GetById(long id)
        {
            //TODO GetById PaymentDAO

            throw new NotImplementedException();
        }

        public PaymentDTO Update(long id, PaymentDTO entity)
        {
            //TODO Update PaymentDAO

            throw new NotImplementedException();
        }
    }
}
