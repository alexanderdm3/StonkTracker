using Microsoft.Extensions.Configuration;

namespace StonkTracker.Data
{
    public class DataRepository
    {
        private readonly IConfiguration configuration;
        private readonly string configString;
        public DataRepository(IConfiguration config)
        {
            configuration = config;
            configuration.GetConnectionString("Stonks");
        }
    }
}
