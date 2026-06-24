using System.Text.Json.Serialization;

namespace SShop.API.Models
{
    public class ShoppingItemDto
    {
        // Use JsonPropertyName to map the exact JSON keys from the website
        [JsonPropertyName("id")]
        public string WebsiteId { get; set; } = string.Empty;

        [JsonPropertyName("product_name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("cost")]
        public decimal Cost { get; set; }
    }
}
