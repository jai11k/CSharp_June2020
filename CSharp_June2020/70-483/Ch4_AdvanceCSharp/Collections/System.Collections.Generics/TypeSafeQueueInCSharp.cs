using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*
    Queue<T> is a type-safe class of System.Collections.Generic namespace. It stores and
    retrieves data in FIFO (First In, First Out) order. In other words, it manages a
    collection of data on a first come, first served basis. It is much faster than Queue
    defined in System.Collections because value-type gets boxed/unboxed in Queue, whereas
    Queue<T> always type-safes it.

Below are some common methods and properties used in Queue<T> class.
Enqueue()    Add an element to the end of the Queue
Dequeue()    Remove and return the object at the beginning of the Queue 
Peek()       Return the object at the beginning of the queue without removing it
ToArray()    Copy the Queue elements to a new array
Contains()   Return true if a specified object is in the Queue
Clear()      Remove all objects from the Queue
Clone()      Create a shallow copy of the Queue
Count        Get the actual number of objects in Queue

     */
    #endregion

    public class TypeSafeQueueInCSharp
    {
        static void Main(string[] args)
        {
            Queue<string> days = new Queue<string>();
            //Add(Enque) string object in days
            days.Enqueue("Mon");
            days.Enqueue("Tue");
            days.Enqueue("Wed");
            days.Enqueue("Thu");
            days.Enqueue("Fri");
            days.Enqueue("Sat");
            days.Enqueue("Sun");
            // Displays the properties and values of the Queue.
            Console.WriteLine("Total elements in queue<string> are {0}",
                days.Count);
            //Remove and return first element of the queue<string>
            Console.WriteLine("{0}", days.Dequeue());
            //return first element of queue without removing it from queue
            //return 'Tue'
            Console.WriteLine("{0}", days.Peek());
            //Iterate over each element of queue
            Console.WriteLine();
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }

        }
    }
}
