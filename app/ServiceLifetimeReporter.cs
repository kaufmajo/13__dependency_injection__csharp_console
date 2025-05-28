namespace ConsoleDI.Example;

internal sealed class ServiceLifetimeReporter(
    IExampleTransientService transientService,
    IExampleScopedService scopedService,
    IExampleSingletonService singletonService)
{
    public void ReportServiceLifetimeDetails(string lifetimeDetails)
    {
        Console.WriteLine(lifetimeDetails);

        LogService(transientService, "Always different", ConsoleColor.Green);
        LogService(scopedService, "Changes only with lifetime", ConsoleColor.Red);
        LogService(singletonService, "Always the same", ConsoleColor.Yellow);
    }

    private static void LogService<T>(T service, string message, ConsoleColor color)
        where T : IReportServiceLifetime
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"       {typeof(T).Name}: {service.Id} ({message})");
        Console.ResetColor();
    }
}