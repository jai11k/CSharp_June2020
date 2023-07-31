using Ch2_TypesInCSharp;
using Ch3_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs
{
    public class FindTwoNumbersThatAddUpToTheTargetSum
    {
        static void Main()
        {
            //probelm

            //Given an array of integers and a target sum, find two numbers that add up to make the target sum. c#


            int[] arr = { 2, 7, 11, 15 }; // Example input array
            int targetSum = 9; // Example target sum

            int[] result = FindTwoNumbersWithTargetSum(arr, targetSum);

            if (result.Length == 2)
            {
                Console.WriteLine($"The two numbers are at indices {result[0]} and {result[1]}.");
                Console.WriteLine($"The numbers are {arr[result[0]]} and {arr[result[1]]}.");
            }
            else
            {
                Console.WriteLine("No two numbers found that add up to the target sum.");
            }
        }
        static int[] FindTwoNumbersWithTargetSum(int[] nums, int targetSum)
        {
            // Create a dictionary to store the elements seen so far and their indices
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = targetSum - nums[i];

                // Check if the complement is present in the dictionary
                if (numIndices.TryGetValue(complement, out int complementIndex))
                {
                    // Return the indices of the two numbers that add up to the target sum
                    return new int[] { complementIndex, i };
                }

                // Add the current element to the dictionary with its index
                numIndices[nums[i]] = i;
            }

            // If no pair is found, return an empty array
            return new int[0];
        }

        static int[] FindTwoNumbersWithTargetSumAnother(int[] nums, int targetSum)
        {
            // Sort the array in ascending order
            Array.Sort(nums);

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int currentSum = nums[left] + nums[right];

                if (currentSum == targetSum)
                {
                    // Return the indices of the two numbers that add up to the target sum
                    return new int[] { left, right };
                }
                else if (currentSum < targetSum)
                {
                    // Move the left pointer to increase the sum
                    left++;
                }
                else
                {
                    // Move the right pointer to decrease the sum
                    right--;
                }
            }

            // If no pair is found, return an empty array
            return new int[0];
        }

    }

    
}
