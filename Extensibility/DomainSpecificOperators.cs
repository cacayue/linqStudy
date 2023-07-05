using LinqBooks.BusinessObjects;

namespace Extensibility;

public static class DomainSpecificOperators
{
    public static IEnumerable<Book> Where(
        this IEnumerable<Book> source,
        Func<Book, Boolean> predicate)
    {
        foreach (var book in source)
        {
            Console.WriteLine($"processing book {book.Title}");
            if (predicate(book))
            {
                yield return book;
            }
        }
    }

    public static IEnumerable<TResult> Select<TResult>(
        this IEnumerable<Book> source,
        Func<Book, TResult> selector)
    {
        foreach (var book in source)
        {
            Console.WriteLine($"processing book {book.Title}");
            yield return selector(book);
        }
    }
}