using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*
    Stack<T> is a class of System.Collections.Generic namespace. It stores and retrieves
    elements in LIFO (Last In, First Out) order. In other words, elements pushed at the end
    will pop up first, for example, a pile of plates. It is much faster than Stack defined
    in System.Collections because value-type gets boxed/unboxed in Stack, whereas Stack<T>
    always type-safes it.


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

    public class TypeSafeStackInCSharp
    {
        public TypeSafeStackInCSharp()
        {
            Stack<string> history = new Stack<string>();
            //Insert browser history in stack<string>
            history.Push("google.com");
            history.Push("facebook.com/imaliasad");
            history.Push("twitter.com/imaliasad");
            history.Push("youtube.com");
            // Displays the properties and values of the Stack<string>.
            Console.WriteLine("Total elements in stack<string> are {0}",
                history.Count);
            //Remove and return top element of the Stack<string>
            Console.WriteLine("{0}", history.Pop());
            //return top element of Stack<string> without removing it from Stack
            //return 'twitter.com/imaliasad'
            Console.WriteLine("{0}", history.Peek());
            //Iterate over each element of Stack<string>
            Console.WriteLine();
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }

        }
    }
}
