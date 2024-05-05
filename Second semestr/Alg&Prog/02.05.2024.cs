using System;
using System.Linq;
using System.Net.WebSockets;
class Hz
{
    static void Main()
    {
        int[] a = { 0, 7, 45, 18, 173, 56, 893, 345, 333, 44, 992993, 786, 321 };

        Console.WriteLine("Задание 1.");

        var lastNumber3 = a.Where(x => (x % 10) % 3 == 0);
        Console.WriteLine("Элементы, у которых последняя цифра кратна 3:");
        foreach (var ln3 in lastNumber3) Console.WriteLine(ln3);

        var chetNumOnA = a.Where(x => x.ToString().Any(c => c % 2 == 0));//Ноль считается чётным, чаще всего.
        Console.WriteLine(@"
Элементы у которого в записи присутствует хотя бы одна четная цифра:");
        foreach (var cn in chetNumOnA) Console.WriteLine(cn);

        Console.WriteLine(@"
Задание 2.");
        var chetNumbersWithA = a.Where(x => x % 2 == 0);
        var withReplacedNumbers = chetNumbersWithA.Select((x, index) => index % 2 == 1 ? 2 : x).ToArray();//если на четной позиции (счет с 0), то возвращается 2, иначе само число
        var fin = withReplacedNumbers.Where(x => x % 2 == 0);
        foreach (var f in fin) Console.WriteLine(f);
    }
}