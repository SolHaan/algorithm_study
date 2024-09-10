/*
    DFS, BFS 개념 파악 문제
    양방향 확인 필요

    DFS : 깊이 우선 탐색
    - 방문한 곳을 끝까지 탐색

    BFS : 너비 우선 탐색
    - 한 Depth를 다 훑고 가는 탐색
*/

using System;

namespace Algorithm
{
    class Program
    {
        static int N, M, V;
        static bool[,] nodes; // 인접 행렬
        static bool[] visited; // 방문 여부

        static void Reset()
        {
            for(int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }
        }

        static Queue<int> bfsQueue = new Queue<int>();

        static void Main(string[] args)
        {
            Answer();
        }

        static void Answer ()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = inputs[0];
            M = inputs[1];
            V = inputs[2];

            nodes = new bool[N+1, N+1];
            visited = new bool[N+1];

            for(int i = 0; i < M; i++)
            {
                int[] points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                nodes[points[0], points[1]] = true;
                nodes[points[1], points[0]] = true; // 양방향 처리
            }

            DFS(V);

            Reset();
            Console.WriteLine();

            BFS(V);
        }

        static void DFS(int v) 
        {
            visited[v] = true;
            Console.Write($"{v} ");

            for(int i = 1; i <= N; i++)
            {
                if(nodes[v, i] == true && !visited[i])
                {
                    DFS(i);
                }
            }
        }

        static void BFS(int v)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            for(int i = 1; i <= N; i++)
            {
                if(nodes[v, i] == true && !visited[i])
                {
                    if(!bfsQueue.Contains(i))
                        bfsQueue.Enqueue(i);
                }
            }

            if(bfsQueue.Count > 0)
                BFS(bfsQueue.Dequeue());
        }
    }
}