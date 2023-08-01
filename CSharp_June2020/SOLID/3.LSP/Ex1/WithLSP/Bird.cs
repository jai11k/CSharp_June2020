

using System;

namespace SOLID._3.LSP.Ex1.WithLSP
{
    //LSP states that - all classes should be substitutable for their base C# classes.
    //this example made no sense,see ex2
    public abstract class Bird
    {
        public abstract void Fly();
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            // Penguins cannot fly, so we don't implement anything here.
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
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
