using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class ToSecureStringExtensions
{
    public static SecureString ToSecuredString(this string plainString)
    {
        if (string.IsNullOrEmpty(plainString)) return new SecureString();
        var secure = new SecureString();
        foreach (var c in plainString)
        {
            secure.AppendChar(c);
        }
        return secure;

    }  
}