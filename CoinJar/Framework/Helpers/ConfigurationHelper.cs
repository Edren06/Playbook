using System.Data.SqlClient;

namespace CoinJar.Framework.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetSqlConnection()
        {
            var config = GetConfiguration();
            return new SqlConnection(config.GetSection("Data").GetSection("ConnectionString").Value).ConnectionString;
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
    
}
