using System;
using System.IO;
class Hz
{
    static void Main()
    {
        string shortestSubA = "";
        int minSubLeng = int.MaxValue;
        using (StreamReader file = new StreamReader(@"MyFile.txt"))
        {
            string line = file.ReadLine();
            while (line != null)
            {
                int subLeng = 0;
                foreach (char c in line)
                {
                    if (c == 'a') subLeng++;
                }
                if ((subLeng > 0) && (subLeng < minSubLeng))
                {
                    minSubLeng = subLeng;
                    shortestSubA = line;
                }
            }
        }
        Console.WriteLine(@$"Строка с наименьшей длиной подпоследовательности 'а': 
{shortestSubA}
Длина подпоследовательности:
{minSubLeng}");
    }
}