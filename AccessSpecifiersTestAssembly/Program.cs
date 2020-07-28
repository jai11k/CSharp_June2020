using System;
using Ch3_OOP;

namespace AccessSpecifiersTestAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Print();
            
        }
    }


    class DerivedClass : TestAccessSpecifiersInOtherAssembly
    {
        //jo fields base class me protected thi,derived me private jesa behave krengi
        public void Print()
        {
            TestAccessSpecifiersInOtherAssembly obj = new TestAccessSpecifiersInOtherAssembly();
            base.dob_protectedInternal = 12011996;

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.dob_protectedInternal=0;
        }
    }
}
