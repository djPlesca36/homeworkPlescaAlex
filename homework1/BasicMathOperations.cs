using System;

namespace homework1

{
    class BasicMathOperations{
        public static void Run()
        {
            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {(num2 != 0 ? (num1 / num2).ToString() : "Cannot divide by zero")}");
        }
    }
}
