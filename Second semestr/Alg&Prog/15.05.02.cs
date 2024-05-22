using System;
using System.Collections.Generic;
using System.Linq;
class Rab
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Kolvo { get; set; }
    public double Price { get; set; }
    public double ZP { get; set; }
    public string Specialization { get; set; }
}
class Product
{
    public string Category { get; set; }
    public int Kolvo { get; set; }
    public double TotalPrice => Kolvo * Price;
    public double Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Rab> rabs = new List<Rab>();
        Console.WriteLine("Введите информацию о работниках. Если работники закончились, введите пустую строку:");
        while (true)
        {
            Console.Write("Имя работника: ");string n = Console.ReadLine();
            if (n.ToLower() == "")
                break;
            Console.Write("Категория работы: ");string category = Console.ReadLine();
            Console.Write("Количество произведенной продукции: ");int kolvo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена за единицу продукции: ");double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Зарплата работника: ");double zp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Специализация: ");string specialization = Console.ReadLine();

            rabs.Add(new Rab
            {
                Id = rabs.Count + 1,
                Name = n,
                Category = category,
                Kolvo = kolvo,
                Price = price,
                ZP = zp,
                Specialization = specialization
            });
        }
        //Определить количество работников, которые получают зарплату меньше, чем вырабатывают продукцию
        var s1 = rabs.Where(emp => emp.ZP < emp.Kolvo * emp.Price).Count();
        Console.WriteLine($"Количество работников с низкой зарплатой: {s1}");
        //Количество единиц произведенной продукции по каждой категории
        var s2 = rabs.GroupBy(emp => emp.Category)
                        .Select(group => new Product
                        {
                            Category = group.Key,
                            Kolvo = group.Sum(emp => emp.Kolvo),
                            Price = group.First().Price
                        });
        foreach (var product in s2)
        {
            Console.WriteLine($"Категория: {product.Category}, Произведено: {product.Kolvo}");
        }
        //Суммарный денежный эквивалент произведенной продукции по всем товарам
        double s3 = rabs.Sum(emp => emp.Kolvo * emp.Price);
        Console.WriteLine($"Суммарный денежный эквивалент произведенной продукции: {s3}");
        //Количество работников, которые получают больше 50% от суммы производимого продукта
        var s4 = rabs.Where(emp => emp.ZP > emp.Kolvo * emp.Price * 0.5).Count();
        Console.WriteLine($"Количество работников, получающих более 50% от стоимости производимой продукции: {s4}");
    }
}
