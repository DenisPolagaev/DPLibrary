using System.Collections.Generic;

public static class StringJoinExtensions
{
    public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
    {
        return string.Join(separator, @this);
    }
    
    public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
    {
        return string.Join(separator.ToString(), @this);
    }
}