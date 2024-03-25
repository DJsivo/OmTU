using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество вершин:");
        int numVersh = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество ребер: ");
        int numEdge = Convert.ToInt32(Console.ReadLine());
        List<Edge> edges = new List<Edge>();
        for (int i = 1; i <= numEdge; i++)
        {
            Console.WriteLine($"Введите вершины и вес ребра {i} через пробел: ");
            string[] p = Console.ReadLine().Split(' ');

            int versh1 = Convert.ToInt32(p[0]);
            int versh2 = Convert.ToInt32(p[1]);
            int weight = Convert.ToInt32(p[2]);
            edges.Add(new Edge(versh1, versh2, weight));
        }
        var sortedEdges = edges.OrderBy(e => e.Weight).ToList();
        List<int> derevo = new List<int>();
        derevo.Add(1); // Начало с вершины 1
        int sum = 0;
        while (derevo.Count != numVersh)
        {
            foreach (var edge in sortedEdges)
            {
                if ((derevo.Contains(edge.Versh1) && !derevo.Contains(edge.Versh2)) || (derevo.Contains(edge.Versh2) && !derevo.Contains(edge.Versh1)))
                {
                    sum += edge.Weight;
                    derevo.Add(derevo.Contains(edge.Versh1) ? edge.Versh2 : edge.Versh1);
                    break;
                }
            }
        }
        Console.WriteLine($"Длина минимального дерева: {sum}");
    }
}
public class Edge
{
    public int Versh1 { get; set; }
    public int Versh2 { get; set; }
    public int Weight { get; set; }
    public Edge(int versh1, int versh2, int weight)
    {
        Versh1 = versh1;
        Versh2 = versh2;
        Weight = weight;
    }
}

