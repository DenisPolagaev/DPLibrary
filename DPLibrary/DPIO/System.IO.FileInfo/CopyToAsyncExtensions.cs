using System.IO;
using System.Threading.Tasks;

public static class CopyToAsyncExtensions
{
    public static async Task CopyTo(this FileInfo @this, FileInfo destination, FileMode destinationMode = FileMode.Create)
    {
        using var sourceStream = new FileStream(@this.FullName, FileMode.Open);
        using var destinationStream = new FileStream(destination.FullName, destinationMode);
        await sourceStream.CopyToAsync(destinationStream);
    }
}