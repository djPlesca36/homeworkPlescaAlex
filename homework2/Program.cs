using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 310);
            Book book3 = new Book("Amintiri din Copilarie", "Mihai Eminescu", 269);

            book1.CheckOut();
            book2.ReturnBook();
            book3.CheckOut();

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book3.ToString());
        }
    }
}
