# Методы расширения для System.Collections.Generic.IDictionary[TKey,TValue]

### [.AddOrUpdate(TKey, TValue)][0]
[0]: AddOrUpdateExtensions.cs
Добавляет или обновляет элемент по ключу.
```c#
var dictionary = new Dictionary<string, int>();
dictionary.AddOrUpdate("Fizz", 1); // return 1;
            
var value1 = dictionary.AddOrUpdate("Fizz", 2);
Assert.AreEqual(2, value1);
```
### [.ContainsAllKey(T1, T2, T3...)][1]
[1]: ContainsAllKeyExtensions.
Проверяет наличие всех ключей в словаре.
```c#
var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};

var result = dictionary.ContainsAll(
    new KeyValuePair<string, int>("a", 1),
    new KeyValuePair<string, int>("b", 2));
```
### [.ConstainsAnyKey(T1, T2, T3...)][2]
[2]: ContainsAnyKeyExtensions.cs
Проверяет наличие хотя бы одного ключа в словаре.
```c#
var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};

var result = dictionary.ContainsAny(
    new KeyValuePair<string, int>("a", 1),
    new KeyValuePair<string, int>("c", 2),
    new KeyValuePair<string, int>("c", 2));
```
### [.GetOrAdd(TKey, TValue)][3]
[3]: GetOrAddExtensions.cs
Добавляет или возвращает элемент по ключу.
```c#
var dictionary = new Dictionary<string, int>();
int value1 = dictionary.GetOrAdd("Fizz", 1); // return 1;
int value2 = dictionary.GetOrAdd("Fizz", 0); // return 1; // словарь уже содержит такой ключ

int value3 = dictionary.GetOrAdd("Fizz1", (n) => 1);
```

### [.RemoveIfContains(TKey)][4]
[4]: RemoveIfContainsKeyExtensions.cs
Удаляет элемент, если передаваемый ключ существует.
```c#
var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};
            
dictionary.RemoveIfContainsKey("a");
```
### [.ToSorted()][5]
[5]: ToSortedDictionaryExtensions.cs
Преобразовывает коллекцию в сортированную коллекцию.
```c#
var dictionary = new Dictionary<string, int> {{"b", 2},{"a", 1}, {"c", 3}};
 
SortedDictionary<string, int> result = dictionary.ToSortedDictionary();
```
