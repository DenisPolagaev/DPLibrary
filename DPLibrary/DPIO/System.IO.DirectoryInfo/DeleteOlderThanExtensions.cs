using System;
using System.IO;
using System.Linq;

public static class DeleteOlderThanExtensions
{
    public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan,
        SearchOption searchOption = SearchOption.AllDirectories,
        string folderPatten = "*.*", string filePattern = "*.*")
    {
        var minDate = DateTime.Now.Subtract(timeSpan);

        obj.GetFiles(filePattern, searchOption)
            .Where(x => x.LastWriteTime < minDate)
            .ToList()
            .ForEach(x => x.Delete());

        obj.GetDirectories(folderPatten, searchOption)
            .Where(x => x.LastWriteTime < minDate)
            .ToList()
            .ForEach(x => x.Delete());
    }

    public static void DeleteOlderThan(this DirectoryInfo obj, DateTime minDate,
        SearchOption searchOption = SearchOption.AllDirectories,
        string folderPatten = "*.*", string filePattern = "*.*")
    {
        obj.GetFiles(filePattern, searchOption)
            .Where(x => x.LastWriteTime < minDate)
            .ToList()
            .ForEach(x => x.Delete());

        obj.GetDirectories(folderPatten, searchOption)
            .Where(x => x.LastWriteTime < minDate)
            .ToList()
            .ForEach(x => x.Delete());
    }
}