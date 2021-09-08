using System.Collections.Generic;
using System.Linq;

public static partial class IsNullOrEmptyExtensions
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
    {
        return @this == null || !@this.Any();
    }  
}