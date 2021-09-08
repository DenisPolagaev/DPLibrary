using System;
using System.IO;
using System.Linq;

public static class DeleteDirectoriesWhereExtensions
{
    public static void DeleteDirectoriesWhere(this DirectoryInfo obj, Func<DirectoryInfo, bool> predicate, 
        SearchOption searchOption = SearchOption.AllDirectories, string directoryPatten = "*.*")
    {
        obj.GetDirectories(directoryPatten, searchOption)
            .Where(predicate)
            .ToList()
            .ForEach(x => x.Delete());
    }   
}