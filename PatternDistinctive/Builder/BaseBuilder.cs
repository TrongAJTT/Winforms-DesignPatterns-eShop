using System.Collections.Generic;
using System.Data;

namespace _3S_eShop.PatternDistinctive.DbBuilder
{
    internal interface BaseBuilder<T> where T : class
    {
        T Build();
        // Trả về một đối tượng T sau khi đã thiết lập các thuộc tính cần thiết.
        T FromDataRow(DataRow row);
        // Trả về một đối tượng T từ một dòng dữ liệu.
        List<T> FromDataTable(DataTable dt);
        // Trả về một danh sách các đối tượng T từ một bảng dữ liệu.
    }
}