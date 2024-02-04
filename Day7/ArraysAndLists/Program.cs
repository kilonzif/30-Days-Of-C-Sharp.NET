using System;
using System.Collections.Generic;

namespace ArraysAndLists

{
    /// <summary>
    /// This namespace contains a collection of methods for Classes and Objects in C#.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            //TwoSum Test
            //Example 1:

         nums = [2,7,11,15], target = 9
      
        Console.WriteLine(nums);

            // Example 2:

            // Input: nums = [3,2,4], target = 6
            // Output: [1,2]
            // Example 3:

            // Input: nums = [3,3], target = 6
            // Output: [0,1]

        }

       

        /* 
       Two Sum: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
       You may assume that each input would have exactly one solution, and you may not use the same element twice. You can return the answer in any order. Input: nums = [2,7,11,15], target = 9 Output: [0,1]
        */

      public int[] TwoSum(int[] nums, int target) {
      Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement)) {
                return new int[] { numIndices[complement], i };
            }

            if (!numIndices.ContainsKey(nums[i])) {
                numIndices[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }


 
        }
    }
}
