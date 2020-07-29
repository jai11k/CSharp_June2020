using System;
namespace Ch4_AdvanceCSharp
{

    #region jaankari
    /* pageno 96
The boxed value object boxedAge is being unboxed into int unboxedAge. During unboxing,
    CLR does the following operation:
• Check the boxed value is of the given value type.
• Assign a value to a value type variable from the boxed value.
     */
    #endregion
    public class BoxingANDUnBoxing
    {
        static void Main(string[] args)
        {
            int age = 22;
            object boxedAge = age; //boxing
            int unboxedAge = (int)boxedAge; //unboxing
        }
    }
}
