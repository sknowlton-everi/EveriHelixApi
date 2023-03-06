using EveriHelixAPI.Services;
using EveriHelixAPI.Services.Impl;

namespace EveriHelixAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IHelixService, HelixService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}