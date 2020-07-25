using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_FundamentalsOfCSharp
{
    class ParamsKeyword
    {
        #region jaankari

        /*  
        pageNo-32 
        Use Params Array to Pass Unlimited Method Argument
        The number of arguments of a method depends upon the length of a parameter list in method’s signature.
        For example, in our previous example of “Sum” method, we cannot pass more than two values in its
        arguments. But with param array we can pass an unlimited number of arguments. */
        #endregion

      static  int Sum(params int[] args)
        {
            int add = 0;
            foreach (int item in args)
            {
                add = add + item;
            }
            return add;
        }

        static void Main(string[] args)
        {
          int sum = Sum(1, 2, 3, 4, 5);
            Console.WriteLine("Sum =" + sum);
        }
    }
}
