using System;

public static class ConvertStringToEnumExtensions
{
    public static T ToEnum<T>(this string @this)
    {
        return (T) Enum.Parse(typeof(T), @this, true);
    }
    
    public static T ToEnum<T>(this string @this, T defaultValue) where T : struct
    {
        try
        {
            return !Enum.TryParse(@this, true, out T enumValue) ? defaultValue : enumValue;
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}