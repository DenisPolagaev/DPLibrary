using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class GetFilesWhereExtension
{
    public static IEnumerable<FileInfo> GetFilesWhere(this DirectoryInfo @this, IEnumerable<string> searchPatterns,
        SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().Where(predicate);
    }

    public static IEnumerable<FileInfo> GetFilesWhere(this DirectoryInfo @this, string searchPattern,
        SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        return GetFilesWhere(@this, new[] {searchPattern}, searchOption, predicate);
    }

    public static IEnumerable<FileInfo> GetFilesWhere(this DirectoryInfo @this, Func<FileInfo, bool> predicate, string searchPattern = "*.*", 
        SearchOption searchOption = SearchOption.AllDirectories)
    {
        return GetFilesWhere(@this, new []{searchPattern}, searchOption, predicate);
    }
}