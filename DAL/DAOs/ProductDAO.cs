using System;
using System.Collections.Generic;
using System.Data;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.DAL.DAOs
{
    public class ProductDAO: ICrudRepository<ProductDTO, long>
    {
        public string TableName => "Products";
        public ProductDTO Add(ProductDTO entity)
        {
            string query = $"INSERT INTO {TableName} (category_id, brand_id, name, description, specification, thumb, images, status, warranty, hide, created_at) " +
                $"VALUES (@cate, @brand, @pname, @desc, @spec, @thum, @image, @stat, @warr, @hid, @create);";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            entity.Id = Convert.ToInt64(DataProvider.Instance.GetLastInsertedId());
            return entity;
        }

        public bool AnyMatch(string property, string value)
        {
            string query = $"SELECT COUNT(*) FROM {TableName} WHERE {property} like @value";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, value)) > 0;
        }

        public long Count()
        {
            //TODO Tien - Count - ProductDAO
            throw new NotImplementedException();
        }

        public void Delete(ProductDTO entity)
        {
            //TODO Tien - Delete - ProductDAO
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            //TODO Tien - DeleteById - ProductDAO
            throw new NotImplementedException();
        }
        
        public List<ProductDTO> FindMatch(string property, string value)
        {
            //TODO Tien - FindMatch - ProductDAO
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAll()
        {
            //TODO Tien - GetAll - ProductDAO
            throw new NotImplementedException();
        }

        public ProductDTO GetById(long id)
        {
            string query = $"SELECT * FROM {TableName} WHERE id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id);
            if (dt.Rows.Count == 0) return null;
            return new ProductBuilder().FromDataRow(dt.Rows[0]);
        }

        public ProductDTO Update(long id, ProductDTO entity)
        {
            string query = $"UPDATE {TableName} SET category_id = @cate, brand_id = @brand, name = @pname, description = @desc, specification = @spec, thumb = @thum, images = @image, status = @stat, warranty = @warr, hide = @hid, created_at = @create WHERE id = @id;";
            entity.Id = id;
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }

        public long GetProductCountBaseOnStatus(string status)
        {
            string query = $"SELECT COUNT(*) FROM {TableName} " +
                $"WHERE status = @status AND hide = 0";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, status));
        }

    }
}
