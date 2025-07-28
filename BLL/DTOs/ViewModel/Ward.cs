using System.Text.Json.Serialization;

namespace _3S_eShop.BLL.DTOs.ViewModel
{
    public class Ward
    {
        // Sử dụng [JsonPropertyName] nếu tên trong JSON là "Name", "Id" (viết hoa)
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        // Ghi đè ToString để ComboBox hiển thị tên dễ dàng (Cách 1)
        // public override string ToString() => Name;
    }
}
