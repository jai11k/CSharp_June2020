using System;
using System.Collections;

namespace Ch4_AdvanceCSharp
{

    #region jaankari

    /*
     IEnumerable interface is defined in System.Collections namespace. It helps to create
    a customized non- generic collection. It contains a single GetEnumerator method that
    returns an IEnumerator. We’ll discuss IEnumerator in much detail in a later topic. But
    for now, IEnumerator is used to iterate over a collection, stores the information of a
    current index, its value, and whether or not a collection iteration has completed.

     */

    #endregion

    public interface IEnumerable
    {

        IEnumerator GetEnumerator();
    }

    class myArrayList : IEnumerable
    {
        object[] array = new object[4];
        int index = -1;
        public void Add(object o)
        {
            if (++index < array.Length)
            {
                array[index] = o;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }

    public class IEnumerableInCSharp
    {
        static void Main(string[] args)
        {
            myArrayList list = new myArrayList();
            //stores object data in myArraylist
            list.Add("Ali");
            list.Add(22);
            list.Add("Sundus");
            list.Add(21);

            var v=list.GetEnumerator();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
