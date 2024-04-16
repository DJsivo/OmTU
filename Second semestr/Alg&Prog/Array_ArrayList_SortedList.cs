using System;
using System.Collections;
using System.Collections.Generic;
namespace Met
{

    class Menu
    {
        public static void Menus()
        {
            Console.WriteLine(@"    Выберите пункт меню: 

    Array: 

    1.Count
    2.BinarySearch
    3.Copy
    4.Find
    5.FindLast
    6.IndexOf
    7.Reverse
    8.Resize
    9.Sort

    ArrayList:

    10.Count
    11.BinarySearch
    12.Copy
    13.IndexOf
    14.Insert
    15.Reverse
    16.Sort
    17.Add

    SortedList:

    18.Add
    19.IndexOfKey
    20.IndexOfValue
    21.GetKey
    22.GetByIndex
    23.Exit the Menu
");
        }
        class Program
        {
            static void Main()
            {
                Array myarray = Array.CreateInstance(typeof(int), 6);
                myarray.SetValue(15, 0);
                myarray.SetValue(2, 1);
                myarray.SetValue(17, 2);
                myarray.SetValue(15, 3);
                myarray.SetValue(9, 4);
                myarray.SetValue(2, 5);
                ArrayList ListAr = new ArrayList()
        {
            "Cat",
            "Dog",
            "Apple",
            "Watch",
            "Water",
            "Bad",
            "April"
        };
                string[] arli = new string[ListAr.Count];

            SortedList sortedList = new SortedList();
                sortedList.Add("1","Strawberry");
                sortedList.Add("7", "Pirat");
                sortedList.Add("3", "Bred");


                Menu.Menus();
                bool exit = false;
                while (!exit)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Ведите эллемент количество которого хотите узнать: ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Metodu.Kol(myarray, c);
                            break;
                        case 2:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Введите элемент, индекс которого хотите найти в остортированном массиве: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Metodu.Poisk(myarray, b);
                            break;
                        case 3:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            int[] arrayCopy = new int[myarray.Length];
                            Array.Copy(myarray, arrayCopy, myarray.Length);
                            Console.Write("Скопированный массив: ");
                            Metodu.PrintArray(arrayCopy);
                            break;
                        case 4:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Введите число, по которому осуществляется поиск: ");
                            int g = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Array.Find(myarray.Cast<int>().ToArray(), i => i == g));
                            break;
                        case 5:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Введите число, по которому осуществляется поиск: ");
                            int t = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Array.FindLast(myarray.Cast<int>().ToArray(), i => i == t));
                            break;
                        case 6:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Введите число индекс которого хотите найти: ");
                            int k = Convert.ToInt32(Console.ReadLine());
                            int result2 = Array.IndexOf(myarray, k);
                            Console.WriteLine(result2);
                            break;
                        case 7:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Array.Reverse(myarray);
                            Console.Write("Перевернутый массив: ");
                            foreach (int i in myarray) Console.Write($"{i} ");
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Введите на сколько нужно увеличить длину массива(цифра): ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Новый массив: ");
                            Metodu.Razmer(myarray, a + myarray.Length);
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.Write("Массив: ");
                            Metodu.PrintArray(myarray);
                            Console.Write("Отсортированный массив: ");
                            Metodu.Sorted(myarray);
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            Console.Write("Количество элементов в листе: ");
                            Console.WriteLine(ListAr.Count);
                            break;
                        case 11:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            ListAr.Sort();
                            Console.Write("Введите элемент, индекс которого хотите найти в остортированном листе: ");
                            string str4 = Console.ReadLine();
                            int index1 = ListAr.BinarySearch(str4);
                            Console.WriteLine(index1);
                            break;
                        case 12:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            ListAr.CopyTo(arli, 0);
                            Console.WriteLine("Копирование из ArrayList в массив: ");
                            Metodu.PrintArray1(arli);
                            break;
                        case 13:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            Console.WriteLine("Введите элемент, индекс которого хотите найти: ");
                            string str = Console.ReadLine();
                            int result3 = ListAr.IndexOf(str);
                            Console.WriteLine(result3);
                            break;
                        case 14:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            Console.Write($"Ведите индекс на который хотите вставить элемент (не выше {ListAr.Count}): ");
                            int l = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите элемент: ");
                            string str1 = Console.ReadLine();
                            ListAr.Insert(l, str1);
                            Console.Write("Полученный лист: ");
                            Metodu.PrintArray2(ListAr);
                            break;
                        case 15:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            ListAr.Reverse();
                            Console.Write("Перевернутый лист: ");
                            Metodu.PrintArray2(ListAr);
                            break;
                        case 16:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            Console.Write("Отсортированный лист: ");
                            Metodu.Sorted1(ListAr);
                            Console.WriteLine();
                            break;
                        case 17:
                            Console.Write("Лист: ");
                            Metodu.PrintArray2(ListAr);
                            Console.Write("Введите элемент, который хотите добавить в лист: ");
                            string str5 = Console.ReadLine();
                            ListAr.Add(str5);
                            Metodu.PrintArray2(ListAr);
                            break;
                        case 18:
                            Console.WriteLine("Введите сначала ключ, потом значение добавляемого элемента:");
                            sortedList.Add(Console.ReadLine(),Console.ReadLine());
                            Console.WriteLine("\nВаш лист теперь:");
                            Metodu.SLShow(sortedList);
                            break;
                        case 19:
                            Console.WriteLine("Введите ключ, индекс которого определить:");
                            Console.WriteLine(sortedList.IndexOfKey(Console.ReadLine()));
                            break;
                        case 20:
                            Console.WriteLine("Введите значение, индекс которого определить:");
                            Console.WriteLine(sortedList.IndexOfValue(Console.ReadLine()));
                            break;
                        case 21:
                            Console.WriteLine("Введите индекс, по которому нужно найти ключ:");
                            Console.WriteLine(sortedList.GetKey(Convert.ToInt32(Console.ReadLine())));
                            break;
                        case 22:
                            Console.WriteLine("Введите индекс, по которому нужно найти значение:");
                            Console.WriteLine(sortedList.GetByIndex(Convert.ToInt32(Console.ReadLine())));
                            break;
                        case 23:
                            exit = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        class Metodu
        {
            
            public static void Kol(Array array, int c)
            {
                ICollection arrayColection = (ICollection)array;
                Console.WriteLine(array.Cast<int>().Count(x => x == c));
            }
            public static void Sorted(Array array)
            {
                Array.Sort(array);
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
            }
            public static void Poisk(Array array, int n)
            {
                int[] sortedarray = new int[array.Length];
                Array.Copy(array, sortedarray, array.Length);
                Array.Sort(sortedarray);
                Console.Write("Отсортированный массив: ");
                Metodu.PrintArray(sortedarray);
                int index = Array.BinarySearch(sortedarray, n);
                Console.WriteLine($"Индекс элемента {n}: {index}");
            }
            public static void Razmer(Array array, int a)
            {
                Array newarray = Array.CreateInstance(typeof(int), a);
                Array.Copy(array, newarray, array.Length);
                for (int i = 0; i < newarray.Length; i++)
                {
                    Console.Write(newarray.GetValue(i) + " ");
                }
            }
            public static void PrintArray(Array array)
            {
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            public static void PrintArray1(string[] array)
            {
                foreach (string i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            public static void PrintArray2(ArrayList list)
            {
                foreach (var i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            public static void Sorted1(ArrayList ar)
            {
                ar.Sort();
                foreach (string i in ar)
                {
                    Console.Write(i + " ");
                }
            }
            public static void SLShow(SortedList sortedList)
            {
                for (int i = 0; i < sortedList.Count; i++)
                    Console.WriteLine($"{sortedList.GetKey(i)} : {sortedList.GetByIndex(i)}"); Console.WriteLine();
            }
        }
    }
}
