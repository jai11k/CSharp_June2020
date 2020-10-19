using System;
using System.Linq.Expressions;

namespace CSharp_June2020._BasicButCool
{
    public class ExpressionTreeWithLambdaExpression
    {
        static void Main(string[] args)
        {
            //Expression tree
            //(10+20)-(5+3)

            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,
                                            Expression.Constant(10),
                                            Expression.Constant(20));

            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
                                        Expression.Constant(3),
                                        Expression.Constant(5));

            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract,
                                       b1,
                                        b2);

            int result = Expression.Lambda<Func<int>>(b3).Compile()();
//TODO we need to understand this.
            //    int res = Expression.Lambda<Func<int>>(6).Compile()();
            Console.WriteLine("-->" + result);

            

          
        }
    }
}
