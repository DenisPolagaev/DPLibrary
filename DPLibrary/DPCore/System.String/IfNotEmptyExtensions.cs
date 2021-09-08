public static partial class IfNotEmptyExtensions
{
    public static string IfNotEmpty(this string @this, string alternativeValue)
        => !@this.IsEmpty() ? @this : alternativeValue;     
}