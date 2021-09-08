using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class CopyInfoExtensions
{
    public static void CopyInto(this SecureString @this, SecureString destination)
    {
        destination.Clear();
        foreach (var chr in @this.ToUnsecuredString())
        {
            destination.AppendChar(chr);
        }
    }   
}