using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.DAL.DAOs
{
    public class RoleDAO: ICrudRepository<RoleDTO, long>
    {
        public string TableName => "Roles";
        public RoleDTO Add(RoleDTO entity)
        {
            //TODO Tien - Add - RoleDAO
            throw new NotImplementedException();
        }
        public bool AnyMatch(string property, string value)
        {
            //TODO Tien - AnyMatch - RoleDAO
            throw new NotImplementedException();
        }
        public long Count()
        {
            //TODO Tien - Count - RoleDAO
            throw new NotImplementedException();
        }
        public void Delete(RoleDTO entity)
        {
            //TODO Tien - Delete - RoleDAO
            throw new NotImplementedException();
        }
        public void DeleteById(long id)
        {
            //TODO Tien - DeleteById - RoleDAO
            throw new NotImplementedException();
        }
        public List<RoleDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - RoleDAO
            throw new NotImplementedException();
        }
        public List<RoleDTO> GetAll()
        {
            //TODO Tien - GetAll - RoleDAO
            throw new NotImplementedException();
        }
        public RoleDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE id = {id}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0) return null;
            return new RoleBuilder().FromDataRow(dt.Rows[0]);
        }
        public RoleDTO Update(long id, RoleDTO entity)
        {
            //TODO Tien - Update - RoleDAO
            throw new NotImplementedException();
        }
    }
}
