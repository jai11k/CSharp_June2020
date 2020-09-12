using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_June2020._BasicButCool.GenericDelegates
{
    #region jaankari
    /*
        Func is built-in delegate type.
        Func delegate type must return a value.
        Func delegate type can have zero to 16 input parameters.
        Func delegate does not allow ref and out parameters.
        Func delegate type can be used with an anonymous method or lambda expression.
     */
    #endregion
    public class GenericDelegates
    {
        static void Main(string[] args)
        {
            #region Func
            Func<int, int, string> funcdemo1 = (x, y) => x + y + "";
            Console.WriteLine("Func=>" + funcdemo1);

            //this only has return type
            Func<int> funcdemo2 = () => new Random().Next(1, 100);
            #endregion

            #region Action
            Action<string> action = str => Console.WriteLine(str);
            action.Invoke("I am Action Delegate");
            #endregion

            #region Predicate
            Predicate<string> predicate = strin => strin.Length > 5;
            bool hai5TonVaddi = predicate.Invoke("Jai");
            #endregion
        }
    }
}
