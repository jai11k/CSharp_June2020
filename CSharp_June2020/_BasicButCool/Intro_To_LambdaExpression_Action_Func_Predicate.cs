using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_June2020._BasicButCool
{
   public class Intro_To_LambdaExpression_Action_Func_Predicate
    {

        #region jaankari
        /*
         * Lambda expression,ACtion,Func,Predicate make your deligate code shorter sweeter and simpler.
         * Lamda expression helps to build expression trees. -> LINQ,Business Languages
         * 
         */
        #endregion

        delegate double CalculateCirCleAreaPtr(int r);

        #region Lesson1
        //static CalculateCirCleAreaPtr calculateCirCleAreaPtr = CalculateCirCleArea;
        #endregion
        static void Main(string[] args)
        {
            #region Lesson1_DeclareAndInvokeDelegate
            //double areaofcircle = calculateCirCleAreaPtr.Invoke(4);
            //Console.WriteLine("are of circle=" + areaofcircle);
            #endregion

            #region Lesson2_AnonymousMethodWithDelegate
            // //trying to make it short
            // CalculateCirCleAreaPtr calculateCirCleAreaPtr = new CalculateCirCleAreaPtr
            //    (
            //   delegate (int r)
            //   {
            //       return 3.14 * r * r;
            //}
            //    );
            // double areaofcircle = calculateCirCleAreaPtr.Invoke(4);
            // Console.WriteLine("are of circle=" + areaofcircle);
            #endregion

            #region Lesson3_LambdaExpression
            ////more shorter sweeter and simpler
            ////by using lambda expression
            ////so you can see
            ////lambda expression is nothing but simple inline code

            //CalculateCirCleAreaPtr calculateCirCleAreaPtr = x => 3.14 * x * x;
            //calculateCirCleAreaPtr.Invoke(4);
            ////lamda expression is divided into two parts
            ////where x is input parameter & 3.14*x*x is line od code ya can say return type.




            ////double areaofcircle = calculateCirCleAreaPtr.Invoke(4);
            ////Console.WriteLine("are of circle=" + areaofcircle);
            #endregion

            #region Lesson4_Lamda+Func_i.e_GenericDelegate
            //Func is a generic delegate
            //Func is a redimate delegate

            Func<int, Double> func = radius => 3.14 * radius * radius;

            double areaofcircle = func.Invoke(20);
            Console.WriteLine("area of circle=" + areaofcircle);

            //if a function does not have return type?
            //then use Action delegate

            Action<string> action = str => Console.WriteLine(str);
            action.Invoke("I am Action Delegate");

            //Predicate generic delegate
            //It is an extension to func
            //It will always return bool.
            //It is used for checking purposes.

            Predicate<string> predicate = strin => strin.Length > 5;
            bool hai5TonVaddi =predicate.Invoke("Jai");

            #endregion

            #region Lesson5_NEW
          double areacircle=  CalculateCirCleAreaLamda(4);
            #endregion



        }

        #region Lesson1_DeclareAndInvokeDelegate
        //static double CalculateCirCleArea(int r)
        //{
        //    return 3.14 * r * r;
        //}
        #endregion

        #region Lesson5_NEW
        static double CalculateCirCleAreaLamda(int r)=>3.14 * r * r;
        #endregion

    }
}
