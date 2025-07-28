using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    internal class CouponDAO : ICrudRepository<CouponDTO, long>
    {
        public string TableName => "Coupons";

        public CouponDTO Add(CouponDTO entity)
        {
            string query = $"INSERT INTO {TableName} VALUES (@id, @disPer, @maxDisPer, @start, @stat, @expi, @remain)";
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
            return (long) DataProvider.Instance.CountRows(TableName);
        }

        public void Delete(CouponDTO entity)
        {
            string query = $"DELETE FROM {TableName} WHERE Id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"DELETE FROM {TableName} WHERE Id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<CouponDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new CouponBuilder().FromDataTable(dt);
        }

        public List<CouponDTO> GetAll()
        {
            string query = $"SELECT * FROM {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new CouponBuilder().FromDataTable(dt);
        }

        public CouponDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE Id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new CouponBuilder().FromDataRow(dt.Rows[0]);
        }

        public CouponDTO Update(long id, CouponDTO entity)
        {
            entity.Id = id;
            string query = $"UPDATE {TableName} " +
                $"SET discount_percent = @dis_der, max_discount_amount = @maxDisPer, start_date = @start, status = @stat, expiration_date = @expi, remaining_uses = @remain " +
                $"WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }
    }
}