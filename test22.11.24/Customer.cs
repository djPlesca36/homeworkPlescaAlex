namespace OnlineStore
{
    public class Customer
    {
        public string Name { get; set; } = "Unknown";
        public string Email { get; set; } = "Unknown";

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Customer: {Name}, Email: {Email}";
        }
    }
}
