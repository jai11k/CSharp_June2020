using System;
using System.Collections.Generic;
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
            Console.WriteLine(j); // j = 1
        }
    }
}
