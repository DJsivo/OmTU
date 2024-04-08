using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Prog
{
    static void Main()
    {
        Queue<string> baze = new Queue<string>();//Создала очередь
        Dictionary<string, int> phoneMinD = new Dictionary<string, int>();//[ телефон  -  кол - во минут ]
        Dictionary<string, int> datePhoneD = new Dictionary<string, int>();//[ дата  - кол-во разговоров подсчитаю ] 
        Hashtable phoneMinH = new Hashtable();
        Hashtable datePhoneH = new Hashtable();

        Console.WriteLine("Сколько было разговоров?"); int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите информацию о звонке №{i} в формате: [НомерТелефона Дата ВремяНачалаЗвонка Минуты]");
            baze.Enqueue(Console.ReadLine());
        }//Добавление в очередь
        while (baze.Count >= 1)//Всё по словарю
        {
            string[] bazeCopy = baze.Dequeue().Split(' ');
            string number = bazeCopy[0];//номера
            string date = bazeCopy[1];//Даты звонков
            int minutes = int.Parse(bazeCopy[3]);//Продолжительность разговора
            if (phoneMinD.ContainsKey(number))//Накапливание минут по номеру
                phoneMinD[number] += minutes;
            else
                phoneMinD.Add(number, minutes);//Добавление в словарь с ключ-номерами

            if (phoneMinH.ContainsKey(number))
                phoneMinH[number] = (int)phoneMinH[number] + minutes;
            else
                phoneMinH.Add(number, minutes);

            if (datePhoneD.ContainsKey(date))//Накапливание минут по дате
                datePhoneD[date] += minutes;
            else
                datePhoneD.Add(date, minutes);//Добавление в словарь с ключ-датами

            if (datePhoneH.ContainsKey(date))
                datePhoneH[date] = (int)datePhoneH[date] + minutes;
            else
                datePhoneH.Add(date, minutes);
        }

        Console.WriteLine("\nDictionary. Время разговоров по номеру:");
        foreach (var fN in phoneMinD)
        {
            Console.WriteLine($"Номер телефона: {fN.Key} \t Общее количество минут разговора по этому номеру: {fN.Value}");
        }
        Console.WriteLine("\nDictionary. Время разговоров по дню:");
        foreach (var dF in datePhoneD)
        {
            Console.WriteLine($"Дата: {dF.Key} \t Общее время разговоров в этот день: {dF.Value}");
        }
        Console.WriteLine("\nHashtable. Время разговоров по номеру:");
        foreach (DictionaryEntry fNh in phoneMinH)
        {
            Console.WriteLine($"Номер телефона: {fNh.Key} \t Общее количество минут разговора по этому номеру: {fNh.Value}");
        }
        Console.WriteLine("\nHashtable. Время разговоров по дню:");
        foreach (DictionaryEntry dFh in datePhoneH)
        {
            Console.WriteLine($"Дата: {dFh.Key} \t Общее время разговоров в этот день: {dFh.Value}");
        }
    }
}