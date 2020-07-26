using System;
namespace Ch2_TypesInCSharp
{
    #region jaankari
    /*
    as is a keyword used to explicitly convert one type to another.If a type converts
    successfully, it would return value in that type. If a type doesn’t convert properly,
    it returns null value.
    */
    #endregion

    class A
    {

    }
    class B : A
    {

    }

    public class AsKeyword
    {
        static void Main(string[] args)
        {
            A a = new B();

            //convert explicitly from type A to B
            B b = a as B;
        }

    }
}
