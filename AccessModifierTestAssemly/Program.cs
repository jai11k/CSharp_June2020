using System;
using Ch3_OOP;

namespace AccessModifierTestAssemly
{
    class Program
    {
        static void Main(string[] args)
        {
            //only public methods will be accessed here in other assembly
            MoreAccess access = new MoreAccess();
            access.Method();

            DerivedAccess derivedAccess = new DerivedAccess();
            derivedAccess.


        }
    }

    class DerivedAccess : MoreAccess
    {
        int a;
    }

}
