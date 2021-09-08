using System.Collections.Generic;
using System.Linq;

public static partial class ContainsAnyExtensions
{
    public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
    {
        return values.Any(@this.Contains);
    }
}