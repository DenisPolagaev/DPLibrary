using System;

/// <summary>
///     Класс содержащий методы расширения для <see cref="bool" />.
/// </summary>
public static class ToBinaryExtensions
{
    public static byte ToBinary(this bool @this)
    {
        return Convert.ToByte(@this);
    }  
}