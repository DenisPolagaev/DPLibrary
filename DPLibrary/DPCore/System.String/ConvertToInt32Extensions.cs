using System;
using System.Globalization;

public static class ConvertToInt32Extensions
{
    public static int ToInt32(this string @this) => @this.ToInt32(CultureInfo.InvariantCulture);
    public static int ToInt32(this string @this, IFormatProvider formatProvider) => int.Parse(@this, formatProvider);

    public static int ToInt32(this string @this, int defaultValue)
    {
        return @this.ToInt32(defaultValue, CultureInfo.InvariantCulture);
    }

    public static int ToInt32(this string @this, int defaultValue, IFormatProvider formatProvider)
    {
        try
        {
            return int.Parse(@this, formatProvider);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
}