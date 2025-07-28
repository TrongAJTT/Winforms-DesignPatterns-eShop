using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    internal class BrandDAO : ICrudRepository<BrandDTO, long>
    {
        public string TableName => "Brands";

        public BrandDTO Add(BrandDTO entity)
        {
            string query = $"INSERT INTO {TableName} (category_id, name, description, image130, image40) VALUES (@cateId, @name, @description, @img130, @img40)";
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

        public void Delete(BrandDTO entity)
        {
            string query = $"DELETE FROM {TableName} WHERE Id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"DELETE FROM {TableName} WHERE Id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<BrandDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new BrandBuilder().FromDataTable(dt);
        }

        public List<BrandDTO> GetAll()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery($"SELECT * FROM {TableName}");
            return new BrandBuilder().FromDataTable(dt);
        }

        public BrandDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE Id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new BrandBuilder().FromDataRow(dt.Rows[0]);
        }

        public BrandDTO Update(long id, BrandDTO entity)
        {
            entity.Id = id;
            string query = $"UPDATE {TableName} " +
                $"SET category_id = @cateId, name = @name, description = @description, image130 = @img130, image40 = @img40 " +
                $"WHERE Id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }

        public List<BrandDTO> FindByCategory(long categoryId)
        {
            string query = $"SELECT * FROM {TableName} WHERE category_id = @cateId";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, categoryId);
            return new BrandBuilder().FromDataTable(dt);
        }
    }
}
