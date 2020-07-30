using System;
namespace CSharp_June2020.Ch3_OOP.Polymorphism
{
    #region jaankari
    /*
    abstract is a keyword used with method in abstract class to declare an abstract method.
    Unlike virtual method, abstract method doesn’t have its definition of method. Thus,
    its derived class must implement the definition of abstract method, otherwise compile
    time error will generate. Abstract methods always declare inside an abstract class
     */
    #endregion 

    public class DynamicPolymorphism_AbstractMethod
    {
        static void Main(string[] args)
        {
            Vehicle3 vc = new Bike3();
            vc.Run();

        }
    }

    abstract class Vehicle3
    {
        public abstract void Run();
    }
    class Bike3 : Vehicle3
    {
        public override void Run()
        {
            Console.WriteLine("Run Bike");
        }
    }

}
