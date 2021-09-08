using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class GetFilesExtensions
{
    public static IEnumerable<FileInfo> GetFiles(this DirectoryInfo @this, 
        IEnumerable<string> searchPatterns, SearchOption searchOption = SearchOption.AllDirectories)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct();
    }

    public static IEnumerable<FileInfo> GetFiles(this DirectoryInfo @this, 
        string searchPattern = "*.*", SearchOption searchOption = SearchOption.AllDirectories)
    {
        return GetFiles(@this, new []{searchPattern}, searchOption);
    }
}