using System;
using System.Globalization;

public static class ConvertToDoubleExtensions
{
    public static double ToDouble(this string @this) => @this.ToDouble(CultureInfo.InvariantCulture);
    public static double ToDouble(this string @this, IFormatProvider formatProvider) => double.Parse(@this, formatProvider);
    public static double ToDouble(this string @this, double defaultValue) => @this.ToDouble(defaultValue, CultureInfo.InvariantCulture);

    public static double ToDouble(this string @this, double defaultValue , IFormatProvider formatProvider)
    {
        try
        {
            return double.Parse(@this, formatProvider);
        }
        catch (FormatException)
        {
            return defaultValue;
        }

    }
}