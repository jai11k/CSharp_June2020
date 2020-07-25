using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_FundamentalsOfCSharp
{
   public class PassbyReferenceWithRefKeyword
    {
        //PgNo-30
        static void PassByRef(ref int i)
        {
            i = i + 1;
        }
        static void Main(string[] args)
        {
            int j = 0;
            PassByRef(ref j);
            Console.WriteLine(j); //j = 1
        }
    }
}
