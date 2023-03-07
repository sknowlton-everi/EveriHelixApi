using EveriHelixAPI.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace EveriHelixAPI.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void bindConfig(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<HelixConfig>(builder.Configuration.GetSection(HelixConfig.Key));
        }
    }
}