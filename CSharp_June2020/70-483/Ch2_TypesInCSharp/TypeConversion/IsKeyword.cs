using System;
using Ch2_TypesInCSharp;

namespace CSharp_June2020.Ch2_TypesInCSharp.TypeConversion
{


    #region jaankari
    /*
    It’s a keyword that is used to match a type. If a type matches it returns true;
    otherwise it returns false. A common use of is keyword comes with (type) explicit type
    conversion.
    */
    #endregion

    public class IsKeyword
    {
        static void Main(string[] args)
        {
            A a = new B();
            if(a is B)
            {
                //convert explicitly from type A to B
                B b = (B)a;
            }
        }
    }
}
