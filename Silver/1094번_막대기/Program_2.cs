/*
    아주 간단한 풀이를 발견했다.

    1. stick이 나오는 건 한정적이므로 미리 배열을 생성
    2. 그리디 알고리즘과 유사하게 풀이 진행
    3. X를 넘지 않는 수만 count
*/

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
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) return;

            int X = Int32.Parse(input);
            int[] sticks = { 64, 32, 16, 8, 4, 2, 1 };
            int count = 0;

            foreach(var stick in sticks) {
                if (X >= stick) {
                    count++;
                    X -= stick;
                }

                if (X == stick) {
                    return;
                }
            }

            Console.WriteLine(count);
        }
    }
}