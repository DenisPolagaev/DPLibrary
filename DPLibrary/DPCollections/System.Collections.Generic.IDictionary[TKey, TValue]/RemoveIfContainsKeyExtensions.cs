using System.Collections.Generic;

public static class RemoveIfContainsKeyExtensions
{
    public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key)
    {
        if (!@this.ContainsKey(key)) return;
        @this.Remove(key);
    } 
}