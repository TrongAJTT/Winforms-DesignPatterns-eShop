using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;

namespace _3S_eShop.BLL
{
    internal class UserAddressBLL
    {
        private UserAddressDAO dao;

        public UserAddressBLL(UserAddressDAO userAddressDAO)
        {
            this.dao = userAddressDAO;
        }

        public List<UserAddressDTO> GetAddressOfUser(long userId)
        {
            return dao.GetByUserId(userId);
        }

        internal UserAddressDTO AddAddressForUser(long userId, UserAddressDTO address)
        {
            address.UserId = userId;
            // Nếu người dùng chưa có địa chỉ thì bắt buộc phải có địa chỉ mặc định
            if (!dao.AnyMatch("user_id", userId.ToString()))
            {
                MySystem.ShowToastMessageAtTopRight("Địa chỉ đầu tiên, mặc định đã được thiết lập cho bạn");
                address.IsDefault = true;
            }
            // Tải địa chỉ lên
            return dao.Add(address);
        }

        internal void SetDefaultAddressFor(long id)
        {
            var address = dao.GetById(id);
            if (address == null) return;
            // Set all other addresses to not default
            var allAddresses = dao.GetByUserId(address.UserId);
            foreach (var addr in allAddresses)
            {
                if (addr.Id != id && addr.IsDefault)
                {
                    addr.IsDefault = false;
                    dao.Update(addr.Id, addr);
                }
            }
            // Set the selected address to default
            address.IsDefault = true;
            dao.Update(address.Id, address);
        }
    }
}
