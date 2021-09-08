using System.IO;
using System.Linq;

public static class PathCombineDirectoryExtensions
{
    public static DirectoryInfo PathCombineDirectory(this DirectoryInfo @this, params string[] paths)
    {
        var list = paths.ToList();
        list.Insert(0, @this.FullName);
        return new DirectoryInfo(Path.Combine(list.ToArray()));
    }
}