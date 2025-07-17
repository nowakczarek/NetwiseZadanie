using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {

    });

var host = builder.Build();
Console.WriteLine("App started.");