using System;
class Posledovatelnost_iz_n
{
    static void Main()
    {
        int n, min_sub, cur_sub = 1, number, prv_number;
        n = Convert.ToInt32(Console.ReadLine());
        min_sub = n;
        prv_number = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == prv_number)
            {
                cur_sub++;

            }
            else
            {
                if(min_sub > cur_sub)
                {
                    min_sub = cur_sub;

                }
                cur_sub = 1;
            }
            prv_number = number;
        }
        Console.WriteLine(min_sub);
    }
}