using System;
namespace Ch2_TypesInCSharp
{
   public class AnonymousType
    {
        #region jaankari
        //pgNo-51
        /*
       types that don;t have name

• In anonymous type, property value cannot be null.
• Anonymous type doesn’t have method definition.
• Anonymous types are class type.
• Anonymous type cannot be used as method’s parameter of return type.
• Anonymous type is useful to store query result from collection.
         */



        #endregion

        static void Main(string[] args)
        {
            var person = new { Name = "Babar", Age = 24 };
            Console.WriteLine("Name=" + person.Name);
            Console.WriteLine("Age= {0}" , person.Name);

        }
    }
}
