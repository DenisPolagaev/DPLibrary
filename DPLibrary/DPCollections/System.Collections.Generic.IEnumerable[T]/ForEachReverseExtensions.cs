using System;
using System.Collections.Generic;
using System.Linq;

public static class ForEachReverseExtensions
{
    public static IEnumerable<T> ForEachReverse<T>( this IEnumerable<T> @this, Action<T> action )
    {
        var list = @this.ToList();
        for ( var i = list.Count - 1; i >= 0; i-- )
            action( list[i] );
        return list;
    }
    
    public static void VoidForEachReverse<T>( this IEnumerable<T> @this, Action<T> action )
    {
        var list = @this.ToList();
        for ( var i = list.Count - 1; i >= 0; i-- )
            action( list[i] );
    }
}