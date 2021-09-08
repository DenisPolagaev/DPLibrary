using System;

public static class IsDateEqualExtensions
{
    public static bool IsDateEqual(this DateTime @this, DateTime dateToCompare) => @this.Date == dateToCompare.Date;
}