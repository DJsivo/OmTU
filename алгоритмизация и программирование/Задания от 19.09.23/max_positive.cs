using System;
class Posledovatelnost
{
    static void Main()
    {
        int a, k; 
        a = Convert.ToInt32(Console.ReadLine());
        k = 0;
        for (int i = 1; i <= 9; i++)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                if (a > k) k = a;
            }
        }
        if(k!=0) { Console.WriteLine(k);}
        else { Console.WriteLine("Такого нет");}
    }
}
