using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3S_eShop.DAL.DAOs
{
    internal class CategoryDAO : ICrudRepository<CategoryDTO, long>
    {
        public string TableName => "Categories";

        public CategoryDTO Add(CategoryDTO entity)
        {
            string query = $"insert into {TableName} (name, description, image130, image40) values (@name, @descr, @img130, @img40)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            return DataProvider.Instance.AnyMatch(TableName, property, value);
        }

        public long Count()
        {
            return (long)DataProvider.Instance.CountRows(TableName);
        }

        public void Delete(CategoryDTO entity)
        {
            string query = $"delete from {TableName} where id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"delete from {TableName} where id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<CategoryDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new CategoryBuilder().FromDataTable(dt);
        }

        public List<CategoryDTO> GetAll()
        {
            string query = $"select * from {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new CategoryBuilder().FromDataTable(dt);
        }

        public CategoryDTO GetById(long id)
        {
            string query = $"select * from {TableName} where id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new CategoryBuilder().FromDataRow(dt.Rows[0]);
        }

        public CategoryDTO Update(long id, CategoryDTO entity)
        {
            string query = $"update {TableName} " +
                $"set name = @name, description = @desc, image130 = @img130, image40 = @img40 " +
                $"where id = @id";
            var parameters = entity.GenUpdateObject().Concat(new object[] { id }).ToArray();
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return entity;
        }
    }
}
