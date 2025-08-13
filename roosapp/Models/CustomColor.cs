namespace roosapp.models
{
    public class CustomColor
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        public string hex { get; set; }

        public CustomColor(string name, string hex)
        {
            this.name = name;
            this.hex = hex;
        }

        public CustomColor() { }
    }
}
