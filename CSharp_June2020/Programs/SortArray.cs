using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs.Sort_Array
{
    public class SortArray
    {
        static void Main()
        {
            SortingArrayInDesc();
        }

        private static void SortingArrayInDesc()
        {
            int[] arr = { 5, 2, 8, 1, 4, 3 }; // Example input array

            // Sort the array in descending order using a custom comparison
            Array.Sort(arr, (x, y) => y.CompareTo(x));

            // Print the sorted array
            Console.WriteLine("Sorted array in descending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            // Output: 8 5 4 3 2 1
        }

        static void BubbleSort(int[] arr)
        {
            int arrLength = arr.Length;
            bool swapped;

            for (int i = 0; i < arrLength - 1; i++)
            {
                swapped = false;

                // Last i elements are already in place, so no need to check them again
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    // Compare adjacent elements and swap if necessary
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                    break;
            }
        }
    }
}
