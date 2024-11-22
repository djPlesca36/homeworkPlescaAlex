namespace OnlineStore
{
    public class Electronics : Product
    {
        public string Brand { get; set; } = "Unknown";
        public int WarrantyMonths { get; set; } = 0;

        public Electronics(string name, decimal price, string brand, int warrantyMonths)
            : base(name, price)
        {
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        }

        public override string ToString()
        {
            return base.ToString() + $", Brand: {Brand}, Warranty: {WarrantyMonths} months";
        }
    }
}
