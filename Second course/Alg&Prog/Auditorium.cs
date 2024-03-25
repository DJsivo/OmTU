using System;
using System.Collections.Generic;
using System.Linq;

public class Menu
{
    public Auditorium auditoriums = new Auditorium();

    public void MenuWindow()
    {
        int check = 0;
        do
        {
            Console.WriteLine(@" 
_______________________________________MENU_________________________________________ 
Введите 1 для создания базы данных 
Введите 2 для добавления в базу данных 
Введите 3 для изменения данных аудитории по заданному номеру 
Введите 4 для выборки аудиторий с количеством мест >=, чем заданное число 
Введите 5 для выборки аудиторий с проектором 
Введите 6 для выборки аудиторий с компьютерами и количеством мест >=, чем заданное число  
Введите 7 для выборки аудиторий по номеру этажа 
Введите 8 для вывода всех данных по аудитории 
Введите 9 для выхода из меню  
        ");
            while (!int.TryParse(Console.ReadLine(), out check)/* Пытается преобразовать в инт, если всё норм, то возвращает нам наш чек*/ 
            || check < 1 || check > 9)
            {
                Console.WriteLine("Некорректный ввод.");
            }
            switch (check)
            {
                case 1:
                    auditoriums.CreateBase();
                    break;
                case 2:
                    auditoriums.AddAudi();
                    break;
                case 3:
                    auditoriums.ChangeAudi();
                    break;
                case 4:
                    auditoriums.BySeats();
                    break;
                case 5:
                    auditoriums.ByProjector();
                    break;
                case 6:
                    auditoriums.ByComputersAndSeats();
                    break;
                case 7:
                    auditoriums.ByFloor();
                    break;
                case 8:
                    auditoriums.AllInfo();
                    break;
                case 9:
                    Console.WriteLine("Выход из программы.");
                    break;
            }
        } while (check != 9);
    }
}
public class Auditorium
{
    public int Number { get; set; }
    public int Seats { get; set; }
    public bool Projector { get; set; }
    public bool Computers { get; set; }

    public List<Auditorium> auditoriums = new List<Auditorium>();

    public void CreateBase()
    {
        Auditorium auditoriums = new Auditorium();
        Console.WriteLine("База создана и готова к работе.");
    }//"Создание" базы. Работает нормально.

    public void AddAudi()
    {
        Auditorium newAudi = new Auditorium();
        Console.WriteLine("Введите номер аудитории:"); int a = int.Parse(Console.ReadLine());if (a <= 999) newAudi.Number = a;else Console.WriteLine("Неверный формат ввода.");
        Console.WriteLine("Введите количество посадочных мест:"); newAudi.Seats = int.Parse(Console.ReadLine());
        Console.WriteLine("Есть ли проектор (true/false):"); newAudi.Projector = bool.Parse(Console.ReadLine());
        Console.WriteLine("Есть ли компьютеры (true/false):"); newAudi.Computers = bool.Parse(Console.ReadLine());
        auditoriums.Add(newAudi);
        Console.WriteLine("Аудитория добавлена.");
    }//Добавление в базу. Работает нормально.

    public void ChangeAudi()
    {
        Console.WriteLine("Введите номер аудитории для изменения:");
        int number = Convert.ToInt32((Console.ReadLine()));
        foreach (var auditorium in auditoriums) 
        { 
            if(auditorium.Number == number)//Проверяем на удовлетворительность
            {
                    Console.WriteLine("Введите новое количество посадочных мест:");auditorium.Seats = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("Наличие проектора (true/false):");auditorium.Projector = Convert.ToBoolean((Console.ReadLine()));
                    Console.WriteLine("Наличие компьютеров (true/false):");auditorium.Computers = Convert.ToBoolean((Console.ReadLine()));
            }
        }
    }//Изменение. Работает.

    public void BySeats()
    {
        Console.WriteLine("Введите минимальное количество посадочных мест:");
        int minSeats = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("");
        foreach (var auditorium in auditoriums)
        {
            if (auditorium.Seats >= minSeats) 
                Console.WriteLine(@$"
Аудитория {auditorium.Number}:
{auditorium.Seats} мест
Проектор: {auditorium.Projector}
Компьютеры: {auditorium.Computers}");
        }
    }//С местами >= заданного числа. Работает.

    public void ByProjector()
    {
        foreach (var auditorium in auditoriums)
        {
            if (auditorium.Projector==true) Console.WriteLine(@$"
Аудитория {auditorium.Number}:
{auditorium.Seats} мест 
Проектор: {auditorium.Projector}
Компьютеры: {auditorium.Computers}");
        }
    }//По проекторам. Работает.

    public void ByComputersAndSeats()
    {
        Console.WriteLine("Введите минимальное количество посадочных мест:");
        int minSeats = Convert.ToInt32((Console.ReadLine()));
        foreach (var auditorium in auditoriums)
        {
            if ((auditorium.Seats >= minSeats)&&(auditorium.Computers == true)) Console.WriteLine(@$"
Аудитория {auditorium.Number}:
{auditorium.Seats} мест
Проектор: {auditorium.Projector}
Компьютеры: {auditorium.Computers}");
        }
    }//По местам и наличию компьютеров. Работает. 

    public void ByFloor()
    {
        Console.WriteLine("Введите номер этажа:");
        int floorNumber = Convert.ToInt32((Console.ReadLine()));
        foreach (var auditorium in auditoriums)
        {
            if ((auditorium.Number / 100) == floorNumber) 
                Console.WriteLine(""); Console.WriteLine(@$"
Аудитория {auditorium.Number}:
{auditorium.Seats} мест 
Проектор: {auditorium.Projector}
Компьютеры: {auditorium.Computers}");
        }
    }//по этажу. Работает.

    public void AllInfo()
    {
        foreach (var auditorium in auditoriums)
        {
            Console.WriteLine("");
            Console.WriteLine(@$"
Аудитория {auditorium.Number}:
{auditorium.Seats} мест 
Проектор: {auditorium.Projector}
Компьютеры: {auditorium.Computers}");
        }
    }//Вся инфа. Робит.
}
public class Hz
{
    public static void Main()
    {
        Menu menu = new Menu();
        menu.MenuWindow();
    }
}