# Методы расширения для System.Collections.Generic.ICollection[T]

### [.AddRange(T1,T2,T3...)][0]
[0]: AddRangeExtensions.cs
Добавляет передаваемые элементы в коллекцию.
```c#
var ICollection<string> stringCollection = new List<string>();

stringCollection.AddRange("Вася", "Петя", "Люба");
```

### [.ContainsAll(T1,T2,T3...)][1]
[1]: ContainsAllExtensions.cs
Проверяет, все ли элементы есть в коллекции.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

var result = stringCollection.ContainsAll("Вася", "Петя");
```

### [.ContainsAny(T1,T2,T3...)][2]
[2]: ContainsAnyExtensions.cs
Проверяет, хоть 1 элемент в коллекции.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

var result = stringCollection.ContainsAny("Вася", "Антон");
```
### [.IsEmpty()][3]
[3]: IsEmptyExtensions.cs
Проверяет коллекцию на пустоту.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

var result = stringCollection.IsEmpty();
```
### [.IsNotEmpty()][4]
[4]: IsNotEmptyExtensions.cs
Проверять коллекцию на существование элементов.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

var result = stringCollection.IsNotEmpty();
```
### [.IsNotNullOrEmpty()][5]
[5]: IsNotNullOrEmptyExtensions.cs
Проверяет коллекцию на существование элементов или ссылки.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

var result = stringCollection.IsNotNullOrEmpty();
```
### [.IsNullOrEmpty()][6]
[6]: IsNullOrEmptyExtensions.cs
Проверяет коллекцию на отсутствие элементов или ссылки.
```c#
ICollection<string> stringCollection = null;

var result = stringCollection.IsNullOrEmpty();
```
### [.RemoveRange(T1, T2, T3...)][7]
[7]: RemoveRangeExtensions.cs
Удаляет передваемые объекты из списка.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");

stringCollection.RemoveRange("Петя");
```

### [.RemoveWhere(Func<bool\>)][8]
[8]: RemoveWhereExtensions.cs
Удаляет элементы коллекции по условию.
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");
            
stringCollection.RemoveWhere((s)=>s.Equals("Вася"));
```
```c#
ICollection<string> stringCollection = new List<string>();
stringCollection.AddRange("Вася", "Петя", "Люся");
            
stringCollection.RemoveWhere(IsVasia);

private static bool IsVasia(string name)
{
    return string.Equals(name, "Вася", StringComparison.Ordinal);
}
```