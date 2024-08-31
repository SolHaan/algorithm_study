/*
    문제를 이해했다면 그대로 따르면 되는 문제
*/

using System.Collections.Generic;
using System.Linq;

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
            List<int> sticks = new List<int>();
            
            int result = Divide(X, sticks);
            Console.WriteLine(result);
        }

        static int Divide(int X, List<int> sticks) {
            int currentStick = 64;

            if (sticks.Count < 1) {
                if (currentStick == X || (currentStick/2) == X) {
                    return 1;
                }

                currentStick /= 2;

                if (currentStick > X) {
                    sticks.Add(currentStick);
                }
                else {
                    for(int i = 0; i < 2; i++) {
                    sticks.Add(currentStick);
                    }
                }

                return Divide(X, sticks);
            }

            sticks.Sort();
            currentStick = sticks[0]; // 가장 짧은 것
            sticks.RemoveAt(0);

            currentStick /= 2;
            int sum = sticks.Sum();
            sum += currentStick;

            if (sum < X) {
                for(int i = 0; i < 2; i++) {
                    sticks.Add(currentStick);
                }
            }
            else {
                sticks.Add(currentStick);

                if (sum == X) { // result
                    return sticks.Count;
                }
            }

            return Divide(X, sticks);
        }
    }
}