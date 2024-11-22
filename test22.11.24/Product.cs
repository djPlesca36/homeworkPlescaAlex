using System;
namespace OnlineStore
{
    public class Product
    {
        private string name = "Unknown";
        private decimal price = 0;

        public string Name
        {
            get { return name; }
            set { name = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value > 0 ? value : 0; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price:C}";
        }
    }
}
