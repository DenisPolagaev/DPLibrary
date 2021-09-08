using System.Collections.Generic;

public static partial class IsNotEmptyExtensions
{
    public static bool IsNotEmpty<T>(this ICollection<T> @this)
    {
        return !@this.IsEmpty();
    }    
}