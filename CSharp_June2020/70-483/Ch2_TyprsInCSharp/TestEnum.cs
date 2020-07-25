using System;
using System.Collections.Generic;
using System.Text;

namespace Ch2_TyprsInCSharp
{
   public class TestEnum
    {
        static void Main(string[] args)
        {
            Status player = Status.Alive;

         

            switch (player)
            {
                case Status.Alive:
                    Console.WriteLine("Alive");
                    break;
                case Status.Injured:
                    Console.WriteLine("Inured");
                    //DO Injured Code
                    break;
                case Status.Dead:
                    Console.WriteLine("Dead");
                    //Do Dead Code
                    break;
            }

            int valueOfAlive = (int) player;
            Console.WriteLine("Integer Value of enum status =" + valueOfAlive);

            int valueOfGender = (int) Gender.Female;
            Console.WriteLine("Value of enum gender=" + Gender.Female);
            Console.WriteLine("Integer Value of enum gender=" + valueOfGender);

            int valueOfAccountType = (byte)AccountType.SavingsPlus;
            Console.WriteLine("Value of enum AccountType=" + AccountType.SavingsPlus);
            Console.WriteLine("Integer Value of enum AccountType=" + valueOfAccountType);
        }
    }

    enum Status
    {
        Alive,
        Injured,
        Dead
    }

    enum Gender
    {
        Male=1,
        Female    
    }
    enum AccountType : byte
    {
        // TODO : kini uk memory save krli ehne? kina uk fayda hoega?
   //The value type of Alive would be byte. It helps to minimize the memory storage required to initialize an enum.
    Savings = 1,
    SavingsPlus,
    Current
    }
}
