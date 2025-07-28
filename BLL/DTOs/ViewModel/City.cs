using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace _3S_eShop.BLL.DTOs.ViewModel
{
    public class City
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Districts")]
        public List<District> Districts { get; set; }

        // public override string ToString() => Name;
    }
}
