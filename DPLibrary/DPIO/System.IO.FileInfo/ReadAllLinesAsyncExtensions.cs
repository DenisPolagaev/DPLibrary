using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public static class ReadAllLinesAsyncExtensions
{
    public static async Task<IEnumerable<string>> ReadAllLinesAsync(this FileInfo @this, Encoding encoding = null, int defaultBufferSize = 4096,
        FileOptions fileOptions= FileOptions.Asynchronous | FileOptions.SequentialScan)
    {
        var lines = new List<string>();
        using var stream = new FileStream(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, defaultBufferSize, fileOptions);
        using var reader = new StreamReader(stream, encoding ?? Encoding.UTF8);
        string line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
            lines.Add(line);
        }
        return lines;
    }  
}