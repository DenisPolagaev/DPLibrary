using System;

public static class GetDescriptionExtensions
{
    public static string GetDescription<T>(this T @this)
        where T : struct
    {
        if (EnumInternal<T>.ValueToDescriptionMap.TryGetValue(@this, out var description))
        {
            return description;
        }
        throw new Exception($"{nameof(@this)} {@this} of enum {typeof(T).Name} is not supported.");
    }
}