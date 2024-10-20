using System;

namespace homework1
{
    class Loop{
        public static void Run()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine ("Here is the loop of ...:");

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine (i);
            }

            
        }
    }
}
