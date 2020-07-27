using System;
namespace Ch2_TypesInCSharp
{
    public static class ExtensionMethods
    {
        #region jaankari
        //pgNo-51
        /*
 Extension methods are special static methods. They inject addition methods without
 changing, deriving, or recompiling the original type. They are always called as if they
 were instance method.
• Extension methods are always defined inside static class.
• The first parameter of extension method must have “this” operator, which tells on
whose instance this extension method should give access.
• The extension method should be defined in the same namespace in which it is used, or import the namespace in which the extension method was defined.

         */



        #endregion

        //int ko extend
        public static bool isLessThan(this int origin, int compareValue)
        {
            //return true if origin value is less
            if (origin < compareValue)
                return true;
            else
                return false;
        } 
    }
    class Test
    {
        static void Main(string[] args)
        {
            int age = 22;
            bool check = age.isLessThan(30);
            Console.WriteLine(check);
        }
    }
}
