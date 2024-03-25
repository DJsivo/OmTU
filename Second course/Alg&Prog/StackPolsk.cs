using System;
class Prog
{
    static void Main()
    {
        Console.WriteLine("Польская запись примера(Вводите все символы через пробел):");
        string str = Console.ReadLine();
        Console.WriteLine(Result(str));
    }

    static double Result(string str)
    {
        Stack<double> stack = new Stack<double>();//Здесь хранить числа и результаты постепенных вычислений
        string[] strSymbols = str.Split(' ');
        foreach (string strSymbol in strSymbols)
        {

            if ((strSymbol != "+") && (strSymbol != "-") && (strSymbol != "*") && (strSymbol != "/"))
            {
                stack.Push(double.Parse(strSymbol));
            }
            else
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException("Мне не с чем работать, увы.");
                }
                double symb2 = stack.Pop();
                double symb1 = stack.Pop();
                switch (strSymbol)
                {
                    case "+":
                        stack.Push(symb1 + symb2);
                        break;
                    case "-":
                        stack.Push(symb1 - symb2);
                        break;
                    case "*":
                        stack.Push(symb1 * symb2);
                        break;
                    case "/":
                        if (symb2 == 0) throw new ArgumentException("Я не умею делить на ноль.");
                        stack.Push(symb1 / symb2);
                        break;
                    default:
                        throw new ArgumentException("Я ещё не научился выполнять такие действия.");
                }
            }
        }
        if (stack.Count != 1) Console.WriteLine("Решение не однозначно, но вот один из вариантов:");
        return stack.Pop();
    }
}
