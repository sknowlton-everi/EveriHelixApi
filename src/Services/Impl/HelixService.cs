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
    public class HelixService : IHelixService
    {
        private readonly HelixConfig helixConfig;

        public HelixService(IOptions<HelixConfig> options)
        {
            helixConfig = options.Value;
        }

        public async Task<ProjectList> GetProjectsAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), helixConfig.GetEncryption());

            HttpResponseMessage response = await httpClient.GetAsync($"{helixConfig.BaseUrl}/projects");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            ProjectList result = JsonSerializer.Deserialize<ProjectList>(jsonString);

            return result;
        }

        public async Task<Requirement> GetRequirementAsync(int projectId, int requirementId)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            //bool itemExists = list.Any(x => x.id == id);
            //if (itemExists)
            //{
            //    result = list.Single(x => x.id == id);
            //}

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", "bearer token here");

            HttpResponseMessage response = await httpClient.GetAsync($"{helixConfig.BaseUrl}/{projectId}/requirement/{requirementId}?formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            Requirement result = JsonSerializer.Deserialize<Requirement>(jsonString);

            return result;
        }

        public async Task<RequirementList> GetRequirementsAsync(int projectId)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", "bearer token here");

            HttpResponseMessage response = await httpClient.GetAsync($"{helixConfig.BaseUrl}/{projectId}/requirements?page=1&per_page=300&formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            RequirementList result = JsonSerializer.Deserialize<RequirementList>(jsonString);

            return result;
        }
    }
}