/*
    카테고리 : DP (동적 계획법)
    복잡한 문제를 더 작은 하위 문제로 나누어서 해결하는 기법

    (승률) = (이긴 경기) / (총 경기 수);

    Math.Truncate() : 소수점 버림

    부동소수점 오차 주의
    -1 함정 주의

    미지수 식을 통해 해결
*/

using System;

namespace Algorithm
{
    class Program
    {
        static int X, Y, Z; // 이긴 횟수, 이긴 게임, 승률

        static void Main(string[] args)
        {
            Answer();
        }

        static void Answer ()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            X = inputs[0];
            Y = inputs[1];
            if(X == 0) 
            {
                Console.WriteLine(1);
                return;
            }

            Z = Convert.ToInt32(Math.Truncate((decimal)Y / (decimal)X * 100));

            CalcRecord();
        }

        static void CalcRecord()
        {
            decimal newRecord = (Z + 1) * (decimal)0.01;

            if(newRecord > 1 || (1 - newRecord) == 0)
            {
                Console.WriteLine(-1);
                return;
            }

            var result = Math.Ceiling((X * newRecord - Y) / (1 - newRecord));
            Console.WriteLine(result);
        }
    }
}