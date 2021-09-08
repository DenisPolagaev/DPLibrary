using System.Collections.Generic;
using System.Linq;

public static partial class ContainsAllExtensions
{
    public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
    {
        return values.All(value => @this.ToArray().Contains(value));
    }
    
}