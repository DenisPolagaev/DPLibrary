using System.IO;

public static class RenameExtensions
{
    public static FileInfo Rename(this FileInfo @this, string newName)
    {
        var filePath = new FileInfo(Path.Combine(@this.Directory.FullName, newName));
        @this.MoveTo(filePath.FullName);
        return filePath;
    }
}