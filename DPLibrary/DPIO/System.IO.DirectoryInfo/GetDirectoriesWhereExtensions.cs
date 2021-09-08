using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class GetDirectoriesWhereExtensions
{
    public static IEnumerable<DirectoryInfo> GetDirectoriesWhere(this DirectoryInfo @this, IEnumerable<string> searchPatterns,
        Func<DirectoryInfo, bool> predicate,  SearchOption searchOption = SearchOption.AllDirectories)
    {
        return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().Where(predicate);
    }

    public static IEnumerable<DirectoryInfo> GetDirectoriesWhere(this DirectoryInfo @this, string searchPattern,
        Func<DirectoryInfo, bool> predicate, SearchOption searchOption = SearchOption.AllDirectories)
    {
        return GetDirectoriesWhere(@this, new []{searchPattern}, predicate, searchOption);
    }
}