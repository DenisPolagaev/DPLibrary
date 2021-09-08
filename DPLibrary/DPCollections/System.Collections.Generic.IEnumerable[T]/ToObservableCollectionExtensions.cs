using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class ToObservableCollectionExtensions
{
    public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> @this)
    {
        return new(@this);
    }
}