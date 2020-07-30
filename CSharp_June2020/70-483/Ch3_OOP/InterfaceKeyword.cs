using System;
namespace Ch3_OOP
{
    #region jaankari
    /*
    Interface cannot be instantiated. Its members have no implementation detail. All
    implementation detail is defined by classes which implement (inherit) interfaces.
    Interface provides the highest level of abstraction.
     */
    #endregion

    public class InterfaceKeyword
    {
        static void Main(string[] args)
        {
            //Implement interface implicitly
            IVehicle vehicle = new Bike1();
            Console.WriteLine(vehicle.Wheels);

            //Implement interface explicitly
            Student1 std = new Student1();
            int english = ((IEnglish)std).Marks;
            int math = ((IMath)std).Marks;
            Console.WriteLine("English Marks = {0} Math Marks = {1}",
                               english, math);

        }
    }

    interface IVehicle
    {
        int Wheels { get; }
    }
    class Bike1 : IVehicle
    {
        private int wheels;
        public int Wheels
        {
            get
            {
                return wheels;
            }
        }
    }


    interface IEnglish
    {
        int Marks { get; }
    }
    interface IMath
    {
        int Marks { get; }
    }
    class Student1 : IEnglish, IMath
    {
        int english = 10;
        int math = 9;
        int IMath.Marks
        {
            get
            {
                return english;
            }
        }
        int IEnglish.Marks
        {
            get
            {
                return math;
            }
        }
    }




}
