using System;
class hz
{
    static void Main()
    {
        int n, k;
        n = Convert.ToInt32(Console.ReadLine());//Кол-во строк
        k = Convert.ToInt32(Console.ReadLine());//Кол-во столбцов
        int[,] a = new int[n, k];
        Console.WriteLine("Введите массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //1 Задание
        int count = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int Max = a[i, 0];
            int Min = a[i, 0];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (Max < a[i, j])
                {
                    Max = a[i, j];
                }
                if (Min > a[i, j])
                {
                    Min = a[i, j];
                }
            }
            if (Max % 2 == 0 && Min % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество строк в которых минимальный и максимальный элементы четные = {count}");
        //2 Задание
        Console.Write("Номера столбцов в которых все элементы положительные(начиная с нуля): ");
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int c = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] >= 0)
                {
                    c ++;
                }
            }
            if (c == n)
            {
                Console.Write(j);
            }
        }
        Console.WriteLine();
        //3 Задание
        int zero = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (a[i, j] == 0)
                {
                    zero ++;
                }
            }
        }
        Console.WriteLine($"Количество нулевых элементов во всем массиве = {zero}");
        //4 Задание
        for (int i = 0; i < n; i++)
        {
            int summa = 0;
            for (int j = 0; j < k; j++)
            {
                summa += a[i, j];
            }
            if (summa == 0)
            {
                Console.WriteLine("Да, в массиве имеется строка с нулевой суммой.");
                break;
            }
            else
            {
                Console.WriteLine("Нет, в массиве не имеется строка с нулевой суммой.");
                break;
            }
        }
        //5 Задание
        int quantity = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int even = 0;
                int[] str1 = new int[k];
                int[] str2 = new int[k];
                for (int m = 0; m < k; m++)
                {
                    str1[m] = a[i, m];
                    str2[m] = a[j, m];
                }
                Array.Sort(str1);
                Array.Sort(str2);
                for (int m = 0; m < k; m++)
                {
                    if (str1[m] == str2[m])
                    {
                        even += 1;
                    }
                }
                if (even == k) quantity += 1;
            }
        }
        Console.WriteLine($"Количество пар строк, состоящих из одинаковых элементов: {quantity}");
    }
}