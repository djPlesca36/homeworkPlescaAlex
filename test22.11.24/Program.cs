using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineStore
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static List<Customer> customers = new List<Customer>();
        static List<Order> orders = new List<Order>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Create Order");
                Console.WriteLine("4. Display All");
                Console.WriteLine("5. Save to CSV");
                Console.WriteLine("6. Load from CSV");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 7)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddProduct(); break;
                    case 2: AddCustomer(); break;
                    case 3: CreateOrder(); break;
                    case 4: DisplayAll(); break;
                    case 5: SaveToCSV(); break;
                    case 6: LoadFromCSV(); break;
                    case 7: return;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("\n1. Add Electronics");
            Console.WriteLine("2. Add Clothing");
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Returning to menu.");
                return;
            }

            Console.Write("Enter product name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter product price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price)) price = 0;

            if (choice == 1)
            {
                Console.Write("Enter brand: ");
                string brand = Console.ReadLine() ?? "Unknown";

                Console.Write("Enter warranty months: ");
                if (!int.TryParse(Console.ReadLine(), out int warranty)) warranty = 0;

                products.Add(new Electronics(name, price, brand, warranty));
            }
            else if (choice == 2)
            {
                Console.Write("Enter size: ");
                string size = Console.ReadLine() ?? "Unknown";

                Console.Write("Enter color: ");
                string color = Console.ReadLine() ?? "Unknown";

                products.Add(new Clothing(name, price, size, color));
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter customer email: ");
            string email = Console.ReadLine() ?? "Unknown";

            customers.Add(new Customer(name, email));
        }

        static void CreateOrder()
        {
            if (products.Count == 0 || customers.Count == 0)
            {
                Console.WriteLine("Add products and customers first.");
                return;
            }

            Console.WriteLine("\nAvailable Customers:");
            for (int i = 0; i < customers.Count; i++) Console.WriteLine($"{i + 1}. {customers[i]}");

            Console.Write("Select customer: ");
            if (!int.TryParse(Console.ReadLine(), out int custIndex) || custIndex < 1 || custIndex > customers.Count)
            {
                Console.WriteLine("Invalid customer choice.");
                return;
            }

            Console.WriteLine("\nAvailable Products:");
            for (int i = 0; i < products.Count; i++) Console.WriteLine($"{i + 1}. {products[i]}");

            Console.Write("Select product: ");
            if (!int.TryParse(Console.ReadLine(), out int prodIndex) || prodIndex < 1 || prodIndex > products.Count)
            {
                Console.WriteLine("Invalid product choice.");
                return;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            orders.Add(new Order(customers[custIndex - 1], products[prodIndex - 1], quantity));
        }

        static void DisplayAll()
        {
            Console.WriteLine("\nProducts:");
            foreach (var product in products) Console.WriteLine(product);

            Console.WriteLine("\nCustomers:");
            foreach (var customer in customers) Console.WriteLine(customer);

            Console.WriteLine("\nOrders:");
            foreach (var order in orders) Console.WriteLine(order);
        }

        static void SaveToCSV()
        {
            using (StreamWriter writer = new StreamWriter("store_data.csv"))
            {
                foreach (var product in products)
                {
                    if (product is Electronics electronics)
                        writer.WriteLine($"Product,Electronics,{electronics.Name},{electronics.Price},{electronics.Brand},{electronics.WarrantyMonths}");
                    else if (product is Clothing clothing)
                        writer.WriteLine($"Product,Clothing,{clothing.Name},{clothing.Price},{clothing.Size},{clothing.Color}");
                }

                foreach (var customer in customers)
                    writer.WriteLine($"Customer,{customer.Name},{customer.Email}");

                foreach (var order in orders)
                    writer.WriteLine($"Order,{order.Customer.Name},{order.Product.Name},{order.Quantity}");
            }
            Console.WriteLine("Data saved to store_data.csv.");
        }

        static void LoadFromCSV()
        {
            if (!File.Exists("store_data.csv"))
            {
                Console.WriteLine("File not found. Returning to menu.");
                return;
            }

            products.Clear();
            customers.Clear();
            orders.Clear();

            using (StreamReader reader = new StreamReader("store_data.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    switch (parts[0])
                    {
                        case "Product":
                            if (parts[1] == "Electronics")
                                products.Add(new Electronics(parts[2], decimal.Parse(parts[3]), parts[4], int.Parse(parts[5])));
                            else if (parts[1] == "Clothing")
                                products.Add(new Clothing(parts[2], decimal.Parse(parts[3]), parts[4], parts[5]));
                            break;
                        case "Customer":
                            customers.Add(new Customer(parts[1], parts[2]));
                            break;
                        case "Order":
                            var customer = customers.Find(c => c.Name == parts[1]);
                            var product = products.Find(p => p.Name == parts[2]);

                            if (customer == null || product == null)
                            {
                                Console.WriteLine($"Warning: Invalid order data for customer '{parts[1]}' or product '{parts[2]}'. Skipping.");
                                continue;
                            }

                            orders.Add(new Order(customer, product, int.Parse(parts[3])));
                            break;
                    }
                }
            }
            Console.WriteLine("Data loaded from store_data.csv.");
        }
    }
}
