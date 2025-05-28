# Dependency Injection

## Links

<https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage>

## Install & run

Clone the project

```ps
git clone https://github.com/kaufmajo/13__dependency_injection__csharp_console.git
```

Change into directory

```ps
cd app
```

Run the application

```ps
dotnet run
```

## Notes

Aus der App-Ausgabe können Sie folgendes sehen:

- Transient-Dienste sind immer unterschiedlich; bei jedem Abruf des Dienstes wird eine neue Instanz erstellt.
- Scoped Dienste ändern sich nur mit einem neuen Bereich, sind aber dieselbe Instanz innerhalb eines Bereichs.
- Singleton-Dienste sind immer gleich, eine neue Instanz wird nur einmal erstellt.
