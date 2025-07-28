using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    internal class DiscountDAO : ICrudRepository<DiscountDTO, long>
    {
        public string TableName => "Discounts";

        public DiscountDTO Add(DiscountDTO entity)
        {
            string query = $"INSERT INTO {TableName} (variantId, discountPrice, startDate, endDate) " +
                $"VALUES (@variantId, @discount, @start, @end)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = (long) DataProvider.Instance.GetLastInsertedId();
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

        public void Delete(DiscountDTO entity)
        {
            string query = $"DELETE FROM {TableName} WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"DELETE FROM {TableName} WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<DiscountDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new DiscountBuilder().FromDataTable(dt);
        }

        public List<DiscountDTO> GetAll()
        {
            string query = $"SELECT * FROM {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new DiscountBuilder().FromDataTable(dt);
        }

        public DiscountDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new DiscountBuilder().FromDataRow(dt.Rows[0]);
        }

        public DiscountDTO Update(long id, DiscountDTO entity)
        {
            string query = $"UPDATE {TableName} " +
                $"SET variantId = @variantId, discountPrice = @discount, " +
                    $"startDate = @start, endDate = @end " +
                $"WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            entity.Id = id;
            return entity;
        }
    }
}
