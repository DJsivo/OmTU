using System.Threading.Channels;

class Bank
{
    public int Num { get; set; }//Номер счёта
    public string Name { get; set; }//ФИО
    public double Income { get; set; }//Доходы
    public double Expenses { get; set; }//Исходы
    public double Nalog => Income * 0.05;//Налог
    public double Balance => Income - (Expenses + Nalog);//Баланс

}
class Hz
{
    static void Main(string[] args)
    {
        List<Bank> clients = new List<Bank>()
        {
            new Bank { Num = 1, Name = "Богатов Богдан Вячеславович", Income = 35000, Expenses = 10000 },
            new Bank { Num = 2, Name = "Алекберова Мария Васильевна", Income = 21000, Expenses = 4500 },
            new Bank { Num = 3, Name = "Симоненко Валентин Антонович", Income = 6000, Expenses = 7000 },
            new Bank { Num = 4, Name = "Василенко Николай Артурович", Income = 3000, Expenses = 2000 },
            new Bank { Num = 5, Name = "Матроскина Александра Александровна", Income = 7000, Expenses = 8000 },
            new Bank { Num = 6, Name = "Жиряненко Светлана Борисовна", Income = 8000, Expenses = 7000 }
        };
        
        int negativeBalance = clients.Count(c => c.Balance < 0);//просто считаем
        Console.WriteLine(@$"Количество клиентов с отрицательным балансом:
{negativeBalance}
");

        Bank richestClient = clients.OrderByDescending(c => c.Balance)//сортируем по убыванию по полю баланса
            .First();// и берем верхнее
        Console.WriteLine(@$"Клиент с самым большим балансом:
{richestClient.Name}

Его баланс:
{richestClient.Balance}
");

        double AverageBalanceDolzhnikov = clients.Where(c => c.Balance < 0)//Берем всех с отрицательным балансом
            .Average(c => c.Income);//Считаем среднее по полю дохода
        Console.WriteLine(@$"Средний доход по счетам с отрицательным балансом:
{AverageBalanceDolzhnikov}
");

        double totalNalog = clients.Sum(c => c.Nalog);//суммируем по полю налогов
        Console.WriteLine(@$"Суммарная сумма налогов со всех клиентов: 
{totalNalog}
");
    }
}