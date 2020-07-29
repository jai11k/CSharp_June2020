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
            GenericClass2<int> genInt = new GenericClass2<int>();
            int intData = genInt.GenericMethod(70);
            genInt.GenericProperty = 483;
            Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);

            //2.
            //Here <T> type become string. Which is a reference type
            GenericClass3<string> genStr = new GenericClass3<string>();
            string strData = genStr.GenericMethod("C#");
            genStr.GenericProperty = "Certification Exam: ";
            Console.WriteLine("{0} {1}", strData, genStr.GenericProperty);

            //3.
            //Here 'T' is Myclass. Which has public default constructor
            GenericClass4<MyClass> genMC = new GenericClass4<MyClass>();

            //4.
            GenericClass5<Person1> genPer = new GenericClass5<Person1>();
            //Student is also a Person. This is also valid.
            GenericClass5<Student1> genStd = new GenericClass5<Student1>();

            //5.
            //Here 'T' is IPerson
            GenericClass6<IPerson> genIPer = new GenericClass6<IPerson>();
            //Here 'T' is Person which has implement 'IPerson'
            GenericClass6<Person> genPer1 = new GenericClass6<Person>();
            //Here 'T' is Student it inherit 'Person' which implement 'IPerson'.
            GenericClass6<Student> genStd1 = new GenericClass6<Student>();

            //6.
            //Here 'T' and 'U' types are same
            GenericClass7<Person2, Person2> genPP =
                new GenericClass7<Person2, Person2>();
            //Here 'T' inherit 'U' type
            GenericClass7<Student2, Person2> genSP =
                new GenericClass7<Student2, Person2>();


        }
    }


    #region Constraint "where T : struct"
    class GenericClass2<T> where T : struct
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
    class GenericClass3<T> where T : class
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

    class GenericClass4<T> where T : new()
    {
        //code
    }
    #endregion

    #region Constraint “where T: BaseClass”
    class Person1
    {
    }
    class Student1 : Person1
    {
    }
    class GenericClass5<T> where T : Person1
    {
        //code
    }
    #endregion

    #region Constraint "where T : interfaceName"
    interface IPerson
    {
        void walking();
    }
    class Person : IPerson
    {
        //Implement Iperson
        public void walking()
        {
            Console.WriteLine("wallking");
        }
    }
    class Student : Person
    {
        //code
    }
    class GenericClass6<T> where T : IPerson
    {
        //code
    }

    #endregion

    #region Constraint “where T: U”
    class Person2
    {
        //code
    }
        class Student2 : Person2
        {
            //code
    }
    class GenericClass7<T,U> where T : U
    {
                //code
    }


                #endregion



            }
