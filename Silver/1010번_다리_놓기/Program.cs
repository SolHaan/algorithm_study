/*
    Point : 다리끼리는 서로 겹칠 수 없다.
    조합 : 중복 없이, 순서를 고려하지 않고 선택하는 것

    => 조합을 사용해서 푸는 문제

    주의 : int는 런타임 에러가 발생하므로 BigIntegger을 사용
*/

using System;
using System.Numerics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Answer();
        }

        static void Answer()
        {
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) return;

            int T = Int32.Parse(input);

            for(int i = 0; i < T; i++) {
                ConnectBridge();
            }
        }

        static void ConnectBridge() {
            BigInteger result = 1;

            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) return;

            string[] NM = input.Split(' ');

            int N = Int32.Parse(NM[0]);
            int M = Int32.Parse(NM[1]);

            // factorial
            for(int i = 0; i < M; i++) {
                result *= (M - i);
            }

            for(int i = 0; i < N; i++) {
                result /= (N - i);
            }

            for(int i = 0; i < M-N; i++) {
                result /= ((M-N) - i);
            }

            Console.WriteLine(result);
        }
    }
}