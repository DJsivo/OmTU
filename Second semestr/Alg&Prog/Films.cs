using System;
using System.Collections.Generic;
using System.Linq;
class Pr
{
    static void Main()
    {
        List<Film> films = new List<Film>
        {
            new Film("Фильм 1", new DateTime(2022, 7, 1, 14, 30, 0), 50, 50),
            new Film("Фильм 2", new DateTime(2022, 1, 6, 16, 0, 0), 20, 80),
            new Film("Фильм 3", new DateTime(2022, 1, 1, 17, 30, 0), 30, 70),
            new Film("Фильм 4", new DateTime(2023, 5, 1, 15, 01, 0), 40, 70),
            new Film("Фильм 5", new DateTime(2024, 1, 4, 12, 30, 0), 35, 65)
        };

        var men50percent = films.Where(f => (f.Prodano / (f.Prodano + f.Empt)) < 0.5);
        var after3 = films.Where(f => f.StartTime.TimeOfDay > new TimeSpan(15, 0, 0));

        Console.WriteLine("Фильмы с процентом занятых мест < 50:");
        foreach (var film in men50percent)
        {
            Console.WriteLine($"{film.Name} - {film.StartTime}");
        }

        Console.WriteLine("\nФильмы с сеансами начинающимися после 15:00:");
        foreach (var film in after3)
        {
            Console.WriteLine($"{film.Name} - {film.StartTime}");
        }
    }
}

class Film
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public double Prodano { get; set; }
    public double Empt { get; set; }

    public Film(string name, DateTime startTime, double prodano, double empt)
    {
        Name = name;
        StartTime = startTime;
        Prodano = prodano;
        Empt = empt;
    }
}