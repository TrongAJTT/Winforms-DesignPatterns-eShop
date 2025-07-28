using System.Collections.Generic;

namespace _3S_eShop.DAL
{
    internal interface ICrudRepository<T, Tkey> where T : class
    {
        string TableName { get; }
        // Trả về tên tương ứng của bảng trên CSDL
        List<T> GetAll();
        // Trả về tất cả các bản ghi
        T GetById(Tkey id);
        // Lấy ra bản ghi theo id
        T Add(T entity);
        // Thêm một bản ghi và trả về bản ghi mới với id được cập nhật
        T Update(Tkey id, T entity);
        // Cập nhật bản ghi và trả về bản ghi với thông tin được cập nhật
        void Delete(T entity);
        // Xóa bản ghi
        void DeleteById(Tkey id);
        // Xóa bản ghi theo id
        long Count();
        // Đếm số bản ghi
        bool AnyMatch(string property, string value);
        // Kiểm tra xem có bản ghi nào khớp với điều kiện không
        List<T> FindMatch(string property, string value);
        // Tìm kiếm các bản ghi khớp với điều kiện
    }
}