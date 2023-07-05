namespace Extensibility;

public static class CustomImplementation
{
    public static IEnumerable<TSource> Where<TSource>(
        this IEnumerable<TSource> source,
        Func<TSource, Boolean> predicate)
    {
        Console.WriteLine("Custome Where");
        return Enumerable.Where(source,predicate);
    }

    public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
        Func<TSource, TResult> seletor)
    {
        Console.WriteLine("Select<TSource,TResult>");
        return Enumerable.Select(source,seletor);
    }
}