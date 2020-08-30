using System;
namespace Ch4_AdvanceCSharp
{
    public class GenericsInCSharp
    {
        static void Main(string[] args)
        {
            //Here <T> type become string
            FirstGenericClass<string> genStr = new FirstGenericClass<string>();
            string strData = genStr.GenericMethod("C#");
            genStr.GenericProperty = "Certification Exam: ";
            Console.WriteLine("{0} {1}", strData, genStr.GenericProperty);

            //Here <T> type become int
            FirstGenericClass<int> genInt = new FirstGenericClass<int>();
            int intData = genInt.GenericMethod(70);
            genInt.GenericProperty = 483;
            Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);
        }
    }
    class FirstGenericClass<T>
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
