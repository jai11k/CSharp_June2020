using System;
using System.Reflection;

namespace ReflectionsInCSharp.UsecaseNo4.AccessingPrivateMembers
{

    //use case-> Accessing Private Members
    //Accessing Private Members: Reflection can be used to access and modify private or inaccessible members of a type.
    //However, this should be used with caution as it can lead to fragile code and may not be recommended in most scenarios.
    public class ReflectionCanAccessPvtMembers
    {
        static void Main()
        {
            Type type = typeof(MyClass);

            // Create an instance of the type using reflection
            object instance = Activator.CreateInstance(type);

            // Access the private field "secretMessage" and print its value
            FieldInfo field = type.GetField("secretMessage", BindingFlags.NonPublic | BindingFlags.Instance);
            string secretValue = (string)field.GetValue(instance);
            Console.WriteLine(secretValue);
        }
    }

    public class MyClass
    {
        private string secretMessage = "This is a secret!";

        public void PrintSecret()
        {
            Console.WriteLine(secretMessage);
        }
    }
}
