using System;
namespace CSharp_June2020._BasicButCool
{
    public class MoreOnDelegate
    {

        #region jaankari
        /*
         Deligates is a pointer to function.
       ^dull ^monotonous ^tedious ^repetitous ^stupid defination.

        Dictionary meaning of delegate is :-
        Delegate is reperesntative.
        It is a kind of reperesntative b/w two parties.

        Delegate is a reference type.
        Actually-> Delegate is a type safe function pointer.
         #meaning-> A delegate points to a function & when u invoke this delegate function gets invoked. #

         * 
         */
        #endregion



        static void Main(string[] args)
        {
            //comment lesson-1 when to use lesson-2

            #region Lession-1_Main_Method
            //SomeMethodPtr obj = new SomeMethodPtr(SomeMethod);
            //obj.Invoke();// does it really make sense
            //SomeMethod(); // why not like this?
            #endregion

            #region Lession-2_Main_Method
            MyClass obj = new MyClass();
         //   obj.LongRunning1();

            obj.LongRunning2(CallbackMethod);
            //Now here there are two parties WhatIsDeligate,MyClass
            //
            //   suppose MyClass wants to provde update to WhatIsDelegate that for loop is on which iteration.
            //
            //       WhatIsDeligate  <---UPDATES----  MyClass
            //
            //     

            #endregion


        }

        #region Lession-2_Main_Class
          
        static void CallbackMethod(int i)
        {
            Console.WriteLine("--->" + i);
        }
        #endregion


        #region Lesson-1
        public delegate void SomeMethodPtr();

        static void SomeMethod()
        {
            Console.WriteLine("Some Method called");
        }
        #endregion

    }

    #region Lesson_2

    public delegate void CallBack(int i);
       

    class MyClass
    {

        public void LongRunning1()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Does some thing long.
                
            }
        }
        public void LongRunning2(CallBack obj)
        {
            for(int i=0;i<10000;i++)
            {
                //Does some thing long.
                obj(i);
            }
        }
    }

    #endregion
}
