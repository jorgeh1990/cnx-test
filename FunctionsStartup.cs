using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(CNX.TEST.Startup))]

namespace CNX.TEST
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var odataBaseUrl = Environment.GetEnvironmentVariable("odataBaseUrl");
            builder.Services.AddHttpClient("ODataPeople", c =>
                                    {
                                        c.BaseAddress = new Uri(odataBaseUrl);
                                    })
            .AddTypedClient(c => Refit.RestService.For<IPeopleService>(c));

            string SalesLTConnectionString = Environment.GetEnvironmentVariable("SalesLTConnectionString");
            builder.Services.AddDbContext<SalesLTContext>(
                options => options.UseSqlServer(SalesLTConnectionString));

            //builder.Services.AddSingleton<ILoggerProvider, MyLoggerProvider>();
        }
    }
}