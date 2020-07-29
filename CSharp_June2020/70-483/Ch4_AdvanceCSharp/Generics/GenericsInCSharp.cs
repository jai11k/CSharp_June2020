using System;
namespace Ch4_AdvanceCSharp
{
    public class GenericsInCSharp
    {
        static void Main(string[] args)
        {
            //Here <T> type become string
            GenericClass<string> genStr = new GenericClass<string>();
            string strData = genStr.GenericMethod("C#");
            genStr.GenericProperty = "Certification Exam: ";
            Console.WriteLine("{0} {1}", strData, genStr.GenericProperty);

            //Here <T> type become int
            GenericClass<int> genInt = new GenericClass<int>();
            int intData = genInt.GenericMethod(70);
            genInt.GenericProperty = 483;
            Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);
        }
    }
    class GenericClass<T>
    {
        //type 'T' will define at the instantiation of GenericClass
        private T genericField;

        public T GenericMethod(T genericParameter)
        {
            this.genericField = genericParameter;
            return this.genericField;
        }
        public T GenericProperty { get; set; }
    }
}
