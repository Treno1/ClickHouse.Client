namespace ClickHouse.Client.ADO
{
    public class ClickHouseClientSettings
    {
        public ClickHouseClientSettings(string connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public string ConnectionString { get; set; }
    }
}
