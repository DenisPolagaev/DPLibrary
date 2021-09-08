public static partial class IsEmptyExtensions
{
    public static bool IsEmpty(this string @this )
        => string.IsNullOrEmpty( @this ) || string.IsNullOrWhiteSpace( @this );   
}