using System;
using System.Collections;

namespace CSharp_June2020.Ch4_AdvanceCSharp.Collections.System.Collections
{
    #region jaankari
    /*
    Stack is a class of System.Collections namespace. It stores and retrieves objects
    in LIFO (Last In, First Out) order. In other words, elements pushed at the end
    will pop first, for example, a pile of plates.
    Below are some common methods and properties used in Stack class.

       

Push()     Insert the object at the top of the Stack
Pop()      Remove and return object at the top of the Stack
Peek()     Return the object at the top of the Stack without removing it
ToArray()  Copy the Stack elements to a new array
Contains() Return true if a specified object is in the Stack
Clear()    Remove all objects from the Stack
Clone()    Create a shallow copy of the Stack
Count      Get the actual number of objects in Stack
     */
    #endregion

    public class StackInCSharp
    {
        static void Main(string[] args)
        {
            Stack history = new Stack();
            //Insert browser history in stack
            history.Push("google.com");
            history.Push("facebook.com/imaliasad");
            history.Push("twitter.com/imaliasad");
            history.Push("youtube.com");
            // Displays the properties and values of the Stack.
            Console.WriteLine("Total elements in stack are {0}", history.Count);
            //Remove and return top element of the Stack
            Console.WriteLine("{0}", history.Pop());
            //return top element of Stack without removing it from Stack
            //return 'twitter.com/imaliasad'
            Console.WriteLine("{0}", history.Peek());
            //Iterate over each element of Stack
            Console.WriteLine();
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
        }
    }
}
