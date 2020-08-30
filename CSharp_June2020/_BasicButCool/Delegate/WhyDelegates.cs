using System;
using System.Collections.Generic;

namespace CSharp_June2020._BasicButCool
{
    public class WhyDelegates
    {

        #region jaankari

        /*
         We wana make employee class reusable but we have hard coded the logic to prmote employee.
        Lets say
        Company A promotes on the basis of exp.
        &
        Company A promotes on the basis of salary.
         */

        #endregion

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { ID = 101, Name = "Jai", Salary = 3000, Experience = 6 });
            list.Add(new Employee() { ID = 102, Name = "Simran", Salary = 5000, Experience = 3 });
            list.Add(new Employee() { ID = 103, Name = "Abhi", Salary = 40000, Experience = 10 });
            list.Add(new Employee() { ID = 104, Name = "Ghai", Salary = 35, Experience = 1 });
            list.Add(new Employee() { ID = 105, Name = "Shubham", Salary = 9000, Experience = 5 });

            #region Lesson-1_MainMethod -->
            //hard coded logic , method cannot be re-used if a company wants to promote with another creteria.
            //  Employee.promoteEmployee(list);
            #endregion

            #region Lesson-2_MainMethod
            //as delegate is similar to class it needs instance

            IsPromotable isPromotable = new IsPromotable(PromoteCreteria2); // this needs function to which delegate u wana point , intelisense ;) , ofcourse same defination as of delegate vala function.

            Employee.promoteEmployee(list, isPromotable);

            #endregion

        }


        static bool PromoteCreteria1(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

        static bool PromoteCreteria2(Employee emp)
        {
            if (emp.Salary >= 8000)
                return true;
            else
                return false;
        }

    }

    //return type is bool bcz-> if condition in promoteEmployee(List<Employee> list) returns true
    // Signature using Employee object bcz -->if condition in promoteEmployee(List<Employee> list)  is using too.
    // and thats the logic where we need flexibilty.
    public delegate bool IsPromotable(Employee emp);

 public    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        #region Lesson1
        //hard coded logic , method cannot be re-used if a company wants to promote with another creteria.
        public static void  promoteEmployee(List<Employee> list)
        {
            foreach (var emp in list)
            {
                if(emp.Experience >=5)
                {
                    Console.WriteLine(emp.Name + " pormoted. ");
                }
            }
        }

        #endregion

        #region Lesson2
       
        public static void promoteEmployee(List<Employee> list,IsPromotable isPromotable)
        {
            foreach (var emp in list)
            {
                //isPromotable according to defination of delegate needs object of Employee
                if (isPromotable(emp)) 
                {
                    Console.WriteLine(emp.Name + " pormoted. ");
                }
            }
        }

        #endregion


    }
}
