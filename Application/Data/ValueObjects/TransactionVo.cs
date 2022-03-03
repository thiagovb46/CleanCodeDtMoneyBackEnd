using System.Text.Json.Serialization;

namespace Application.Data.ValueObjects
{
    public class TransactionVo
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public float Ammount { get; set; }
        [JsonIgnore]
        public DateTime createdAt { get;set;}
    }
}
