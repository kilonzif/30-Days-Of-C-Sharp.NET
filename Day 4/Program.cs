using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop Example
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // While Loop Example
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }

            // For Each Loop Example
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            //Nested Loops 
            for (int i = 1; i <= 10; i++)
            {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"5 x {j} = {5*j}");
            }
            }

            //Do While Loops 
            int i = 1;
            do
            {
            Console.WriteLine(i);
            i++;
            } while (i <= 5);


                    
    }
    }
}





