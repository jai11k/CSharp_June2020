﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Collections;

namespace CSharp_June2020
{
    public class Test
    {
        static void Main(string[] args)
        {

            #region ListNalPange
            // List<int> expectedlist = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // List<int> unexpectedlist = new List<int>() { 1, 2, 3, 4,1,2,3,4, 5, 6 };

            //IEnumerable<int> duplicateExpectedlist = expectedlist.GroupBy(x => x).Where(g => g.Count() > 1)
            //     .Select(x => x.Key);


            // IEnumerable<int> duplicateunExpectedlist = unexpectedlist.GroupBy(x => x).Where(g => g.Count() > 1)
            //     .Select(x => x.Key);


            // Console.WriteLine("expected list should be empty= ");
            // foreach (int i in duplicateExpectedlist)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("\n");

            // Console.WriteLine("UnExpextedList should not be empty");
            // foreach (int i in duplicateunExpectedlist)
            // {
            //     Console.WriteLine(i);
            // }
            #endregion


            //     List<Employee> empList = new List<Employee>()
            //     {
            //         new Employee(){empID=1,empName="Jai",empSal=900M},
            //         new Employee(){empID=2,empName="Simran",empSal=200M},
            //         new Employee(){empID=3,empName="Abhi",empSal=500M},
            //         new Employee(){empID=4,empName="Shubham",empSal=600M},
            //         new Employee(){empID=5,empName="Karan",empSal=700M},
            //     };

            //string s=     function1("--");
            // //TODO ... akal hai eh?
            //     string s2 = function1(null);
            //     empList.Sum(x => x.empSal);

            //int value = 0;
            //bool test = Convert.ToBoolean(value);
            //Console.WriteLine("Bool value =" + test);


            List<string> lis = new List<string>();
            lis.Add("jai simran singh");
            lis.Add("jai pal singh");

          var test=  lis.Where(x => x.Contains("simran"));

        }


        static string function1([NotNull] string args) => args + "@";
        
    }

    class Employee
    {
        public int empID {get; set; }
        public string empName { get; set; }

        public decimal empSal { get; set; }
    }
}

public class Person : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        // new syntax seen, search and save it
        if (obj is Person otherPerson)
        {
            // Compare based on age
            return this.Age.CompareTo(otherPerson.Age);
        }
        else
        {
            throw new ArgumentException("Object is not a Person.");
        }
    }
}