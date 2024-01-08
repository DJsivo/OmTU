using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

class Person
{
    //создаем поля
    private string Name;//ФИО
    private int YearBirth;
    private string Education;
    private string Adress;
    //описываем объект
    public Person(string Name, int YearBirth, string Education, string Adress)
    {
        this.Name = Name;
        this.YearBirth = YearBirth;
        this.Education = Education;
        this.Adress = Adress;
    }
    //Get-ы
    public String GetInfo(Person man)
    {
        return man.Name +"    "+ Convert.ToString(man.YearBirth)+"     "+ man.Education +"    "+ man.Adress;
    }
    //Методы для сортировки
    public Person? SortedName(Person man, String sortname)
    {
        if (man.Name.Equals(sortname))
        {
            return man;
        }
        else
        {
            return null;
        }
    }
    public Person? SortedYear(Person man,int sortyear)
    {
        if (man.YearBirth == sortyear)
        {
            return man;
        }
        else
        {
            return null;
        }
    }
    public Person? SortedEducation(Person man,String sortedu)
    {
        if (man.Education.Equals(sortedu))
        {
            return man;
        }
        else
        {
            return null;
        }
    }
}
class Sortirovka
{
    static void Main()
    {
        //Получение инфы о параметрах сортировки
        Console.WriteLine("Напишите имя для сортировки:");string sortname = Console.ReadLine();
        Console.WriteLine("Напишите год рождения для сортировки:");int sortyear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Напишите образование для сортировки:");string sortedu = Console.ReadLine();
        //Массив с людьми
        Person[] mans = new Person[10];
        mans[0] = new Person("Kostya", 2018, "Empty", "Tatarsk");
        mans[1] = new Person("Nastya", 2005, "Secondary", "Gorsk");
        mans[2] = new Person("Kostya", 2005, "Secondary", "Omsk");
        mans[3] = new Person("Ura", 1986, "Higher", "Krondshtat");
        mans[4] = new Person("Tolya", 1957, "Higher", "Neapol");
        mans[5] = new Person("Masha", 2007, "Primary", "Paris");
        mans[6] = new Person("Kolya", 2006, "Secondary", "Kursk");
        mans[7] = new Person("Angelina", 2002, "Higher", "Vologda");
        mans[8] = new Person("Maksim", 1984, "Higher", "Murmansk");
        mans[9] = new Person("Angelina", 2005, "Secondary", "Tashkent");  
        Console.WriteLine("\nИнформация о людях с таким именем:");
        for (int i = 0; i < mans.Length; i++)
        {
            Person man = mans[i];
            if (man.SortedName(man, sortname) != null) Console.WriteLine(man.GetInfo(man));
        }
        Console.WriteLine("\nИнформация о людях данного года рождения:");
        for (int i = 0; i < mans.Length; i++)
        {
            Person man = mans[i];
            if (man.SortedYear(man, sortyear) != null) Console.WriteLine(man.GetInfo(man));
        }
        Console.WriteLine("\nИнформации о людях с таким уровнем образования:");
        for (int i = 0; i < mans.Length; i++)
        {
            Person man = mans[i];
            if (man.SortedEducation(man, sortedu) != null) Console.WriteLine(man.GetInfo(man));
        }
    }
}
