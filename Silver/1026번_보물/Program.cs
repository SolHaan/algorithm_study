/*
    정렬을 통해서 큰 수는 작은 값을 주도록 했다.
*/

using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Answer();
        }

        static void Answer ()
        {
            string input = Console.ReadLine();
            int N = Int32.Parse(input); 

            int[] A = GetIntArray();
            int[] B = GetIntArray();

            Array.Sort(A);
            Array.Reverse(A);
            Array.Sort(B);

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += A[i] * B[i];
            }

            Console.WriteLine(sum);
        }

        static int[] GetIntArray() 
        {
            var input = Console.ReadLine().Split(" ");
            return Array.ConvertAll(input, i => int.Parse(i));
        }
    }
}