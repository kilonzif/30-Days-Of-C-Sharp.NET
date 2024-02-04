using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Dictionaries
{
    /// <summary>
    /// This namespace contains a collection of methods for Dictionaries in C#.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
      
            //1. creating a dictionary 
            Dictionary<string, int> fruits = new Dictionary<string, int>();

            //2. Adding Key-Value Pairs:
            fruits.Add("Apple", 10);
            fruits.Add("Banana", 15);
            fruits.Add("Orange", 20);

            //3. Accessing Values by Key:
            int appleCount = fruits["Apple"];  // Output: 10

            //4. Handling Potential Key Absence:

            int mangoCount;
            if (fruits.TryGetValue("Mango", out mangoCount))
            {
                Console.WriteLine("Key found, mangoCount now holds the value");
            }
            else
            {
                Console.WriteLine("Key not found"); 
            }

            //5. Iterating Over Key-Value Pairs:
            foreach (KeyValuePair<string, int> fruit in fruits)
                {
                    Console.WriteLine($"{fruit.Key}: {fruit.Value}");
                }

            //6. Checking for Key Existence:
            bool hasBanana = fruits.ContainsKey("Banana");  // Returns true

            //7. Removing Key-Value Pairs:
            fruits.Clear();


           // 8. Clearing the Dictionary:

            
            fruits.Clear();

            // 9. Counting Key-Value Pairs:
            int totalFruits = fruits.Count;

           // 10. Using SortedDictionary for Ordered Access:

            SortedDictionary<string, int> sortedFruits = new SortedDictionary<string, int>(fruits);

            // 11. Using ConcurrentDictionary for Thread Safety:

            ConcurrentDictionary<string, int> threadSafeFruits = new ConcurrentDictionary<string, int>();



        }

       

   


 
        }
    }
}
