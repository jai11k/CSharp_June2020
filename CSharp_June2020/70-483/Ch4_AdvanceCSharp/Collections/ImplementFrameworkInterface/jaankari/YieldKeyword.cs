using System;
using System.Collections.Generic;

namespace Ch4_AdvanceCSharp.jaankari
{
    public class YieldKeyword
    {
        #region jaankari
        /*

        Yield keyword is used for
        1. Custom Iteration without temp collection

        Ex- getListOfNumbersGreaterThanFive(numbers);

        2. Statefull Iteration

        Ex- getRunningTotalOfList(numbers);
         */
        #endregion

        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            //numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);

            Console.WriteLine(numbers.Count);


            //Notice debug la k eh null rehnda.. eh odo fill hunda jado 28 no. line ch is nu use krna

            //TODO  this concept was done in  MANZOOR tutorial
            //TODO  foreach loop di debuging .. oh v samjni ae...
            //TODO  fucntion call hunda .. yield ik single value wapis le k calling function ko aanda fr calling function
            //ohnu jini itreate ho gi hundi loop ose position te bejhda

            var listofnumbers = getListOfNumbersGreaterThanFive(numbers);


            foreach (var item in listofnumbers)
            {
                Console.WriteLine("-->" + item);
            }

            Console.WriteLine("\n");

            var runningTotalList=getRunningTotalOfList(numbers);
            foreach (var item in runningTotalList)
            {
                Console.WriteLine("RUnning Total-->" + item);
            }


        }

        static IEnumerable<int> getListOfNumbersGreaterThanFive(IEnumerable<int> list)
        {
            Console.WriteLine("-jai-");
            foreach (int i in list)
            {
                if (i > 5)
                {

                    yield return i;
                }
            }
        }

        static IEnumerable<int> getRunningTotalOfList(IEnumerable<int> list)
        {
            Console.WriteLine("Entered!!!! function");
            int runningTotal = 0;
            foreach (int i in list)
            {
                Console.WriteLine("Entered!!!! function in loop");
                runningTotal += i;
                yield return runningTotal;
            }
        }
    }
}
