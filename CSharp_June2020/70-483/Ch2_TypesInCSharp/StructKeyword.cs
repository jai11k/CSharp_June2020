using System;
using System.Collections.Generic;
using System.Text;

namespace Ch2_TypesInCSharp
{
    class StructKeyword
    {
        #region jaankari
        //must read book after reading this pgNo-42

        #region Kudvenkat_ClassesVsStruct
        /*
        Just like classes structs can have fields,properties,constructors and methods.
        A structure is a value type where as a class is a refernce type.
        All the differences that are applicable to value types and reference types are also applicable to classes and structs.
 1. Structs are stored on stack,where as classes are stored on the heap.
 2. Value types hold their value in memory where they are declared, but reference types hold a reference to an object in memory.
 3. Value tyeps are destroyed immediately after the scope is lost, where as fir reference types only the reference variable is
      destroyed after the scope is lost.The object is later destroyed by garabage collector.
 4. When you copy a struct into another struct,a new copy of that struct gets created and modidication on one struct will not affect
      the values contained by the other struct.
 5. When you copy a class into another class,we only get a copy of the refernce variable.Both the reference variable point to the
      same object on the heap.So, operations on one variable will affect the values contained by the other reference variable.
 6. Structures can't have destructors,but classes can have destructors.
 7. Structures cannot have explicit parameter less constructor where as a class can.(This makes sense bcz a struct does not have a
          concept of object reference variable and object that's why they don't need to have a parameterless constructor and a destructor)
8. Structures can't inherit from another class where as a class can,both struct and class can inherit from an interface.
9. Examples of struct in(dot net core framework) - int (System.Int32),double (System, Double)

          Note-A class or a struct cannot inherit from another struct.Struct are sealed types.
           */


        #endregion

        /* 
Struct is used to encapsulate the attribute and behavior of an entity. It’s used to define
those objects which hold small memory. Most primitive types (int, float, bool) in C# are
made up from struct. Struct doesn’t support all object-oriented principles.

The data encapsulated by struct are its data member. The variables are known as fields and
functions included in it are called member functions.
struct is not limited to fields, but it can also have functions, constructors, indexers,
events, nested types, and an implemented interface.

   Constructor in struct    
• Default Constructor (parameter less) is not allowed in struct.
• Constructor is optional in struct but if included it must not be parameterless.
• Constructor can be overload but each overloaded constructor must initialize all data members.
• Data members or fields cannot be initialized in the struct body. Use constructor to initialize them.
• Creating the object (without a new keyword) would not cause constructor calling even though a constructor is present.
         */


        #endregion


        static void Main(string[] args)
{
    Vector vector = new Vector();
    vector.x = 5;
    vector.y = 11;
    Console.WriteLine("x = {0}", vector.x);
    Console.WriteLine("y = {0}", vector.y);

    //doubt why there is a new keyword for intialiazing value type
    //struct Vector needs a struct type of value :)
    //struct Int32 needs a Int32 type of value

    Int32 i = new Int32();
    i = 5;
    Console.WriteLine("--->" + i);

}
}

struct Vector
{
public int x;
public int y;

//Constructor
public Vector(int a,int b)
{
    //Initialize fields
    x = a;
    y = b;
}
}
}
