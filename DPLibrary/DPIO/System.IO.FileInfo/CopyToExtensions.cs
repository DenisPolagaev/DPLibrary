using System.IO;

public static class CopyToExtensions
{
    public static void CopyTo(this FileInfo @this, FileInfo destination, FileMode destinationMode = FileMode.Create)
    {
        using var sourceStream = new FileStream(@this.FullName, FileMode.Open);
        using var destinationStream = new FileStream(destination.FullName, destinationMode);
        sourceStream.CopyTo(destinationStream);
    }
}