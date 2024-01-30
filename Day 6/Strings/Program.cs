using System;
using System.Collections.Generic;

namespace Strings
{
    /// <summary>
    /// This namespace contains a collection of methods for string manipulation tasks.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            // Exercise 1: Count character frequencies
            string sampleString = "google.com";
            Dictionary<char, int> characterCounts = getCharacterFrequency(sampleString);
            Console.WriteLine(characterCounts);

            // Exercise 2: Combine first and last two characters
            string newString = getNewString("w3resource");
            Console.WriteLine(newString);

            // Exercise 3: Add "ing" or "ly" to the end
            string modifiedString = addEnding("abc");
            Console.WriteLine(modifiedString);
        }

        /// <summary>
        /// Counts the frequency of each character in a string.
        /// </summary>
        /// <param name="word">The input string.</param>
        /// <returns>A dictionary containing character frequencies.</returns>
        public static Dictionary<char, int> getCharacterFrequency(string word)
        {
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (characterCounts.ContainsKey(c))
                {
                    characterCounts[c]++;
                }
                else
                {
                    characterCounts.Add(c, 1);
                }
            }

            return characterCounts;
        }

        /// <summary>
        /// Creates a new string by combining the first two and last two characters of a given string.
        /// </summary>
        /// <param name="givenString">The input string.</param>
        /// <returns>The new string, or an empty string if the input length is less than 2.</returns>
        public static string getNewString(string givenString)
        {
            string newString = "";
            if (givenString.Length < 2)
            {
                return newString;
            }

            string beginStr = givenString.Substring(0, 2);
            string endStr = givenString.Substring(givenString.Length - 2);
            newString = beginStr + endStr;
            return newString;
        }

        /// <summary>
        /// Adds "ing" or "ly" to the end of a string based on its length and ending.
        /// </summary>
        /// <param name="givenStr">The input string.</param>
        /// <returns>The modified string.</returns>
        public static string addEnding(string givenStr)
        {
            if (givenStr.Length < 3)
            {
                return givenStr;
            }

            bool endsWithING = givenStr.EndsWith("ing");
            if (endsWithING)
            {
                return givenStr + "ly";
            }
            else
            {
                return givenStr + "ing";
            }
        }
    }
}
