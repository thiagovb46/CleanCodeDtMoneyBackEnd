namespace Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string  Category { get; set; }
        public float Ammount { get; set; }
        public DateTime createdAt { get; set; }
    }
}
