using System;
using System.Collections;
class Prog
{
    static void Main()
    {
        HashSet<string> uniqueNumbers = new HashSet<string>();
        Console.WriteLine("Сколько было номеров?"); int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите информацию в формате: [номерТелефона продолжительностьЗвонка]");
            string[] allCalls = Console.ReadLine().Split(' ');
            uniqueNumbers.Add(allCalls[0]);
        }
        Console.WriteLine("уникальные номера:");
        foreach (string uN in uniqueNumbers)
            Console.WriteLine(uN);
    }
}