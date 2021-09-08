using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class GetDirectoriesExtensions
{
    
    public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, IEnumerable<string> searchPatterns, 
        SearchOption searchOption = SearchOption.AllDirectories)
    {
        return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().ToArray();
    }

    public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, string searchPattern,
        SearchOption searchOption = SearchOption.AllDirectories)
    {
        return GetDirectories(@this, new []{searchPattern}, searchOption);
    }
}