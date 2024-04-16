using System;
using System.Collections.Generic;
class Dijkstraa
{
    
    public static int[] Dijkstra(int[,] graph, int source, int[] parent )
    {
        int n = graph.GetLength(0);
        int[] distance = new int[n];
        bool[] visited = new bool[n];
        

        for (int i = 0; i < n; i++)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < n - 1; count++)
        {
            int u = MinDistance(distance, visited);
            visited[u] = true;

            for (int v = 0; v < n; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                {
                    distance[v] = distance[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }

        return distance;
        
    }

    private static int MinDistance(int[] distance, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < distance.Length; i++)
        {
            if (!visited[i] && distance[i] <= min)
            {
                min = distance[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    private static List<int> GetS(int source, int destination, int[] parent)
    {
        List<int> s = new List<int>();
        int current = destination;

        while (current != source)
        {
            s.Add(current);
            current = parent[current];
        }

        s.Add(source);
        s.Reverse();

        return s;
    }

    public static void Main()
    {
       
        int[,] graph = {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };
        int[] parent = new int[graph.GetLength(0)];
        Console.Write("С какой вершины начать? ");
        int youVertex = Convert.ToInt32(Console.ReadLine());
        int n = graph.GetLength(0);
        if (youVertex < n)
        {
            int[] distance = Dijkstra(graph, youVertex, parent);

            for (int i = 0; i < n; i++)
            {
                if (i != youVertex)
                {
                    List<int> s = GetS(youVertex, i, parent);
                    Console.WriteLine($"Минимальная дистанция от {youVertex} до {i}: {distance[i]}");
                    Console.WriteLine("Путь:");
                    foreach (int p in s)
                    {
                        Console.Write(p + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Нет такой.");
        }
    }
}