using Microsoft.Extensions.Configuration;

namespace DB_project.Utils
{
    public static class Configurator
    {
        public static readonly IConfiguration Config;

        static Configurator()
        {
            Config = new ConfigurationBuilder().AddJsonFile("settings.json", true, true).Build();
        }
    }
}