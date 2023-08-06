using Ch2_TypesInCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Programs.UplersDemoTest
{
//    This is a demo task.

//Write a function:

//class Solution { public int solution(int[] A); }

//    that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

//    For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

//Given A = [1, 2, 3], the function should return 4.

//Given A = [−1, −3], the function should return 1.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[1..100, 000];
//each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
    public class Solution
    {

        static void Main()
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };
            int[] B = {1,2,3 };
            int[] C = { -1,-3 }; //failing


            Console.WriteLine("Req output is " + solutionJai(C));
            //Console.WriteLine("CHATGPT Req output is "+ solutionChatGPT(C));

            Console.WriteLine("trying Req output is "+ TryingThereOnCSharp6(C));
        }
        public static int solutionJai(int[] A)
        {
            Array.Sort(A);
            // Implement your solution here

            for (int i = A[0]; i < A[A.Length-1]; i++)
            {
                if (!A.Contains(i))
                {
                    if (i <= 0)
                        continue;

                    return i;
                }
            }

            int toReturn = A[A.Length - 1] + 1;
            return toReturn == 0 ? 1 : toReturn;
        }

        public static int solutionChatGPT(int[] a)
        {
            HashSet<int> elementsSet = new HashSet<int>(a);

            int smallestPositiveInteger = 1;

            while (elementsSet.Contains(smallestPositiveInteger))
            {
                smallestPositiveInteger++;
            }

            return smallestPositiveInteger;
        }

        public static int TryingThereOnCSharp6(int[] A)
        {
            Array.Sort(A);
            // Implement your solution here

            for (int i = A[0]; i < A[A.Length - 1]; i++)
            {
                if (!ArrayContainsNumber(A, i))
                {
                    if (i <= 0)
                        continue;

                    return i;
                }
            }
            int toReturn = A[A.Length - 1] + 1;
            return toReturn==0 ? 1 : toReturn;

        }

        public static bool ArrayContainsNumber(int[] array, int number)
        {
            foreach (int element in array)
            {
                if (element == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
    
}
