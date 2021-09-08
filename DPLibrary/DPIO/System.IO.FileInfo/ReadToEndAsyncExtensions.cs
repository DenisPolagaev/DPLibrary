using System.IO;
using System.Text;
using System.Threading.Tasks;

public static class ReadToEndAsyncExtensions
{
    public static async Task<string> ReadToEndAsync(this FileInfo @this, Encoding encoding, long position)
    {
        using var stream =
            new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite) {Position = position};
        using var reader = new StreamReader(stream, encoding);
        return await reader.ReadToEndAsync();
    }
    
    public static async Task<string> ReadToEndAsync(this FileInfo @this, Encoding encoding)
    {
        using var stream = new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(stream, encoding);
        return await reader.ReadToEndAsync();
    }
    
    public static async Task<string> ReadToEndAsync(this FileInfo @this, long position)
    {
        using var stream =
            new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite) {Position = position};
        using var reader = new StreamReader(stream, Encoding.Default);
        return await reader.ReadToEndAsync();
    }
    
    public static async Task<string> ReadToEndAsync(this FileInfo @this)
    {
        using var stream = new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(stream, Encoding.Default);
        return await reader.ReadToEndAsync();
    }
}