using System;
class HZ {
    static void Main()
    {
        string line = "";
        line = Console.ReadLine();
        string[] s = line.Split(' ');
        int n = Convert.ToInt32(s[0]);
        int m = Convert.ToInt32(s[1]);
        line = Console.ReadLine();
        string[] Start = line.Split(' ');
        int xSt = Convert.ToInt32(Start[0]);
        int ySt = Convert.ToInt32(Start[1]);
        int zSt = Convert.ToInt32(Start[2]);
        int prom = 0;
        for (int i = 0; i < m; i++)
        {
            line = Console.ReadLine();
            string[] step = line.Split(' ');
            string osb = step[0];
            int sloy = Convert.ToInt32(step[1]);
            int orientation = Convert.ToInt32(step[2]);

            if (osb == "X")
            {
                if (xSt == sloy)
                {
                    if (orientation == 1)
                    {
                        prom = zSt;
                        zSt = n + 1 - ySt;
                        ySt = prom;
                    }
                    else
                    {
                        prom = ySt;
                        ySt = n + 1 - zSt;
                        zSt = prom;
                    }

                }
            }
            if (osb == "Y")
            {
                if (ySt == sloy)
                {
                    if (orientation == 1)
                    {
                        prom = zSt;
                        zSt = n + 1 - xSt;
                        xSt = prom;
                    }
                    else
                    {
                        prom = xSt;
                        xSt = n + 1 - zSt;
                        zSt = prom;
                    }
                }
            }
            if (osb == "Z")
            {
                if (zSt == sloy)
                {
                    if (orientation > 0)
                    {
                        prom = ySt;
                        ySt = n + 1 - xSt;
                        xSt = prom;
                    }
                    else
                    {
                        prom = xSt;
                        xSt = n + 1 - ySt;
                        ySt = prom;
                    }
                }
            }
        }
        Console.WriteLine(@$"Конечное положение:
({xSt},{ySt},{zSt})");
    }
}
