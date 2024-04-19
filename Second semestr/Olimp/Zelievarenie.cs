class Hz
{
    static void Main(string[] args)
    {
        List<string> actions = new List<string>();
        Console.WriteLine("Кол-во строк:"); int n = int.Parse(Console.ReadLine()); Console.WriteLine("Введите их все.");
        for (int i = 0; i < n; i++) { actions.Add(Console.ReadLine()); }
        string spell = "";
        List<string> Spp = new List<string>();
        foreach (string i in actions)
        {
            spell = "";
            if (i.Split()[0] == "DUST")
            {
                string[] sub = i.Split();
                sub = sub.Skip(1).ToArray();
                foreach (string j in sub)
                {
                    if (int.TryParse(j, out int number))
                    {
                        spell += Spp[Convert.ToInt32(j) - 1];
                    }
                    else
                    {
                        spell += j;
                    }
                }
                Spp.Add($"DT{spell}TD");
            }
            else if (i.Split()[0] == "MIX")
            {
                string[] substr = i.Split();
                substr = substr.Skip(1).ToArray();
                foreach (string j in substr)
                {
                    if (int.TryParse(j, out int number)) spell += Spp[Convert.ToInt32(j) - 1];
                    else spell += j;
                }
                Spp.Add($"MX{spell}XM");
            }
            else if (i.Split()[0] == "WATER")
            {
                string[] substr = i.Split();
                substr = substr.Skip(1).ToArray();
                foreach (string j in substr)
                {
                    if (int.TryParse(j, out int number)) spell += Spp[Convert.ToInt32(j) - 1];
                    else spell += j;
                }
                Spp.Add($"WT{spell}TW");
            }
            else if (i.Split()[0] == "FIRE")
            {
                string[] sub = i.Split();
                sub = sub.Skip(1).ToArray();
                foreach (string j in sub)
                {
                    if (int.TryParse(j, out int number)) spell += Spp[Convert.ToInt32(j) - 1];
                    else spell += j;
                }
                Spp.Add($"FR{spell}RF");
            }
        }
        Console.WriteLine(Spp[Spp.Count - 1]);
    }
}