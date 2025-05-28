using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleDI.Example;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
builder.Services.AddTransient<ServiceLifetimeReporter>();

using IHost host = builder.Build();

Console.WriteLine("----------------------------------------");
Console.WriteLine("Scope 1: Create a service provider and get a ServiceLifetimeReporter instance");

ExemplifyServiceLifetime(host.Services, "Lifetime 1");

Console.WriteLine("----------------------------------------");
Console.WriteLine("Scope 2: Create a service provider and get a ServiceLifetimeReporter instance");

ExemplifyServiceLifetime(host.Services, "Lifetime 2");

Console.WriteLine("----------------------------------------");

await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    Console.WriteLine();

    using IServiceScope serviceScope = hostProvider.CreateScope();

    IServiceProvider provider = serviceScope.ServiceProvider;

    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();

    logger.ReportServiceLifetimeDetails(
        $"   {lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine("");

    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"   {lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine();
}
