# Методы расширения для System.Boolean

### [.ExecuteFalse(Action)][0]
[0]: ExecuteIfFalseExtensions.cs
```c#
var fls = false;
var result = false;

fls.ExecuteIfFalse(()=>result = true);
fls.ExecuteIfFalse(UpdateCommand);
```

### [.ExecuteTrue(Action)][1]
[1]: ExecuteIfTrueExtensions.cs
```c#
var fls = true;
var result = false;

fls.ExecuteIfTrue(()=>result = true);
fls.ExecuteIfTrue(UpdateCommand);
```

### [.SelectValue(T, T)][2]
[2]: SelectValueExtensions.cs
```c#
string result = string.Empty;
var flag = true;

result = flag.SelectValue("Дом", "Забор");
``` 

### [.ToBinary()][3]
[3]: ToBinaryExtensions.cs
```c#
var flag = true;
flag.ToBinary();
```
### [.ToString(TrueTranslate, FalseTranslate)][4]
[4]: ToStringExtensions.cs
```c#
var flag = true;
string result = flag.ToString("Да","Нет");
```
