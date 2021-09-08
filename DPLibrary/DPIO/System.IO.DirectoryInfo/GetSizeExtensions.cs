using System.IO;
using System.Linq;

public static class GetSizeExtensions
{
    public static long GetSize(this DirectoryInfo @this, string searchPattern = "*.*",
        SearchOption searchOption = SearchOption.AllDirectories)
    {
        return @this.GetFiles(searchPattern, searchOption).Sum(x => x.Length);
    }
}