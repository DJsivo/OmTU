using System;
class Prog
{
    static void Main(string[] args)
    {
        Console.WriteLine("Количество элементов стека"); int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0) Console.WriteLine("Стек пуст.");//С пустым мы не хотим работать.
        Stack<string> stack = new Stack<string>(n);//Создаю стек.
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


