using System;

namespace Conditionals
{
    class Solution
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // if-else 
            if (theVal == 50) {
                Console.WriteLine("theVal is 50");
            }
            else if (theVal >= 51 && theVal <= 60) {
                Console.WriteLine("theVal is between 51 and 60");
            }
            else {
                Console.WriteLine("theVal is something else");
            }

            // -----------------------
            // Using the ternary operator ?:

            // a two-case if-then
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }

            // can be replaced by a ternary operator ?:
            Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");


            //SWITCH 
            int x = 2;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x is equal to 1");
                    break;
                case 2:
                    Console.WriteLine("x is equal to 2");
                    break;
                default:
                    Console.WriteLine("x is not equal to 1 or 2");
                    break;
            }

        }
    }
}
