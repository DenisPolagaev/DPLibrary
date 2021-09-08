using System;

/// <summary>
///     Класс содержащий методы расширения для <see cref="bool" />.
/// </summary>
public static class ExecuteIfTrueExtensions
{
    public static void ExecuteIfTrue(this bool @this, Action action)
    {
        if (!@this) return;
        action();
    }    
}