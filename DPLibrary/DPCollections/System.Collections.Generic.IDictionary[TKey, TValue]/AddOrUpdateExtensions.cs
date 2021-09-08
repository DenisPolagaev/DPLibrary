using System;
using System.Collections.Generic;

public static class AddOrUpdateExtensions
{
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
    {
        if (@this.ContainsKey(key))
        {
            @this[key] = value;
        }
        else
        {
            @this.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        return @this[key];
    }

    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue addValue,
        Func<TKey, TValue, TValue> updateValueFactory)
    {
        if (@this.ContainsKey(key))
        {
            @this[key] = updateValueFactory(key, @this[key]);
        }
        else
        {
            @this.Add(new KeyValuePair<TKey, TValue>(key, addValue));
        }
        return @this[key];
    }
    
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
    {
        if (@this.ContainsKey(key))
        {
            @this[key] = updateValueFactory(key, @this[key]);
        }
        else
        {
            @this.Add(new KeyValuePair<TKey, TValue>(key, addValueFactory(key)));
        }
        return @this[key];
    }
}