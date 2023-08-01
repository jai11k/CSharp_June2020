using SOLID._3.LSP.Ex3.Without;
using System;

namespace SOLID._3.LSP.Ex1.WithoutLSP
{
    #region jaankari
    
//    1. Without using the Liskov Substitution Principle(LSP) :

//In the first example, the Fly method is being executed for both Penguin and Sparrow instances.However, in the case of
//Penguin, we throw a NotSupportedException to indicate that penguins cannot fly.This is not a proper implementation
//because it violates the Liskov Substitution Principle.Code that relies on the base class (Bird) cannot anticipate that a
//NotSupportedException will be thrown when calling Fly on a Penguin instance.

//2. Using the Liskov Substitution Principle (LSP):

//In the second example, we improve the design by making the Bird class abstract and declaring the Fly method as abstract.
//Now, when we create a Penguin instance and call Fly, the method is executed without throwing any exception.The method in
//Penguin simply provides an empty implementation for Fly.The difference here is that there is no unexpected behavior
//(like throwing exceptions) when using the Fly method with Penguin instances.The Penguin class correctly overrides the Fly
//method with a valid implementation, even if that implementation does nothing.

//    To summarize, using the Liskov Substitution Principle ensures that derived classes can be used as substitutes for their
//    base class without changing the expected behavior.In the LSP-compliant example, the Penguin subclass behaves as expected
//    without throwing unexpected exceptions, making the code more reliable and maintainable.

    #endregion
    public class Bird
    {
        public virtual void Fly()
        {
            // Common implementation of flying for most birds.
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins cannot fly!");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow flying");
            // Implementation of flying specific to Sparrows.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird penguin = new Penguin();
            penguin.Fly();

            
            Console.ReadKey();
        }
    }
}
