using System;
using System.Collections.Generic;

namespace Interview.Programs.LengthOfLongest_SubString
{
    public class LengthOfLongestSubString
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int maxLength = 0;
            int left = 0;
            int right = 0;
            HashSet<char> uniqueChars = new HashSet<char>();

            while (right < s.Length)
            {
                char currentChar = s[right];

                if (!uniqueChars.Contains(currentChar))
                {
                    uniqueChars.Add(currentChar);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    uniqueChars.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }

        public static void Main()
        {
            string input = "abcabcbb";
            int length = LengthOfLongestSubstring(input);
            Console.WriteLine("Length of the longest substring without repeating characters: " + length);
        }
    }
}
