using System.Text.Json.Serialization;

namespace NadavBookstore
{
    public class Book
    {
        [JsonPropertyName("@id")]
        public string BookId { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("publish_date")]
        public DateTime PublishDate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
