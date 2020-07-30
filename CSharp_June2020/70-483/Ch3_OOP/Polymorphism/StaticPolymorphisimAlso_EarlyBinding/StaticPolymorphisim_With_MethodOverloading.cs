using System;
namespace Ch3_OOP
{
    #region jaankari
    /*
     methoda ka name same.signature should be different
     book pageno-82
     */
    #endregion


    public class StaticPolymorphisim_With_MethodOverloading
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Add(1, 2);
            cal.Add("C", "Sharp");

            Display display = new Display();
            display.Show("Jai");
            display.Show("Jai", 315);
        }
    }

    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of ints = {0}", result);
        }
        public void Add(string a, string b)
        {
            string result = a + b;
            Console.WriteLine("Sum of strings = {0}", result);
        }
    }

    class Display
    {

        public void Show(string name)
        {
            Console.WriteLine("Name = {0}", name);
        }
        public void Show(string name, int age)
        {
            Console.WriteLine("Name = {0} - Age = {1}", name, age);
        }

    }

}
