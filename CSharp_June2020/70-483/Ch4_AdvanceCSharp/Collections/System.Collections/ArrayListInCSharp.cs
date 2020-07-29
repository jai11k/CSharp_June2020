using System;
using System.Collections;

namespace Ch4_AdvanceCSharp
{
    public class ArrayListInCSharp
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            //add objects in arraylist
            arraylist.Add(22);
            arraylist.Add("Ali");
            arraylist.Add(true);
            //Iterate over each index of arraylist
            for (int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            arraylist.Remove(22);
            Console.WriteLine();
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
