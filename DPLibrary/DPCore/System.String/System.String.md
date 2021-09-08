# Методы расширения для System.String

## Конвертация

### [.ToBoolean()][0]
[0]: ConvertToBooleanExtensions.cs
```c#
string boolean = "true";

bool b = boolean.ToBoolean();
```

### [.ToByte()][1]
[1]: ConvertToByteExtensions.cs
```c#
string number = "0";

byte b = number.ToByte();
```

### [.ToChar()][2]
[2]: ConvertToCharExtensions.cs
```c#
string ch = "r";

char character = ch.ToChar();
```

### [.ToDateTime()][3]
[3]: ConvertToDateTimeExtensions.cs
```c#
string dateTime = "2020/12/15 11:12:12";
           
var dt = dateTime.ToDateTime();
```

### [.ToDouble()][4]
[4]: ConvertToDoubleExtensions.cs
```c#
string number = "0";

double d = number.ToDouble();
```

### [.ToInt32()][5]
[5]: ConvertToInt32Extensions.cs
```c#
string number = "0";

int i = number.ToInt32();
```

## Остальное

### [.IfNotEmpty(FalseValue)][6]
[6]: IfNotEmptyExtensions.cs
```c#
string str = global::System.String.Empty;

var result = str.IfNotEmpty("дом");
```

### [.IsEmpty()][7]
[7]: IsEmptyExtensions.cs
```c#
string str = global::System.String.Empty;

bool result = str.IsEmpty();
```

### [.IsNotEmpty()][8]
[8]: IsNotEmptyExtensions.cs
```c#
string str = global::System.String.Empty;

var result = str.IsNotEmpty();
```

### [.ToSecureString()][9]
[9]: ToSecureStringExtensions.cs
```c#
var password = "passsword";

var securePassword = password.ToSecuredString();
```


