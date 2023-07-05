namespace CustomLINQ;

public static class SumExtensibility
{
    public static long LongSum(this IEnumerable<int> source)
    {
        if (source == null)
        {
            throw new ArgumentException("source");
        }

        long sum = 0;
        checked
        {
            foreach (var v in source)
            {
                sum += v;
            }
        }

        return sum;
    }
    
    public static long? LongSum(this IEnumerable<int?> source)
    {
        if (source == null)
        {
            throw new ArgumentException("source");
        }

        long? sum = 0;
        checked
        {
            foreach (var v in source)
            {
                if (v != null)
                {
                    sum += v;
                }
            }
        }

        return sum;
    }

    public static long LongSum<T>(this IEnumerable<T> source, Func<T, int> selector)
    {
        return source.Select(selector).LongSum();
    }

    public static long? LongSum<T>(this IEnumerable<T> source, Func<T, int?> selector)
    {
        return source.Select(selector).LongSum();
    }
}