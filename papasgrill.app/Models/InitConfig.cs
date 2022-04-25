using papasgrill.models;

namespace papasgrill.app.Models
{
    public class InitConfig : BaseCoinfig

    {
        private readonly IConfiguration _config;

        public InitConfig()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true);
            _config = builder.Build();
            BaseUrl = _config.GetSection("api").GetValue<string>("BaseUrl");
        }

        public string? BaseUrl { get; set; }
    }
}