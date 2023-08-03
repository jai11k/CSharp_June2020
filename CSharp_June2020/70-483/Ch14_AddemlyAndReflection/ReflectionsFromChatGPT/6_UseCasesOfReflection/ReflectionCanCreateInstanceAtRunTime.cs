using System;
using System.Reflection;

namespace ReflectionsInCSharp.UsecaseNo2.CreatingInstances
{
    //use case -> Creating Instances
    //Creating Instances: With reflection, you can dynamically create instances of types at runtime.
    //This is particularly useful when you need to work with types that are not known at compile time or when you want to create objects
    //based on configuration data.
    public class ReflectionCanCreateInstanceAtRunTime
    {
        static void Main()
        {
            Type type = typeof(MyClass);

            // Create an instance of the type using reflection
            object instance = Activator.CreateInstance(type);

            // Invoke a method on the instance
            MethodInfo method = type.GetMethod("SayHello");
            method.Invoke(instance, null);
        }
    }

    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

}
