using System;
namespace CSharp_June2020.Ch1_FundamentalsOfCSharp
{
    public class StaticType
    {
        #region jaankari
        //pgNo-54
        /*
Unlike normal classes, static classes cannot be instantiated.
They're useful to define helper static methods. Static class doesn’t have any instance
member. All members must be static in static class.
Therefore, members of static classes can access by using the class name itself.
Static class is defined by writing a static keyword before the class definition.

        static constructor
        Unlike normal class, static class doesn’t contain a public instance constructor. It
        contains a private static constructor to initialize static members. It is called
        automatically before the first instance is created or any static members are referenced.
         */



        #endregion

        static void Main(string[] args)
        {
            Helper.MyMethod();
        }
    }


    static class Helper
    {
        public static int age; 

        static Helper()
        {
            age = 22;
        }

        public static void MyMethod()
        {
            Console.WriteLine("static method from Helper class");
        }
    }
}
