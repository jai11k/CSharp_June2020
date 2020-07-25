using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_June2020._70_483.Ch2_TyprsInCSharp
{
    class StructKeywordcs
    {
        #region jaankari
        /* 
    Just like classes structs can have fields,properties,constructors and methods.

            Kudvenkat Classes vs Struct
   1. A structure is a value type where as a class is a refernce type.
   2. All the differences that are applicable to value types and reference types are also applicable to classes and structs.
   3. Structs are stored on stack,where as classes are stored on the heap.
   4. Value types hold their value in memory where they are declared,but reference types hold a reference to an object in memory.
   5. Value tyeps are destroyed immediately after the scope is lost,where as fir reference types only the reference variable is
        destroyed after the scope is lost.The object is later destroyed by garabage collector.
   6. When you copy a struct into another struct,a new copy of that struct gets created and modidication on one struct will not affect
        the values contained by the other struct.
   7. When you copy a class into another class,we only get a copy of the refernce variable.Both the reference variable point to the
        same object on the heap.So,operations on one variable will affect the values contained by the other reference variable.
   8. Structures can't have destructors,but classes can have destructors.
   9. Structures cannot have explicit parameter less constructor where as a class can.(This makes sense bcz a struct does not have a 
            concept of object reference variable and object that's why they don't need to have a parameterless constructor and a destructor)
  10. Structures can't inherit from another class where as a class can,both struct and class can inherit from an interface.
  11. Examples of struct in(dot net core framework) - int(System.Int32),double(System,Double)
    
            Note-A class or a struct cannot inherit from another struct.Struct are sealed types.
             */
        #endregion


        static void Main(string[] args)
        {
            Vector vector = new Vector();
            vector.x = 5;
            vector.y = 10;
            Console.WriteLine("x = {0}", vector.x);
            Console.WriteLine("y = {0}", vector.y);
        }
   }

    struct Vector
    {
        public int x;
        public int y;
    }
}
