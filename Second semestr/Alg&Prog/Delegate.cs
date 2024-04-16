using System;
public interface Calc
{
    double Sum(double a, double b);
    double Razn(double a, double b);
    double Umn(double a, double b);
    double Divide(double a, double b);
    double Square(double a, double b);
    double Sin(double a, double b);
    double Cos(double a, double b);
}
public class Mathematics : Calc
{
    public delegate double Math(double a, double b);
    public double Sum(double a, double b) => a + b;
    public double Razn(double a, double b) => a - b;
    public double Umn(double a, double b) => a * b;
    public double Divide(double a, double b) => a / b;
    public double Square(double a, double b) => System.Math.Sqrt(a);
    public double Sin(double a, double b) => System.Math.Sin(a);
    public double Cos(double a, double b) => System.Math.Cos(a);
}

class Program
{
    static void Main()
    {
        Mathematics MO = new Mathematics();
        try
        {
            Console.WriteLine(@"
Выберите операцию, которую я должен выполнить:
1. Сложение
2. Вычитание
3. Умножение
4. Деление
5. Извлечение квадратного корня
6. Синус
7. Косинус
");
            int n = Convert.ToInt32(Console.ReadLine());
            Mathematics.Math? math = null;
            if (n >= 1 && n <= 4)
            {
                Console.Write("Введите первое число: ");double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");double num2 = Convert.ToDouble(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        math = MO.Sum;
                        break;
                    case 2:
                        math = MO.Razn;
                        break;
                    case 3:
                        math = MO.Umn;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Извините, я как и Вы не умею делить на ноль...");
                        }
                        math = MO.Divide;
                        break;
                }
                if (math != null)
                {
                    Console.WriteLine($"Результат выполнения операции: {math(num1, num2)}");
                }
            }
            else if ((n >=5) && (n <= 7))
            {
                Console.Write("Введите число: ");
                double num = Convert.ToDouble(Console.ReadLine());
                switch (n)
                {
                    case 5:
                        if (num < 0)
                        {
                            throw new Exception("В действительных числах нельзя извлекать квадратный корень из отрицательного числа!");
                        }
                        math = MO.Square;
                        break;
                    case 6:
                        math = MO.Sin;
                        break;
                    case 7:
                        math = MO.Cos;
                        break;
                }

                if (math != null)
                {
                    Console.WriteLine($"Результат выполнения операции: {math(num,0)}");
                }
            }
            else
            {
                throw new Exception("Не попадает в список моих операций");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
