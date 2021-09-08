public static class ReferenceEqualsExtension
{
    public static bool RefEquals<T>(this object @this, T obj)
    {
        return ReferenceEquals(@this, obj);
    }
}