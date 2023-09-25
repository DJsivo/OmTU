using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, a, b, min_a, k = 0;
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        min_a = a;
        for (int i = 1; i < n; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b < min_a)
            {
                k++;
                min_a = b;
            }
        }
        Console.WriteLine(k);
        
    }
}
