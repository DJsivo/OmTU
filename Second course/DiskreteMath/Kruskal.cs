using System;
using System.Collections.Generic;
using System.Linq;
class KruskalAlgorithm
{
    public class Edge
    {
        public int Begin { get; set; }
        public int End { get; set; }
        public int Weight { get; set; }
    }

    public static List<Edge> Kruskal(List<Edge> edges, int numVersh)
    {
        edges = edges.OrderBy(e => e.Weight).ToList();
        List<Edge> glavnoe = new List<Edge>();
        int[] parent = new int[numVersh];

        for (int i = 0; i < numVersh; i++)
        {
            parent[i] = i;
        }

        foreach (Edge edge in edges)
        {
            int vyxod = Svyaz(parent, edge.Begin);
            int zaxod = Svyaz(parent, edge.End);

            if (vyxod != zaxod)
            {
                glavnoe.Add(edge);
                parent[vyxod] = zaxod;
            }
        }

        return glavnoe;
    }

    private static int Svyaz(int[] parent, int indexversh)
    {
        while (parent[indexversh] != indexversh)
        {
            indexversh = parent[indexversh];
        }

        return indexversh;
    }

    static void Main()
    {
        List<Edge> edges = new List<Edge>();
        Console.WriteLine("Ввод:");
        Console.WriteLine("Количество вершин:");
        int numVersh = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество ребер:");
        int numEdges = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numEdges; i++)
        {
            Console.WriteLine("Begin edge: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End edge: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weight edge: "); int c = Convert.ToInt32(Console.ReadLine());
            edges.Add(new Edge() { Begin = a, End = b, Weight = c });
        }
        List<Edge> glavnoe = Kruskal(edges, numVersh);
        Console.Clear();
        int sum = 0;
        foreach (Edge edge in glavnoe)
        {
            Console.WriteLine($"{edge.Begin}  -  {edge.End} :  {edge.Weight}");
            sum += edge.Weight;
        }
        Console.WriteLine(@$"
Суммарный вес: {sum}");
    }
}

//Begin = 0, End = 1, Weight = 2 
//Begin = 0, End = 2, Weight = 2 
//Begin = 0, End = 4, Weight = 7 
//Begin = 1, End = 2, Weight = 2 
//Begin = 1, End = 4, Weight = 2 
//Begin = 1, End = 3, Weight = 9 
//Begin = 2, End = 4, Weight = 5
//Begin = 3, End = 4, Weight = 10 
//Begin = 3, End = 5, Weight = 5 
//Begin = 3, End = 6, Weight = 2 
//Begin = 3, End = 7, Weight = 16 
//Begin = 4, End = 6, Weight = 9 
//Begin = 5, End = 7, Weight = 17 
//Begin = 6, End = 7, Weight = 17 
