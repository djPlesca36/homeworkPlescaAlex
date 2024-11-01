using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Book object using the first constructor
            Book book1 = new Book("1984", "George Orwell");

            // Instantiate another Book object using the second constructor
            Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 310);

            // Call CheckOut on book1 and ReturnBook on book2
            book1.CheckOut();
            book2.ReturnBook();

            // Print details of both books using the overridden ToString() method
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
        }
    }
}
