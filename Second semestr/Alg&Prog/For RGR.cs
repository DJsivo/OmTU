class Hz
{
    static void Main(string[] args)
    {
        Name();
        Menu();  
    }
    static void Name()
    {
        Console.ForegroundColor = ConsoleColor.Blue; 
        Console.SetCursorPosition(90, 0); Console.WriteLine("Автор:"); 
        Console.SetCursorPosition(90, 1); Console.WriteLine("Пудовкина Татьяна"); 
        Console.SetCursorPosition(90, 2); Console.WriteLine("МО-231"); 
        //Console.ForegroundColor = ConsoleColor.White;
    }
    static void Menu()
    {
        bool menu = true;
        while (menu)
        {

            Console.WriteLine(@"
Что бы вы хотели сделать при помощи стека?
1. Проверить, правильно ли расставлены скобочки.
2. Работа с польской записью
3. Закончить работу.");
            int n = int.Parse(Console.ReadLine());
                
                if ((n < 1) || (n > 3)) throw new Exception("Читайте список функций лучше.");
                switch (n)
                {
                    case 1:Console.Clear();
                    StackAll.Skobochki();
                        break;
                    case 2:Console.Clear();
                    StackAll.Polsk();    
                        break;
                    case 3:Console.Clear();
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
        if (n == 0) Console.WriteLine("Стек пуст.");//С пустым мы не хотим работать.
        Stack<string> stack = new Stack<string>();//Создаю стек.
        Console.WriteLine("Введите все скобочки через \"Enter\"");
        for (int i = 0; i < n; i++) stack.Push(Console.ReadLine());//Заполнение Стека.
        string[] stackArr = new string[stack.Count]; stack.CopyTo(stackArr, 0);//Полная копия стека в Массиве.
        int checkTrue = int.MaxValue;
        for (int i = 0; i < n; i += 2)
        {
            if ((stackArr[i] == ")") && (stackArr[i + 1] == "(")) checkTrue = 1;
            else if ((stackArr[i] == "}") && (stackArr[i + 1] == "{")) checkTrue = 1;
            else if ((stackArr[i] == "]") && (stackArr[i + 1] == "[")) checkTrue = 1;
            else
            {
                checkTrue = 0;
                break;
            }
        }
        if (checkTrue == 1) Console.WriteLine("Запись верна.");
        else Console.WriteLine("Запись неверна.");
    }
}