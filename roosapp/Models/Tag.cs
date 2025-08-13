namespace roosapp.models
{
    public class Tag
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        public CustomColor color { get; set; }

        public Tag(string name, CustomColor color)
        {
            this.name = name;
            this.color = color;
        }

        public Tag() { }

        public Tag(string name, string colorName, string colorHex)
        {
            this.name = name;
            this.color = new CustomColor(colorName, colorHex);
        }
    }
}
