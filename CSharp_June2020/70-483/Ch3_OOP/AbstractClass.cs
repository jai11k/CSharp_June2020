using System;
namespace Ch3_OOP
{
    #region jaankari
    /*
     Abstract classes cannot be instantiated. It is used as base class, where it provides
    common members to all its derived classes. It is either overridden partially or not at
    all. It is also used to declare abstract methods (method without definition) that when
    it inherits, it must be overridden by its derived classes.
     */
    #endregion

    public class AbstractClass
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Bike();
            Console.WriteLine(vehicle.Wheels);
        }
    }

    abstract class Vehicle
    {
        protected int wheels;
        public int Wheels
        {
            get { return wheels; }
        }
    }
    class Bike : Vehicle
    {
        public Bike()
        {
            base.wheels = 2;
        }
    }

}
