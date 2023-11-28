using System;
class Mouse
{
    static void Main()
    {
        int sum = 0, p = 0;
        int n = Convert.ToInt32(Console.ReadLine());//Кол-во мышей
        int w_mouse = Convert.ToInt32(Console.ReadLine());//Положение белой
        int k = Convert.ToInt32(Console.ReadLine());//Шаг
        int[] syr = new int[n];
        for (int i = 0; i < n; i++) syr[i] = i;
        for (int i = 0; i < n - 1; i++)
        {
            while (!((sum == k) && (syr[p] != -1)))
            {
                if (syr[p] != -1) sum = sum + 1;
                p = (p + 1) % n;
            }
            syr[p] = -1; sum = -1;
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            if (syr[i] != -1)
            {
                p = syr[i];
                break;
            }
        }
        if (w_mouse - p < 0) Console.WriteLine($"Белая мышь останется в живых, если начать с{n + (w_mouse - p)}");
        else Console.WriteLine($"Белая мышь останется в живых, если начать с{w_mouse - p}");
    }
}