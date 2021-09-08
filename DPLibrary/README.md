# Личный сборник инструментов

## Оглавление
___
0.  [Методы расширения](#методы-расширения)
1.  [Утилиты](#утилиты)

##Методы расширения:
___
### [System.Collections.Generic][0]
* [ICollection[T]][1]
* [IDictionary[TKey, TValue]][2]
* [IEnumerable[T]][3]
### [System][4]
* [Boolean][5]
* [DateTime][6]
* [Object][7]
* [String][8]

### [System.IO][9]
* [IEnumerable\<DirectoryInfo>][10]
* [IEnumerable\<FileInfo>][11]
* [DirectoryInfo][12]
* [FileInfo][13]

### [System.Security][14]
* [SecureString][15]




[0]: DPCollections/
[1]: DPCollections/System.Collections.Generic.ICollection%5BT%5D/System.Collections.Generic.ICollection%5BT%5D.md
[2]: DPCollections/System.Collections.Generic.IDictionary%5BTKey,%20TValue%5D/System.Collections.Generic.IDictionary%5BTKey,TValue%5D.md
[3]: DPCollections/System.Collections.Generic.IEnumerable%5BT%5D/System.Collections.Generic.IEnumerable%5BT%5D.md
[4]: DPCore/
[5]: DPCore/System.Boolean/System.Boolean.md
[6]: DPCore/System.DateTime/System.DateTime.md
[7]: DPCore/System.Object/System.Object.md
[8]: DPCore/System.String/System.String.md
[9]: DPIO/
[10]: DPIO/System.Collections.Generic.IEnumerable%5BDirectoryInfo%5D/System.IO.IEnumerable_DirectoryInfo_.md
[11]: DPIO/System.Collections.Generic.IEnumerable%5BFileInfo%5D/System.IO.IEnumerable_FileInfo_.md
[12]: DPIO/System.IO.DirectoryInfo/System.IO.DirectoryInfo.md
[13]: DPIO/System.IO.DirectoryInfo/System.IO.FileInfo.md
[14]: DPSecurity/
[15]: DPSecurity/System.Security.SecureString

##Утилиты

###Подключение к локальной шаре (SMB Protocol)

```c#
using System.Net;
using System.Security;
using DPLibrary.DPNet.SMB;

SecureString password = new SecureString();
NetworkCredential networkCredential = new NetworkCredential("login", password);
//NetworkCredential networkCredential = new NetworkCredential("login", "password");
//NetworkCredential networkCredential = new NetworkCredential("login", "password", "domain");
//NetworkCredential networkCredential = new NetworkCredential("login", password, "domain");
using (var smb = new NetworkSMBConnection(@"network\path", networkCredential)) // если не подключились -  Win32Exception
{
    // Code
}
```

### Запуск задачи по времени

```c#
using System;
using DPLibrary.DPThreading.Schedule;

var scheduler = new Scheduler();
Action<string> log = Console.WriteLine; // Optional
Action execute = () => { /* code */ };
TimeSpan startTime = new TimeSpan(12, 54, 30);
TimeSpan interval = new TimeSpan(0, 4, 0); // Optional
scheduler.ScheduleJob(execute,startTime , interval, log);
```