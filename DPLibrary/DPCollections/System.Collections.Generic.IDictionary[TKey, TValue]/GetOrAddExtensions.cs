using System;
using System.Collections.Generic;

public static class GetOrAddExtensions
{
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
    {
        if (@this.ContainsKey(key)) return @this[key];
        @this.Add(new KeyValuePair<TKey, TValue>(key, value));
        return @this[key];
    }
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> valueFactory)
    {
        if (@this.ContainsKey(key)) return @this[key];
        @this.Add(new KeyValuePair<TKey, TValue>(key, valueFactory(key)));
        return @this[key];
    }
}