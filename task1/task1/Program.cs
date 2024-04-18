using task1;

class Program
{
    public static void Main()
    {
        Book a = new Book();
        List<Book> katalog = new List<Book>()
        {
       new Book("Дфра",12),
       new Book("Карара",12),
       new Book("Лали",12),
       new Book("Ромбинзон круз",12),
       new Book("Буратино",12)
        };

        katalog = a.TypeComparison(katalog);

        foreach(Book book in katalog)
        {
            Console.WriteLine($"{book.Name}");
        }
    }
}
