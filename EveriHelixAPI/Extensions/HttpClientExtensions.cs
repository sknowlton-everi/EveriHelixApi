using EveriHelixAPI.Infrastructure.Filters;
using EveriHelixAPI.Services;
using EveriHelixAPI.Services.Impl;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

namespace EveriHelixAPI.Extensions
{
    public static class HttpClientExtensions
    {
        private static string HELIX_REST_URL = "https://127.0.0.1:8443/helix-alm/api/v0/";

        public static void AddHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient("Everi Helix", x =>
            {
                x.BaseAddress = new Uri(HELIX_REST_URL);
            });
        }
    }
}