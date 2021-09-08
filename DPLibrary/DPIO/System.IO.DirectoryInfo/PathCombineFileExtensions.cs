using System.IO;
using System.Linq;

public static class PathCombineFileExtensions
{
    public static FileInfo PathCombineFile(this DirectoryInfo @this, params string[] paths)
    {
        var list = paths.ToList();
        list.Insert(0, @this.FullName);
        return new FileInfo(Path.Combine(list.ToArray()));
    }
}