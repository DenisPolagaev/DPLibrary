using System;
using System.IO;
using System.Linq;

public static class DeleteFileWhereExtensions
{
    public static void DeleteFilesWhere(this DirectoryInfo obj, Func<FileInfo, bool> predicate, 
        SearchOption searchOption = SearchOption.AllDirectories, string deletePatten = "*.*")
    {
        obj.GetFiles(deletePatten, searchOption)
            .Where(predicate)
            .ToList()
            .ForEach(x => x.Delete());
    }
}