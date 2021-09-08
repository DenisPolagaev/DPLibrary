using System.Collections.Generic;
using System.Linq;

public static partial class IsEmptyExtensions
{
    public static bool IsEmpty<T>(this IEnumerable<T> @this)
    {
        return !@this.Any();
    }
}