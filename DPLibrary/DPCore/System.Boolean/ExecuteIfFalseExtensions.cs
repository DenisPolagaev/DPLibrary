using System;

/// <summary>
///     Класс содержащий методы расширения для <see cref="bool" />.
/// </summary>
public static class ExecuteIfFalseExtensions
{
    public static void ExecuteIfFalse(this bool @this, Action action)
    {
        if (@this) return;
        action();
    }
}