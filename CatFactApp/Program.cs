using CatFactApp.Extensions;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddRequiredServices();
    });

var host = builder.Build();
Console.WriteLine("App started.");