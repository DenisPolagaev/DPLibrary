using System.Collections.Generic;
using System.Linq;

public static partial class ContainsAnyExtensions
{
    public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
    {
        return values.Any(value => @this.ToArray().Contains(value));
    }    
}