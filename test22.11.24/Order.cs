namespace OnlineStore
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Order(Customer customer, Product product, int quantity)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Order: {Customer.Name} ordered {Quantity} x {Product.Name} (Total: {Product.Price * Quantity:C})";
        }
    }
}
