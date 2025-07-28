using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.DAL.DAOs
{
    public class ProductVariantDAO : ICrudRepository<ProductVariantDTO, long>
    {
        public string TableName => "Product_Variants";

        public ProductVariantDTO Add(ProductVariantDTO entity)
        {
            string query = $"INSERT INTO {TableName} (product_id, label, description, price, discount_price, stock_quantity) VALUES (@prodId, @lbl, @desc, @pri, @disprice, @stock);";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            //TODO Tien - AnyMatch - ProductVariantDAO
            throw new NotImplementedException();
        }

        public long Count()
        {
            //TODO Tien - Count - ProductVariantDAO
            throw new NotImplementedException();
        }

        public void Delete(ProductVariantDTO entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(long id)
        {
            string query = $"DELETE FROM {TableName} WHERE id = @id;";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<ProductVariantDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - ProductVariantDAO
            throw new NotImplementedException();
        }

        public List<ProductVariantDTO> GetAll()
        {
            //TODO Tien - GetAll - ProductVariantDAO
            throw new NotImplementedException();
        }

        public ProductVariantDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE id = @id;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt == null || dt.Rows.Count == 0) return null;
            return new ProductVariantBuilder().FromDataRow(dt.Rows[0]);
        }

        public ProductVariantDTO Update(long id, ProductVariantDTO entity)
        {
            string query = $"UPDATE {TableName} SET product_id = @prodId, label = @lbl, description = @desc, price = @pri, discount_price = @disprice, stock_quantity = @stock WHERE id = @id;";
            entity.Id = id;
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }

        public List<ProductVariantDTO> GetByProductId(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE product_id = @prodId;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt == null) return null;
            return new ProductVariantBuilder().FromDataTable(dt);
        }
    }
}
