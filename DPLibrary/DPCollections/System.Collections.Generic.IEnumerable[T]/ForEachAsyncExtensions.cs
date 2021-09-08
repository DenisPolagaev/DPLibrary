using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class ForEachAsyncExtensions
{
    public static async Task<IEnumerable<T>> ForEachAsync<T>(this IEnumerable<T> @this, Func<T, Task> action)
    {
        var array = @this.ToArray();
        foreach (var t in array)
        {
            await action(t);
        }
        return array;
    } 
    public static async void VoidForEachAsync<T>(this IEnumerable<T> @this, Func<T, Task> action)
    {
        var array = @this.ToArray();
        foreach (var t in array)
        {
            await action(t);
        }
    }
}