using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, a, prev_a, k=0;
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            prev_a = Convert.ToInt32(Console.ReadLine());
            if (a < prev_a) k++;
            a = prev_a;
        }
        Console.WriteLine(k);
    }
}