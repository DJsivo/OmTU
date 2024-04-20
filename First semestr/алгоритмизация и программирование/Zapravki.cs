using System;
using System.Collections;
    class Hz
    {
        static void Main()
        {
            int K = Convert.ToInt32(Console.ReadLine()),
             N = Convert.ToInt32(Console.ReadLine()),
             minR = int.MaxValue,
             minI = 0,
             r = K;
            int[] City = new int[K];
            bool can = false;
            for (int i = 0; i < K; i++)
                City[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < K; i++)
                r += City[i];

            for (int i = 0; i < City[^1]; i++)
            {
                bool C = true;


                foreach (int city in City)
                {
                    if (city >= i)
                        r--;
                    else
                        r++;
                    if (Math.Abs(city - i) < N)
                        C = false;
                }
                if (C)
                {
                    can = true;
                    if (r < minR)
                    {
                        minR = r;
                        minI = i;
                    }
                }
            }
            if (can)
                Console.WriteLine
                    ($"Ответ: на километре {minI} минимальное расстояние будет {minR}");
            else
                Console.WriteLine
                    ("Нет мест для заправок");
            Console.ReadKey();
        }
    }