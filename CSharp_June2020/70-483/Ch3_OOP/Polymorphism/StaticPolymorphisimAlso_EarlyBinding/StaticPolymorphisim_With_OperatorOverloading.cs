using System;
namespace Ch3_OOP
{
    public class StaticPolymorphisim_With_OperatorOverloading
    {
        #region jaankari
        /*
Generally, in C# we can overload three kinds of operators:

1.Unary operator->operates on a single operand (+, -, !, ++, --, true, false). These are unary
operators which can be overloaded in C#.

2. Binary Operators->operates on two operands (+, -, *, /, %, &, |, ^, <<, >>). These are
Binary operators which can be overloaded in C#.

3. Comparison Operators->operates on two operands and returns Boolean value when it
compares left-sided operand’s value with right-sided operand’s value (==, !=, <, >, <=, >=).
These are comparison operators which can be overloaded in C#.

NOTE->always overload opposite operator of comparison operator. For example, whenever we
      overload less than operator we must overload greater than operator as well. the same
      applies to ==, != operator.


         */
        #endregion


        static void Main(string[] args)
        {
            //Unary operator->
            Distance distance = new Distance();
            distance.meter = 5;
            distance++;
            distance++;
            Console.WriteLine(distance.meter); //9

            //Binary Operators->
            Student2 s1 = new Student2 { Marks = 10 };
            Student2 s2 = new Student2 { Marks = 20 };
            Student2 s3 = s1 + s2; //add ki jagah multiply 
            Console.WriteLine(s3.Marks);
            /*
            Student s3 = s1 + s2;
            when it is called, operator + method will get executed,
            which takes s1 and s2 for its parameter values.
            */

            //Comparison Operators
            Distance1 d1 = new Distance1 { meter = 10 };
            Distance1 d2 = new Distance1 { meter = 20 };
            if (d1 < d2)
            {
                Console.WriteLine("d1 is less than d2");
            }
            else if (d2 < d1)
            {
                Console.WriteLine("d2 is less than d1");
            }
            /*
         if(d1 < d2): When this code is executed, operator < method will get executed,
         which takes d1 and d2 as its parameter.It returns true if d1's meter value is
         less than d2's meter value.
            */
        }

    }

    class Distance
    {
        public int meter { get; set; }

        public static Distance operator ++(Distance dis)
        {
            dis.meter += 2;
            return dis;
        }
    }

    class Student2
    {
        public int Marks { get; set; }
        // + Operator Overloading Method
        public static Student2 operator +(Student2 s1, Student2 s2)
        {
            Student2 std = new Student2();
            std.Marks = s1.Marks * s2.Marks;
            return std;
        }
    }

    class Distance1
    {
        public int meter { get; set; }
        public static bool operator <(Distance1 d1, Distance1 d2)
        {
            return (d1.meter < d2.meter);
        }
        public static bool operator >(Distance1 d1, Distance1 d2)
        {
            return (d1.meter > d2.meter);
        }
    }

}
