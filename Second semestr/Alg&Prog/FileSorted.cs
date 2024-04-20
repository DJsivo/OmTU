using System;
using System.IO;
class Hz
{
    static void Main()
    {
        Console.WriteLine(@"Как расположены числа в файлах?
1. По позрастанию.
2. По убыванию.");int n = int.Parse(Console.ReadLine());
        if (n != 1 && n != 2) throw new Exception("Не может такого быть.");
        else 
        {
            using (StreamReader read1 = new StreamReader(@"file1.txt"))
            using (StreamReader read2 = new StreamReader(@"file2.txt"))
            using (StreamWriter write = new StreamWriter(@"final_file.txt"))
            {
                string line1 = read1.ReadLine();
                string line2 = read2.ReadLine();
                
                while (line1 != null && line2 != null)
                {
                    int first = int.Parse(line1);
                    int second = int.Parse(line2);
                    if (n == 1)
                    {
                        if (first <= second)
                        {
                            write.WriteLine(first);
                            line1 = read1.ReadLine();
                        }
                        else
                        {
                            write.WriteLine(second);
                            line2 = read2.ReadLine();
                        }
                    }
                    if (n == 2)
                    {
                        if (first >= second)
                        {
                            write.WriteLine(first);
                            line1 = read1.ReadLine();
                        }
                        else
                        {
                            write.WriteLine(second);
                            line2 = read2.ReadLine();
                        }
                    }
                    
                }
                while (line1 != null)
                {
                    write.WriteLine(line1);
                    line1 = read1.ReadLine();
                }

                while (line2 != null)
                {
                    write.WriteLine(line2);
                    line2 = read2.ReadLine();
                }
            }
            Console.WriteLine("Файлы успешно объединены и отсортированы в файле \"final_file.txt\"");
        } 
    }
}
