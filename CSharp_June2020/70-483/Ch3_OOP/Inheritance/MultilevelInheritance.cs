using System;
namespace Ch3_OOP
{
    public class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Child child = new Child();

        }

    }

    class GrandParent1
    {
        public GrandParent1()
        {
            Console.WriteLine("Grand Parent");
        }
    }
    class Parent1 : GrandParent1
    {
        public Parent1()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child1 : Parent1
    {
        public Child1()
        {
            Console.WriteLine("Child");
        }
    }



}
