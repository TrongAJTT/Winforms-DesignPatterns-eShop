using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL.DTOs
{
    public class UserAddressDTO : BaseDTO<UserAddressDTO>
    {
        private long id;
        private long userId;
        private string recipientName;
        private string recipientPhone;
        private string administrativeArea;
        private string streetAddress;
        private bool isDefault;

        public UserAddressDTO
        (
            long id, 
            long userId, 
            string recipientName, 
            string recipientPhone, 
            string administrativeArea, 
            string streetAddress, 
            bool isDefault
        )
        {
            this.Id = id;
            this.UserId = userId;
            this.RecipientName = recipientName;
            this.RecipientPhone = recipientPhone;
            this.AdministrativeArea = administrativeArea;
            this.StreetAddress = streetAddress;
            this.IsDefault = isDefault;
        }

        public string TableName => "User_Address";

        public long Id { get => id; set => id = value; }
        public long UserId { get => userId; set => userId = value; }
        public string RecipientName { get => recipientName; set => recipientName = value; }
        public string RecipientPhone { get => recipientPhone; set => recipientPhone = value; }
        public string AdministrativeArea { get => administrativeArea; set => administrativeArea = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public bool IsDefault { get => isDefault; set => isDefault = value; }

        public bool Equals(UserAddressDTO obj)
        {
            return this.Id == obj.Id || (this.UserId == obj.UserId && this.RecipientName == obj.RecipientName && this.RecipientPhone == obj.RecipientPhone && this.AdministrativeArea == obj.AdministrativeArea && this.StreetAddress == obj.StreetAddress && this.IsDefault == obj.IsDefault);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.UserId, this.RecipientName, this.RecipientPhone, this.AdministrativeArea, this.StreetAddress, this.IsDefault };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.UserId, this.RecipientName, this.RecipientPhone, this.AdministrativeArea, this.StreetAddress, this.IsDefault, this.Id };
        }
    }
}
