using System;
class Hz
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[,] array = new string[N, 2];
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            string[] input_split = input.Split(' ');
            array[i, 0] = input_split[0];
            array[i, 1] = input_split[1];
        }
        double number = int.Parse(Console.ReadLine());
        double count_x = 0;
        for (int i = N - 1; 0 <= i; i--)
        {
            switch (array[i, 0])
            {
                case "+":
                    if (array[i, 1] != "x")
                        number -= int.Parse(array[i, 1]);
                    else
                        count_x -= 1;
                    break;
                case "-":
                    if (array[i, 1] != "x")
                        number += int.Parse(array[i, 1]);
                    else
                        count_x += 1;
                    break;
                case "*":
                    if (array[i, 1] != "x")
                    {
                        number /= int.Parse(array[i, 1]);
                        count_x /= int.Parse(array[i, 1]);
                    }
                    break;
            }
        }
        
        Console.WriteLine($" Вы загадали число: {Convert.ToInt32(number/(1 - count_x))}");
    }
}