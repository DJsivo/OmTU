using System;
class hz
{
    static void Main()
    {
        while (true)
        {
            int summa = -1, p = 0;
            bool flag = false;
            int ns = Convert.ToInt32(Console.ReadLine());//Кол-во серых мышей
            int nb = Convert.ToInt32(Console.ReadLine());//Кол-во белых мышей
            int k = Convert.ToInt32(Console.ReadLine());//Шаг
            int os = Convert.ToInt32(Console.ReadLine());//Сколько останется серых
            int ob = Convert.ToInt32(Console.ReadLine());//Сколько останется белых
            int ms = ns - os;
            int[] syr = new int[ns + nb];
            for (int i = 0; i < ns + nb; i++) syr[i] = i;
            for (int i = 0; i < (ns + nb) - (ob + os); i++)
            {
                while (!((summa == k) && (syr[p] != -1)))
                {
                    if (syr[p] != -1) summa += 1;
                    if ((summa != k) || (syr[p] == -1)) p = (p + 1) % (nb + ns);
                }
                syr[p] = -1; summa = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < ns + nb; i++)
            {
                if ((ns < os) || (nb < ob))
                {
                    flag = true; break;
                }
                if (syr[i] == -1)
                {
                    if (ms != 0)
                    {
                        ms += -1;
                        Console.WriteLine($"Расположить серую(м) мышь на {i + 1} месте");
                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположить белую(м) мышь на {i + 1} месте");
                    }
                }
                else
                {
                    if (os != 0)
                    {
                        os += -1;
                        Console.WriteLine($"Расположить серую(ж) мышь на {i + 1} месте");
                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположить белую(ж) мышь на {i + 1} месте");
                    }
                }
            }
            if (flag) Console.WriteLine("Расположить не возможно");
            Console.WriteLine();
        }
    }
}