using System;
namespace CSharp_June2020._BasicButCool
{

    #region jaankari
    /*
    IMAGE added in jaankari folder
     */
    #endregion


    public delegate void SampleDelegate();                      //Lesson1,2
    public delegate int SampleDelegate2();                      //Lesson3
    public delegate void SampleDelegate3(out int number);       //Lesson4

    public class MulticastDelegate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n - 0");


            //comment one lesson when using the other
            #region Lesson1
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodOne);
            //del3 = new SampleDelegate(SampleMethodOne);
            //del4 = del1 + del2 + del3;
            //del4();
            #endregion

            Console.WriteLine("\n - 1");

            #region Lesson2
            //del4 = del1 + del2 + del3 - del2;
            //del4();
            #endregion

            Console.WriteLine("\n - 2");

            #region Lesson3
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //del += SampleMethodThree;
            //del -= SampleMethodOne;
            //del();
            #endregion

            Console.WriteLine("\n - 3");

            #region Lesson3
            SampleDelegate2 dele = new SampleDelegate2(SampleMethodFour);
            dele += SampleMethodFive;
            int valueReturnedByDelegate = dele(); //5 bcz its latest
            Console.WriteLine("Value Returned By Delegate=" + valueReturnedByDelegate);
            #endregion

            Console.WriteLine("\n- 4");

            #region Lesson4
           // SampleDelegate3 dellesson4 = new SampleDelegate3(SampleMethodSix);
           // dellesson4 += SampleMethodSeven;
           // int valuetobePassedAsParameter = 4; // as out keyword k sath direct value as a parameter ni pass kr skte fir wo value wapis kis me le k ayega

           //dellesson4(out valuetobePassedAsParameter);

           // Console.WriteLine("Value Returned By Delegate=" + valuetobePassedAsParameter);
            #endregion


        }

        #region VoidReturntypeForLesson1,2

        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }


        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }


        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
        #endregion

        #region IntReturntypeForLesson3

        public static int SampleMethodFour()
        {
            return 4;
        }
        public static int SampleMethodFive()
        {
            return 5;
        }
        #endregion

        #region outKeywordInParameterForLesson4

        public static void SampleMethodSix(out int number)
        {
            number = 6;
            //Console.WriteLine("SampleMethodSix Invoked");
        }
        public static void SampleMethodSeven(out int number)
        {
            number = 7;
            //Console.WriteLine("SampleMethodSeven Invoked");
        }
        #endregion


    }
}
