using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFactApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CatFactApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services)
        {
            services.AddHttpClient<ICatFactService, CatFactService>(client =>
            {
                client.BaseAddress = new Uri("https://catfact.ninja/");
            });
            services.AddTransient<IFileWriter, FileWriter>();

            return services;
        }
    }
}
