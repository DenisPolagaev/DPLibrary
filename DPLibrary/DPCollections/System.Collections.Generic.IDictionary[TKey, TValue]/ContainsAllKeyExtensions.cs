using System.Collections.Generic;
using System.Linq;

public static class ContainsAllKeyExtensions
{
    public static bool ContainsAllKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
    {
        return keys.All(@this.ContainsKey);
    } 
}