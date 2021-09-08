using System.Collections.Generic;

public static class RemoveRangeExtensions
{
    public static void RemoveRange<T>(this ICollection<T> @this, params T[] values)
    {
        foreach (var value in values)
        {
            @this.Remove(value);
        }
    }    
}