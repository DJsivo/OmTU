using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;
public struct City
{
    public string Name;
    public string Country;
    public int Population;
}
public class Action
{
    private List<City> cities;
    public Action()
    {
        cities = new List<City>();
    }
    public void ReadBase(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (var line in lines)
        {
            string[] _base = line.Split(' ');
            City city = new City
            {
                Name = _base[0],
                Country = _base[1],
                Population = int.Parse(_base[2])
            };
            cities.Add(city);
        }
    }
    public void SortedByName(char let)
    {
        List<City> sorted = new List<City>();
        foreach (var city in cities)
        {
            if (city.Name[0] == let)
            {
                sorted.Add(city);
                Console.WriteLine(city.Name);
            }
        }
        using (FileStream fs = File.Create(@"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByName.txt"))
        SaveToFile(sorted, @"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByName.txt");
    }
    public void SortedByContries(string country)
    {
        List<City> sorted = new List<City>();
        foreach (var city in cities)
        {
            if (city.Country == country) sorted.Add(city);
        }
        using(FileStream fs = File.Create(@"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByContries.txt"))
        SaveToFile(sorted, @"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByContries.txt");
    }
    public void SortedByPopulation(int minPopulation)
    {
        List<City> sorted = new List<City>();
        foreach (var city in cities)
        {
            if (city.Population > minPopulation) sorted.Add(city);
        }
        FileStream fs = File.Create(@"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByPopulation.txt");
        SaveToFile(sorted, @"C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\ByPopulation.txt");
    }
    private void SaveToFile(List<City> sorted,string adress)
    {
        List<string> sortedl = new List<string>();
        foreach (var city in sorted)
        {
            sortedl.Add(city.Name + city.Country + Convert.ToString(city.Population));
        }
        File.AppendAllLines(adress, sortedl);   
    }
}
class Program
{
    static void Main()
    {
        try {
            Action act = new Action();
            act.ReadBase("C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\Коды\\Files\\BaseCities.txt");
            Console.WriteLine(@"Что сделать с базой?
1. Сформировать файл с городами начинающимися на заданную букву.
2. Сформировать файл с городами расположенными в заданной стране.
3. Сформировать файл с городами, население которых больше заданного числа.
4. Всё.");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Введите букву, города начинающиеся с которой нужно найти.");
                    act.SortedByName(Convert.ToChar(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Введите страну.");
                    act.SortedByContries(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Введите минимальную планку населения.");
                    act.SortedByPopulation(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("Введите букву, города начинающиеся с которой нужно найти.");
                    act.SortedByName(Convert.ToChar(Console.ReadLine())); Console.WriteLine();
                    Console.WriteLine("Введите страну.");
                    act.SortedByContries(Console.ReadLine()); Console.WriteLine();
                    Console.WriteLine("Введите минимальную планку населения.");
                    act.SortedByPopulation(Convert.ToInt32(Console.ReadLine()));
                    break;
                default: Console.WriteLine("Я так не умею."); break;
            }
        }
        catch{}   
    }
}