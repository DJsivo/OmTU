using System;
class Posledovatelnost_iz_n{
static void Main()
    {
        int n, max_sub, cur_sub = 1, num, prv_num; 
        n = Convert.ToInt32(Console.ReadLine());
        max_sub = 1;
        prv_num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n - 1; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num != prv_num)
            {
                cur_sub++;

            }
            else
            {
                if ((max_sub < cur_sub) & (cur_sub > 1))
                {
                    max_sub = cur_sub;

                }
                cur_sub = 1;
            }
            prv_num = num;
        }
        Console.WriteLine(max_sub);
    }
}
