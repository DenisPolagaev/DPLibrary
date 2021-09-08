using System;
using System.Globalization;

public static class ConvertToByteExtensions
{
    public static byte ToByte(this string @this, IFormatProvider formatProvider) => byte.Parse(@this, formatProvider);

    public static byte ToByte(this string @this) => byte.Parse(@this, CultureInfo.CurrentCulture);
    
}