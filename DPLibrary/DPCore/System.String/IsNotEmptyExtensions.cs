public static  partial class IsNotEmptyExtensions
{
    public static bool IsNotEmpty(this string @this )
        => !@this.IsEmpty();
}