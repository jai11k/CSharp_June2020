using System;
namespace CSharp_June2020._BasicButCool
{
    #region basicsOfDelegate

    /*
     *  1. Notice delegate syntax is very very similar to function's syntax.
       (just by adding delegate keyword it becomes delegate)
        2. This delegate can be used point to any fucntion with similar syntax
           i.e with same function defination i.e return type & signature.
        3. 
     */

    public delegate void HelloPtr(string msg);
    #endregion

    public class WhatIsDelegate
    {

        #region jaankari
        /*
         Deligates is a pointer to function.
       ^dull ^monotonous ^tedious ^repetitous ^stupid defination.

        Dictionary meaning of delegate is :-
        Delegate is reperesntative.
        It is a kind of reperesntative b/w two parties.

        Delegate is a reference type.
        Actually-> Delegate is a type safe function pointer.
         #meaning-> A delegate points to a function & when u invoke this delegate function gets invoked. #

         * 
         */
        #endregion

        static void Main(string[] args)
        {
            Hello("Normal bandea vali hello");
            //How do we make this delegate HelloPtr point to a fucntion.
            //    This is where delegate is similar to as class. we have to make instance.

            //give the fucntion as parameter u wana point to. :)
            HelloPtr del = new HelloPtr(Hello);  //intellisense ;)
            del("Hello from delegate");



        }


        static void Hello(string strMsg)
        {
            Console.WriteLine(strMsg);
        }

    }
}
