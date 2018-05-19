[![Build status](https://ci.appveyor.com/api/projects/status/orkh8wfdq6rk3pyo?svg=true)](https://ci.appveyor.com/project/sarathkcm/pluralize-net)  [![Coverage Status](https://coveralls.io/repos/github/sarathkcm/Pluralize.NET/badge.svg?branch=master&v=1)](https://coveralls.io/github/sarathkcm/Pluralize.NET?branch=master)   [![NuGet version](https://badge.fury.io/nu/pluralize.net.svg)](https://www.nuget.org/packages/pluralize.net)
# What is it?
This is a C# port of Blake Embrey's [pluralize](https://github.com/blakeembrey/pluralize) library which helps in pluralizing or singularizing any English word.
# Why
I could not find a good C# alternative for converting words from singular to plural and vice versa. [System.Data.Entity.Design.PluralizationServices.PluralizationService](https://msdn.microsoft.com/en-us/library/system.data.entity.design.pluralizationservices.pluralizationservice(v=vs.110).aspx) and [Humanizer](http://humanizr.net/) library did not meet the expectations (try 'shoes' or 'toes'). However this small but awesome Javascript libray [pluralize](https://github.com/blakeembrey/pluralize) worked very well for me and I decided to convert the code to C# and use it.
# How
**Install from NuGet**

Using Package manager console
```
Install-Package Pluralize.NET
```

Using dotnet CLI
```
dotnet add package Pluralize.NET
```

Using paket CLI
```
paket add Pluralize.NET
```

**Include using directive**
```C#
using Pluralize.NET
```
**Write code**
```C#
var singular = new Pluralizer().Singularize("Horses");
var plural = new Pluralizer().Pluralize("Horse");
```

**Profit!**

# Supported .NET Versions
The Nuget package supports the following .NET versions. This pretty much covers versions 4.0 and above. Please open an issue if you want to support any .NET version in particular.

* .NET 4.0
* .NET Standard 1.1
* .NET 4.5.1
* .NET 4.6
* .NET Standard 2.0

# Licence
[MIT](https://github.com/sarathkcm/Pluralize.NET/blob/master/LICENCE) - because the original project is MIT
