class hz
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу на языке Тау-Кита:");
        string tau = Console.ReadLine();
        Resh(tau);
    }
    static void Resh(string tau)
    {
        string[] sms = tau.Split(' ');
        string humansms = "";
        string hwords = "";
        if (sms.Length % 2 == 0)
        {
            hwords = sms[sms.Length / 2] + " ";
            for (int i = 1; i <= sms.Length / 2 - 1; i++)
            {
                hwords += sms[sms.Length / 2 - i] + " ";
                hwords += sms[sms.Length / 2 + i] + " ";
            }
            hwords += sms[0];
        }
        else
        {
            hwords = sms[(sms.Length - 1) / 2] + " ";
            for (int i = 1; i <= (sms.Length - 1) / 2; i++)
            {
                hwords += sms[(sms.Length - 1) / 2 - i] + " ";
                hwords += sms[(sms.Length - 1) / 2 + i] + " ";
            }
        }
        hwords = hwords.Trim();
        string[] hWords = hwords.Split(' ');
        for (int k = 0; k < hWords.Length; k++)
        {
            string hword = "";
            char[] hWord = hWords[k].ToCharArray();
            if (hWord.Length % 2 == 0)
            {
                hword += hWord[hWord.Length / 2];
                for (int i = 1; i <= hWords[k].Length / 2 - 1; i++)
                {
                    hword += hWord[hWord.Length / 2 - i];
                    hword += hWord[hWord.Length / 2 + i];
                }
                hword += hWord[0];
            }
            else
            {
                hword += hWord[(hWord.Length - 1) / 2];
                for (int i = 1; i <= (hWord.Length - 1) / 2; i++)
                {
                    hword += hWord[(hWord.Length - 1) / 2 - i];
                    hword += hWord[(hWord.Length - 1) / 2 + i];
                }
            }
            humansms += hword + " ";
        }
        Console.WriteLine("Человеческая интерпретация:"); Console.WriteLine(humansms);
    }
}