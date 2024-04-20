using System;

class HW
{
    static void Main()
    {
        int N, a, b, max, max1, s0 = 0, s1 = 0, s2 = 0, sum0 = 0, sum1 = 0, sum2 = 0, sum01 = 0, sum02 = 0, sum03 = 0, sum11 = 0, sum12 = 0, sum13 = 0, sum21 = 0, sum22 = 0, sum23 = 0;
        Console.Write("Строк:"); N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < N; i++)
        {
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if ((sum0 + a) % 3 == 0)
                if ((sum0 + b) % 3 == 0)
                    sum01 = Math.Max(sum0 + b, sum0 + a);
                else sum01 = sum0 + a;
            else
                if ((sum0 + b) % 3 == 0)
                sum01 = sum0 + b;

            if (((sum1 + a) % 3 == 0) && (sum1 + a > sum0))
                if (((sum1 + b) % 3 == 0) && (sum1 + b > sum0)) sum02 = Math.Max(sum1 + b, sum1 + a);
                else sum02 = sum1 + a;
            else if (((sum1 + b) % 3 == 0) && (sum1 + b > sum0)) sum02 = sum1 + b;

            if (((sum2 + a) % 3 == 0) && (sum2 + a > sum0))
                if (((sum2 + b) % 3 == 0) && (sum2 + b > sum0)) sum03 = Math.Max(sum2 + b, sum2 + a);
                else sum03 = sum2 + a;
            else if (((sum2 + b) % 3 == 0) && (sum2 + b > sum0)) sum03 = sum2 + b;


            if ((sum1 + a) % 3 == 1)
                if ((sum1 + b) % 3 == 1) sum11 = Math.Max(sum1 + b, sum1 + a);
                else sum11 = sum1 + a;
            else if ((sum1 + b) % 3 == 1) sum11 = sum1 + b;

            if (((sum0 + a) % 3 == 1) && (sum0 + a > sum1))
                if (((sum0 + b) % 3 == 1) && (sum0 + b > sum1)) sum12 = Math.Max(sum0 + b, sum0 + a);
                else sum12 = sum0 + a;
            else if (((sum0 + b) % 3 == 1) && (sum0 + b > sum1)) sum12 = sum0 + b;

            if (((sum2 + a) % 3 == 1) && (sum2 + a > sum1))
                if (((sum2 + b) % 3 == 1) && (sum2 + b > sum1)) sum13 = Math.Max(sum2 + b, sum2 + a);
                else sum13 = sum2 + a;
            else if (((sum2 + b) % 3 == 0) && (sum2 + b > sum1)) sum13 = sum2 + b;


            if ((sum2 + a) % 3 == 2)
                if ((sum2 + b) % 3 == 2) sum21 = Math.Max(sum2 + b, sum2 + a);
                else sum21 = sum2 + a;
            else if ((sum2 + b) % 3 == 1) sum21 = sum2 + b;

            if (((sum0 + a) % 3 == 2) && (sum0 + a > sum2))
                if (((sum0 + b) % 3 == 2) && (sum0 + b > sum2)) sum22 = Math.Max(sum0 + b, sum0 + a);
                else sum22 = sum0 + a;
            else if (((sum0 + b) % 3 == 2) && (sum0 + b > sum2)) sum22 = sum0 + b;


            if (((sum1 + a) % 3 == 2) && (sum1 + a > sum2))
                if (((sum1 + b) % 3 == 2) && (sum1 + b > sum2)) sum23 = Math.Max(sum1 + b, sum1 + a);
                else sum23 = sum1 + a;
            else if (((sum1 + b) % 3 == 2) && (sum1 + b > sum2)) sum23 = sum1 + b;


            if (sum0 == Math.Max(sum01, Math.Max(sum03, sum02))) s0 = 0; else s0 = 1;
            if (sum1 == Math.Max(sum11, Math.Max(sum13, sum12))) s1 = 0; else s1 = 1;
            if (sum2 == Math.Max(sum21, Math.Max(sum23, sum22))) s1 = 0; else s2 = 1;
            sum0 = Math.Max(sum01, Math.Max(sum03, sum02));
            sum1 = Math.Max(sum11, Math.Max(sum13, sum12));
            sum2 = Math.Max(sum21, Math.Max(sum23, sum22));
        }

        Console.Write("A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (((sum0 + a) % 3 == 0) && (s0 == 1))
            if ((sum0 + b) % 3 == 0)
                sum01 = Math.Max(sum0 + b, sum0 + a);
            else sum01 = sum0 + a;
        else
            if (((sum0 + b) % 3 == 0) && (s0 == 1))
            sum01 = sum0 + b;
        else sum01 = 0;

        if (((sum1 + a) % 3 == 0) && (s1 == 1))
            if ((sum1 + b) % 3 == 0)
                sum02 = Math.Max(sum1 + b, sum1 + a);
            else sum02 = sum1 + a;
        else
            if (((sum1 + b) % 3 == 0) && (s1 == 1))
            sum02 = sum1 + b;
        else sum02 = 0;

        if (((sum2 + a) % 3 == 0) && (s2 == 1))
            if ((sum2 + b) % 3 == 0)
                sum03 = Math.Max(sum2 + b, sum2 + a);
            else sum03 = sum2 + a;
        else
            if (((sum2 + b) % 3 == 0) && (s2 == 1))
            sum03 = sum2 + b;
        else sum03 = 0;

        sum0 = Math.Max(sum01, Math.Max(sum02, sum03));

        Console.WriteLine("Ответ: " + sum0);
    }
}