namespace ClickHouse.Client.ADO
{
    public class ClickHouseConnectionSettings
    {
        public ClickHouseConnectionSettings(string connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public string ConnectionString { get; set; }
    }
}
