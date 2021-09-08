using System;
using System.Collections.Generic;
using System.IO;

public static partial class ForEachExtension
{
    public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
    {
        foreach (var t in @this)
        {
            action(t);
        }
        return @this;
    }
    
    public static void VoidForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
    {
        foreach (var t in @this)
        {
            action(t);
        }
    }
}