using System;
using System.Collections.Generic;
using System.IO;

public static partial class ForEachExtension
{
    public static void VoidForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
    {
        foreach (var t in @this)
        {
            action(t);
        }
    }
    public static IEnumerable<DirectoryInfo> ForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
    {
        foreach (var t in @this)
        {
            action(t);
        }
        return @this;
    }
}