namespace roosapp.models
{
    public class Place
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        public Tag? tag { get; set; } // TODO tag maken en importen

        public Place() { }

        public Place(string name, Tag? tag)
        {
            this.name = name;
            this.tag = tag;
        }
    }
}
