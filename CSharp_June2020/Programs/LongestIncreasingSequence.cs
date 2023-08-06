using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs.LongestIncreasingSequence
{
    public class LongestIncreasingSequence
    {
        public static int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            if (n == 0) return 0;

            int[] dp = new int[n];
            dp[0] = 1;
            int maxLength = 1;

            for (int i = 1; i < n; i++)
            {
                dp[i] = 1; // Initialize the length of LIS ending at index i to 1

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                maxLength = Math.Max(maxLength, dp[i]);
            }

            return maxLength;
        }

        public static void Main()
        {
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            int length = LengthOfLIS(nums);
            Console.WriteLine("Length of the longest increasing subsequence: " + length);
        }
    }
}
