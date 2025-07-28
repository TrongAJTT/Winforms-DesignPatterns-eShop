namespace _3S_eShop.BLL.DTOs
{
    interface BaseDTO<T> where T : class
    {
        string TableName { get; }
        // Trả về tên tương ứng của bảng trên CSDL
        bool Equals(T obj);
        // So sánh 2 đối tượng, phục vụ cho việc kiểm tra trùng lặp ở một số thuộc tính nhất định.
        object[] GenSaveObject();
        // Tạo mảng object chứa các giá trị của đối tượng, phục vụ cho việc lưu trữ dữ liệu vào CSDL.
        // Tương quan với hàm Add ở lớp DAO.
        object[] GenUpdateObject();
        // Tạo mảng object chứa các giá trị của đối tượng, phục vụ cho việc cập nhật dữ liệu vào CSDL.
        // Tương quan với hàm Update ở lớp DAO.
        // PS: Nhiều bảng có các tham số khi lưu lên csdl và cập nhật csdl giống nhau.
    }
}
