using System;
namespace Ch3_OOP
{
    #region jaankari
    /*
     #METHOD OVERRIDING#
    Virtual is a keyword used with method in base class to define a virtual method.
    Virtual method has a definition of its method; its derived class can inherit or override
    its definition. Thus, when calling the method name the runtime will determine which method
    to invoke.
     */
    #endregion

    public class DynamicPolymorphism_VirtualMethod
    {
        static void Main(string[] args)
        {

            Vehicle2 vc = new Bike2();
            vc.Run();

            /*
             vc.Run(); control will first move to base “Run” method. When runtime is
            encountered, it’s a virtual method; it will then move to its derived class
            “Bike” definition to find implementation of “Run()” method. If it finds the
            method it will invoke it; otherwise it will come back to base class to run
            virtual Run() method.
             */
            vc.Stop();



        }
    }

    class Vehicle2
    {
        public virtual void Run()
        {
            Console.WriteLine("Run Vehicle");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehical stopped");
        }

    }

    class Bike2 : Vehicle2
    {
        public override void Run()
        {
            Console.WriteLine("Bike Run");
        }

        public void Stop()
        {
            Console.WriteLine("bike stopped");
        }

    }
}
