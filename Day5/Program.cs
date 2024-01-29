using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = Sum(numbers);
            Console.WriteLine(sum); // Output: 15

            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int secondLargest = SecondLargest(numbers2);
            Console.WriteLine(secondLargest); // Output: 7

            PrintPersonInfo("John Doe", 25, "Software Engineer"); // Output: My name is John Doe, I am 25 years old and I work as a Software Engineer.

        }




        //Calculate the sum of all the numbers in a given list 

        public static int Sum(List<int> numbers)
        {
            return numbers.Sum();
        }

        //second-largest number in a list
        public static int SecondLargest(List<int> numbers)
            {
                if (numbers.Count < 2)
                {
                    throw new ArgumentException("The list must contain at least two numbers.");
                }

                int largest = numbers[0];
                int secondLargest = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > largest)
                    {
                        secondLargest = largest;
                        largest = number;
                    }
                    else if (number > secondLargest && number != largest)
                    {
                        secondLargest = number;
                    }
                }

                return secondLargest;
            }


            /* Printing Info About A  Person*/
            public static void PrintPersonInfo(string name, int age, string occupation)
                {
                    Console.WriteLine($"My name is {name}, I am {age} years old and I work as a {occupation}.");
                }


    }
    
    
  

}