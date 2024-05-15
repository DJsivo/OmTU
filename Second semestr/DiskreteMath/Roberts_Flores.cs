using System;
using System.Collections.Generic;
using System.IO;
class Hz
{
    static void Main(string[] args)
    {
        int[,] graph = new int[,]
        {
            { 0, 1, 1, 1, 0, 0, 0 },
            { 1, 0, 1, 0, 1, 0, 1 },
            { 1, 1, 0, 1, 1, 1, 1 },
            { 1, 0, 1, 0, 1, 1, 1 },
            { 0, 1, 1, 1, 0, 1, 0 },
            { 0, 0, 1, 1, 1, 0, 1 },
            { 0, 1, 1, 1, 0, 1, 0 }
        };
        List<List<int>> cicle = new List<List<int>>();
        List<List<int>> putb = new List<List<int>>();
        void NV(List<int> path)
        {
            List<int> may = new List<int>();
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[path[path.Count - 1], i] == 1 && !path.Contains(i)) may.Add(i);
            }

            if (may.Count == 0 && path.Count == graph.GetLength(0))
            {
                if (graph[path[0], path[path.Count - 1]] == 1) cicle.Add(path);
                else putb.Add(path);
                return;
            }

            foreach (int i in may)
            {
                List<int> newPath = new List<int>(path);
                newPath.Add(i);
                NV(newPath);
            }
        }
        NV(new List<int> { 0 });
        Console.WriteLine($"Пути({putb.Count}):");
        foreach (var i in putb) 
        { 
            foreach(int j in i) Console.Write(j+ ", ");Console.WriteLine();
        }
        Console.WriteLine($"\nЦиклы({cicle.Count}):");
        foreach (var i in cicle)
        {
            foreach (int j in i)Console.Write(j + ", ");Console.WriteLine();
        }
    }
}
