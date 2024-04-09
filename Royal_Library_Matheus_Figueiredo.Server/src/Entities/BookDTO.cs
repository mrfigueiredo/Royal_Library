using Newtonsoft.Json;

namespace Royal_Library_Matheus_Figueiredo.Server.src.Entities
{
    public class BookDTO
    {
        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "Title")]
        public string title { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "Type")]
        public string type { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "Author")]
        public string author { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "Total Copies")]
        public int total_copies { get; set; }

        [JsonProperty(PropertyName = "Copies in Use")]
        public int copies_in_use { get; set; }

        [JsonProperty(PropertyName = "ISBN")]
        public string isbn { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "Category")]
        public string category { get; set; } = string.Empty;
    }
}
