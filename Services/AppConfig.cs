using Microsoft.Extensions.Configuration;

namespace HausaufgabenManagerUI_WinForm.Services
{
    internal static class AppConfig
    {
        private static readonly IConfiguration _configuration;

        static AppConfig()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        internal static string GetLocalConnectionString()
        {
            return _configuration.GetConnectionString("LocalConnection");
        }

        internal static string GetGlobaleConnectionString()
        {
            return _configuration.GetConnectionString("GlobaleConnection");
        }
    }
}
