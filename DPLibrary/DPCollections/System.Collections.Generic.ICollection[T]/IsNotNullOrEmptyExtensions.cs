using System.Collections.Generic;

public static partial class IsNotNullOrEmptyExtensions
{
    public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
    {
        return @this != null && @this.Count != 0;
    }
}