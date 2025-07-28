using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder
{
    internal class UserAddressBuilder
    {
        private long id;
        private long userId;
        private string recipientName;
        private string recipientPhone;
        private string administrativeArea;
        private string streetAddress;
        private bool isDefault;

        public UserAddressBuilder SetAdministrativeArea(string administrativeArea)
        {
            this.administrativeArea = administrativeArea;
            return this;
        }

        public UserAddressBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public UserAddressBuilder SetIsDefault(bool isDefault)
        {
            this.isDefault = isDefault;
            return this;
        }

        public UserAddressBuilder SetRecipientPhone(string phonePhone)
        {
            this.recipientPhone = phonePhone;
            return this;
        }

        public UserAddressBuilder SetRecipentName(string recipentName)
        {
            this.recipientName = recipentName;
            return this;
        }

        public UserAddressBuilder SetStreetAddress(string streetAddress)
        {
            this.streetAddress = streetAddress;
            return this;
        }

        public UserAddressBuilder SetUserId(long userId)
        {
            this.userId = userId;
            return this;
        }

        public UserAddressDTO Build()
        {
            return new UserAddressDTO(id, userId, recipientName, recipientPhone, administrativeArea, streetAddress, isDefault);
        }

        public UserAddressBuilder Default()
        {
            this.id = -1;
            this.userId = -1;
            this.recipientName = string.Empty;
            this.recipientPhone = string.Empty;
            this.administrativeArea = string.Empty;
            this.streetAddress = string.Empty;
            this.isDefault = false;
            return this;
        }

        public UserAddressDTO FromDataRow(DataRow row)
        {
            return new UserAddressDTO(
                Convert.ToInt64(row[0]),
                Convert.ToInt64(row[1]),
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                row[5].ToString(),
                Convert.ToBoolean(row[6])
            );
        }

        public List<UserAddressDTO> FromDataTable(DataTable dt)
        {
            return dt.AsEnumerable().Select(row => FromDataRow(row)).ToList();
        }
    }
}
