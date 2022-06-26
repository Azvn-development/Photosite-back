using Microsoft.Extensions.Configuration;

namespace Photosite.Test.Configuration
{
    public static class ConfigConfiguration
    {
        public static ConfigurationManager GetConfigConfiguration()
        {
            var configuration = new ConfigurationManager();
            configuration.AddJsonFile("appsettings.json");

            return configuration;
        } // GetConfigConfiguration
    }
}
