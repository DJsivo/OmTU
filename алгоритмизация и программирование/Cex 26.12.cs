using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class Cex
{
    private string Name;
    private int Year;
    private int V;//В штуках
    public Cex(string Name, int Year, int V)
    {
        this.Name = Name;
        this.Year = Year;
        this.V = V;
    }
    public int SummV(string name, Cex[] cexa)
    {
        int summ = 0;
        for (int i = 0; i < 10; i++)
        {
            if (cexa[i].Name == name) summ += cexa[i].V;
        }
        return summ;
    }
    public string Intensive(string name, Cex[] cexa)
    {
        string intensiveCex ="\n";
        for (int i = 0; i < 10; i++)
        { 
            if ((cexa[i].Name == name))
            {
                intensiveCex += "В " + cexa[i].Year + " году, интенсификация равна:" +Convert.ToString(Convert.ToDouble(cexa[i].V)/365 +"\n") ;
            }
        }
        return intensiveCex;
    }
    public string Table(string name, Cex[] cexa)
    {
        Console.WriteLine(name+":");
        string table = "";
        for (int i = 0; i < 10; i++)
        {
            if ((cexa[i].Name == name))
            {
                table += "Год:  " + Convert.ToString(cexa[i].Year) +"  Объем: "+ Convert.ToString(cexa[i].V) +"\n";
            }
        }
        return table;
    }
}
class program
{
    static void Main()
    {
        Cex[] cexa = new Cex[10];
        cexa[0] = new Cex("Цех 1", 2005, 8000);
        cexa[1] = new Cex("Цех 2", 2007, 9999);
        cexa[2] = new Cex("Цех 3", 2009, 8777);
        cexa[3] = new Cex("Цех 2", 2006, 3542);
        cexa[4] = new Cex("Цех 1", 2007, 6931);
        cexa[5] = new Cex("Цех 2", 2005, 7391);
        cexa[6] = new Cex("Цех 1", 2010, 1231);
        cexa[7] = new Cex("Цех 3", 2016, 3671);
        cexa[8] = new Cex("Цех 1", 2009, 7246);
        cexa[9] = new Cex("Цех 3", 2007, 4212);
        Console.WriteLine("" + cexa[0].Table("Цех 1", cexa));
        Console.WriteLine("" + cexa[0].Table("Цех 2", cexa));
        Console.WriteLine("" + cexa[0].Table("Цех 3", cexa));
        Console.WriteLine("Общий объем выпуска продукции для цеха 1: " + cexa[0].SummV("Цех 1", cexa));
        Console.WriteLine("Общий объем выпуска продукции для цеха 2: " + cexa[1].SummV("Цех 2", cexa));
        Console.WriteLine("Общий объем выпуска продукции для цеха 3: " + cexa[2].SummV("Цех 3", cexa));
        Console.WriteLine("");
        Console.WriteLine("Интенсификация по годам для цеха 1: " + cexa[0].Intensive("Цех 1", cexa));
        Console.WriteLine("Интенсификация по годам для цеха 2: " + cexa[0].Intensive("Цех 2", cexa));
        Console.WriteLine("Интенсификация по годам для цеха 3: " + cexa[0].Intensive("Цех 3", cexa));
        
    }
}