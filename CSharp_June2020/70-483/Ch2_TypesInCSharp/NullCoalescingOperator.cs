using System;
namespace Ch2_TypesInCSharp
{
    public class NullCoalescingOperator
    {
        #region jaankari
        //pgNo-52 also in chapter1
        /*
        • Nullable<T> is an alternative of “?” operator. The above example can be written as Nullable<bool> isMarried = null;
• Value type is boxed whenever it becomes nullable.

         */



        #endregion

        static void Main(string[] args)
        {
            bool? isMarried = null;
            bool married = isMarried ?? false;

        }
    }
}
