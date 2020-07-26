using System;
namespace CSharp_June2020.Ch2_TypesInCSharp.UserDefinedTypeConversion
{
    class Byte
    {
        #region jaankari
        /*
       
        */
        #endregion

        public int bits = 8;

        public static implicit operator int(Byte b)
        {
            return b.bits;
        }
    }

    public class ImplicitUserDefinedConversion
    {
        static void Main(string[] args)
        {
            Byte b = new Byte();
            int totalBits = b;
            Console.WriteLine(totalBits);
        }
    }
}
