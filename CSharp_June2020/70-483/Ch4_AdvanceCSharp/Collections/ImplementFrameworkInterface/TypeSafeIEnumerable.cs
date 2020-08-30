using System;
using System.Collections;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp
{
    public class TypeSafeIEnumerable
    {
        static void Main(string[] args)
        {
            myList<Person> people = new myList<Person>();
            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Hogi", Age = 12 });
            Console.WriteLine("Total person: {0} \n", people.Length);
            foreach (Person person in people)
            {
                Console.WriteLine("Name:{0} Age:{1}", person.Name, person.Age);
            }

        }
    }

    class myList<T> : IEnumerable<T>
    {
        List<T> list = new List<T>();
        //Get length of list<T>
        public int Length
        {
            get { return list.Count; }
        }
        public void Add(T data)
        {
            list.Add(data);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return IEnumerator<T> GetEnumerator()
            return this.GetEnumerator();
        }
    }

    class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
