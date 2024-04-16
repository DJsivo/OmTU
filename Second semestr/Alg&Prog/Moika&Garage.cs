using System;
using System.Collections.Generic;
class Car
    {
     public string Name { get; set; }
     public int YearOfBirth { get; set; }
     public Car(string name, int yearOfBirth)
     {
         Name = name;
         YearOfBirth = yearOfBirth;
     }
}
class Garage
{
    private List<Car> cars = new List<Car>();
    public void AddCar(Car car){cars.Add(car);}
    public void WashAllCars(Func<Car, bool> washedch)
    {
        foreach (Car car in cars)
        {
            if (washedch(car))
            {
                Console.WriteLine($"Помыта машина {car.Name} {car.YearOfBirth}-ого года выпуска.");
            }
            else
            {
                Console.WriteLine($"Не получилось помыть {car.Name} {car.YearOfBirth}-ого года выпуска.");
            }    
        }
    }
}
class WashBuilding
{
    public bool WashCar(Car car)
    {
        if (string.IsNullOrWhiteSpace(car.Name))
        {
            return false;
        }
        Console.WriteLine($"Автомобиль {car.Name} помыт");
        return true;
    }
}
class Program
{
    static void Main()
    {
        Garage garage = new Garage();
        garage.AddCar(new Car("Toyota", 1986));
        garage.AddCar(new Car("BMW", 2005));
        garage.AddCar(new Car("Audi", 1991));
        Func<Car, bool> washFunc = delegate (Car car) {return true;};
        garage.WashAllCars(washFunc);
    }
}
