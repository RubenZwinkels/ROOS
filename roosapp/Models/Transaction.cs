namespace roosapp.models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal amount { get; set; }
        public DateOnly date { get; set; }
        public string title { get; set; }
        public Place place { get; set; }    // TODO place maken en importen
        public List<Tag> tags { get; set; } // TODO tag maken en importen
				public Category category { get; set; } // TODO category maken en importen

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
