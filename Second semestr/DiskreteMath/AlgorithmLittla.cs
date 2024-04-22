using System;
using System.ComponentModel.DataAnnotations;
public class Rebra
{
    int V1 { get; set; }
    int V2 { get; set; }
    public Rebra(int V1, int V2)
    {
        this.V1 = V1;
        this.V2 = V2;
    }
    public static void Print(Rebra rebro)
    {
        Console.Write($"({rebro.V1},{rebro.V2})\t");
    }
}
class Hz
{
    static void Main(string[] args)
    {
        int[,] graph =
        {
            {int.MaxValue, 44, 74, 41, 5},
            {14, int.MaxValue, 47, 12, 52},
            {85, 47, int.MaxValue, 65,  45},
            {45, 58, 65, int.MaxValue,  75},
            {74, 63, 9, 75, int.MaxValue},
        };
        int[,] copygraph = new int[graph.GetLength(0), graph.GetLength(1)];//Тут степени нулей
        List<Rebra> prohli = new List<Rebra>();
        int sum = 0;
        for (int pr = 0; pr < graph.GetLength(0) - 2; pr++)
        {
            int[] stroka = new int[graph.GetLength(0)];//Хранение минимумов из строк
            int[] stolb = new int[graph.GetLength(1)];//Хранение минимумов из столбцов
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                int minstr = int.MaxValue;
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] < minstr) { minstr = graph[i, j]; stroka[i] = graph[i, j]; }
                }
            }//Min for any string
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if ((graph[i, j] != int.MaxValue) && (stroka[i] != int.MaxValue)) graph[i, j] -= stroka[i];
                }
            }//Vichet min iz any string
            for (int j = 0; j < graph.GetLength(1); j++)
            {
                int minstol = int.MaxValue;
                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[i, j] < minstol) { minstol = graph[i, j]; stolb[j] = graph[i, j]; }
                }
            }//Min for any colomn
            for (int j = 0; j < graph.GetLength(1); j++)
            {
                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if ((graph[i, j] != int.MaxValue) && (stolb[j] != int.MaxValue)) graph[i, j] -= stolb[j];
                }
            }//Vachet min iz any colomn
            foreach (int i in stroka) if (i != int.MaxValue) sum += i;//Sum min's string
            foreach (int j in stolb) if (j != int.MaxValue) sum += j;//Sum min's string + colomn
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if ((graph[i, j] == 0))
                    {
                        graph[i, j] = int.MaxValue;
                        int minstolb = int.MaxValue;
                        int minstr = int.MaxValue;
                        for (int l = 0; l < graph.GetLength(1); l++)
                        {
                            if (graph[i, l] < minstr) { minstr = graph[i, l]; }
                        }
                        for (int k = 0; k < graph.GetLength(0); k++)
                        {
                            if (graph[k, j] < minstolb) { minstolb = graph[k, j]; }
                        }
                        copygraph[i, j] = minstolb + minstr;//Him degree
                        graph[i, j] = 0;
                    }
                }
            }//Degree any null
            int MaxMark = 0;
            int UdalStr = int.MaxValue;
            int UdalStolb = int.MaxValue;
            for (int i = 0; i < copygraph.GetLength(0); i++)
            {
                for (int j = 0; j < copygraph.GetLength(1); j++)
                {
                    if (copygraph[i, j] > MaxMark) { MaxMark = copygraph[i, j]; UdalStr = i; UdalStolb = j; }
                }
            }
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                graph[i, UdalStolb] = int.MaxValue;
                graph[UdalStr, i] = int.MaxValue;
            }
            Array.Clear(copygraph);//Чистим степени нулей
            prohli.Add(new Rebra(UdalStr, UdalStolb));
        }
        Console.WriteLine($"Длина пути: {sum}");
        for (int i = 0; i < graph.GetLength(0); i++) { for (int j = 0; j < graph.GetLength(1); j++) { if (graph[i, j] == 0) prohli.Add(new Rebra(i, j)); } }
        Console.WriteLine("\nРебра входящие в гамильтонов цикл:"); foreach (Rebra p in prohli) { Rebra.Print(p); }
        Console.WriteLine();
    }
}
// Console.WriteLine("Наш граф:"); for (int i = 0; i < graph.GetLength(0); i++) { for (int j = 0; j < graph.GetLength(1); j++) { if (graph[i, j] == int.MaxValue) Console.Write("Inf \t"); else Console.Write(graph[i, j] + "\t"); } Console.WriteLine(); }
