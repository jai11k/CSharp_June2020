using System;
using System.Collections;

namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*
 enumerates means
 to mention separately as if in counting; name one by one; specify, as in a list: 
     */
    #endregion

    public class IEnumeratorInCSharp
    {
        static void Main(string[] args)
        {
            People obj = new People(3);
            obj.Add(new Person2 { Name = "Ali", Age = 22 });
            obj.Add(new Person2 { Name = "Sundus", Age = 21 });
            obj.Add(new Person2 { Name = "Hogi", Age = 12 });
            foreach (var item in obj)
            {
                //Cast from object to Person...kyuki interface di implemenatation ch object type hai
                Person2 person = (Person2)item;
                Console.WriteLine("Name:{0} Age:{1}", person.Name, person.Age);
                //Console.WriteLine("{0}---", item);
            }
        }
    }

    class People : IEnumerable
    {
        Person2[] people;
        int index = -1;
        public void Add(Person2 per)
        {
            if (++index < people.Length)
            {
                people[index] = per;
            }
        }
        public People(int size)
        {
            people = new Person2[size];
        }
        public IEnumerator GetEnumerator()
        {

            //as IEnumerator is parent class of PersonEnum
            //IEnumerator test = new PersonEnumerator(people); //kuch aisa,polymorphisism
            //test.Current;
            //test.MoveNext
         //    then this is internally used by IEnumerable :) in foreach loop

            return new PersonEnumerator(people);

           
        }
    }
    //Implement IEnumerator
    class PersonEnumerator : IEnumerator
    {
        Person2[] _people;
        int index = -1;
        public PersonEnumerator(Person2[] people)
        {
            _people = people;
        }
        //Check whether foreach can move to next iteration or not
        public bool MoveNext()
        {
            return (++index < _people.Length);
        }
        //Reset the iteration
        public void Reset()
        {
            index = -1;
        }
        //Get current value
        public object Current
        {
            get
            {
                return _people[index];
            }
        }
    }

    class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
