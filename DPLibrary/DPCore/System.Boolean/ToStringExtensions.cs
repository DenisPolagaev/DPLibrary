/// <summary>
///     Класс содержащий методы расширения для <see cref="bool" />.
/// </summary>
public static class ToStringExtensions
{
    /// <summary>
    /// Возвращает строку, на основе логического значения True или False
    /// </summary>
    /// <param name="this">текущее логическое значение</param>
    /// <param name="trueValue">истеное значение</param>
    /// <param name="falseValue">ложно значение</param>
    /// <returns></returns>
    public static string ToString(this bool @this, string trueValue, string falseValue)
    {
        return @this ? trueValue : falseValue;
    }
}