using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, a, b, longgest_podposled = 1, current_longgest_podposled = 1;//m, k
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b > a)
            {
                current_longgest_podposled++;
                
            }
            else if (current_longgest_podposled> longgest_podposled) 
                {
                    longgest_podposled = current_longgest_podposled;
                    current_longgest_podposled = 1;
                }
             a = b;          
        }
        Console.WriteLine(longgest_podposled);
    }
}
