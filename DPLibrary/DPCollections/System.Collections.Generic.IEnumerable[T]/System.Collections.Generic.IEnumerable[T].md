# Методы расширения для System.Collections.Generic.IEnumerable[T]

### [.ToObservableCollection()][0]
[0]: ToObservableCollectionExtensions.cs
Преобразует перечесление в ObservableCollection
```c#
IEnumerable<string> a = new List<string>();

var c = new ObservableCollection<string>(a);
```
### [.ContainsAll(T1, T2, T3...)][1]
[1]: ContainsAllExtensions.cs
Проверяет все ли элементы есть в коллеции.
```c#
IEnumerable<string> en = new List<string>();

var result = en.ContainsAll("af", "af");
```

### [.ContainsAny(T1, T2, T3..)][2]
[2]: ContainsAnyExtensions.cs
Проверяет есть ли хотя бы один элемент в коллеции.
```c#
IEnumerable<string> en = new List<string>();
            
var result = en.ContainsAny("af", "af");
```

### [.ForEach(Action)][3]
#### [.ForEachAsync(Action)][3]
#### [.VoidForEach(Action)][3]
[3]: ForEachExtensions.cs
```c#
IEnumerable<int> en = new List<int>(){1,2,3};
            
int sum = 0;
en.ForEach((c) => sum += c);
```

### [.ForEachReversed(Action)][4]
#### [.VoidForEachReverse(Action)][4]
#### [.ForEachReversedAsync(Action)][5]

[4]: ForEachReverseExtensions.cs
[5]: ForEachReverseAsyncExtensions.cs

```c#
IEnumerable<int> en = new List<int>(){1,2,3};

int sum = 0;
en.ForEachReverse((c) => sum += c);
```

### [.GetAllRepeated(Func)][6]
[6]: GetAllRepeatedExtensions.cs

```c#
class FOO
{
   public string a;
   public int b;
}

var ls = new List<FOO>()
    {
       new FOO(){a = "1", b= 1},
       new FOO(){a = "1", b= 2},
       new FOO(){a = "2", b= 3}
    };

var repeated = ls.GetAllRepeated((c)=> c.a == "1");
```

### [.GetAllDuplicates(Func)][7]
[7]: GetDuplicatesExtensions.cs
```c#
class FOO
{
   public string a;
   public int b;
}
var ls = new List<FOO>()
    {
       new FOO(){a = "1", b= 1},
       new FOO(){a = "1", b= 2},
       new FOO(){a = "2", b= 1}
    };
var duplicatesAB = ls.GetDuplicates(a=> new {a.a, a.b}); // Дубликаты по свойствам A и B 

var duplicatesA = ls.GetDuplicates(a=> a.a); // Дубликаты по A

var duplicatesB = ls.GetDuplicates(a=> a.b); // Дубликаты по B
```

### [.GetMoreThanOnceRepeated(Func)][8]
[8]: GetMoreThanOnceRepeatedExtensions.cs

```c#
class FOO
{
   public string a;
   public int b;
}
var ls = new List<FOO>()
    {
       new FOO(){a = "1", b= 1},
       new FOO(){a = "1", b= 2},
       new FOO(){a = "2", b= 1}
    };
var duplicatesA = ls.GetMoreThanOnceRepeated(c=> c.a);
var duplicatesB = ls.GetMoreThanOnceRepeated(c => c.b);
```

### [.IsEmpty()][9]
[9]: IsEmptyExtensions.cs
```c#
IEnumerable<string> en = new List<string>(){"agag"};

var result = en.IsEmpty();
```

### [.IsNotNullOrEmpty()][10]
[10]: IsNotNullOrEmptyExtensions.cs

```c#
IEnumerable<string> en = new List<string>(){"agag"};

var result = en.IsNotNullOrEmpty();
```
### [.IsNotEmpty()][11]
[11]: IsNotEmptyExtensions.cs
```c#
IEnumerable<string> en = new List<string>(){"agag"};

var result = en.IsNotEmpty();
```
### [.IsNotNullOrEmpty()][12]
[12]: IsNotNullOrEmptyExtensions.cs
```c#
IEnumerable<string> en = new List<string>(){"agag"};

var result = en.IsNotNullOrEmpty();
```
### [.IsNullOrEmpty()][13]
[13]: IsNullOrEmptyExtensions.cs
```c#
IEnumerable<string> en = new List<string>(){"agag"};

var result = en.IsNullOrEmptyExtensions();
```
### [.StringJoin(sep)][14]
[14]: StringJoinExtensions.cs
```c#
IEnumerable<string> en = new List<string>(){"agag", "agag", "aagag"};
var res = en.StringJoin(",");
```
