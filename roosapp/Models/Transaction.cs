namespace roosapp.models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal amount { get; set; }
        public DateOnly date { get; set; }
        public string title { get; set; }
        public Place? place { get; set; }
        public List<Tag>? tags { get; set; }
				public Category category { get; set; }

        public Transaction(decimal amount, DateOnly date, string title, Place place, List<Tag> tags, Category category)
        {
            this.amount = amount;
            this.date = date;
            this.title = title;
            this.place = place;
            this.tags = tags;
            this.category = category;
        }

        public Transaction()
        {
        }
    }

}
