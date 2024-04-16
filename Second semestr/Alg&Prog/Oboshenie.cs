using System;
class Calc<T>
{
    public void Sum(T x, T y)
    {
        dynamic num1 = x;
        dynamic num2 = y;
        dynamic result = num1 + num2;
        Console.WriteLine("Результат операции: " + result);
    }
    public void Razn(T x, T y)
    {
        dynamic num1 = x;
        dynamic num2 = y;
        dynamic result = num1 - num2;
        Console.WriteLine("Результат операции: " + result);
    }
    public void Proizv(T x, T y)
    {
        dynamic num1 = x;
        dynamic num2 = y;
        dynamic result = num1 * num2;
        Console.WriteLine("Результат операции: " + result);
    }
    public void Divide(T x, T y)
    {
        dynamic num1 = x;
        dynamic num2 = y;
        if (num2 == 0) Console.WriteLine("Увы, деление на ноль невозможно.");
        else Console.WriteLine("Результат операции: " + num1 / num2);
    }
}
class Hz
{
    static void Main()
    {
        Console.WriteLine(@"
Выберите тип данных c которым мне работать:
1. Integer
2. Double
");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine(@"Что мне нужно выполнить с этими числами?
1. Суммировать
2. Найти их разность
3. Найти произведение
4. Найти частное"); int t = int.Parse(Console.ReadLine());

                Console.Write("Введите число 1: "); int num1i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число 2: "); int num2i = Convert.ToInt32(Console.ReadLine());
                Calc<int> iC = new Calc<int> ();
                switch (t)
                {
                    case 1:
                        iC.Sum(num1i, num2i);
                        break;
                    case 2:
                        iC.Razn(num1i, num2i);
                        break;
                    case 3:
                        iC.Proizv(num1i, num2i);
                        break;
                    case 4:
                        iC.Divide(num1i, num2i);
                        break;
                    default:
                        Console.WriteLine("Возможно Вы не заметили, но я умею выполнять всего 4 операции.");
                        break;
                }
            break;
            case 2:
                Console.WriteLine(@"Что мне нужно выполнить с этими числами?
1. Суммировать
2. Найти их разность
3. Найти произведение
4. Найти частное"); int b = int.Parse(Console.ReadLine());
                Calc<double> dC = new Calc<double>();
                Console.Write("Введите число 1: "); double num1d = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число 2: "); double num2d = Convert.ToDouble(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        dC.Sum(num1d, num2d);
                        break;
                    case 2:
                        dC.Razn(num1d, num2d);
                        break;
                    case 3:
                        dC.Proizv(num1d, num2d);
                        break;
                    case 4:
                        dC.Divide(num1d, num2d);
                        break;
                    default: Console.WriteLine("Возможно Вы не заметили, но я умею выполнять всего 4 операции.");
                        break;
                }
                break;
            default:
                Console.WriteLine("Я рассматриваю всего 2 типа.");
                break;
        }
    }
}