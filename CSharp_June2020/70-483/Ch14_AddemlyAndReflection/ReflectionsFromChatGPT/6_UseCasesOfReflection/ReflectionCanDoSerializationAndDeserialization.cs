using System;
using System.Reflection;

namespace ReflectionsInCSharp.UsecaseNo5.SerializationAndDeserialization
{
    //use case->SerializationAndDeserialization
    //Serialization/Deserialization: Reflection is commonly used in serialization and deserialization libraries to convert objects to and from
    //their binary or textual representations.
    public class ReflectionCanDoSerializationAndDeserialization
    {
        static void Main()
        {
            Type type = typeof(MyClass);

            // Serialization: Get properties and fields of the type and save their values
            object instance = Activator.CreateInstance(type);
            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();

            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(instance)}");
            }

            foreach (var field in fields)
            {
                Console.WriteLine($"{field.Name}: {field.GetValue(instance)}");
            }
        }
    }
    public class MyClass
    {
        public int MyProperty { get; set; }
        public string MyField;

        public void MyMethod() { }
    }
}
