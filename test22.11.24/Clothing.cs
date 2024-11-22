namespace OnlineStore
{
    public class Clothing : Product
    {
        public string Size { get; set; } = "Unknown";
        public string Color { get; set; } = "Unknown";

        public Clothing(string name, decimal price, string size, string color)
            : base(name, price)
        {
            Size = size;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $", Size: {Size}, Color: {Color}";
        }
    }
}
