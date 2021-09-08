using System.IO;
using System.Text;

public static class ReadToEndExtensions
{
    
    public static string ReadToEnd(this FileInfo @this, long position)
    {
        using var stream =
            new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite) {Position = position};
        using var reader = new StreamReader(stream, Encoding.Default);
        return reader.ReadToEnd();
    }
    
    public static string ReadToEnd(this FileInfo @this, Encoding encoding = null)
    {
        using var stream = new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(stream, encoding ?? Encoding.UTF8);
        return reader.ReadToEnd();
    }
    
    public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
    {
        using var stream =
            new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite) {Position = position};
        using var reader = new StreamReader(stream, encoding);
        return reader.ReadToEnd();
    }
}