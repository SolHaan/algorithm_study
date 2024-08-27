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
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();

            BigInteger A = BigInteger.Parse(inputA);
            BigInteger B = BigInteger.Parse(inputB);

            Console.WriteLine(A+B);
            Console.WriteLine(A-B);
            Console.WriteLine(A*B);
        }
    }
}