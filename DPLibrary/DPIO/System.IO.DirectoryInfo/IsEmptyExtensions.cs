using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

public static partial class IsEmptyExtensions
{
    public static bool IsEmpty(this DirectoryInfo @this)
    {
        return @this.EnumerateFileSystemInfos().Any();
    }
}