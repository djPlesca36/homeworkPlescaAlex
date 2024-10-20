using System;
using System.Diagnostics;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                  ");
            Console.WriteLine("~~~~~~ Laboratory Homework 1  -  20.10.2024 ~~~~~~");
            Console.WriteLine("~~~~~ Welcome to the C# Console Application! ~~~~~");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Data Types Display");
            Console.WriteLine("2. Basic Math Operations");
            Console.WriteLine("3. Conditional Statements");
            Console.WriteLine("4. Loop Demonstration");
            Console.WriteLine("5. Exit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter your choice (1-5):");
            Console.WriteLine("                                                  ");

            string? input = Console.ReadLine();

            string choice = input ?? "Invalid";

            switch (choice)
            {
                case "1":
                    DataTypesDisplay.Run();
                    break;

                case "2":
                    BasicMathOperations.Run();
                    break;

                case "3":
                    ConditionalStatements.Run();
                    break;

                case "4":
                    Loop.Run();
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the application. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                    break;
            }
        }
    }
}
