using System;
using System.ComponentModel.Design;
class hz
{
    static void Main()
    {
        int[,] a = { { 0, 10, 18, 8, int.MaxValue, int.MaxValue },
            { 10, 0, 16, 9, 21, int.MaxValue },
            { int.MaxValue, 16, 0, int.MaxValue, int.MaxValue, 15 },
            { 7, 9, int.MaxValue, 0, int.MaxValue, 12},
            { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0, 23 },
            { int.MaxValue, int.MaxValue, 15, int.MaxValue, 23, 0 }
        };
        int[,] old = a.Clone() as int[,];
        for (int k = 0; k < a.GetLength(0); k++)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((a[i, k] != int.MaxValue) && (a[k, j] != int.MaxValue))
                    {
                        a[i, j] = Math.Min(a[i, j], a[i, k] + a[k, j]);
                    }
                }
            }
        }
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == int.MaxValue) Console.Write("Inf\t"); else Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine(); Console.WriteLine("Откуда"); int st = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Куда"); int kon = Convert.ToInt32(Console.ReadLine()); string distination = "";
        Console.WriteLine("Кратчайший путь из вершины " + st + " в вершину " + kon + ":");
        if (a[st, kon] == int.MaxValue) Console.WriteLine("Путь не существует");
        else if (a[st, kon] == 0) Console.WriteLine("Путь равен нулю");
        else
        {
            //distination = Convert.ToString(st);
            char stt = Convert.ToChar(st);
            while (st != kon)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (a[st, kon] == a[st, i] + a[i, kon])
                    {
                        distination = distination + " " + i;
                        st = i;
                    }
                }
            }
            Console.WriteLine(distination);
        }
    }
}