using System.Collections.Generic;

public static partial class IsNullOrEmptyExtensions
{
    public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
    {
        return !@this.IsNotNullOrEmpty();
    }
}