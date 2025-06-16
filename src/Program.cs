using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs;

namespace STAR__azure_functions
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureWebJobs(b =>
                {
                    b.AddAzureStorageCoreServices();
                })
                .ConfigureAppConfiguration(b =>
                {
                    b.AddEnvironmentVariables();
                    b.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureLogging((context, b) =>
                {
                    b.SetMinimumLevel(LogLevel.Information);
                    b.AddConsole();
                })
                .ConfigureServices(services =>
                {
                    services.AddLogging();
                })
                .UseEnvironment("Development")
                .Build();

            await host.RunAsync();
        }
    }
}
