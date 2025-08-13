namespace roosapp.models
{
    public class Color
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        public string hex { get; set; }

        public Color(string name, string hex)
        {
            this.name = name;
            this.hex = hex;
        }

        public Color() { }
    }
}
