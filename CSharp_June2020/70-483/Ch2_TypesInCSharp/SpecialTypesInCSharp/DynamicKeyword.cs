using System;
namespace Ch2_TypesInCSharp
{
    public class DynamicKeyword
    {
        #region jaankari
        //pgNo-52
        /*
Dynamic type is used to store and manipulate any data whose types definition and operation
errors are determined at runtime. It ignores compile-time checks. Therefore, it is easy to
access COM and DOM APIs with dynamic type.
It is defined by using a dynamic keyword.
        
• Dynamic type can be used for field, property, indexer, method parameter, and return type.
• Exception is thrown at runtime if data type or member name is not compatible.
         */



        #endregion

        static void Main(string[] args)
        {
            dynamic price = 20;
            Console.WriteLine(price.GetType());
            dynamic name = "Ali";
            Console.WriteLine(name.GetType());

            //Output
            //System.Int32
            //System.String

        }
    }
}
