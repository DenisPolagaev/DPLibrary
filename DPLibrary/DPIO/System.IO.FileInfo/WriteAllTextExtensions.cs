using System.IO;
using System.Text;

public static class WriteAllTextExtensions
{
    public static void WriteAllText(this FileInfo @this, string content, 
        Encoding encoding = default, FileMode fileMode = FileMode.Create, FileAccess fileAccess = FileAccess.Write,
        FileShare fileShare = FileShare.Read, int bufferSize = 4096, FileOptions fileOptions = FileOptions.Asynchronous | FileOptions.SequentialScan)
    {
        using var stream = new FileStream(@this.FullName, fileMode, fileAccess, fileShare,
            bufferSize, fileOptions);
        using var writer = new StreamWriter(stream, encoding ?? Encoding.UTF8);
        writer.Write(content);
    }
}