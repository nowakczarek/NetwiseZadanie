using CatFactApp.Extensions;
using CatFactApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddRequiredServices();
    });

var host = builder.Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Application started.");

var catFactService = host.Services.GetRequiredService<ICatFactService>();
var fileWriter = host.Services.GetRequiredService<IFileWriter>();

var catFact = await catFactService.GetCatFactAsync();



if (catFact is not null)
{
    await fileWriter.WriteFactToFileAsync(catFact);
    logger.LogInformation("Udało się pobrać i zapisać fakt o kocie");
}
else
{
    logger.LogError("Nie udało się pobrać i zapisać faktu o kocie");
}



