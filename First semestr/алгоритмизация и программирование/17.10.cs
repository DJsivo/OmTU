using System;
class seventeenthOfOctober
{
    static void Main()
    {
        Console.WriteLine("Кол-во строк:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Кол-во столбцов:");
        int b = Convert.ToInt32(Console.ReadLine());
        int[,] mas = new int[a, b];
        Console.WriteLine("Элементы массива");
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                mas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //Определить количество строк, в которых и минимальный и максимальный элемент четные
        int countString = 0;
        for (int i = 0; i < mas.GetLength(0); i++)//по строчкам
        {
            int maxElementString = mas[i, 0];
            int minElementString = mas[i, 0];
            for (int j = 0; j < mas.GetLength(1); j++)//перебираем по кол-во элементов в строке(столбцов)
            {
                if (maxElementString < mas[i, j])
                {
                    maxElementString = mas[i, j];
                }
                if (minElementString > mas[i, j])
                {
                    minElementString = mas[i, j];
                }
            }
            if ((maxElementString % 2 == 0) && (minElementString % 2 == 0))
            {
                countString ++;
            }
        }
        Console.WriteLine($"количество строк, в которых и минимальный, и максимальный элемент четные: {countString}");
        //Вывести номера столбцов,в которых все элементы положительные 
        Console.Write("Номера столбцов,в которых все элементы положительные: ");
        for (int j = 0; j < mas.GetLength(1); j++)//столбцы
        {
            int c = 0;
            for (int i = 0; i < mas.GetLength(0); i++)//строки
            {
                if (mas[i, j] >= 0)
                {
                    c ++;
                }
            }
            if (c == a)
            {
                Console.WriteLine(j);
            }
        }
        
        //Количество нулевых элементов в массиве 
        int nulElements = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (mas[i, j] == 0)
                {
                    nulElements ++;
                }
            }
        }
        Console.WriteLine($"Количество нулевых элементов в массиве: {nulElements}");
        //Определить, имеется ли строка с нулевой суммой
        for (int i = 0; i < a; i++)
        {
            int sum = 0;
            for (int j = 0; j < b; j++)
            {
                sum += mas[i, j];
            }
            if (sum == 0)
            {
                Console.WriteLine("Да, имеется.");
                break;
            }
            else
            {
                Console.WriteLine("Нет, не имеется.");
                break;
            }
        }
        //Определить количество пар строк из одинаковых элементов
        int count = 0;
        for (int i = 0; i < a - 1; i++)
        {
            for (int j = i + 1; j < a; j++)
            {
                int chet = 0;
                int[] str1 = new int[b];
                int[] str2 = new int[b];
                for (int m = 0; m < b; m++)
                {
                    str1[m] = mas[i, m];
                    str2[m] = mas[j, m];
                }
                Array.Sort(str1);
                Array.Sort(str2);
                for (int m = 0; m < b; m++)
                {
                    if (str1[m] == str2[m])
                    {
                        chet += 1;
                    }
                }
                if (chet == b) count += 1;
            }
        }
        Console.WriteLine($"Количество пар строк, состоящих из одинаковых элементов: {count}");
    }
}