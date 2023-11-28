// See https://aka.ms/new-console-template for more information

using MarcEjemploManco;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.Configure<HostOptions>(options =>
        {
            options.BackgroundServiceExceptionBehavior = BackgroundServiceExceptionBehavior.StopHost;
            options.StartupTimeout = TimeSpan.FromSeconds(2);
        });
        services.AddHostedService<WorkerPosiciones>();
        services.AddHostedService<WorkerStatus>();
    })
    .Build();

await host.RunAsync();
