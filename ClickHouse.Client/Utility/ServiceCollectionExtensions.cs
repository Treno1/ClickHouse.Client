using System.Net;
using System.Net.Http;
using ClickHouse.Client.ADO;
using Microsoft.Extensions.DependencyInjection;

namespace ClickHouse.Client.Utility
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddClickHouseConnection(this IServiceCollection services, string connectionString)
        {
            services
                .AddSingleton(sp => new ClickHouseConnectionSettings(connectionString))
                .AddHttpClient<ClickHouseConnection>()
                .ConfigurePrimaryHttpMessageHandler(() => 
                    new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });

            return services;
        }
    }
}
