using System;
using System.Collections.Generic;
using System.Linq;

public static class GetAllRepeatedExtensions
{
    public static IEnumerable<T> GetAllRepeated<T>(this IEnumerable<T> extList, Func<T, object> groupProps) where T : class
    {
        //Get All the lines that has repeating
        return extList
            .GroupBy(groupProps)
            .Where(z => z.Count() > 1) //Filter only the distinct one
            .SelectMany(z => z);//All in where has to be retuned
    }
}