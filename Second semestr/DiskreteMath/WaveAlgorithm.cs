using System;
class hz
{
    static void Main(string[] args)
    {
        int[,] map = {
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,1000,         1000,          1000,          int.MaxValue,int.MaxValue}, 
        {int.MaxValue,1000,         1000,int.MaxValue,                    1000,int.MaxValue}, 
        {int.MaxValue,1000,         1000,          1000,                    1000,int.MaxValue }, 
        {int.MaxValue,1000,1000,int.MaxValue,                    1000,int.MaxValue }, 
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },        
        };
        int[,] waveMap = new int[map.GetLength(0), map.GetLength(1)];
        waveMap = map;
        Console.WriteLine("Введите координаты начальной ячейки через \"enter\"");
        int st1 = int.Parse(Console.ReadLine()); int st2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты конечной ячейки через \"enter\"");
        int end1 = int.Parse(Console.ReadLine()); int end2 = int.Parse(Console.ReadLine());
        if ((map[st1, st2] == int.MaxValue) || (map[end1, end2] == int.MaxValue)) { Console.WriteLine("Невозможно определить путь."); }
        map[st1, st2] = 0;
        map[end1, end2] = 50;   
        int k = 0;
        while ((map[end1, end2] == 50))
        {
            for (int i = 1; i < map.GetLength(0)-1; i++)
            {
                for (int j = 1; j < map.GetLength(1)-1; j++)
                {
                    if (map[i, j] == k)
                    {
                        if (map[i - 1, j - 1] != int.MaxValue) map[i - 1, j - 1] = Math.Min(k + 1, map[i - 1, j - 1]);
                        if (map[i + 1, j + 1] != int.MaxValue) map[i + 1, j + 1] = Math.Min(k + 1, map[i + 1, j + 1]); 
                        if (map[i - 1, j + 1] != int.MaxValue) map[i - 1, j + 1] = Math.Min(k + 1, map[i - 1, j + 1]); 
                        if (map[i + 1, j - 1] != int.MaxValue) map[i + 1, j - 1] = Math.Min(k + 1, map[i + 1, j - 1]); 
                        if (map[i - 1, j] != int.MaxValue) map[i - 1, j] = Math.Min(k + 1, map[i - 1, j]); 
                        if (map[i + 1, j] != int.MaxValue) map[i + 1, j] = Math.Min(k + 1, map[i + 1, j]); 
                        if (map[i, j - 1] != int.MaxValue) map[i, j - 1] = Math.Min(k + 1, map[i, j - 1]); 
                        if (map[i, j + 1] != int.MaxValue) map[i, j + 1] = Math.Min(k + 1, map[i, j + 1]);   
                    }
                    else {continue;}
                    if (waveMap == map) break;
                    else waveMap = map;
                }
            }
            k++;
        }
        if (map[end1, end2] == 50) Console.WriteLine("Невозможно определить путь.");
        else
        {
            Console.WriteLine("Карта после выполнения алгоритма:");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == int.MaxValue) Console.Write("Inf\t");
                    else Console.Write(map[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nДлина пути: {map[end1, end2]}");
            // Восстановление пути
            int cL = map[end1, end2];
            int ci = end1;
            int cj = end2;
            string S = "";
            while (cL > 1)
            {
                S = $" => ({ci}, {cj}) " + S;
                int minN = int.MaxValue;
                int nextI = ci;
                int nextJ = cj;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0) continue;
                        int ni = ci + i;
                        int nj = cj + j;

                        if (ni >= 0 && ni < map.GetLength(0) && nj >= 0 && nj < map.GetLength(1))
                        {
                            if (map[ni, nj] < minN && map[ni, nj] < map[ci, cj])
                            {
                                minN = map[ni, nj];
                                nextI = ni;
                                nextJ = nj;
                            }
                        }
                    }
                }             
                ci = nextI;
                cj = nextJ;
                cL--;
            }
            Console.WriteLine(@$"Путь:
{S}");
        }
    }
}