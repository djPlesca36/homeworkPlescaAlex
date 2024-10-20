using System;

namespace homework1

{
    class DataTypesDisplay{
        public static void Run()
        {
            Console.WriteLine("Displaying various data types in C#:");
            int integerValue = 10;
            double doubleValue = 10.5;
            char charValue = 'A';
            string stringValue = "Hello, World!";
            bool boolValue = true;

            Console.WriteLine($"Integer: {integerValue}");
            Console.WriteLine($"Double: {doubleValue}");
            Console.WriteLine($"Char: {charValue}");
            Console.WriteLine($"String: {stringValue}");
            Console.WriteLine($"Boolean: {boolValue}");
        }
    }
}
