using LinqBooks.BusinessObjects;

namespace CustomLINQ;

public static class CustomQueryOperators
{
    public static Decimal TotalPrice(this IEnumerable<Book> books)
    {
        if (books == null)
        {
            throw new ArgumentException("books");
        }

        Decimal res = 0;
        foreach (var book in books)
        {
            res += book.Price;
        }

        return res;
    }

    public static Book Min(this IEnumerable<Book> source)
    {
        if (source == null)
        {
            throw new ArgumentException("source");
        }

        Book result = null;
        foreach (var book in source)
        {
            if (result == null || book.PageCount < result.PageCount)
                result = book;
        }

        return result;
    }

    public static IEnumerable<Book> Books(this Publisher publisher, IEnumerable<Book> books)
    {
        return books.Where(book => book.Publisher == publisher);
    }

    public static Boolean IsExpensive(this Book book)
    {
        if (book == null)
        {
            throw new Exception("book");
        }

        return book.Price > 50 || (book.Price / book.PageCount) > 0.10M;
    }
}