using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp
{

    #region jaankari
    /*
    List<T> is a type-safe collection of objects. List can grow and shrink its size
    dynamically. With generics support, it can store a collection of any type in a
    type-safe way. Therefore, it is much faster and optimized than ArrayList.
    List<T> contains many methods and properties that help to manage a group of data.
    The following is list of some frequently used properties and methods defined in
    List<T>.

    
Add()       Add an object to the end of the List<T>
Contains()  Return true if specified object is in List<T>
Sort()      Sort all the objects of List<T> by using comparer
Remove()    Remove the first occurance of specific object in List<T>
RemoveAt()  Remove the object from specified index of List<T>
Clear()     Remove all objects from the List<T>
Find()      Search the object by using specified predicate
Count       Get the actual number of objects stored in List<T>

     */

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    #endregion
    public class ListInCSharp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //Add Person in list
            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Hogi", Age = 12 });
            //Get total number of person in list
            Console.WriteLine("Total person are: {0}", people.Count);
            //Iterate over each person
            Console.WriteLine();
            foreach (var person in people)
            {
                Console.WriteLine("Name: {0} - Age: {1}", person.Name, person.Age);
            }
            //Instantiate and populate list of int with values
            List<int> marks = new List<int>
        {
10, 25, 15, 23
};
            //Remove '25' from the list
            marks.Remove(25);
            //Get each element by its index
            Console.WriteLine();
            Console.Write("Marks: ");
            for (int i = 0; i < marks.Count; i++)
            {
                Console.Write(marks[i] + " ");
            }

        }
    }
}
