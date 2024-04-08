using System;

class Hz
{
    static void Main()
    {
        int[,] a = new int[,]
        {
            { 0, 6, 0, 7, 0 },
            { 0, 0, 5, 8, -4 },
            { 0, -2, 0, 0, 0 },
            { 0, 0, -3, 0, 9 },
            { 2, 0, 7, 0, 0 }
        };
        Console.WriteLine("От какой вершины смотреть расстояния?");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] S = new int[a.GetLength(0)];
        int[] prev = new int[a.GetLength(0)]; // Массив для хранения предыдущих вершин
        for (int i = 0; i < a.GetLength(0); ++i)
        {
            S[i] = int.MaxValue;
            prev[i] = -1; // Инициализируем предыдущие вершины как -1
        }
        S[n] = 0;

        for (int i = 0; i < a.GetLength(0) - 1; i++)
        {
            for (int u = 0; u < a.GetLength(0); u++)
            {
                for (int v = 0; v < a.GetLength(1); v++)
                {
                    if (a[u, v] != 0 && S[u] != int.MaxValue && S[u] + a[u, v] < S[v])
                    {
                        S[v] = Math.Min(S[u] + a[u, v], S[v]);
                        prev[v] = u; // Обновляем предыдущую вершину на кратчайшем пути
                    }
                }
            }
        }

        for (int u = 0; u < a.GetLength(0); u++)
        {
            Console.WriteLine($"Расстояние между {n} и {u} это: {S[u]}");

            // Восстановление пути
            Console.Write("Путь: ");
            int p = u;
            while (p != -1)
            {
                Console.Write($"{p} <- ");
                p = prev[p];
            }
            Console.WriteLine();
        }
    }
}
