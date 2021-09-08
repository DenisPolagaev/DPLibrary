using System;
using System.Collections.Generic;
using System.Linq;

public static class ForEachExtensions
{
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
    {
        var array = @this.ToArray();
        foreach (var t in array)
        {
            action(t);
        }
        return array;
    }

    public static void VoidForEach<T>(this IEnumerable<T> @this, Action<T> action)
    {
        var array = @this.ToArray();
        foreach (var t in array)
        {
            action(t);
        }
    }

    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
    {
        var array = @this.ToArray();

        for (var i = 0; i < array.Length; i++)
        {
            action(array[i], i);
        }

        return array;
    }

    public static void VoidForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
    {
        var array = @this.ToArray();
        for (var i = 0; i < array.Length; i++)
        {
            action(array[i], i);
        }
    }
}