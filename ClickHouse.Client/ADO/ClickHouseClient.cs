using System.Net.Http;

namespace ClickHouse.Client.ADO
{
    public class ClickHouseClient : ClickHouseConnection
    {
        public ClickHouseClient(HttpClient client, ClickHouseClientSettings settings)
            : base(settings.ConnectionString, client)
        {
        }
    }
}
