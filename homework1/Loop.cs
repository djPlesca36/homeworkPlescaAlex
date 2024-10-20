using System;
namespace homework1
{
     class Loop{
        public static void Run()
        {
            Console.WriteLine("Using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Using a while loop to display numbers from 1 to 5
        Console.WriteLine("\nUsing a while loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Using a do-while loop to display numbers from 1 to 5
        Console.WriteLine("\nUsing a do-while loop:");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        }while (k <= 5);
        }
    }
}
