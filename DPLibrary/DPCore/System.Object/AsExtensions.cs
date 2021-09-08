public static class AsExtensions
{
    public static T As<T>(this object @this)
        => (T) @this;
}