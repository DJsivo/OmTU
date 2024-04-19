using System;
class Hz
{
    static void Main(string[] args)
    {
        List<string> personals = new List<string>();
        string person = "";
        List<string> st = new List<string>();
        List<string> fi = new List<string>();

        Console.WriteLine("Сколько строк в входном файле?"); int n = int.Parse(Console.ReadLine()); Console.WriteLine("Введите их все:");
        for (int i = 0; i < n - 1; i++)
        {
            string s = Console.ReadLine();
            if (s != "END") personals.Add(s);
            else person = Console.ReadLine();
        }
        Console.WriteLine("\nВсе подчинённые:");
        if (person.Length >= 4)
        {
            foreach (string i in personals)
            {
                if (i.Split().Length >= 2 && i.Remove(0, 5) == person) person = i.Split()[0];
            }
        }
        for (int i = 0; i < personals.Count; i = i + 2)
        {
            if (personals[i].Split()[0] == person.Split()[0])
            {
                st.Add((personals[i + 1]));
                fi.Add((personals[i + 1]));
                var a = Find(st);
            }
        }
        for (int i = 0; i < fi.Count; i++)
        {
            foreach (string j in personals)
            {
                if (j.Split().Length >= 2 && j.Split()[0] == fi[i].Split()[0]) fi[i] = j;
            }
        }


        foreach (string i in fi)
        {
            if (i.Split().Length >= 2) Console.WriteLine(i);
            else Console.WriteLine($"{i} Unknown Name");
        }
        List<string> Find(List<string> star)
        {
            List<string> l = new List<string>();
            for (int k = 0; k < star.Count; k++)
            {
                for (int i = 0; i < personals.Count; i = i + 2)
                {
                    if (personals[i].Split()[0] == star[k].Split()[0])
                    {
                        l.Add(personals[i + 1]);
                        fi.Add((personals[i + 1]));
                    }
                }
            }
            if (star.Count != 1 && l.Count != 0) return Find(l);
            else return l;
        }

    }
}