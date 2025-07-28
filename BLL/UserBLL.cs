using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.BLL
{
    internal class UserBLL
    {
        private UserDAO userDAO;

        public UserBLL(UserDAO userDAO)
        {
            this.userDAO = userDAO;
        }

        public UserDTO AddUser(string email, string password, string username)
        {
            // Thêm user lên hệ thống
            UserDTO userDTO = new UserBuilder().Default()
                .SetEmail(email)
                .SetPassword(Cipher3S.AESIV.Encrypt(password))
                .SetUsername(username).Build();
            userDTO = userDAO.Add(userDTO);
            // Thêm các dữ liệu mặc định (chạy nền)
            Task.Run(() => {
                new RewardPointBLL(new RewardPointDAO()).AddRewardPointForNewUser(userDTO.Id);
                new CustomerChatBLL(new CustomerChatDAO()).AddChatForNewUser(userDTO.Id);
            });
            // Trả giá trị
            return userDTO;
        }   

        public Boolean IsDuplicateEmail(string email)
        {
            return userDAO.AnyMatch("email", email);
        }

        public UserDTO GetMatchEmail(string email)
        {
            List<UserDTO> lists = userDAO.FindMatch("email", email);
            return lists.Count > 0 ? lists[0] : null;
        }

        public void ChangePassword(string email, string newPassword)
        {
            UserDTO userDTO = GetMatchEmail(email);
            userDTO.Password = Cipher3S.AESIV.Encrypt(newPassword);
            userDAO.Update(userDTO.Id, userDTO);
        }

        public void UpdateLasteLoginDate(UserDTO userDTO)
        {
            userDTO.LastLoginDate = DateTime.Now;
            userDAO.Update(userDTO.Id, userDTO);
        }

        public long GetBannedUserCount()
        {
            String query = $"select count(*) from {userDAO.TableName} where is_active = 0";
            return (long) DataProvider.Instance.ExecuteScalar(query);
        }

        public void StopAccount(long userId, string reason)
        {
            StringBuilder builder = new StringBuilder("Bạn đã dừng tài khoản của mình vào " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            if (string.IsNullOrEmpty(reason))
            {
                builder.Append(" mà không nêu rõ lý do.");
            }
            else
            {
                builder.Append(" với lý do: " + reason + ".");
            }
            UserDTO userDTO = userDAO.GetById(userId);
            userDTO.IsActive = false;
            userDTO.BanReason = builder.ToString();
            userDAO.Update(userId, userDTO);
        }

    }
}
