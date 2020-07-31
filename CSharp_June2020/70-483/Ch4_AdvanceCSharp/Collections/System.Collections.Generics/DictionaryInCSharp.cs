using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*
     Dictionary<TKey, TValue> is a class of System.Collections.Generic. It’s a type-safe
    collection of key/ value pairs. Each key in dictionary must be unique and can store
    multiple values against the same key. Dictionary<TKey, TValue> is much faster than
    Hashtable.
    Below are some common methods and properties used in Dictionary<TKey, TValue> class.

        

Add()           Add pair of type-safe key/value in Dictionary.
ContainsKey()   Return true if specific key is in Dictionary.
ContainsValue   Return true if specific value is in Dictionary.
Clear()         Remove all objects from the Dictionary.
Remove()        Remove the element with the specified key in Dictionary.
Count           Get the actual number of key/value pairs in Dictionary.
Keys            Get list of keys contained in Dictionary.
Values          Get list of values contained in Dictionary.

     */
    #endregion

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class DictionaryInCSharp
    {
        static void Main(string[] args)
        {
            //Initialize Dictionary (int for roll# and assign it to student)
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            //Adding student against their roll#
            students.Add(53, new Student { Name = "Ali Asad", Age = 22 });
            students.Add(11, new Student { Name = "Sundus Naveed", Age = 21 });
            students.Add(10, new Student { Name = "Hogi", Age = 12 });
            //Display Name against key
            Console.WriteLine("Roll# 11 is: {0}", students[11].Name);



            //ContainsKey can be use to test key before inserting
            if (!students.ContainsKey(13))
            {
                students.Add(13, new Student { Name = "Lakhtey", Age = 21 });
            }
            // When you use foreach to enumerate elements of dictionary,
            // the elements are retrieved as KeyValuePairPair object.
            //KeyValuePair<TKey, TValue> is the pair of key & value for dictionary
            Console.WriteLine();
            foreach (KeyValuePair<int, Student> student in students)
            {
                Console.WriteLine("Roll#: {0} - Name: {1} - Age: {2}",
                    student.Key, student.Value.Name, student.Value.Age);
            }
            //Get All values stored in Dictionary
            var allValues = students.Values;
            Console.WriteLine();
            foreach (var student in allValues)
            {
                Console.WriteLine("Name: {0} - Age: {1}",
            student.Name, student.Age);
            }
        }
    }
}
