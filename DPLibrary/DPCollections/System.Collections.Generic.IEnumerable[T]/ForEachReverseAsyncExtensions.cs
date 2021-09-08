using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class ForEachReverseAsyncExtensions
{
    public static async Task<IEnumerable<T>> ForEachReverseAsync<T>( this IEnumerable<T> @this, Func<T, Task> action )
    {
        var forEachReverseAsync = @this.ToList();
        var list = forEachReverseAsync.ToList();
        for ( var i = list.Count - 1; i >= 0; i--)
            await action( list[i] );
        return forEachReverseAsync;
    }   
}