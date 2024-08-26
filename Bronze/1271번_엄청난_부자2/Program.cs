using System;
using System.Numerics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem();
        }

        static void Problem ()
        {
            string input = Console.ReadLine();

            string[] moneys = input.Split(' ');

            BigInteger personMoney = 0;
            BigInteger remainMoney = 0;

            personMoney = BigInteger.Parse(moneys[0]) / BigInteger.Parse(moneys[1]);
            remainMoney = BigInteger.Parse(moneys[0]) % BigInteger.Parse(moneys[1]);

            Console.WriteLine(personMoney);
            Console.WriteLine(remainMoney);
        }

        #region 런타임 에러 (Overflow)
        /*
        static void Problem ()
        {
            string input = Console.ReadLine();

            string[] moneys = input.Split(' ');

            int personMoney = 0;
            int remainMoney = 0;

            personMoney = Int32.Parse(moneys[0]) / Int32.Parse(moneys[1]);
            remainMoney = Int32.Parse(moneys[0]) % Int32.Parse(moneys[1]);

            Console.WriteLine(personMoney);
            Console.WriteLine(remainMoney);
        }
        */
        #endregion
    }
}