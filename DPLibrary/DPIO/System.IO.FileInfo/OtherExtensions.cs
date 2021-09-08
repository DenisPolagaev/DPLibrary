using System;
using System.IO;

public static class OtherExtensions
{
    public static string ChangeExtension(this FileInfo @this, string extension)
    {
        if (extension == null) throw new ArgumentNullException(nameof(extension));
        return Path.ChangeExtension(@this.FullName, extension);
    }
    
    public static DirectoryInfo CreateDirectory(this FileInfo @this)
    {
        return Directory.CreateDirectory(@this.Directory.FullName);
    }
    
    public static string GetFileNameWithoutExtension(this FileInfo @this)
    {
        return Path.GetFileNameWithoutExtension(@this.FullName);
    }
    
    public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
    {
        var fileName = string.Concat(newName, @this.Extension);
        var filePath = Path.Combine(@this.Directory.FullName, fileName);
        @this.MoveTo(filePath);
    }
    
    public static string GetPathRoot(this FileInfo @this) => Path.GetPathRoot(@this.FullName);

    public static void Rename(this FileInfo @this, string newName)
    {
        var filePath = Path.Combine(@this.Directory.FullName, newName);
        @this.MoveTo(filePath);
    }
    
}