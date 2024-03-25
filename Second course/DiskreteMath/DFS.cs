using System;
using System.Collections.Generic;

class GraphOnDeep
{
    private static void AddEdge(List<List<int>> graph, int u, int v)
    {
        graph[u].Add(v);
        graph[v].Add(u);
    }//Для заполнения списков всех вершин смежных с определенной

    private static void Reshenie(List<List<int>> graph, int start, bool[] visited)
    {
        visited[start] = true;
        Console.WriteLine(start);

        foreach (var neighbor in graph[start])
        {
            if (!visited[neighbor])
            {
                Reshenie(graph, neighbor, visited);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите количество вершин:");
        int kolvoVer = Convert.ToInt32(Console.ReadLine());
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < kolvoVer; i++)
        {
            graph.Add(new List<int>());
        }
        Console.WriteLine("Введите количество ребер: ");
        int kolvoEdge = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= kolvoEdge; i++)
        {
            Console.WriteLine($"Введите ребро {i} в формате: \"вершина1 вершина2\" ");
            string[] edge = Console.ReadLine().Split();
            int u = Convert.ToInt32(edge[0]);
            int v = Convert.ToInt32(edge[1]);
            AddEdge(graph, u, v);
        }//Добавляем ребра

        bool[] obrabotana = new bool[kolvoVer];

        for (int i = 0; i < kolvoVer; i++)
        {
            if (!obrabotana[i])
            {
                Console.WriteLine("Компонента связности:");
                Reshenie(graph, i, obrabotana);
            }
        }
    }
}