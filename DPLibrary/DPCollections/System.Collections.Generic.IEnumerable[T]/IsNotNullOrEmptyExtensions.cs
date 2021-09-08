using System.Collections.Generic;
using System.Linq;

public static partial class IsNotNullOrEmptyExtensions
{
    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
    {
        return @this != null && @this.Any();
    }   
}