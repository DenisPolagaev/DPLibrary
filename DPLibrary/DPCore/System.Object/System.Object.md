# Методы расширения для System.Object

### [.As\<type>()][0]
[0]: AsExtensions.cs

```c#
var obj = "afagaggag";
var str = obj.As<string>();

var obj = "afagaggag";
var str = obj.As<int>();
```

### [.IsNull()][1]
[1]: IsNullExtensions.cs

```c#
object s = null;
var result = s.IsNull();
```

### [.IsNotNull()][2]
[2]: IsNotNullExtensions.cs
```c#
object s = "";
var result = s.IsNotNull();
```

### [.RefEquals(T)][3]
[3]: ReferenceEqualsExtension.cs
```c#
object a = "";
var b = a;
var result = a.RefEquals(b);
```