using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Ch1_FundamentalsOfCSharp
{
    class OutKeyword
    {
        #region jaankari
        //pageNo-32
        // TODO : ehda afishkaar kyu hoea? jado asi return type ch return krva skde a search
        #endregion
        static void outMethod(out int i)
        {
            i = 1;
        }
        static void Main(string[] args)
        {
            int j; //j=0 default value
            outMethod(out j);

            int add = 0;
            int mul = 1;

            MyMaths(1, 2, out add, out mul);

            Console.WriteLine(j); // j = 1
        }

        static void MyMaths(int num1, int num2,
            out int add,
            out int mult)
        {
            add=num1+ num2;
            mult=num1* num2;
        }
    }
}
