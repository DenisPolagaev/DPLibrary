using System.Collections.Generic;
using System.Linq;

public  static partial class IsNotEmptyExtensions
{
    public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
    {
        return @this.Any();
    }
}