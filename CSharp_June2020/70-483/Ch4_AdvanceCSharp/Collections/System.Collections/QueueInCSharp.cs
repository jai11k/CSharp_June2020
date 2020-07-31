using System;
using System.Collections;

namespace Ch4_AdvanceCSharp
{
    public class QueueInCSharp
    {

        #region jaankari
        /*
         Queue is a class of System.Collections namespace. It stores and retrieves objects
        in FIFO (First In, First Out) order. In other words, it manages a collection of
        objects on a first come, first served basis.
        Below are some common methods and properties used in Queue class.

            
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
        static void Main(string[] args)
        {
            Queue days = new Queue();
            //Add(Enque) objects in queus
            days.Enqueue("Mon");
            days.Enqueue("Tue");
            days.Enqueue("Wed");
            days.Enqueue("Thu");
            days.Enqueue("Fri");
            days.Enqueue("Sat");
            days.Enqueue("Sun");
            // Displays the properties and values of the Queue.
            Console.WriteLine("Total elements in queue are {0}", days.Count);
            //Remove and return first element of the queue
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
