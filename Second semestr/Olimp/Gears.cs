using System;
using System.Collections.Generic;
using System.IO;

public class Prog
{
    public static (int, int, Dictionary<int, int>, List<(int, int)>, int, int, int) ReadInput(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        string[] firstLine = lines[0].Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        Dictionary<int, int> gears = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
        {
            string[] line = lines[i].Split();
            int k = int.Parse(line[0]);
            int rk = int.Parse(line[1]);
            gears[k] = rk;
        }

        List<(int, int)> connections = new List<(int, int)>();
        for (int i = n + 1; i < n + 1 + m; i++)
        {
            string[] line = lines[i].Split();
            int s1 = int.Parse(line[0]);
            int s2 = int.Parse(line[1]);
            connections.Add((s1, s2));
        }

        string[] lastLine = lines[n + 1 + m].Split();
        int z1 = int.Parse(lastLine[0]);
        int z2 = int.Parse(lastLine[1]);

        int v = int.Parse(lines[n + 2 + m]);

        return (n, m, gears, connections, z1, z2, v);
    }

    public static Dictionary<int, List<int>> BuildGraph(List<(int, int)> connections)
    {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        foreach ((int s1, int s2) in connections)
        {
            if (!graph.ContainsKey(s1))
                graph[s1] = new List<int>();
            if (!graph.ContainsKey(s2))
                graph[s2] = new List<int>();
            graph[s1].Add(s2);
            graph[s2].Add(s1);
        }
        return graph;
    }

    public static bool DFS(int node, int parent, Dictionary<int, List<int>> graph, Dictionary<int, int> gears, Dictionary<int, int?> directions, int z1_direction, Dictionary<int, double?> speedRatios)
    {
        foreach (int neighbor in graph[node])
        {
            if (neighbor == parent)
                continue;
            if (directions[neighbor] == null)
            {
                directions[neighbor] = -directions[node];
                speedRatios[neighbor] = speedRatios[node] * gears[node] / gears[neighbor];
                if (!DFS(neighbor, node, graph, gears, directions, z1_direction, speedRatios))
                    return false;
            }
            else if (directions[neighbor] != -directions[node])
                return false;
        }
        return true;
    }

    public static (int, int?, double?) Resh(string filename)
    {
        (int n, int m, Dictionary<int, int> gears, List<(int, int)> connections, int z1, int z2, int v) = ReadInput(filename);

        Dictionary<int, List<int>> graph = BuildGraph(connections);

        Dictionary<int, int?> directions = new Dictionary<int, int?>();
        Dictionary<int, double?> speedRatios = new Dictionary<int, double?>();

        foreach (int i in gears.Keys)
        {
            directions[i] = null;
            speedRatios[i] = null;
        }

        directions[z1] = v;
        speedRatios[z1] = 1.0;

        if (!DFS(z1, -1, graph, gears, directions, v, speedRatios))
            return (-1, null, null);

        if (directions[z2] == null)
            return (-1, null, null);

        int w = directions[z2].Value;
        double o = speedRatios[z2].Value;

        return (1, w, o);
    }

    public static string Print((int, int?, double?) result)
    {
        if (result.Item1 == -1)
            return $"{result.Item1}";
        else
            return $"{result.Item1}\n{result.Item2}\n{result.Item3:F3}";
    }

    public static void Main(string[] args)
    {
            string file1 = $@"C:\Users\t-pud\Downloads\OmSTU\Olimpiadki\Шестеренки\Шестренки\Шестренки\input_s1_08.txt";
            (int, int?, double?) result = Resh(file1);
            Console.WriteLine(Print(result));
    }
}

