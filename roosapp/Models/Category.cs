namespace roosapp.models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string name { get; set; }

        public Category() { }

        public Category(string name)
        {
            this.name = name;
        }
    }
}
