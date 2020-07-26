using System;
namespace Ch2_TypesInCSharp
{
    public class NullableType
    {
        #region jaankari
        //pgNo-52
        /*
Normally, value type cannot be assigned with null value. But with nullable type, value type can be assigned with null value.
Value type can become nullable type by using “?”.

         */



        #endregion

        static void Main(string[] args)
        {
            bool? isMarried = null;
            isMarried = true;

        }
    }
}
