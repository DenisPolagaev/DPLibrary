using System;
using System.Collections.Generic;
using System.Linq;

public static class GetMoreThanOnceRepeatedExtensions
{
    public static IEnumerable<T> GetMoreThanOnceRepeated<T>(this IEnumerable<T> extList, Func<T, object> groupProps) where T : class
    { 
        //Return only the second and next reptition
        return extList
            .GroupBy(groupProps)
            .SelectMany(z => z.Skip(1)); //Skip the first occur and return all the others that repeats
    } 
}