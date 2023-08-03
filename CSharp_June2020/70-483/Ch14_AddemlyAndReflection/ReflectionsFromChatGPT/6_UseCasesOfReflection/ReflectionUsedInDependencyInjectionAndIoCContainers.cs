using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsInCSharp.UsecaseNo6.DependencyInjectionAndIoCContainers
{
    //use case -> DependencyInjectionAndIoCContainers
    //Dependency Injection and IoC Containers: Reflection plays a vital role in dependency injection and inversion of control (IoC) containers,
    //where the container inspects and resolves dependencies automatically.
    public class ReflectionUsedInDependencyInjectionAndIoCContainers
    {
        static void Main()
        {
            // In a real IoC container, reflection would be used to resolve dependencies automatically.
            // For this example, we manually create the objects:
            ILogger logger = new ConsoleLogger();
            MyClass myClass = new MyClass(logger);

            myClass.DoSomething();
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }

    public class MyClass
    {
        private readonly ILogger logger;

        public MyClass(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoSomething()
        {
            logger.Log("Doing something important...");
        }
    }

}
