/// <summary>
///     Класс содержащий методы расширения для <see cref="bool" />.
/// </summary>
public static class SelectValueExtensions
{
    /// <summary>
    /// Возвращает значение, на основе логического значения True или False
    /// </summary>
    /// <param name="this">текущий логический объект</param>
    /// <param name="trueValue">истиное значение, которое будет возвращено в случаи True</param>
    /// <param name="falseValue">ложное значение, которое будет возвращено в случаи True</param>
    /// <returns>значение true, если логическое значение истино, иначе false</returns>
    public static T SelectValue<T>( this bool @this, T trueValue,  T falseValue )
        => @this ? trueValue : falseValue;  
}