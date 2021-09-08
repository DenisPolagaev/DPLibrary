using System.Collections.Generic;

public static class AddRangeExtensions
{
    /// <summary>
    /// Добавляет передаваемые параметры в текущую коллекцию.
    /// </summary>
    /// <param name="this">текущая коллекция</param>
    /// <param name="values">значения для добавления</param>
    /// <typeparam name="T">Параметр универсального типа</typeparam>
    /// <exception cref="System.NotSupportedException">
    /// <see cref="@this"/> доступен только для чтения.
    /// </exception>
    /// <exception cref="System.NullReferenceException">
    /// <see cref="@this"/> не имеет ссылки.
    /// </exception>
    public static void AddRange<T>(this ICollection<T> @this, params T[] values)
    {
        foreach (var value in values)
        {
            @this.Add(value);
        }
    }  
}