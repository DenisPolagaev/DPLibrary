using System;
using System.Collections.Generic;
using System.Linq;

public static class RemoveWhereExtensions
{
    public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
    {
        var list = @this.Where(predicate).ToList();
        foreach (var item in list)
        {
            @this.Remove(item);
        }
    }
}