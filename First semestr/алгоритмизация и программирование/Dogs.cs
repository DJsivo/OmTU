//14.12.2023
using System;
using System.Runtime.InteropServices;

class C
{
    static void Main()
    {
        string sortporoda = "Beagle" , sortokras = "white", newokras="black",newokras1="brown";
        Dog[] dogs = new Dog[10];
        dogs[0] = new Dog("Lucky", "Beagle", "black", "2010","");
        dogs[1] = new Dog("Ryu", "Pug", "brown", "2018", "");
        dogs[2] = new Dog("Chester", "Chihuahua", "black", "2011", "");
        dogs[3] = new Dog("Lucky", "Beagle", "white", "2015", "");
        dogs[4] = new Dog("Chip", "Chihuahua", "white", "2015", "");
        dogs[5] = new Dog("Chester", "Pug", "brown", "2015", "");
        dogs[5] = new Dog("Chip", "Pug", "brown", "2015", "");
        dogs[6] = new Dog("Ryu", "Beagle", "white", "2013", "");
        dogs[7] = new Dog("Spike", "Chihuahua", "gray", "2011", "");
        dogs[8] = new Dog("Pete", "Pug", "brown", "2018", "");
        dogs[9] = new Dog("Spike", "Beagle", "black", "2013", "");
        Console.WriteLine("Сортировка по породе: " + sortporoda +", " + "Сортировка по окрасу: " + sortokras);
        for (int i = 0; i < dogs.Length; i++)
        {
            Dog dog = dogs[i];
            if (dog.sortByporoda(dog, sortporoda) != null)
            {
             
                if (dog.sortByokras(dog, sortokras) != null)
                {
                    Console.WriteLine(dog.getInfo(dog.sortByokras(dog, sortokras)));
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Замена цвета собак с " + newokras1 + " На " + newokras);
        for(int i = 0;i < dogs.Length;i++)
        {
            Dog dog = dogs[i];
            if (dog.getokras(dog).Equals(newokras1))
            {
                Console.WriteLine();
                Console.WriteLine("Заменa цвета для собаки: " + dog.getInfo(dog));
                dogs[i].setokras(newokras);
                Console.WriteLine("После похода собаки в салон: " + dog.getInfo(dog));
            }
        }
    }
}
class Dog
{
    private string name;
    private string poroda;
    private string okras;
    private string dr;
    private string gender;
    public Dog(string name, string poroda, string okras, string dr, string gender)
    {
        this.name = name;
        this.poroda = poroda;
        this.okras = okras;
        this.dr = dr;
        this.gender = gender;
    }
    public Dog sortByporoda(Dog dog, string poroda)
    {
        if (dog.poroda.Equals(poroda)) return dog;
        else return null;
    }
    public Dog sortByokras(Dog dog, string okras)
    {
        if (dog.okras.Equals(okras)) return dog;
        else return null;
    }
    public String getInfo(Dog dog)
    {
        if (dog != null)
        {
            return "Кличка: " + dog.name + "; Порода: " + dog.poroda + "; Окрас: " + dog.okras + "; ДР: " + dog.dr;
        }
        else return null;
    }
    public string getokras(Dog dog)
    {
        return dog.okras;
    }
    public void setokras(string okras)
    {
        this.okras = okras;
    }
}
