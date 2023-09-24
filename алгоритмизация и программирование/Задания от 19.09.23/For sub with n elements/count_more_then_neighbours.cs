using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, a, b, c, k = 0;
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        if ((b > a) & (b > c)) k++;
            for (int i = 1; i < n - 2; i++)
        {
                a = b;
                b = c;
                c = Convert.ToInt32(Console.ReadLine());

                if ((b > a) & (b > c))
            {
                k++;
            }
            
        }
        Console.WriteLine(k);
    }
}