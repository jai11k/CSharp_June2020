using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsInCSharp.UsecaseNo3.InvokingMethodsDynamically
{
    //use case-> Invoking Methods Dynamically
    //Invoking Methods Dynamically: Reflection allows you to invoke methods dynamically without knowing their names or signatures at compile time.
    //This can be useful in scenarios where you have method names as strings or when you want to call methods based on user input.
    public class ReflectionCanInvokeMethodsDynamically
    {
        static void Main()
        {
            Type type = typeof(MyClass);

            // Create an instance of the type using reflection
            object instance = Activator.CreateInstance(type);

            // Invoke the "SayHello" method dynamically with a parameter
            MethodInfo method = type.GetMethod("SayHello");
            method.Invoke(instance, new object[] { "John" });
        }
    }
    public class MyClass
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
