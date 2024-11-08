using System;
namespace requirement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's name: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Unknown";
            }

            Console.Write("Enter the student's age: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                age = 18;
            }

            Student student = new Student(name, age);
            student.DisplayInfo();
        }
    }
}
