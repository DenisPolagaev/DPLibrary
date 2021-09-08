using System;
using System.Runtime.InteropServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class ToUnsecuredStringExtensions
{
    public static string ToUnsecuredString(this SecureString @this)
    {
        // copy&paste from the internal System.Net.UnsafeNclNativeMethods
        var bstrPtr = IntPtr.Zero;
        if (@this == null) return string.Empty;
        if (@this.Length == 0) return string.Empty;
        try
        {
            bstrPtr = Marshal.SecureStringToBSTR(@this);
            return Marshal.PtrToStringBSTR(bstrPtr);
        }
        finally
        {
            if (bstrPtr != IntPtr.Zero)
                Marshal.ZeroFreeBSTR(bstrPtr);
        }
    }   
}