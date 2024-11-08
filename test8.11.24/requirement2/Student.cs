using System;
namespace requirement2
{
    public class Student
    {
        private string name = "Unknown";
        private int age = 18;

        public string Name
        {
            get { return name; }
            set { name = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        public int Age
        {
            get { return age; }
            set { age = value > 0 ? value : 18; }
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
