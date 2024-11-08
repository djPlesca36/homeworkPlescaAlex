using System;
using System.Diagnostics;


namespace requirement1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please choose the operation you want to make");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice from 1 to 4: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

         if (choice == 1)
        {
            result = number1 + number2;
            Console.WriteLine("The result of addition is: {0}", result);
        }
        else if (choice == 2)
        {
            result = number1 - number2;
            Console.WriteLine("The result of subtraction is: {0}", result);
        }
        else if (choice == 3)
        {
            result = number1 * number2;
            Console.WriteLine("The result of multiplication is: {0}", result);
        }
        else if (choice == 4)
        {
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"The result of division is: {0}", result);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            return;
        }

        if (result > 0)
            Console.WriteLine("The result is positive.");
        else if (result < 0)
            Console.WriteLine("The result is negative.");
        else
            Console.WriteLine("The result is zero.");

        }
    }
}
