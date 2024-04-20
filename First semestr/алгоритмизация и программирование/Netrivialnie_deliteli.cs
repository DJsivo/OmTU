//26.12.2023
using System;
class Netr_delit
{
    static void Main()
    {
        for (double num = Math.Round(Math.Sqrt(106732567)); num<=Math.Round(Math.Sqrt(152673836)); num++)
        {
            double d = 0;
            int c= 0;
            for (int j = 2; j < num; j++)
            {
                if ((num * num % j) == 0)
                {
                    d = (num*num) / j;
                    c++;
                }
                if (c > 1) continue;
            }
            if (c == 1)
            {
                Console.WriteLine($"Число: {num*num}. Наибольший делитель: {d}");
            }
        }
    }
}
