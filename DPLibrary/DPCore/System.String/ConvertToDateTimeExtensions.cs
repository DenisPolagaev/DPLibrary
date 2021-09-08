using System;
using System.Globalization;

public static class ConvertToDateTimeExtensions
{
    public static DateTime ToDateTime( this string @this) => DateTime.Parse( @this, CultureInfo.InvariantCulture );
    public static DateTime ToDateTime(this string @this, IFormatProvider formatProvider ) => DateTime.Parse( @this, formatProvider);
}