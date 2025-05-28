# Dependency Injection

## Links

<https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage>

## Install

Console Application

```ps
dotnet new console --language "C#"
```

```ps
Microsoft.Extensions.Hosting
```

## Notes

Aus der App-Ausgabe können Sie folgendes sehen:

Transient-Dienste sind immer unterschiedlich; bei jedem Abruf des Dienstes wird eine neue Instanz erstellt.
Scoped Dienste ändern sich nur mit einem neuen Bereich, sind aber dieselbe Instanz innerhalb eines Bereichs.
Singleton-Dienste sind immer gleich, eine neue Instanz wird nur einmal erstellt.
