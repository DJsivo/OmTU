using System;
using System.Collections.Generic;
public class Program
{
    public static int MaxFlow(int[,] graph, int source, int sink)
    {
        bool[] visited = new bool[graph.GetLength(0)];
        int[] parent = new int[graph.GetLength(0)];

        int MaxFlow = 0;

        while (BFS(graph, source, sink, parent, visited))
        {
            int pathFlow = int.MaxValue;
            int s = sink;

            while (s != source)
            {
                pathFlow = Math.Min(pathFlow, graph[parent[s], s]);
                s = parent[s];
            }
            MaxFlow += pathFlow;
            s = sink;

            while (s != source)
            {
                int u = parent[s];
                graph[u, s] -= pathFlow;
                graph[s, u] += pathFlow;
                s = parent[s];
            }
        }

        return MaxFlow;
    }
    private static bool BFS(int[,] graph, int source, int sink, int[] parent, bool[] visited)
    {
        Array.Fill(visited, false);
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(source);
        visited[source] = true;
        parent[source] = -1;

        while (queue.Count != 0)
        {
            int u = queue.Dequeue();

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (!visited[i] && graph[u, i] > 0)
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                    parent[i] = u;

                    if (i == sink)
                        return true;
                }
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        int[,] graph = new int[,]
        {
            {0, 20, 30, 10, 0},
            {0, 0, 30, 0, 30},
            {0, 0, 0, 10, 20},
            {0, 0, 0, 0, 20},
            {0, 0, 0, 0, 0}
        };
        int source = 0;
        int sink = 4;
        Console.WriteLine($"Maximum flow: {MaxFlow(graph, source, sink)}");
    }
}