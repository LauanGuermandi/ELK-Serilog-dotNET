using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Payment.Api.Logging;
using Serilog;

namespace Payment.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Http("http://127.0.0.1:5009")
                .Enrich.CustomerLogEnricher()
                .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
