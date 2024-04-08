using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы первого множества через пробел:");
        SortedSet<string> set1 = new SortedSet<string>(Console.ReadLine().Split(' '));
        Console.WriteLine("Введите элементы второго множества через пробел:");
        SortedSet<string> set2 = new SortedSet<string>(Console.ReadLine().Split(' '));
        Console.WriteLine("Введите элементы третьего множества через пробел:");
        SortedSet<string> set3 = new SortedSet<string>(Console.ReadLine().Split(' '));

        SortedSet<string> peresech = new SortedSet<string>(set1);
        peresech.IntersectWith(set2);
        peresech.IntersectWith(set3);
        SortedSet<string> union = new SortedSet<string>(set1);
        union.UnionWith(set2);
        union.UnionWith(set3);

        SortedSet<string> dopolnenie1 = new SortedSet<string>(union);
        dopolnenie1.ExceptWith(set1);
        SortedSet<string> dopolnenie2 = new SortedSet<string>(union);
        dopolnenie2.ExceptWith(set2);
        SortedSet<string> dopolnenie3 = new SortedSet<string>(union);
        dopolnenie3.ExceptWith(set3);

        static void WriteL(SortedSet<string> set)
        {
            foreach (string s in set) Console.Write(s + " ");
        }

        Console.Write("\nПересечение множеств: "); WriteL(peresech);
        Console.Write("\nОбъединение множеств: "); WriteL(union);
        Console.Write("\nДополнение для множества 1: "); WriteL(dopolnenie1);
        Console.Write("\nДополнение для множества 2: "); WriteL(dopolnenie2);
        Console.Write("\nДополнение для множества 3: "); WriteL(dopolnenie3);
        
    }
}
