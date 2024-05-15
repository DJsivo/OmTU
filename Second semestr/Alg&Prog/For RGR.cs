class Hz
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Name()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"Автор:
Пудовкина Татьяна Евгеньевна
МО-231");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void Menu()
    {
        bool menu = true;
        while (menu)
        {
            Console.Clear();
            Console.WriteLine(@"
Что бы вы хотели сделать?
1.Узнать, кто автор.
2.Узнать о задаче <проверка правильности расстановки скобочек>
3.Решить задачу <проверка правильности расстановки скобочек>
4.Узнать о задаче <польская запись>
5.Решить задачу <польская запись>
6.Закончить работу.");
            int n = int.Parse(Console.ReadLine());

            if ((n < 1) || (n > 6)) throw new Exception("Читайте список функций лучше.");
            switch (n)
            {
                case 1:
                    Console.Clear();
                    Name();Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(@"Имеется выражение, содержащее 3 вида скобок:
[],{},().
Необходимо определить, правильно ли расставлены скобки.");Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    StackAll.Skobochki(); Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(@"Вы вводите обратную польскую запись. 
Необходимо произвести вычисления на основе Вашей польской записи."); Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    StackAll.Polsk(); Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("\nДо скорой встречи!"); menu = false;
                    break;
            }
        }
    }
}
public class StackAll
{
    public static void Polsk()
    {
        Console.WriteLine("Польская запись примера(Вводите все символы через пробел):");
        string str = Console.ReadLine();
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
        Console.WriteLine($"Ваш ответ:\n{stack.Pop()}\n");
    }
    public static void Skobochki()
    {
        Console.WriteLine("Количество элементов стека"); int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0) throw new Exception("Вы планируете работать с пустым стеком.");//С пустым мы не хотим работать.
        if (n % 2 != 0) throw new Exception("Запись не может быть верна");
        Stack<string> stack = new Stack<string>();//Создаю стек.
        Console.WriteLine("Введите все скобочки через \"Enter\"");
        for (int i = 0; i < n; i++) 
        {
            string charr = Console.ReadLine();
            if (charr != "{" && charr != "}" && charr != "[" && charr != "]" && charr != "(" && charr != ")") throw new Exception("Это не скобочка! Попробуйте снова.");
            stack.Push(charr);//Заполнение Стека.
        }
        string[] stackArr = new string[stack.Count]; stack.CopyTo(stackArr, 0);//Полная копия стека в Массиве.
        int checkTrue = int.MaxValue;
        for (int i = 0; i < (n - 1);)
        {
            string stack1 = stack.Pop();
            string stack2 = stack.Pop();
            if (((string)stack1 == ")") && ((string)stack2 == "(")) checkTrue = 1;
            else if (((string)stack1 == "}") && ((string)stack2 == "{")) checkTrue = 1;
            else if (((string)stack1 == "]") && ((string)stack2 == "[")) checkTrue = 1;
            else
            {
                checkTrue = 0;
                break;
            }
        i += 2;
        }
        if (checkTrue == 1) Console.WriteLine("Запись верна.");
        else Console.WriteLine("Запись неверна.");
    }
}
