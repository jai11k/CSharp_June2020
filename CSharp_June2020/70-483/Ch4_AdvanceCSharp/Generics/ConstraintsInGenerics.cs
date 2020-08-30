using System;
namespace Ch4_AdvanceCSharp
{
    #region jaankari
    /*
     There are 6 kinds of constraints that we can apply on generic type parameters.
    The following tablen lists the kinds of constraints.

        Constraints               Explanation
  1.      where T : struct          Type “T” must be a value type
  2.      where T : class           Type “T” must be a reference type
  3.      where T : new()           Type “T” must has a definition of public default constructor 
  4.      where T : U               Type “T” must be or child of type “U”
  5.      where T : interfaceName   Type “T” must be or implement a specified interface

     */
    #endregion

    public class ConstraintsInGenerics
    {
        static void Main(string[] args)
        {
            //1.
            //Here <T> type become int which is a value type
            GenericClass1<int> genInt = new GenericClass1<int>();
            int intData = genInt.GenericMethod(70);
            genInt.GenericProperty = 483;
            Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);

            //2.
            //Here <T> type become string. Which is a reference type
            GenericClass2<string> genStr = new GenericClass2<string>();
            string strData = genStr.GenericMethod("C#");
            genStr.GenericProperty = "Certification Exam: ";
            Console.WriteLine("{0} {1}", strData, genStr.GenericProperty);

            //3.
            //Here 'T' is Myclass. Which has public default constructor
            GenericClass3<MyClass> genMC = new GenericClass3<MyClass>();

            //4.
            GenericClass4<Person4> genPer = new GenericClass4<Person4>();
            //Student is also a Person. This is also valid.
            GenericClass4<Student4> genStd = new GenericClass4<Student4>();

            //5.
            //Here 'T' is IPerson
            GenericClass5<IPerson> genIPer = new GenericClass5<IPerson>();
            //Here 'T' is Person which has implement 'IPerson'
            GenericClass5<Person5> genPer1 = new GenericClass5<Person5>();
            //Here 'T' is Student it inherit 'Person' which implement 'IPerson'.
            GenericClass5<Student5> genStd1 = new GenericClass5<Student5>();

            //6.
            //Here 'T' and 'U' types are same
            GenericClass6<Person6, Person6> genPP =
                new GenericClass6<Person6, Person6>();
            //Here 'T' inherit 'U' type
            GenericClass6<Student6, Person6> genSP =
                new GenericClass6<Student6, Person6>();


        }
    }


    #region Constraint "where T : struct"
    class GenericClass1<T> where T : struct
    {
        //Where T: struct says, 'T' can only be a value type.
        private T genericField;
        public T GenericMethod(T genericParameter)
        {
            this.genericField = genericParameter;
            return this.genericField;
        }
        public T GenericProperty { get; set; }
    }
    #endregion

    #region   Constraint "where T : class"
    class GenericClass2<T> where T : class
    {
        //type 'T' will be a reference type
        private T genericField;
        public T GenericMethod(T genericParameter)
        {
            this.genericField = genericParameter;
            return this.genericField;
        }
        public T GenericProperty { get; set; }
    }
    #endregion

    #region Constraint "where T : new()"
    class MyClass
    {
        //Public Default Constructor
        public MyClass()
        {
        }
    }

    class GenericClass3<T> where T : new()
    {
        //code
    }
    #endregion

    #region Constraint “where T: BaseClass”
    class Person4
    {
    }
    class Student4 : Person4
    {
    }
    class GenericClass4<T> where T : Person4
    {
        //code
    }
    #endregion

    #region Constraint "where T : interfaceName"
    interface IPerson
    {
        void walking();
    }
    class Person5 : IPerson
    {
        //Implement Iperson
        public void walking()
        {
            Console.WriteLine("wallking");
        }
    }
    class Student5 : Person5
    {
        //code
    }
    class GenericClass5<T> where T : IPerson
    {
        //code
    }

    #endregion

    #region Constraint “where T: U”
    class Person6
    {
        //code
    }
        class Student6 : Person6
        {
            //code
    }
    class GenericClass6<T,U> where T : U
    {
                //code
    }


                #endregion



            }
