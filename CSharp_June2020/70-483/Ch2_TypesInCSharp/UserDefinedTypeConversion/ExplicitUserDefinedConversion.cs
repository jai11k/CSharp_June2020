using System;
namespace CSharp_June2020.Ch2_TypesInCSharp.UserDefinedTypeConversion
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public static explicit operator string(Person per)
        {
            return per.Name;
        }
    }

    public class ExplicitUserDefinedConversion
    {
        static void Main(string[] args)
        {
            Person per = new Person { Age = 22, Name = "Ali" };
            string name = (string)per;
            Console.WriteLine(name);
        }
    }
}
