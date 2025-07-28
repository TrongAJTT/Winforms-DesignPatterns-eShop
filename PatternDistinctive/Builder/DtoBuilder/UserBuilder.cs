using _3S_eShop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder
{
    internal class UserBuilder
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

        public UserBuilder Default()
        {
            this.id = -1;
            this.roleId = 2;
            this.isActive = true;
            this.createdDate = DateTime.Now;
            this.lastLoginDate = DateTime.Now;
            return this;
        }

        public UserBuilder SetActive(bool active)
        {
            this.isActive = active;
            return this;
        }

        public UserBuilder SetBanReason(string banReason)
        {
            this.banReason = banReason;
            return this;
        }

        public UserBuilder SetCreatedAt(DateTime createdAt)
        {
            this.createdDate = createdAt;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            this.email = email;
            return this;
        }

        public UserBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public UserBuilder SetLastLoginDate(DateTime lastLoginDate)
        {
            this.lastLoginDate = lastLoginDate;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            this.password = password;
            return this;
        }

        public UserBuilder SetRoleId(long roleId)
        {
            this.roleId = roleId;
            return this;
        }

        public UserBuilder SetUsername(string username)
        {
            this.username = username;
            return this;
        }

        public UserDTO Build()
        {
            return new UserDTO(id, roleId, email, password, username, isActive, banReason, createdDate, lastLoginDate);
        }

        public UserDTO FromDataRow(DataRow row)
        {
            return new UserBuilder()
                .SetId(Convert.ToInt64(row["id"]))
                .SetRoleId(Convert.ToInt64(row["role_id"]))
                .SetEmail(row["email"].ToString())
                .SetPassword(row["password"].ToString())
                .SetUsername(row["username"].ToString())
                .SetActive(Convert.ToBoolean(row["is_active"]))
                .SetBanReason(row["ban_reason"]?.ToString())
                .SetCreatedAt(Convert.ToDateTime(row["created_date"]))
                .SetLastLoginDate(Convert.ToDateTime(row["last_login_date"]))
                .Build();
        }

        public List<UserDTO> FromDataTable(DataTable dt)
        {
            List<UserDTO> list = new List<UserDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(FromDataRow(row));
            }
            return list;
        }
    }
}