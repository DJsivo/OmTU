class hhh
{
    static void Main(string[] args)
    {
        int mCount = 0;
        int m = int.MaxValue;
        List<string> list = new List<string>();
        try
        {
            StreamReader f1 = new StreamReader("C:\\Users\\t-pud\\Downloads\\OmSTU\\Alg&Proga\\a.txt");
            string line = f1.ReadLine();
            while (line != null)
            {
                foreach (var i in line)
                {
                    if (i == 'A')
                    {
                        mCount = mCount + 1;
                        string s = line;
                        list.Add(s);
                    }
                    if (i != 'A' && mCount != 0)
                    {
                        if (mCount < m)
                        {
                            m = mCount;
                        }
                        mCount = 0;
                    }
                }
                if (mCount < m && mCount != 0)
                    m = mCount;
                line = f1.ReadLine();
            }
            int n = 0;
            foreach (var l in list)
            {
                foreach (var c in l)
                {
                    if (c == 'A')
                    {
                        n++;
                    }
                }
                if (n == m)
                {
                    Console.WriteLine(l);
                    break;
                }
                n = 0;
            }

            f1.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
