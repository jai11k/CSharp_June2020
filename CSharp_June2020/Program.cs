using System;
using System.Collections;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!!");
        }
    }

    interface ITest
    {
        object thisIsprop { get; }
        void method1();
    }

    class Test : ITest,IEnumerator
    {
        public object thisIsprop => "";

        public object Current => throw new NotImplementedException();

        public void method1()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
