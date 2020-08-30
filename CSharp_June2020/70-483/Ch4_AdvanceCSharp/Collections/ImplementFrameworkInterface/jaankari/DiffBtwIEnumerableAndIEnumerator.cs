using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp.jaankari
{
    #region

    /*

    In simple words both IEnumerable and IEnumerator help us to loop through the collections.
    What shoudl i use?

       IEnumerable uses IEnumerator internally.IEnumerable is sugar coating on IEnumerator.
       IEnumerable was made to make the syntax shorter and sweeter.

    we can see ienumerable object has GetEnumertor function which give back IEnumerator collection.

    Diff.

    IEnumerable does not remember the current element in iterating loop while IEnumerator does.


     */

    #endregion



    public class DiffBtwIEnumerableAndIEnumerator
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1994);
            oyears.Add(1995);
            oyears.Add(1996);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);
            oyears.Add(2011);

            IEnumerable<int> ienum = (IEnumerable<int>)oyears;

            foreach(int singleyear in oyears)
            {
                Console.WriteLine(singleyear);
            }

            Console.WriteLine("\n");

            IEnumerator<int> ienumerator = oyears.GetEnumerator();

            while(ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current.ToString());
            }


            Console.WriteLine("---------");

            Iterate1991to2001UsingIEnumerator(ienum.GetEnumerator());
            Iterate1991to2001UsingIEnumerable(ienum);


        }


        static void Iterate1991to2001UsingIEnumerator(IEnumerator<int> obj)
        {
            //itreate before 2001
            while (obj.MoveNext())
            {
                Console.WriteLine("IEnumerator Testing" + obj.Current.ToString());
                if (Convert.ToInt16(obj.Current) >2001)
                {
                    IterateAfter2001UsingIEnumerator(obj);
                }

            }


        }

        static void IterateAfter2001UsingIEnumerator(IEnumerator<int> obj)
        {
            //iterarte after 2001

            while (obj.MoveNext())
            {
                Console.WriteLine("IEnumerator Testing"+obj.Current.ToString());
                

            }
        }

        static void Iterate1991to2001UsingIEnumerable(IEnumerable<int> obj)
        {
            foreach(int singleyear in obj)
            {
                Console.WriteLine("IEnumerable Testing" + singleyear);
                if(singleyear > 2000)
                {
                    IterateAfter2001UsingIEnumerable(obj);
                }
            }
        }

        static void IterateAfter2001UsingIEnumerable(IEnumerable<int> obj)
        {
            foreach (int singleyear in obj)
            {
                Console.WriteLine("IEnumerable Testing" + singleyear);
            }
        }
    }
}
