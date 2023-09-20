using System;
class Posledovatelnost_iz_n
{
    static void Main(){
        int n, num, prev_num, diff, button = 1;
        n = Convert.ToInt32(Console.ReadLine());    
        prev_num = Convert.ToInt32(Console.ReadLine());
        num = Convert.ToInt32(Console.ReadLine());
        diff = prev_num - num;
        if (diff > 0)
        {
            for (int i = 0; i < n - 2; i++)
            {
                prev_num = num;
                num = Convert.ToInt32(Console.ReadLine());
                if((prev_num - num) != diff)
                {
                    button = 0;
                }
            }
        } else
        {
            button = 0;
        }
    
        if(button == 1) 
        {
        Console.WriteLine("Является равномено убывающей");
        } else
        {
        Console.WriteLine("Не является равномено убывающей");
        }
    }
}