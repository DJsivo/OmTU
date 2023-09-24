using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, a, b, max_a, k = 0;
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            max_a = a;
            b = Convert.ToInt32(Console.ReadLine());
            if (b < max_a)
            {
                k++;
            }
            else
            {
                max_a = b;
            }
        }
        Console.WriteLine(k);
    }
}