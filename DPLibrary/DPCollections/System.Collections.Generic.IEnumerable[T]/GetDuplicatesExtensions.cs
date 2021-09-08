using System;
using System.Collections.Generic;
using System.Linq;

public static partial class GetDuplicatesExtensions
{
    public static IEnumerable<U> GetDuplicates<T, U>(this IEnumerable<T> @this, Func<T, U> keySelector)
    {
        return @this.GroupBy(keySelector)
            .Where(group => group.Count() > 1)
            .Select(group => group.Key);
    }
    public static IEnumerable<TSource> GetDuplicates<TSource, TKey>(this IEnumerable<TSource> @this, Func<TSource, TKey> selector, IEqualityComparer<TKey> comparer)
    {
        var hash = new HashSet<TKey>(comparer);
        return @this.Where(item => !hash.Add(selector(item))).ToList();
    }

    public static IEnumerable<TSource> GetDuplicates<TSource>(this IEnumerable<TSource> @this, IEqualityComparer<TSource> comparer)
    {
        return @this.GetDuplicates(x => x, comparer);      
    }
    
    public static IEnumerable<TSource> GetDuplicates<TSource>(this IEnumerable<TSource> @this)
    {
        return @this.GetDuplicates(x => x, null);
    }
}