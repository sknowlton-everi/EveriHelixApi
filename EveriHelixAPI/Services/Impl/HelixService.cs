using EveriHelixAPI.Extensions;
using EveriHelixAPI.Models;
using Serilog;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace EveriHelixAPI.Services.Impl
{
    public class HelixService : IHelixService
    {
        private static string HELIX_REST_URL = "https://127.0.0.1:8443/helix-alm/api/v0";
        private static string USERNAME = "Administrator";
        private static string PASSWORD = "Atilla455";

        public HelixService()
        {
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
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), USERNAME.getBasicAuth(PASSWORD));

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/projects");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ProjectList result = JsonSerializer.Deserialize<ProjectList>(jsonString);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8603 // Possible null reference return.
            return result;
#pragma warning restore CS8603 // Possible null reference return.
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

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/{projectId}/requirement/{requirementId}?formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Requirement result = JsonSerializer.Deserialize<Requirement>(jsonString);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8603 // Possible null reference return.
            return result;
#pragma warning restore CS8603 // Possible null reference return.
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

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/{projectId}/requirements?page=1&per_page=300&formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            RequirementList result = JsonSerializer.Deserialize<RequirementList>(jsonString);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8603 // Possible null reference return.
            return result;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}