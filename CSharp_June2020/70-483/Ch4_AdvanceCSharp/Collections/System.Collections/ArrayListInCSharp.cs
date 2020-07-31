using System;
using System.Collections;

namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*

    ArrayList      Array of objects whose size can grow and shrink dynamically 

    ArrayList
It’s an array of objects which can grow and shrink its size dynamically. Unlike arrays,
an ArrayList can hold data of multiple data types. It can be accessed by its index.
Inserting and deleting an element at the middle of an ArrayList is more costly than inserting
or deleting an element at the end an ArrayList.

An ArrayList contains many methods and properties that help to manage a group of objects. The following is a list of some frequently used properties and methods defined in an ArrayList.
Frequently used classes in system.collections namespace
Explanation


    Add()         Add an object to the end of ArrayList
    Contains()    Return true if specific object is in ArrayList
    Clone()       Create a shallow copy of ArrayList
    Remove()      Remove the first occurance of specific object in ArrayList Remove the object from specific index of ArrayList Remove all objects from the ArrayList
    RemoveAt()    Remove the object from specific index of ArrayList
    Clear()       Remove all objects from the ArrayList
    Count         Get the actual number of objects stored in ArrayList
    Capacity      Get or Set number of objects that ArrayList can contain

     */
    #endregion

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
