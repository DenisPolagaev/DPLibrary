using System.Collections.Generic;
using System.Linq;

public static class ContainsAnyKeyExtensions
{
    public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
    {
        return keys.Any(@this.ContainsKey);
    }  
}