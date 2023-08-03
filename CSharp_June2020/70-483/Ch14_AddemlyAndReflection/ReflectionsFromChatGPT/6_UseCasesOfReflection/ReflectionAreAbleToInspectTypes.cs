using System;
using System.Reflection;

namespace ReflectionsInCSharp.UsecaseNo1.InspectTypes
{
    //use case -> Inspecting Types
    //Inspecting Types: You can use reflection to examine the structure and members of classes, interfaces, enums, and other types at runtime.
    //For example, you can get information about properties, methods, fields, events, and constructors of a type.
    public class ReflectionAreAbleToInspectTypes
    {
        static void Main()
        {
            Type type = typeof(MyClass);

            // Get properties of the type
            PropertyInfo[] properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            // Get methods of the type
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }

    public class MyClass
    {
        public int MyProperty { get; set; }
        public void MyMethod() { }
    }

}
