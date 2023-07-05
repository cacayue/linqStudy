using LinqBooks;

namespace CustomLINQ // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            TotalPrice();
            BookFilter();
        }

        static void TotalPrice()
        {
            var query = from publisher in SampleData.Publishers
                join book in SampleData.Books on publisher equals book.Publisher into pubBooks
                select new
                {
                    Publisher = publisher.Name,
                    TotalPrice = pubBooks.TotalPrice()
                };
            foreach (var pubBook in query)
            {
                Console.WriteLine(ObjectDumper.Dump(pubBook));
            }
        }

        static void BookFilter()
        {
            var query = from publisher in SampleData.Publishers
                select new
                {
                    Publisher = publisher,
                    TotalPrice = publisher.Books(SampleData.Books).TotalPrice()
                };
            foreach (var pubBook in query)
            {
                Console.WriteLine(ObjectDumper.Dump(pubBook));
            }
        }
    }
}