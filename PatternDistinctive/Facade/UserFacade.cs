using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL;
using _3S_eShop.DAL.DAOs;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3S_eShop.PatternDistinctive.Facade
{
    internal class UserFacade
    {
        private ICrudRepository<UserDTO, long> repository;

        public UserFacade(ICrudRepository<UserDTO, long> repository)
        {
            this.repository = repository;
        }

        public void UpdateActive(long id, bool isActive, string banReason)
        {
            if(repository is UserDAO user)
            {
                user.UpdateActive(id, isActive, banReason);
            }
            
        }

        public void UpdateEmail(long id, string email)
        {
            UserDTO userDTO = repository.GetById(id);
            if(userDTO == null)
            {
                return;
            }
            userDTO.Email = email;
            repository.Update(id, userDTO);
            MainForm.User.Email = email;
        }

        public void UpdateUsername(long id, string username)
        {
            UserDTO userDTO = repository.GetById(id);
            if (userDTO == null)
            {
                throw new Exception("User not found");
            }
            userDTO.Username = username;
            repository.Update(id, userDTO);
            MainForm.User.Username = username;
        }
    }
}
