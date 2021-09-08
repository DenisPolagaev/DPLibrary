public static class ConvertToBooleanExtensions
{
    public static bool ToBoolean(this string @this) => bool.Parse(@this);
}