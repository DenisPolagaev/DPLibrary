using System.Collections.Generic;
using System.Linq;

public static partial class ContainsAllExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="this"></param>
    /// <param name="values"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static bool ContainsAll<T>(this ICollection<T> @this, params T[] values)
    { 
        return values.All(@this.Contains);
    }
}