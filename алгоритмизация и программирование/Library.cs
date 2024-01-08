using System;
class Books
{
    private String Author;
    private String Name;
    private int Year;
    private int[] MonthGive = new int[12];
    public Books(String Author, String Name, int Year, int[] MonthGive)
    {
        this.Author = Author;
        this.Name = Name;
        this.Year = Year;
        this.MonthGive = MonthGive;
    }
    public String GetInfo(Books book)
    {
        String MonthGive = "";
        for (int i = 0; i < 12; i++)
        {
            if (book.MonthGive[i] == 1) MonthGive += (i + 1) + ", ";
        }
        return "Автор:  " + book.Author + "\n Название:  " + book.Name + "\n Год выпуска:  " + book.Year + "\n Месяца выдачи в этом году:  " + MonthGive;
    }
    public Books SortedYear(Books book, int sortYear)//позже года
    {
        if (book.Year > sortYear) return book;
        else return null;
    }
    public Books? SortedAuthor(Books book, string sortauthor)//автора
    {
        if (book.Author.Equals(sortauthor)) return book;
        else return null;
    }
    public Books? SortedName(Books book, string sortname)//название
    {
        if (book.Author.Equals(sortname)) return book;
        else return null;
    }
    public int CountMonth (Books book)//количество месяцев в году, в которых выдавалась книга
    {
        int countMonth = 0;
        for (int i = 0; i < 12; i++)
        {
            if (book.MonthGive[i] == 1) countMonth++;
        }
        return countMonth;
    }
}
class Work
{
    static void Main()
    {
        Console.WriteLine("Year"); int sortyear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Author"); string sortauthor = Console.ReadLine();
        Console.WriteLine("Name"); string sortname = Console.ReadLine();

        Books[] books = new Books[10];
        books[0] = new Books("Т.Е.Пудовкина", "Отсылки для никого", 1954, new int[12] { 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1 });
        books[1] = new Books("Т.А.Романова", "Утопленница Серафима", 2025, new int[12] { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1 });
        books[2] = new Books("А.А.Журавлева", "Лилипут в стране Гуливеров", 2024, new int[12] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1 });
        books[3] = new Books("А.А.Романова", "Царь-Тай", 2023, new int[12] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 });
        books[4] = new Books("Т.А.Пудовкина", "Портрет Ангелины Романовой", 1972, new int[12] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 });
        books[5] = new Books("Т.А.Летун", "Зима в современном лагере", 2025, new int[12] { 0, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1 });
        books[6] = new Books("Т.А.Романова", "Труп в библиотеке", 1954, new int[12] { 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1 });
        books[7] = new Books("Агата Кристи", "10 негритят", 1939, new int[12] { 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1 });
        books[8] = new Books("Агата Кристи", "Убийство Роджера Экройда", 1926, new int[12] { 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1 });
        books[9] = new Books("Анна Тод", "После", 2014, new int[12] { 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 });
        Console.WriteLine(" "); Console.WriteLine("ВСЕ КНИГИ, ВЫПУЩЕННЫЕ ПОЗЖЕ ЗАДАННОГО ГОДА: ");
        for (int i = 0; i < books.Length; i++)
        {
            Books book = books[i];
            if (book.SortedYear(book, sortyear) != null) Console.WriteLine(" "); Console.WriteLine(book.GetInfo(book));
        }
        Console.WriteLine(" "); Console.WriteLine("ВСЕ КНИГИ ЗАДАННОГО АВТОРА: ");
        for (int i = 0; i < books.Length; i++)
        {
            Books book = books[i];
            if (book.SortedAuthor(book, sortauthor) != null) Console.WriteLine(" "); Console.WriteLine(book.GetInfo(book));
        }
        Console.WriteLine(" "); Console.WriteLine("ВСЕ КНИГИ ЗАДАННОГО НАЗВАНИЯ: ");
        for (int i = 0; i < books.Length; i++)
        {
            Books book = books[i];
            if (book.SortedName(book, sortname) != null) Console.WriteLine(" "); Console.WriteLine(book.GetInfo(book));
        }
        Console.WriteLine(" "); Console.WriteLine("КОЛИЧЕСТВО МЕСЯЦЕВ В ГОДУ, В КОТОРЫХ ВЫДАВАЛАСЬ КНИГА:  ");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(" ");Console.WriteLine($"Для книги: \n {books[i].GetInfo(books[i])} \n Количество месяцев в году, в которых выдавалась книга: {books[i].CountMonth(books[i])}");
        }
    }
}
