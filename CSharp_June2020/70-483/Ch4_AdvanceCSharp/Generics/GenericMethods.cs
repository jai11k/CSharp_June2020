using System;
namespace Ch4_AdvanceCSharp
{

    #region jaankari
    /*
     Generic methods help to type-safe a method’s argument type, which helps in calling
     a method’s parameter for multiple types.

• Generic method defines by using “<>” angle brackets.
• T is a generic type parameter; it refers to any compile-time type that is given when
  the generic method is called.
     */
    #endregion
    public class GenericMethods
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            //Call generic method which has single generic type
            ex.GenericMethodArgs<int>(10);
            int FromSingle = ex.ReturnFromGenericMethodArgs<int>(10);
            Console.WriteLine(FromSingle + "\n");
            //Call generic method which has multiple generic type
            ex.MultipleGenericMethodArgs<string, int>("Exam", 70483);
            int FromMultiple =
                ex.ReturnFromMultipleGenericMethodArgs<string, int>("Exam: ");
            Console.WriteLine(FromMultiple);
        }
    }
    class Example
    {
        public void GenericMethodArgs<T>(T first)
        {
            Console.WriteLine(first);
        }
        public T ReturnFromGenericMethodArgs<T>(T first)
        {
            return first;
        }
        public void MultipleGenericMethodArgs<T, U>(T first, U second)
        {
            Console.WriteLine("{0}: {1}", first, second);
        }
        public U ReturnFromMultipleGenericMethodArgs<T, U>(T first)
        {
            U temp = default(U);
            return temp;
        }
    }
}
