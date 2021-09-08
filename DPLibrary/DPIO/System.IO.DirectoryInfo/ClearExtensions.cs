using System;
using System.IO;
using System.Threading.Tasks;

public  static class ClearExtensions
{
    public static void Clear(this DirectoryInfo @this)
    {
        Array.ForEach(@this.GetFiles(), x => x.Delete());
        Array.ForEach(@this.GetDirectories(), x => x.Delete(true));
    }

    public static void ParallelClear(this DirectoryInfo @this)
    {
        Parallel.ForEach(@this.GetFiles(), (x) => x.Delete());
        Parallel.ForEach(@this.GetDirectories(), (x) => x.Delete(true));
    }
}