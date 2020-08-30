using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_June2020
{
    public class Test
    {
        static void Main(string[] args)
        {
            List<int> expectedlist = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> unexpectedlist = new List<int>() { 1, 2, 3, 4,1,2,3,4, 5, 6 };

           IEnumerable<int> duplicateExpectedlist = expectedlist.GroupBy(x => x).Where(g => g.Count() > 1)
                .Select(x => x.Key);


            IEnumerable<int> duplicateunExpectedlist = unexpectedlist.GroupBy(x => x).Where(g => g.Count() > 1)
                .Select(x => x.Key);


            Console.WriteLine("expected list should be empty= ");
            foreach (int i in duplicateExpectedlist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            Console.WriteLine("UnExpextedList should not be empty");
            foreach (int i in duplicateunExpectedlist)
            {
                Console.WriteLine(i);
            }

}
    }
}
