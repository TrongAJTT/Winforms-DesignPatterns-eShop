using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.DAL.DAOs
{
    internal class CartProductDAO : ICrudRepository<CartProductDTO, long[]>
    {
        public string TableName => "Cart_Products";

        /// <summary>
        /// Không cập nhật lại bất kỳ thông tin nào của entity
        /// </summary>
        public CartProductDTO Add(CartProductDTO entity)
        {
            string query = $"insert into {TableName} values (@user, @prod, @vari, @quan)";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenSaveObject());
            return entity;
        }

        /// <summary>
        /// Hàm này không khả dụng với bảng này, sẽ luôn báo lỗi
        /// </summary>
        public bool AnyMatch(string property, string value)
        {
            string query = $"select count(*) from {TableName} where {property} = @value";
            return Convert.ToInt64(DataProvider.Instance.ExecuteScalar(query, value)) > 0;
        }

        public long Count()
        {
            return (long)DataProvider.Instance.CountRows(TableName);
        }

        public void Delete(CartProductDTO entity)
        {
            string query = $"delete from {TableName} " +
                $"where user_id = @userId and product_id = @product_id and variant_id = @variant_id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenIdentityObject());
        }

        /// <summary>
        /// 3 id lần lượt bao gồm: userId, product_id, variant_id
        /// </summary>
        public void DeleteById(long[] id)
        {
            string query = $"delete from {TableName} " +
                $"where user_id = @userId and product_id = @product_id and variant_id = @variant_id";
            DataProvider.Instance.ExecuteNonQuery(query, id);
        }

        public List<CartProductDTO> FindMatch(string property, string value)
        {
            DataTable dt = DataProvider.Instance.FindMatch(TableName, property, value);
            return new CartProductBuilder().FromDataTable(dt);
        }

        public List<CartProductDTO> GetAll()
        {
            string query = $"select * from {TableName}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return new CartProductBuilder().FromDataTable(dt);
        }

        public CartProductDTO GetById(long[] id)
        {
            string query = $"select * from {TableName} " +
                $"where user_id = @userId and product_id = @product_id and variant_id = @variant_id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, id[0], id[1], id[2]);
            if (dt.Rows.Count == 0) return null;
            return new CartProductBuilder().FromDataRow(dt.Rows[0]);
        }

        /// <summary>
        /// id chỉ bao gồm userId
        /// </summary>
        public CartProductDTO Update(long[] id, CartProductDTO entity)
        {
            entity.SetIdentity(id);
            string query = $"update {TableName} " +
                $"set quantity = @quantity where user_id = @userId and product_id = @product_id and variant_id = @variant_id";
            DataProvider.Instance.ExecuteNonQuery(query, entity.GenUpdateObject());
            return entity;
        }
    }
}
