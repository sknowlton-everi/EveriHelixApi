using EveriHelixAPI.Extensions;
using EveriHelixAPI.Infrastructure;
using EveriHelixAPI.Models;
using Microsoft.Extensions.Options;
using Serilog;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace EveriHelixAPI.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly HelixConfig helixConfig;

        public UserService(IOptions<HelixConfig> options)
        {
            helixConfig = options.Value;
        }

        public Task<ProjectList> ValidateCredentialsAsync(string username, string password)
        {
            return authenticateWithHelix(username, password);
        }

        public Task<Token> AuthenticateAsync(int projectId, string username, string password)
        {
            return getAccessToken(projectId, username, password);
        }

        private async Task<ProjectList> authenticateWithHelix(string username, string password)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), username.getBasicAuth(password));

            HttpResponseMessage response = await httpClient.GetAsync($"{helixConfig.BaseUrl}/projects");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            ProjectList result = JsonSerializer.Deserialize<ProjectList>(jsonString);
            return result;
        }

        private async Task<Token> getAccessToken(int projectId, string username, string password)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), username.getBasicAuth(password));

            HttpResponseMessage response = await httpClient.GetAsync($"{helixConfig.BaseUrl}/{projectId}/token");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            Token result = JsonSerializer.Deserialize<Token>(jsonString);
            return result;
        }
    }
}