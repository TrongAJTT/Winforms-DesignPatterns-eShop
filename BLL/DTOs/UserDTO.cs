using System;

namespace _3S_eShop.BLL.DTOs
{
    public class UserDTO : BaseDTO<UserDTO>
    {
        private long id;
        private long roleId;
        private string email;
        private string password;
        private string username;
        private bool isActive;
        private string banReason;
        private DateTime createdDate;
        private DateTime lastLoginDate;

        public UserDTO(long id, long roleId, string email, string password, string username, bool isActive, string banReason, DateTime createdDate, DateTime lastLoginDate)
        {
            this.id = id;
            this.roleId = roleId;
            this.email = email;
            this.password = password;
            this.username = username;
            this.isActive = isActive;
            this.banReason = banReason;
            this.createdDate = createdDate;
            this.lastLoginDate = lastLoginDate;
        }

        public string TableName { get => "Users"; }
        public long Id { get => id; set => id = value; }
        public long RoleId { get => roleId; set => roleId = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string BanReason { get => banReason; set => banReason = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime LastLoginDate { get => lastLoginDate; set => lastLoginDate = value; }

        public bool Equals(UserDTO obj)
        {
            return (this.Id == obj.Id) || this.email.Equals(obj.email);
        }

        public object[] GenSaveObject()
        {
            return new object[] { this.roleId, this.email, this.password, this.username, this.createdDate, this.lastLoginDate };
        }

        public object[] GenUpdateObject()
        {
            return new object[] { this.email, this.password, this.username, this.IsActive, this.BanReason, this.lastLoginDate, this.Id };
        }

        public override string ToString()
        {
            return $"UserDTO: id={id}, roleId={roleId}, email={email}, password={password}, username={username}, isActive={isActive}, banReason={banReason}, createdDate={createdDate}, lastLoginDate={lastLoginDate}";
        }
    }
}
